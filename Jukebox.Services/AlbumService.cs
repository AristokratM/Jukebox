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
using Jukebox.Data.UnitOfWork.Abstract;

namespace Jukebox.Services
{
    public class AlbumService : IAlbumService<Album, int>
    {
        private readonly IUnitOfWork unitOfWork;
        public AlbumService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            
        }
        public void Create(Album container)
        {
            unitOfWork.AlbumRepository.Create(container.ToEntity());
        }

        public void DeleteById(int id)
        {
            unitOfWork.AlbumRepository.DeleteById(id);
        }

        public IList<Album> GetAll()
        {
            return unitOfWork.AlbumRepository.GetAll().Select(c => c.ToDomain()).ToList();
        }

        public Album GetById(int id)
        {
            return unitOfWork.AlbumRepository.GetById(id).ToDomain();
        }

        public IList<Song> GetContainerItems(Album container)
        {
            return unitOfWork.AlbumRepository.GetAlbumItems(container.ToEntity()).Select(s => s.ToDomain()).ToList();
        }

        public IList<Album> GetFilteredContainers(IFiltrator<Album> filtrator)
        {
            IList<Album> albums = unitOfWork.AlbumRepository.GetAll().Select(c => c.ToDomain()).ToList();
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

        public IList<Song> GetFilteredContainerItemsFromContainers(IList<Album> containers, IFiltrator<Song> filtrator)
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
            unitOfWork.AlbumRepository.Update(container.ToEntity());
        }
    }
}
