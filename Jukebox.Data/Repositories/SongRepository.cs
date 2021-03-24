using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Data.Repositories.Abstract;
using Jukebox.Entities;
using Jukebox.Entities.Abstract;

namespace Jukebox.Data.Repositories
{
    public class SongRepository : Repository<SongEntity, int>, ISongRepository<SongEntity, int>
    {
        private JukeboxContext context;

        public SongRepository(JukeboxContext context) : base(context)
        {
            this.context = context;
        }

        public IList<SongEntity> GetSongsFromContainer(AlbumEntity containerEntity)
        {
            return context.Songs.Where(s=>s.ContainerId == containerEntity.Id).ToList();
        }

    }
}
