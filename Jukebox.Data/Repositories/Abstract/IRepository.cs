using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Entities.Abstract;
namespace Jukebox.Data.Repositories.Abstract
{
    public interface IRepository<T> where T: IBaseEntity
    {
        void Create(T entity);
        void Update(T entity);

        T GetById(int id);

        void DeleteById(int id);

        IList<T> GetAll();
    }
}
