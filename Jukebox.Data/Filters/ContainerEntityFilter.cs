using Jukebox.Data.Filters.Abstract;
using Jukebox.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox.Data.Filters
{
    public class ContainerEntityFilter : IEntityFiltrator<AlbumEntity>
    {
        public string Name { get; set; }

        public float Balance { get; set; }
        public ContainerEntityFilter(float balance, string name)
        {
            Name = name;
            Balance = balance;
        }
        public bool Filter(AlbumEntity model)
        {
            return NameFilter(model) && BalanceFilter(model);
        }

        private bool NameFilter(AlbumEntity model)
        {
            return Name.Equals("") || Name.Equals(model.Name);
        }

        private bool BalanceFilter(AlbumEntity model)
        {
            return Balance >= model.ItemPlayPrice;
        }
    }
}
