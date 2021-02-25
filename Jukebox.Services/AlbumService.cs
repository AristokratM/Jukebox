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

namespace Jukebox.Services
{
    public class AlbumService : IContainerService<Album>
    {
        private readonly IContainerRepository _containerRepository;

        public AlbumService(IContainerRepository containerRepository)
        {
            _containerRepository = containerRepository;
        }
        public void Add(Album container)
        {
            _containerRepository.Add(container.ToEntity());
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Album GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Album container)
        {
            throw new NotImplementedException();
        }
    }
}
