using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Data.Repositories.Abstract;
using Jukebox.Domain.Abstract;
using Jukebox.Domain;
using Jukebox.Services.Abstract;
using Jukebox.Mappers;
using Jukebox.Entities;
namespace Jukebox.Services
{
    public class AlbumService<Song> : IContainerService<Album, Song> where Song : IContainerItem
    {
        private readonly IContainerRepository<AlbumEntity, SongEntity> _containerRepository;
        public AlbumService(IContainerRepository<AlbumEntity, SongEntity> containerRepository)
        {
            _containerRepository = containerRepository;
            
        }
        public void Create(Album container)
        {
            _containerRepository.Create(container.ToEntity());
        }

        public void DeleteById(int id)
        {
            _containerRepository.DeleteById(id);
        }

        public IList<Album> GetAll()
        {
            return _containerRepository.GetAll().Select(c => c.ToDomain()).ToList();
        }

        public Album GetById(int id)
        {
            return _containerRepository.GetById(id).ToDomain();
        }

        public IList<Song> GetContainerItems(Album container)
        {
            return (IList<Song>)_containerRepository.GetContainerItems(container.ToEntity()).Select(s => s.ToDomain()).ToList();
        }

        public IList<Album> GetFilteredContainers(IFiltrator<IContainer> filtrator)
        {
            IList<Album> albums = _containerRepository.GetAll().Select(c => c.ToDomain()).ToList();
            IList<Album> filteredAlbums = new List<Album>();
            foreach (var album in albums)
            {
                if(filtrator.Filter(album))
                {
                    filteredAlbums.Add(album);
                }
            }
            return filteredAlbums;
        }

        public IList<Song> GetFilteredContainerItemsFromContainers(IList<Album> containers, IFiltrator<IContainerItem> filtrator)
        {
            IList<Song> songs = new List<Song>();
            foreach (var container in containers)
            {
                foreach (var containerItem in GetContainerItems(container))
                {
                    if (filtrator.Filter(containerItem))
                    {
                        songs.Add(containerItem);
                    }
                }
            }
            return songs;
        }
        public void Update(Album container)
        {
            _containerRepository.Update(container.ToEntity());
        }
    }
}
