using System;
using System.Collections.Generic;
using System.Text;
using Jukebox.Abstract;
using Jukebox.Services;
using Jukebox.Services.Abstract;
using Jukebox.Domain;
using Jukebox.Data.Repositories;
using Jukebox.Entities;
using Jukebox.Data.UnitOfWork;

namespace Jukebox
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataReader dataReader = new ConsoleDataReader();
            IAlbumService<Album, int> containerService = new AlbumService(new UnitOfWork());
            var jukebox = new Jukebox(containerService);
            var filteredContainerItems = jukebox.GetFilteredContainerItemFromFilteredContainers(dataReader.GetContainerFilter(), dataReader.GetContainerItemFilter());
            foreach (var containerItem in filteredContainerItems)
            {
                Console.WriteLine(containerItem);
            }
        }
    }
}
