using System;
using System.Collections.Generic;
using System.Text;
using Jukebox.Models;
namespace Jukebox.FilterBehavior
{
    public interface IFilterBehavior<T> where T:BaseClass<T>
    {
        public List<T> filter(List<T> data);
    }
}
