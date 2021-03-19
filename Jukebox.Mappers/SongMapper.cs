using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Entities;
using Jukebox.Domain;
namespace Jukebox.Mappers
{
    public static class SongMapper
    {
        public static SongEntity ToEntity(this Song song)
        {
            return new SongEntity
            {
                Author = song.Author,
                Genre = song.Genre,
                Name = song.Name,
                Duration = song.Duration,
                Id = song.Id,
                ContainerId = song.ContainerId,
                Performer = song.Performer,
                CreatedDate = DateTime.Now
                
            };
        }

        public static Song ToDomain(this SongEntity songEntity)
        {
            return new Song
            {
                Author = songEntity.Author,
                Genre = songEntity.Genre,
                Name = songEntity.Name,
                Duration = songEntity.Duration,
                Id = songEntity.Id,
                ContainerId = songEntity.ContainerId,
                Performer = songEntity.Performer
            };
        }

    }
}
