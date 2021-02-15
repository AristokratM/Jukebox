using System;
using System.Collections.Generic;
using System.Text;
using Jukebox.Interfaces;
namespace Jukebox.Models
{
    public class Album: IBase<Album>, IContainer
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
        public string Name { get; set; }

        private Guid _id;
        public Guid Id
        {
            get { if (_id == Guid.Empty) _id = Guid.NewGuid(); return _id; }
        }



        public Album(String name, DateTime releaseDate, Single itemPlayPrice) 
        {
            this.Name = name;
            this.ReleaseDate = releaseDate;
            this.ItemPlayPrice = itemPlayPrice;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", Name, ReleaseDate, ItemPlayPrice);
        }
    }
}
