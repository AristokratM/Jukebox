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
       private  IContainerService<Album,Song> _containerService; 
        public Jukebox(IContainerService<Album, Song> containerService)
        {
            _containerService = containerService;
        }
       public IList<SongModel> GetFilteredContainerItemFromFilteredContainers(IFiltrator<IContainer> containerFiltrator, IFiltrator<IContainerItem> containerItemFiltrator)
        {
            IList<Album> filteredAlbums = _containerService.GetFilteredContainers(containerFiltrator);
            IList<Song> filteredSongsFromContainers = _containerService.GetFilteredContainerItemsFromContainers(filteredAlbums, containerItemFiltrator);
            return filteredSongsFromContainers.Select(s => s.ToModel()).ToList();
        }

    }
}
