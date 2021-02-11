using System;
using System.Collections.Generic;
using System.Text;
using Jukebox.Models;
namespace Jukebox.Interfaces
{
    public interface IFilterBehavior<T>
    {
        public List<T> filter(List<T> data);
    }
}
