using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox.Data.Interfaces
{
    public interface IDAO<T> where T:BaseClass<T>
    {
         T Get(Guid id);
    }
}
