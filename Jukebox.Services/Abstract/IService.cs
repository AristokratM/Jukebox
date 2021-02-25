using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Domain.Abstract;
namespace Jukebox.Services.Abstract
{
    public interface IService<T> where T: IBase
    {
        void Create(T dto);
        void Update(T dto);
        T GetById(int id);
        void DeleteById(int id);

        IList<T> GetAll();
    }
}
