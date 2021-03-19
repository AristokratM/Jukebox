using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Domain;
using Jukebox.Services.Abstract;
using Jukebox.Data.Repositories.Abstract;
using Jukebox.Entities;
using Jukebox.Mappers;
using Jukebox.Domain.Abstract;
using Jukebox.Data.UnitOfWork.Abstract;

namespace Jukebox.Services
{
    public class SongService : IContainerItemService<Song>
    {
        private readonly IUnitOfWork unitOfWork;

        public SongService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public void Create(Song dto)
        {
            unitOfWork.SongRepository.Create(dto.ToEntity());
        }

        public void DeleteById(int id)
        {
            unitOfWork.SongRepository.DeleteById(id);
        }

        public IList<Song> GetAll()
        {
            return unitOfWork.SongRepository.GetAll().Select(s=> s.ToDomain()).ToList();
        }

        public Song GetById(int id)
        {
            return unitOfWork.SongRepository.GetById(id).ToDomain();
        }


        public void Update(Song dto)
        {
            unitOfWork.SongRepository.Update(dto.ToEntity());
        }

        
    }
}
