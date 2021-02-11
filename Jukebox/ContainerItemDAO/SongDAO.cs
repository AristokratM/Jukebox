using Jukebox.Models;
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
   //             IContainerItemDAO<Song> ici = this;
   //             AlbumDAO albDAO = new AlbumDAO(ici);
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
