using System;
using System.Collections.Generic;
using Jukebox;
using Jukebox.Services.Abstract;
using Jukebox.Domain;
using Jukebox.Models;
using Jukebox.Domain.Abstract;
using System.Linq;
using Jukebox.Mappers;
namespace Jukebox
{
    class Jukebox
    {
       private  IAlbumService<Album,int> containerService; 
        public Jukebox(IAlbumService<Album, int> containerService)
        {
            this.containerService = containerService;
        }
       public IList<Song> GetFilteredContainerItemFromFilteredContainers(IFiltrator<Album> containerFiltrator, IFiltrator<Song> containerItemFiltrator)
        {
            IList<Album> filteredAlbums = containerService.GetFilteredContainers(containerFiltrator);
            IList<Song> filteredSongsFromContainers = containerService.GetFilteredContainerItemsFromContainers(filteredAlbums, containerItemFiltrator);
            return filteredSongsFromContainers;
        }

    }
}
