using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Domain.Filters;
using Jukebox.Data.Filters;
namespace Jukebox.Mappers
{
    public static class FilterMappers
    {
        public static ContainerEntityFilter ToEntity(this ContainerFilter filter)
        {
            return new ContainerEntityFilter(filter.Balance, filter.Name);
        }
        
        public static ContainerItemEntityFilter ToEntity(this ContainerItemFilter filter)
        {
            return new ContainerItemEntityFilter(filter.Author, filter.Genre, filter.Performer);
        }
        
    }
}
