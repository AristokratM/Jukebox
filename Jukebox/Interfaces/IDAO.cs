using Jukebox.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jukebox.Interfaces
{
    public interface IDAO<T>
    {
        public T Get(Guid id);

        public void Create(T obj);

        public void Update(Guid id, T obj);

        public void Delete(Guid id);

        public List<T> GetAll();

    }
}
