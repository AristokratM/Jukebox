using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox.Entities.Abstract
{
    public interface IContainerEntity : IBaseEntity
    {

        String Name { get; set; }

        DateTime ReleaseDate { get; set; }

        Single ItemPlayPrice { get; set; }
    }
}
