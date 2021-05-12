using Jukebox.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox.Data.Filters.Abstract
{
    public interface IEntityFiltrator<T>
    {
        bool Filter(T entity);
    }
}
