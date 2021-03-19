using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Entities.Abstract;
namespace Jukebox.Data.Repositories.Abstract
{
    public interface IRepository<T, K> where T: IBaseEntity<K>
    {
        void Create(T entity);
        void Update(T entity);

        T GetById(K id);

        void DeleteById(K id);

        IList<T> GetAll();
    }
}
