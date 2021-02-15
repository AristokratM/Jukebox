using System;
using System.Collections.Generic;
using System.Text;

namespace Jukebox.Interfaces
{
    public interface IDataReader
    {

        public IFiltrator<IContainer> GetContainerFilter();

        public IFiltrator<IContainerItem> GetContainerItemFilter();
    }
}
