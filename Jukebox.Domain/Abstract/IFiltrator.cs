using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox.Domain.Abstract
{
    public interface IFiltrator<T>
    {
         Boolean Filter(T model);
    }
}
