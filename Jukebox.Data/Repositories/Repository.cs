using Jukebox.Data.Repositories.Abstract;
using Jukebox.Entities;
using Jukebox.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox.Data.Repositories
{
    public class Repository<T, K> : IRepository<T, K> where T : class, IBaseEntity<K>
    {
        private JukeboxContext context;
        private DbSet<T> dbSet;
        public Repository(JukeboxContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }
        public void Create(T entity)
        {
            dbSet.Add(entity);
        }

        public void DeleteById(K id)
        {
            T entityToDelete = dbSet.Find(id);
            if(context.Entry(entityToDelete).State ==EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public IList<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(K id)
        {
            return dbSet.Find(id);
        }

        public void Update(T entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
