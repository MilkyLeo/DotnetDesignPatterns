using System.Collections.Generic;
using System.Linq;

namespace CommandPattern
{
    /// <summary>
    /// A concrete command for modifying order
    /// </summary>
    public class ModifyCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
        {
            var item = currentItems.First(x => x.Name == newItem.Name);
            item.Price = newItem.Price;
            item.Amount = newItem.Amount;
        }
    }
}