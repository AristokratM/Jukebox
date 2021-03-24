using Jukebox.Domain;
using Jukebox.Domain.Abstract;
using Jukebox.Domain.Filters;
using Jukebox.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp.Commands;

namespace WpfApp.ViewModels
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private IAlbumService<Album, int> albumService;

        private string albumName = string.Empty;
        public string AlbumName
        {
            get { return albumName; }
            set { albumName = value; OnPropertyChanged(nameof(AlbumName)); }
        }
        private string author = string.Empty;
        public string Author
        {
            get { return author; }
            set { author = value; OnPropertyChanged(nameof(Author)); }
        }
        private string genre = string.Empty;
        public string Genre
        {
            get { return genre; }
            set { genre = value; OnPropertyChanged(nameof(Genre)); }
        }
        private string performer = string.Empty;
        public string Performer
        {
            get { return performer; }
            set { performer = value; OnPropertyChanged(nameof(Performer)); }
        }
        private RelayCommand displayCommand;
        public RelayCommand DisplayCommand
        {
            get
            {
                return displayCommand ?? (displayCommand = new RelayCommand(obj =>
                {
                    MessageBox.Show($"{AlbumName}  {Genre}  {Performer}  {Author}");
                }));
            }
        }
        private RelayCommand findCommand;
        public RelayCommand FindCommand
        {
            get
            {
                return findCommand ?? (findCommand = new RelayCommand(obj =>
                {
                    IFiltrator<Album> albumFiltrator = new ContainerFilter(100, AlbumName);
                    IFiltrator<Song> songFiltrator = new ContainerItemFilter(Author, Genre, Performer);
                    Songs.Clear();
                    foreach (var item in GetFilteredContainerItemFromFilteredContainers(albumFiltrator, songFiltrator))
                    {
                        Songs.Add(item);
                    }
                }));
            }
        }
        public IList<Song> GetFilteredContainerItemFromFilteredContainers(IFiltrator<Album> containerFiltrator, IFiltrator<Song> containerItemFiltrator)
        {
            IList<Album> filteredAlbums = albumService.GetFilteredContainers(containerFiltrator);
            IList<Song> filteredSongsFromContainers = albumService.GetFilteredContainerItemsFromContainers(filteredAlbums, containerItemFiltrator);
            return filteredSongsFromContainers;
        }

        public ApplicationViewModel(IAlbumService<Album, int> albumService)
        {
            this.albumService = albumService;
            Songs = new ObservableCollection<Song>();
        }
        public ObservableCollection<Song> Songs { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
