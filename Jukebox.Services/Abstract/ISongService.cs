using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Domain.Abstract;
namespace Jukebox.Services.Abstract
{
    public interface ISongService<T, K> : IService<T, K> where T:IBase<K>
    {
       

    }
}
