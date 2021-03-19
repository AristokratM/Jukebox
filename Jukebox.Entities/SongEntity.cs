using Jukebox.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Jukebox.Entities
{
    public class SongEntity : IBaseEntity<int>
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public string Performer { get; set; }
        public int Id { get; set; }
        public float Duration { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ContainerId { get; set; }

    }
}
