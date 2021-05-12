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
        private JukeboxContext context = new JukeboxContext();
        public IAlbumRepository<AlbumEntity, int> AlbumRepository
        {
            get
            {
                if(albumRepository == null)
                {
                    albumRepository = new AlbumRepository(context);
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
                    songRepository = new SongRepository(context);
                }
                return songRepository;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
