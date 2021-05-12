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
using Jukebox.Domain.Filters;

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
            return unitOfWork.AlbumRepository.GetFilteredAlbums(filtrator.ToEntity()).Select(s=>s.ToDomain()).ToList();
        }

        public IList<Song> GetFilteredContainerItemsFromContainers(IList<Album> containers, IFiltrator<Song> filtrator)
        {
            return unitOfWork.AlbumRepository.GetFilteredContainerItemsFromAlbums(
                containers.Select(s => s.ToEntity()).ToList(), 
                filtrator.ToEntity()).Select(s => s.ToDomain()).ToList();
        }
        public void Update(Album container)
        {
            unitOfWork.AlbumRepository.Update(container.ToEntity());
        }
    }
}
