using System;

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

            patron.AddOneMenuItemToOrder(new MenuItem("French Fries", 2, 1.99));
            patron.AddOneMenuItemToOrder(new MenuItem("Hamburger", 2, 2.59));
            patron.AddOneMenuItemToOrder(new MenuItem("Drink", 2, 1.19));
            patron.ShowCurrentOrder();

            patron.RemoveOneMenuItemFromOrder(new MenuItem("French Fries", 2, 1.99));
            patron.ShowCurrentOrder();

            patron.ModifyOneMenuItemInOrder(new MenuItem("Hamburger", 4, 2.59));
            patron.ShowCurrentOrder();

            Console.ReadKey();
        }
    }
}
