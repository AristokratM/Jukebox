using Jukebox.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox.Services.Abstract
{
    public interface IContainerService<T> where T:IContainer
    {
        void Add(T container);
        void Update(T container);
        T GetById(int id);
        void DeleteById(int id);
    }
}
