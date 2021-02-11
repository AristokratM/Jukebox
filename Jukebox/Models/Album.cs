using System;
using System.Collections.Generic;
using System.Text;
using Jukebox.Interfaces;
namespace Jukebox.Models
{
    public class Album:BaseClass<Album>, IContainer
    {

        private DateTime _releaseDate;
        public DateTime ReleaseDate
        {
            get { return _releaseDate; }
            set { _releaseDate = value; }
        }
        private Single _itemPlayPrice;
        public Single ItemPlayPrice
        {
            get { return _itemPlayPrice; }
            set { _itemPlayPrice = value; }
        }

        public Album(String name, DateTime releaseDate, Single itemPlayPrice) : base(name)
        {
            this.ReleaseDate = releaseDate;
            this.ItemPlayPrice = itemPlayPrice;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", Name, ReleaseDate, ItemPlayPrice);
        }
    }
}
