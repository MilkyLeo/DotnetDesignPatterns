using System;

namespace FacadePattern
{
    //If you don't want other code accessing the complex bits of a class or process, 
    //you hide those bits by covering them with a Facade.
    //https://exceptionnotfound.net/the-daily-design-pattern-facade/

    class Program
    {
        static void Main()
        {
            var server = new Server();

            Console.WriteLine("Hellow! I'm the server. What's your name?");
            var name = Console.ReadLine();

            var patron = new Patron(name);
            Console.WriteLine("Hello " + patron.Name + ". What appetizer would you like? (1-15):");
            var appId = int.Parse(Console.ReadLine());

            Console.WriteLine("That's a good one.  What entree would you like? (1-20):");
            var entreeId = int.Parse(Console.ReadLine());

            Console.WriteLine("A great choice!  Finally, what drink would you like? (1-60):");
            var drinkId = int.Parse(Console.ReadLine());

            Console.WriteLine("I'll get that order in right away.");

            server.PlaceOrder(patron, appId, entreeId, drinkId);

            Console.ReadKey();
        }
    }
}
