using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Entities.Abstract;
namespace Jukebox.Data.Repositories.Abstract
{
    public interface IContainerItemRepository<T>: IRepository<T> where T:IContainerItemEntity
    {
        IList<T> GetContainerItemsFromContainer(IContainerEntity containerEntity);
    }
}
