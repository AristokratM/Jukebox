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
    public class AlbumRepository : IAlbumRepository<AlbumEntity, int> 
    {
        private static IDictionary<int, AlbumEntity> _data;
        private ISongRepository<SongEntity, int> _containerItemRepository;
        public AlbumRepository(ISongRepository<SongEntity, int> containerItemRepository)
        {
            _containerItemRepository = containerItemRepository;
            if(_data == null)
            {
                _data = new Dictionary<int, AlbumEntity>();
                AlbumEntity albumEntity = new AlbumEntity {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    ItemPlayPrice = 50,
                    Name = "Буерак",
                    ReleaseDate = new DateTime(2002, 5, 4)
                };
                Create(albumEntity);
                albumEntity = new AlbumEntity
                {
                    Id = 2,
                    CreatedDate = DateTime.Now,
                    ItemPlayPrice = 30,
                    Name = "Album2",
                    ReleaseDate = new DateTime(2007, 2, 6)
                };
                Create(albumEntity);
                albumEntity = new AlbumEntity
                {
                    Id = 3,
                    CreatedDate = DateTime.Now,
                    ItemPlayPrice = 70,
                    Name = "Album3",
                    ReleaseDate = new DateTime(2020, 3, 1)
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

        public IList<SongEntity> GetAlbumItems(AlbumEntity containerEntity)
        {
            return _containerItemRepository.GetSongsFromContainer(containerEntity);
        }

        public void Update(AlbumEntity container)
        {
            _data[container.Id] = container;
        }

    }
}
