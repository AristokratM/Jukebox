using System;
using Jukebox.Models;
using Jukebox.Interfaces;
using Jukebox.ContainerDAO;
using Jukebox.ContainerItemDAO;
using System.Collections.Generic;
using Jukebox.Filters;
namespace Jukebox
{
    class Jukebox
    {
        private static IContainerItemDAO<Song> _songItemsDAO = new SongDAO();
        private static IContainerDAO<Album> _containerSongDAO = new AlbumDAO<Song>(_songItemsDAO);
        private static IDataReader _dataReader = new ConsoleDataReader();
        private Jukebox()
        {
        }
        static void Main(string[] args)
        {
            Single balance = Convert.ToSingle(_dataReader.GetUserBalance());
            String albumName = _dataReader.GetContainerName();
            IFiltrator<IContainer> containerFiltrator = new ContainerFilter(balance, albumName);
            String author = _dataReader.GetContainerItemAuthor();
            String genre = _dataReader.GetContainerItemGenre();
            String performer = _dataReader.GetContainerItemPerformer();
            IFiltrator<IContainerItem> containerItemFiltrator = new ContainerItemFilter(author, genre, performer);
            foreach (var song in GetContainerItems(GetContainers(containerFiltrator), containerItemFiltrator))
            {
                Console.WriteLine(song);
            }
        }
        public static IList<IContainer> GetContainers(IFiltrator<IContainer> filtrator)
        {
            IList<IContainer> albums = new List<IContainer>();
            foreach (var album in _containerSongDAO.GetAll())
            {
                if(filtrator.Filter(album))
                {
                    albums.Add(album);
                }
            }
            return albums;
        }
        public static IList<IContainerItem> GetContainerItems(IList<IContainer> albums, IFiltrator<IContainerItem> filtrator)
        {
            IList<IContainerItem> songs = new List<IContainerItem>();
            foreach (var album in albums)
            {
                foreach (var song in _containerSongDAO.GetContainerItems(album))
                {
                    if (filtrator.Filter(song))
                    {
                        songs.Add(song);
                    }
                }
            }
            return songs;
        }
    }
}
