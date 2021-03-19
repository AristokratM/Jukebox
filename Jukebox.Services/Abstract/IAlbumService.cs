using Jukebox.Domain;
using Jukebox.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox.Services.Abstract
{
    public interface IAlbumService<T, K>: IService<T, K> where T:IBase<K>
    {
        IList<Song> GetContainerItems(T container);
        IList<T> GetFilteredContainers(IFiltrator<T> filtrator);

        IList<Song> GetFilteredContainerItemsFromContainers(IList<T> containers, IFiltrator<Song> filtrator);
    }
}
