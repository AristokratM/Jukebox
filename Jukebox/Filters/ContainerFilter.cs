using System;
using System.Collections.Generic;
using System.Text;
using Jukebox.Interfaces;
namespace Jukebox.Filters
{
    public class ContainerFilter : IFiltrator<IContainer>
    {
        private String Name { get; set; }

        private Single Balance { get; set; }
        public ContainerFilter (Single balance, String name)
        {
            Name = name;
            Balance = balance;
        }
        public bool Filter(IContainer model)
        {
            return NameFilter(model) && BalanceFilter(model);
        }

        private bool NameFilter(IContainer model)
        {
            return Name.Equals("") || Name.Equals(model.Name);
        }

        private bool BalanceFilter(IContainer model)
        {
            return Balance >= model.ItemPlayPrice;
        }
    }
}
