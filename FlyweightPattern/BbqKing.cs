using System;
using System.Globalization;

namespace FlyweightPattern
{
    class BbqKing : Slider
    {
        public BbqKing()
        {
            Name = "BBQ King";
            Cheese = "American";
            Toppings = "Onion rings, lettuce, and BBQ sauce";
            Price = 2.49m;
        }

        public override void Display(int orderTotal)
        {
            Console.WriteLine("Slider #" + orderTotal + ": " + Name + " - topped with " + Cheese + 
                              " cheese and " + Toppings + "! $" + Price.ToString(CultureInfo.InvariantCulture));
        }
    }
}