using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Data.Repositories.Abstract;
using Jukebox.Entities.Abstract;
using Jukebox.Entities;

namespace Jukebox.Data.Repositories
{
    public class AlbumRepository : Repository<AlbumEntity, int>, IAlbumRepository<AlbumEntity, int> 
    {
        private JukeboxContext context;
        public AlbumRepository(JukeboxContext context) : base(context)
        {
            this.context = context;
        }
      
        public IList<SongEntity> GetAlbumItems(AlbumEntity containerEntity)
        {
            return context.Songs.Where(s => s.ContainerId == containerEntity.Id).ToList();
        }


    }
}
