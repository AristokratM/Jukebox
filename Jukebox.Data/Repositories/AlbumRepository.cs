using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Data.Repositories.Abstract;
using Jukebox.Entities.Abstract;
using Jukebox.Entities;

namespace Jukebox.Data.Repositories
{
    public class AlbumRepository : IContainerRepository<AlbumEntity>
    {
        private static IDictionary<Int32, AlbumEntity> _data;
        private IContainerItemRepository<SongEntity> _containerItemRepository;
        public AlbumRepository(IContainerItemRepository<SongEntity> containerItemRepository)
        {
            _containerItemRepository = containerItemRepository;
            if(_data == null)
            {
                _data = new Dictionary<Int32, AlbumEntity>();
                AlbumEntity albumEntity = new AlbumEntity {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    ItemPlayPrice = 50,
                    Name = "Буерак",
                    ReleaseDate = new DateTime(2002, 13, 5)
                };
                Create(albumEntity);
                albumEntity = new AlbumEntity
                {
                    Id = 2,
                    CreatedDate = DateTime.Now,
                    ItemPlayPrice = 30,
                    Name = "Album2",
                    ReleaseDate = new DateTime(2007, 14, 6)
                };
                Create(albumEntity);
                albumEntity = new AlbumEntity
                {
                    Id = 3,
                    CreatedDate = DateTime.Now,
                    ItemPlayPrice = 70,
                    Name = "Album3",
                    ReleaseDate = new DateTime(2020, 24, 1)
                };
                Create(albumEntity);
            }
        }
        public void Create(AlbumEntity container)
        {
            _data.Add(container.Id, container);
        }

        public void DeleteById(int id)
        {
            _data.Remove(id);
        }

        public IList<AlbumEntity> GetAll()
        {
            return _data.Values.ToList();
        }

        public AlbumEntity GetById(int id)
        {
            return _data[id];
        }

        public IList<IContainerItemEntity> GetContainerItems(AlbumEntity albumEntity)
        {
            return (IList<IContainerItemEntity>)_containerItemRepository.GetContainerItemsFromContainer(albumEntity);
        }

        public void Update(AlbumEntity container)
        {
            _data[container.Id] = container;
        }
    }
}
