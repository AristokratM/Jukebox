using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox.Entities.Abstract
{
    public interface IBaseEntity
    {
        Int32 Id { get; set; }
        DateTime CreatedDate { get; set; }
    }
}
