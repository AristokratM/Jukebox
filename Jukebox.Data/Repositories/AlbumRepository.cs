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
        public AlbumRepository()
        {
            if(_data == null)
            {
                _data = new Dictionary<Int32, AlbumEntity>();
                AlbumEntity albumEntity = new AlbumEntity {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    ItemPlayPrice = 50,
                    Name = "NЮ",
                    ReleaseDate = new DateTime(2002, 13, 5)
                };
                Add(albumEntity);
                albumEntity = new AlbumEntity
                {
                    Id = 2,
                    CreatedDate = DateTime.Now,
                    ItemPlayPrice = 30,
                    Name = "Album2",
                    ReleaseDate = new DateTime(2007, 14, 6)
                };
                Add(albumEntity);
                albumEntity = new AlbumEntity
                {
                    Id = 3,
                    CreatedDate = DateTime.Now,
                    ItemPlayPrice = 70,
                    Name = "Album3",
                    ReleaseDate = new DateTime(2020, 24, 1)
                };
                Add(albumEntity);
            }
        }
        public void Add(AlbumEntity container)
        {
            _data.Add(container.Id, container);
        }

        public void DeleteById(int id)
        {
            _data.Remove(id);
        }

        public AlbumEntity GetById(int id)
        {
            return _data[id];
        }

        public void Update(AlbumEntity container)
        {
            _data[container.Id] = container;
        }
    }
}
