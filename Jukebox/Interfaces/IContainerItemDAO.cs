using System;
using System.Collections.Generic;
using System.Text;
using Jukebox.Models;
namespace Jukebox.Interfaces
{
    public interface IContainerItemDAO<T> : IDAO<T> where T : IContainerItem
    {

    }
}
