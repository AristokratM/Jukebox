using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Entities.Abstract;

namespace Jukebox.Data.Repositories.Abstract
{
    public interface IContainerRepository<T, K> : IRepository<T> where T:IContainerEntity where K : IContainerItemEntity
    {
        IList<K> GetContainerItems(T containerEntity);
    }
}
