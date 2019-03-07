using System;
using System.Globalization;

namespace FlyweightPattern
{
    class BaconMaster : Slider
    {
        public BaconMaster()
        {
            Name = "BaconMaster";
            Toppings = "lots of bacon";
            Cheese = "American";
            Price = 2.39m;
        }

        public override void Display(int orderTotal)
        {
            Console.WriteLine("Slider #" + orderTotal + ": " + Name + " - topped with " + 
                              Cheese + " cheese and " + Toppings + "! $" + Price.ToString(CultureInfo.InvariantCulture));
        }
    }
}