using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Entities;
using Jukebox.Entities.Abstract;

namespace Jukebox.Data.Repositories.Abstract
{
    public interface IAlbumRepository<T, K> : IRepository<T, K> where T:IBaseEntity<K>
    {
        IList<SongEntity> GetAlbumItems(T album);
    }
}
