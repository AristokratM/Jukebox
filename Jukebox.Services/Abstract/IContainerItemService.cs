using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Domain.Abstract;
namespace Jukebox.Services.Abstract
{
    public interface IContainerItemService<T> : IService<T> where T:IContainerItem
    {
    }
}
