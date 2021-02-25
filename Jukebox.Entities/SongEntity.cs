using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Entities.Abstract;
namespace Jukebox.Entities
{
    public class SongEntity : IContainerItemEntity
    {
        public String Name { get; set; }
        public String Genre { get; set; }
        public String Author { get; set; }
        public String Performer { get; set; }
        public Int32 Id { get; set; }
        public Single Duration { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int32 ContainerId { get; set; }

    }
}
