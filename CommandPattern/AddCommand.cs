using System.Collections.Generic;

namespace CommandPattern
{
    /// <summary>
    /// A concrete command for adding order
    /// </summary>
    public class AddCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
        {
            currentItems.Add(newItem);
        }
    }
}