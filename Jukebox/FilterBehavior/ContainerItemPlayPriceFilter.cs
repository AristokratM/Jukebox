using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Jukebox.Interfaces;
namespace Jukebox.FilterBehavior
{
    public class ContainerItemPlayPriceFilter : IFilterBehavior<IContainer>
    {
        public List<IContainer> filter(List<IContainer> data, String query)
        {
            Single price = Convert.ToSingle(query);
            return data.Where(c => c.ItemPlayPrice <= price).ToList();
        }
    }
}
