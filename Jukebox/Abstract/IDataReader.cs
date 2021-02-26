using System;
using System.Collections.Generic;
using System.Text;
using Jukebox.Domain.Abstract;
namespace Jukebox.Abstract
{
    public interface IDataReader
    {
         IFiltrator<IContainer> GetContainerFilter();

         IFiltrator<IContainerItem> GetContainerItemFilter();
    }
}
