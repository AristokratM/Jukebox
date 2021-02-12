using System;
using System.Collections.Generic;
using System.Text;
using Jukebox.Models;
namespace Jukebox.Interfaces
{
    public interface IContainerDAO<T> : IDAO<T> 
    {
        public IList<IContainerItem> GetContainerItems(IContainer container);

    }
}
