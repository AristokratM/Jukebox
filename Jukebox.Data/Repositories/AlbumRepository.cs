using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Data.Repositories.Abstract;
using Jukebox.Entities.Abstract;
using Jukebox.Entities;
using Jukebox.Data.Filters.Abstract;

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

        public IList<AlbumEntity> GetFilteredAlbums(IEntityFiltrator<AlbumEntity> filtrator)
        {
            IList<AlbumEntity> albumEntities = new List<AlbumEntity>();
            foreach (var albumEntity in GetAll())
            {
                if(filtrator.Filter(albumEntity))
                {
                    albumEntities.Add(albumEntity);
                }
            }
            return albumEntities;
        }

        public IList<SongEntity> GetFilteredContainerItemsFromAlbums(IList<AlbumEntity> albums, IEntityFiltrator<SongEntity> filtrator)
        {
            IList<SongEntity> containerItems = new List<SongEntity>();
            foreach (var albumEntity in albums)
            {
                foreach (var containerItem in GetAlbumItems(albumEntity))
                {
                    if(filtrator.Filter(containerItem))
                    {
                        containerItems.Add(containerItem);
                    }
                }
            }
            return containerItems;
        }
    }
}
