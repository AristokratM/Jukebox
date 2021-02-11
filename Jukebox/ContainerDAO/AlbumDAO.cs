using Jukebox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jukebox.Interfaces;
namespace Jukebox.ContainerDAO
{
    public class AlbumDAO<T> : IContainerDAO<Album> where T :IContainerItem
    {
        private static IDictionary<Guid, Album> data;
        private IContainerItemDAO<T> _containerItemDAO;
        public AlbumDAO(IContainerItemDAO<T> containerItemDAO)
        {
            if (data == null)
            {
                data = new Dictionary<Guid, Album>();
                Album alb;
                alb = new Album("Album1", DateTime.Now, 50);
                this.Create(alb);
                alb = new Album("Album2", new DateTime(2002,5, 13), 30);
                this.Create(alb);
                alb = new Album("Album3", new DateTime(2020, 6, 15), 10);
                this.Create(alb);
            }
            _containerItemDAO = containerItemDAO;
        }
        public void Create(Album obj)
        {
            data.Add(obj.Id, obj);
        }

        public void Delete(Guid id)
        {
            data.Remove(id);
        }

        public Album Get(Guid id)
        {
            return data[id];
        }

        public List<Album> GetAll()
        {
            return data.Values.ToList();
        }

        public List<IContainerItem> GetContainerItems(IContainer container)
        {
            List<IContainerItem> containerItems = new List<IContainerItem>();
            foreach (var containerItem in _containerItemDAO.GetAll())
            {
                if (containerItem.ContainerId.Equals(container.Id))
                {
                    containerItems.Add(containerItem);
                }
            }
            return containerItems;
        }

        public void Update(Guid id, Album obj)
        {
            data.Add(id, obj);
        }
    }
}
