using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Models.Abstract;
namespace Jukebox.Models
{
    public class AlbumModel: IContainerModel
    {
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public float ItemPlayPrice { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", Name, ReleaseDate, ItemPlayPrice);
        }
    }
}
