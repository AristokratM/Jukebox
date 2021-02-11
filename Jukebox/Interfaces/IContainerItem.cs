using System;
using System.Collections.Generic;
using System.Text;

namespace Jukebox.Interfaces
{
    public interface IContainerItem
    {
        public Guid Id { get; }
        public String Name { get; set; }
        public String Genre { get; set; }
        public String Author { get; set; }
        public String Performer { get; set; }
        public Single Duration { get; set; }

        public Guid ContainerId { get; set; }
    }
}
