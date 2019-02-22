using System;
using System.Collections.Generic;
using System.Linq;

namespace BuilderPattern
{
    public class Meal
    {
        private readonly List<IItem> _items = new List<IItem>();

        public void AddItems(IItem item)
        {
            _items.Add(item);
        }

        public float Cost
        {
            get
            {
                return _items.Sum(item => item.Price());
            }
        }

        public void ShowItems()
        {
            foreach (var item in _items)
            {
                Console.WriteLine("Item : " + item.Name);
                Console.WriteLine("Packing : " + item.Packing().Packing);
                Console.WriteLine("Price : " + item.Price());
            }
        }

    }
}