using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox.Models.Abstract
{
    public interface IContainerItemModel : IBaseModel
    {
        String Name { get; set; }
        String Genre { get; set; }
        String Author { get; set; }
        String Performer { get; set; }
        Single Duration { get; set; }

        Int32 ContainerId { get; set; }
    }
}
