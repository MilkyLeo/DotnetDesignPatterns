using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CommandPattern
{
    //https://exceptionnotfound.net/command-the-daily-design-pattern/
    //The Command design pattern encapsulates a request as an object, thereby allowing us to treat that
    //request differently based on what class receives said command.
    //Further, it enables much more complex architectures, and even enables operations such as undo/redo.
    internal class Program
    {
        private static void Main()
        {
            var patron = new Patron();

            patron.MakeOneItemOrder(1 /*Add*/, new MenuItem("French Fries", 2, 1.99));
            patron.MakeOneItemOrder(1 /*Add*/, new MenuItem("Hamburger", 2, 2.59));
            patron.MakeOneItemOrder(1 /*Add*/, new MenuItem("Drink", 2, 1.19));
            patron.ShowCurrentOrder();

            //Remove the French Fries
            patron.MakeOneItemOrder(3 /*Remove*/, new MenuItem("French Fries", 2, 1.99));
            patron.ShowCurrentOrder();

            //Now we want 4 Humburgers rather than 2
            patron.MakeOneItemOrder(2 /*Modify*/, new MenuItem("Hamburger", 4, 2.59));
            patron.ShowCurrentOrder();

            Console.ReadKey();
        }

        /// <summary>
        /// Represents an item being ordered from this restaurant.
        /// </summary>
        public class MenuItem
        {
            public string Name { get; set; }
            public int Amount { set; get; }
            public double Price { get; set; }

            public MenuItem(string name, int amount, double price)
            {
                Name = name;
                Amount = amount;
                Price = price;
            }

            public void Display()
            {
                Console.WriteLine("\nName: " + Name);
                Console.WriteLine("Amount: " + Amount.ToString());
                Console.WriteLine("Price: $" + Price.ToString(CultureInfo.CurrentCulture));
            }
        }

        /// <summary>
        /// The Command abstract class
        /// </summary>
        public abstract class OrderCommand
        {
            public abstract void Execute(List<MenuItem> order, MenuItem newItem);
        }

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

        /// <summary>
        /// A concrete command for removing order
        /// </summary>
        public class RemoveCommand : OrderCommand
        {
            public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
            {
                currentItems.Remove(currentItems.First(x => x.Name == newItem.Name));
            }
        }

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


        public class FastFoodOrder
        {
            public List<MenuItem> CurrentItems { get; set; }

            public FastFoodOrder()
            {
                CurrentItems = new List<MenuItem>();
            }

            public void ExcuteCommand(OrderCommand command, MenuItem item) //Shouldn't be here!
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

        public class CommandFactory
        {
            public OrderCommand GetCommand(int commandOption)
            {
                switch (commandOption)
                {
                    case 1:
                        return new AddCommand();
                    case 2:
                        return new ModifyCommand();
                    case 3:
                        return new RemoveCommand();
                    default:
                        return new AddCommand();
                }
                    
            }
        }

        public class Patron
        {
            private OrderCommand _orderCommand;
            private MenuItem _menuItem;
            private readonly FastFoodOrder _order;

            public Patron()
            {
                _order = new FastFoodOrder();
            }

            public void MakeOneItemOrder(int commandOption, MenuItem item)
            {
                SetCommand(commandOption);
                SetMenuItem(item);

                ExecuteCommand();
            }
            private void SetCommand(int commandOption)
            {
                _orderCommand = new CommandFactory().GetCommand(commandOption);
            }

            private void SetMenuItem(MenuItem item)
            {
                _menuItem = item;
            }

            public void ExecuteCommand()
            {
                _order.ExcuteCommand(_orderCommand, _menuItem);
            }

            public void ShowCurrentOrder()
            {
                _order.ShowCurrentItems();
            }
        }
    }


}
