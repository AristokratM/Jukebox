using Jukebox.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Jukebox.Entities
{
    public class AlbumEntity : IBaseEntity<int>
    {
        public int Id { get; set ; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public float ItemPlayPrice { get; set; }
    }
}
