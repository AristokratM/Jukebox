using System;
using System.Collections.Generic;
using System.Text;

namespace Jukebox.Interfaces
{
    public interface IContainer
    {
        public Guid Id { get; }
        public String Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public Single ItemPlayPrice { get; set; }
    }
}
