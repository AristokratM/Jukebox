﻿using Jukebox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jukebox.Interfaces;
using Jukebox.ContainerDAO;
namespace Jukebox.ContainerItemDAO
{
    public class SongDAO : IContainerItemDAO<Song>
    {
        private IDictionary<Guid, Song> data;

        public SongDAO()
        {

            if (data == null)
            {
                data = new Dictionary<Guid, Song>();
                AlbumDAO<Song> albDAO = new AlbumDAO<Song>(this);
                List<Album> albums = albDAO.GetAll();
                Song song;
                song = new Song(albums[0], "Корень Имбиря", "Панк-рок", "Буерак", "Буерак", 2.59f);
                this.Create(song);
                song = new Song(albums[1], "Song2", "Genre2", "Author2", "Performer2", 3.42f);
                this.Create(song);
                song = new Song(albums[2], "Song3", "Genre3", "Author2", "Performer3", 3.42f);
                this.Create(song);
                song = new Song(albums[2], "Song4", "Genre2", "Author2", "Performer2", 3.42f);
                this.Create(song);
            }
        }
        public void Create(Song obj)
        {
            data.Add(obj.Id, obj);
        }

        public void Delete(Guid id)
        {
            data.Remove(id);
        }

        public Song Get(Guid id)
        {
            return data[id];
        }

        public List<Song> GetAll()
        {
            return data.Values.ToList();
        }

        public void Update(Guid id, Song obj)
        {
            data.Add(id, obj);
        }
    }
}
