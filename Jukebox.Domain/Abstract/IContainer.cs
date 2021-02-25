using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox.Domain.Abstract
{
    public interface IContainer
    {
        String Name { get; set; }

        DateTime ReleaseDate { get; set; }

        Single ItemPlayPrice { get; set; }
    }
}
