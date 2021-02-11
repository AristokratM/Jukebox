using System;
using Jukebox.Models;
using Jukebox.Interfaces;
using Jukebox.ContainerDAO;
using Jukebox.ContainerItemDAO;
using System.Collections.Generic;

namespace Jukebox
{
    class Jukebox
    {
        public static IContainerItemDAO<Song> _songItemsDAO = new SongDAO();
        private static IContainerDAO<Album> _containerSongDAO = new AlbumDAO<Song>(_songItemsDAO);
        private static IDataReader _dataReader = new ConsoleDataReader();
        private Jukebox()
        {
        }
        static void Main(string[] args)
        {
            foreach (var song in GetContainerItems())
            {
                Console.WriteLine(song);
            }
        }
        public static List<IContainerItem> GetContainerItems()
        {
            Single balance = Convert.ToSingle(_dataReader.GetUserBalance());
            String albumName = _dataReader.GetContainerName();
            String author = _dataReader.GetContainerItemAuthor();
            String genre = _dataReader.GetContainerItemGenre();
            String performer = _dataReader.GetContainerItemPerformer();
            List<IContainerItem> songs = new List<IContainerItem>();
            foreach (var album in _containerSongDAO.GetAll())
            {
                if (album.ItemPlayPrice <= balance)
                {
                    if (albumName.Equals("") || album.Name.Equals(albumName))
                    {
                        foreach (var song in _containerSongDAO.GetContainerItems(album))
                        {
                            if( (author.Equals("") || author.Equals(song.Author)) && 
                                (genre.Equals("") || genre.Equals(song.Genre)) &&
                                (performer.Equals("") || performer.Equals(song.Performer)))
                            {
                                songs.Add(song);
                            }
                        }
                    }
                }
            }
            return songs;
        }
    }
}
