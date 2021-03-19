using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jukebox.Domain.Abstract;
namespace Jukebox.Domain.Filters
{
    public class ContainerFilter : IFiltrator<Album>
    {
        private string Name { get; set; }

        private float Balance { get; set; }
        public ContainerFilter(float balance, string name)
        {
            Name = name;
            Balance = balance;
        }
        public bool Filter(Album model)
        {
            return NameFilter(model) && BalanceFilter(model);
        }

        private bool NameFilter(Album model)
        {
            return Name.Equals("") || Name.Equals(model.Name);
        }

        private bool BalanceFilter(Album model)
        {
            return Balance >= model.ItemPlayPrice;
        }
    }
}
