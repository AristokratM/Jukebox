using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Domain.Abstract;
namespace Jukebox.Services.Abstract
{
    public interface IService<T, K> where T: IBase<K>
    {
        void Create(T dto);
        void Update(T dto);
        T GetById(K id);
        void DeleteById(K id);

        IList<T> GetAll();
    }
}
