using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Data.Repositories.Abstract;
using Jukebox.Entities;
using Jukebox.Entities.Abstract;

namespace Jukebox.Data.Repositories
{
    public class SongRepository : ISongRepository<SongEntity, int>
    {
        private static  IDictionary<Int32, SongEntity> _data;

        public SongRepository()
        {
            if(_data == null)
            {
                _data = new Dictionary<Int32, SongEntity>();
                AlbumRepository albumRepository = new AlbumRepository(this);
                IList<AlbumEntity> albumEntities = albumRepository.GetAll();
                SongEntity songEntity;
                songEntity = new SongEntity { 
                    ContainerId =  albumEntities[0].Id,
                    Name = "Корень Имбиря",
                    Genre = "Панк-рок",
                    Performer = "Буерак",
                    Author ="Буерак", 
                    Duration = 2.59f,
                    CreatedDate = DateTime.Now,
                    Id = 1
                };
                Create(songEntity);
                songEntity = new SongEntity
                {
                    ContainerId = albumEntities[1].Id,
                    Name = "Song2",
                    Genre = "Genre2",
                    Performer = "Performer2",
                    Author = "Author2",
                    Duration = 4.32f,
                    CreatedDate = DateTime.Now,
                    Id = 2
                };
                Create(songEntity);
                songEntity = new SongEntity
                {
                    ContainerId = albumEntities[1].Id,
                    Name = "Song3",
                    Genre = "Genre3",
                    Performer = "Performer3",
                    Author = "Author2",
                    Duration = 5.22f,
                    CreatedDate = DateTime.Now,
                    Id = 3
                };
                Create(songEntity);
                songEntity = new SongEntity
                {
                    ContainerId = albumEntities[2].Id,
                    Name = "Song4",
                    Genre = "Genre2",
                    Performer = "Performer2",
                    Author = "Author2",
                    Duration = 1.12f,
                    CreatedDate = DateTime.Now,
                    Id = 4
                };
                Create(songEntity);

            }
        }
        public void Create(SongEntity entity)
        {
            _data.Add(entity.Id, entity);
        }

        public void DeleteById(int id)
        {
            _data.Remove(id);
        }

        public IList<SongEntity> GetAll()
        {
            return _data.Values.ToList();
        }

        public SongEntity GetById(int id)
        {
            return _data[id];
        }

        public IList<SongEntity> GetSongsFromContainer(AlbumEntity containerEntity)
        {
            IList<SongEntity> result = new List<SongEntity>();
            foreach (var song in GetAll())
            {
                if(song.ContainerId == containerEntity.Id)
                {
                    result.Add(song);
                }
            }
            return result;
        }

        public void Update(SongEntity entity)
        {
            _data[entity.Id] = entity;
        }
    }
}
