using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Entities.Abstract;

namespace Jukebox.Data.Repositories.Abstract
{
    public interface IContainerRepository<T> where T:IContainerEntity
    {
        void Add(T container);
        void Update(T container);

        T GetById(int id);

        void DeleteById(int id);
    }
}
