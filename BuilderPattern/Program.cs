using System;

namespace BuilderPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var mealBuilder = new MealBulder();

            var vegMeal = mealBuilder.PrepareVegMeal();
            Console.WriteLine("Veg Meal:");
            vegMeal.ShowItems();
            Console.WriteLine("Total Cost: " + vegMeal.Cost);

            var nonVegMeal = mealBuilder.PrepareNonVegMeal();
            Console.WriteLine("\n\nNon-Veg Meal:");
            nonVegMeal.ShowItems();
            Console.WriteLine("Total Cost: " + nonVegMeal.Cost);
        }
    }
}
