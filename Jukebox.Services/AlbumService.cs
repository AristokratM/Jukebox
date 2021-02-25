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
    public class AlbumService : IContainerService<Album>
    {
        private readonly IContainerRepository<AlbumEntity> _containerRepository;

        public AlbumService(IContainerRepository<AlbumEntity> containerRepository)
        {
            _containerRepository = containerRepository;
        }
        public void Add(Album container)
        {
            _containerRepository.Add(container.ToEntity());
        }

        public void DeleteById(int id)
        {
            _containerRepository.DeleteById(id);
        }

        public Album GetById(int id)
        {
            return _containerRepository.GetById(id).ToDomain();
        }

        public void Update(Album container)
        {
            _containerRepository.Update(container.ToEntity());
        }
    }
}
