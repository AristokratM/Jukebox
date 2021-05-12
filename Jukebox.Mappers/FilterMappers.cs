using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Domain.Filters;
using Jukebox.Data.Filters;
using Jukebox.Domain.Abstract;
using Jukebox.Data.Filters.Abstract;
using Jukebox.Entities;
using Jukebox.Domain;

namespace Jukebox.Mappers
{
    public static class FilterMappers
    {

        public static IEntityFiltrator<AlbumEntity> ToEntity(this IFiltrator<Album> filter)
        {
            if(filter is ContainerFilter)
            {
                ContainerFilter filterImpl = ((ContainerFilter)filter);
                return new ContainerEntityFilter(filterImpl.Balance, filterImpl.Name);
            }
            return new ContainerEntityFilter(0, string.Empty);
        }

        public static IEntityFiltrator<SongEntity> ToEntity(this IFiltrator<Song> filter)
        {
            if (filter is ContainerItemFilter)
            {
                ContainerItemFilter filterImpl = ((ContainerItemFilter)filter);
                return new ContainerItemEntityFilter(filterImpl.Author, filterImpl.Genre, filterImpl.Performer);
            }
            return new ContainerItemEntityFilter(string.Empty, string.Empty, string.Empty);
        }
    }
}
