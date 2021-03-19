using Jukebox.Data.Repositories;
using Jukebox.Data.Repositories.Abstract;
using Jukebox.Data.UnitOfWork.Abstract;
using Jukebox.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private IAlbumRepository<AlbumEntity, int> albumRepository;
        private ISongRepository<SongEntity, int> songRepository;
        public IAlbumRepository<AlbumEntity, int> AlbumRepository
        {
            get
            {
                if(albumRepository == null)
                {
                    albumRepository = new AlbumRepository(SongRepository);
                }
                return albumRepository;
            }
        }

        public ISongRepository<SongEntity, int> SongRepository
        {
            get
            {
                if(songRepository == null)
                {
                    songRepository = new SongRepository();
                }
                return songRepository;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
