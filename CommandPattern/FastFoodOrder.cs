using System;
using System.Collections.Generic;

namespace CommandPattern
{
    public class FastFoodOrder
    {
        public List<MenuItem> CurrentItems { get; set; }

        public FastFoodOrder()
        {
            CurrentItems = new List<MenuItem>();
        }

        public void ExcuteCommand(OrderCommand command, MenuItem item)
        {
            command.Execute(CurrentItems, item);
        }

        public void ShowCurrentItems()
        {
            foreach (var item in CurrentItems)
            {
                item.Display();
            }
            Console.WriteLine("---------------------------------------------");
        }
    }
}