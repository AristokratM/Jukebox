using System;
using System.Collections.Generic;
using System.Text;
using Jukebox.Abstract;
using Jukebox.Services;
using Jukebox.Services.Abstract;
using Jukebox.Domain;
using Jukebox.Data.Repositories;
using Jukebox.Entities;
namespace Jukebox
{
    class Program
    {
        private static IDataReader dataReader = new ConsoleDataReader();
        private static IContainerService<Album, Song> containerService = new AlbumService<Song>(new AlbumRepository(new SongRepository()));
        static void Main(string[] args)
        {

            var jukebox = new Jukebox(containerService);
            var filteredContainerItems = jukebox.GetFilteredContainerItemFromFilteredContainers(dataReader.GetContainerFilter(), dataReader.GetContainerItemFilter());
            foreach (var containerItem in filteredContainerItems)
            {
                Console.WriteLine(containerItem);
            }
        }
    }
}
