using Jukebox.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox.Services.Abstract
{
    public interface IContainerService<T, K>: IService<T> where T:IContainer
    {
        IList<K> GetContainerItems(T container);
        IList<T> GetFilteredContainers(IFiltrator<IContainer> filtrator);

        IList<K> GetFilteredContainerItemsFromContainers(IList<T> containers, IFiltrator<IContainerItem> filtrator);
    }
}
