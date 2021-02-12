using System;
using System.Collections.Generic;
using System.Text;

namespace Jukebox.Interfaces
{
    public interface IFiltrator<T>
    {
        public Boolean Filter(T model);
    }
}
