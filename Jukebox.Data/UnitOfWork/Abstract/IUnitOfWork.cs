using Jukebox.Data.Repositories.Abstract;
using Jukebox.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox.Data.UnitOfWork.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IAlbumRepository<AlbumEntity, int> AlbumRepository { get; }

        ISongRepository<SongEntity, int> SongRepository { get; }
    }
}
