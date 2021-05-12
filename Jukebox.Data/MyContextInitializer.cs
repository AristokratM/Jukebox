using Jukebox.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox.Data
{
    public class MyContextInitializer : DropCreateDatabaseAlways<JukeboxContext>
    {
        protected override void Seed(JukeboxContext context)
        {
            AlbumEntity albumEntity1 = new AlbumEntity
            {
                Id = 1,
                CreatedDate = DateTime.Now,
                ItemPlayPrice = 50,
                Name = "Буерак",
                ReleaseDate = new DateTime(2002, 5, 4)
            };
            AlbumEntity albumEntity2 = new AlbumEntity
            {
                Id = 2,
                CreatedDate = DateTime.Now,
                ItemPlayPrice = 30,
                Name = "Album2",
                ReleaseDate = new DateTime(2007, 2, 6)
            };
            AlbumEntity albumEntity3 = new AlbumEntity
            {
                Id = 3,
                CreatedDate = DateTime.Now,
                ItemPlayPrice = 70,
                Name = "Album3",
                ReleaseDate = new DateTime(2020, 3, 1)
            };
            context.ALbums.Add(albumEntity1);
            context.ALbums.Add(albumEntity2);
            context.ALbums.Add(albumEntity3);
            SongEntity songEntity1 = new SongEntity
            {
                ContainerId = albumEntity1.Id,
                Name = "Корень Имбиря",
                Genre = "Панк-рок",
                Performer = "Буерак",
                Author = "Буерак",
                Duration = 2.59f,
                CreatedDate = DateTime.Now,
                Id = 1
            };
            SongEntity songEntity2 = new SongEntity
            {
                ContainerId = albumEntity2.Id,
                Name = "Song2",
                Genre = "Genre2",
                Performer = "Performer2",
                Author = "Author2",
                Duration = 4.32f,
                CreatedDate = DateTime.Now,
                Id = 2
            };
            SongEntity songEntity3 = new SongEntity
            {
                ContainerId = albumEntity2.Id,
                Name = "Song3",
                Genre = "Genre3",
                Performer = "Performer3",
                Author = "Author2",
                Duration = 5.22f,
                CreatedDate = DateTime.Now,
                Id = 3
            };
            SongEntity songEntity4 = new SongEntity
            {
                ContainerId = albumEntity3.Id,
                Name = "Song4",
                Genre = "Genre2",
                Performer = "Performer2",
                Author = "Author2",
                Duration = 1.12f,
                CreatedDate = DateTime.Now,
                Id = 4
            };
            context.Songs.Add(songEntity1);
            context.Songs.Add(songEntity2);
            context.Songs.Add(songEntity3);
            context.Songs.Add(songEntity4);
            context.SaveChanges();
        }
    }
}
