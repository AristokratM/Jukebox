using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox.Entities.Abstract
{
    public interface IBaseEntity<K>
    {
        K Id { get; set; }
        DateTime CreatedDate { get; set; }
    }
}
