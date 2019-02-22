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
    }
}
