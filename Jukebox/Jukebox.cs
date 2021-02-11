using System;
using Jukebox.Models;
using Jukebox.Interfaces;
using Jukebox.ContainerDAO;
using Jukebox.ContainerItemDAO;
namespace Jukebox
{
    class Jukebox
    {
        private Single Balance { get; set; }
        public static IContainerItemDAO<Song> _songItemsDAO = new SongDAO();
        private static IContainerDAO<Album> _containerSongDAO = new AlbumDAO<Song>(_songItemsDAO);

        private Jukebox()
        {
        }
        static void Main(string[] args)
        {

            foreach (var album in _containerSongDAO.GetAll())
            {
                Console.WriteLine(album);
                foreach (var song in _containerSongDAO.GetContainerItems(album))
                {
                    Console.WriteLine(song);
                }
            }
        }
    }
}
