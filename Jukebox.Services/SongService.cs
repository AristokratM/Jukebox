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

namespace Jukebox.Services
{
    public class SongService : IContainerItemService<Song>
    {
        private readonly IContainerItemRepository<SongEntity> _containerItemRepository;

        public SongService(IContainerItemRepository<SongEntity> containerItemRepository)
        {
            _containerItemRepository = containerItemRepository;
        }
        public void Create(Song dto)
        {
            _containerItemRepository.Create(dto.ToEntity());
        }

        public void DeleteById(int id)
        {
            _containerItemRepository.DeleteById(id);
        }

        public IList<Song> GetAll()
        {
            return _containerItemRepository.GetAll().Select(s=> s.ToDomain()).ToList();
        }

        public Song GetById(int id)
        {
            return _containerItemRepository.GetById(id).ToDomain();
        }


        public void Update(Song dto)
        {
            _containerItemRepository.Update(dto.ToEntity());
        }

        
    }
}
