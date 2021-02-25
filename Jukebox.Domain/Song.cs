using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Domain.Abstract;
namespace Jukebox.Domain
{
    public class Song : IContainerItem
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Performer { get; set; }
        public String Genre { get; set; }
        public String Author { get; set; }
        public Single Duration { get; set; }
        public Int32 ContainerId { get; set; }
    }
}
