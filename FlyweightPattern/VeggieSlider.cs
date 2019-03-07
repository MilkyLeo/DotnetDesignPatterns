using System;
using System.Globalization;

namespace FlyweightPattern
{
    class VeggieSlider: Slider
    {
        public VeggieSlider()
        {
            Name = "Veggie Slider";
            Toppings = "lettuce, onion, tomato, and pickles";
            Cheese = "Swiss";
            Price = 1.99m;
        }

        public override void Display(int orderTotal)
        {
            Console.WriteLine("Slider #" + orderTotal + ": " + Name + " - topped with " + Cheese +
                              " cheese and " + Toppings + "! $" + Price.ToString(CultureInfo.InvariantCulture));
        }
    }
}