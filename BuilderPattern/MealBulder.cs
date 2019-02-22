namespace BuilderPattern
{
    public class MealBulder
    {
        public Meal PrepareVegMeal()
        {
            var meal = new Meal();
            meal.AddItems(new VegBurger());
            meal.AddItems(new Coke());
            return meal;
        }

        public Meal PrepareNonVegMeal()
        {
            var meal = new Meal();
            meal.AddItems(new ChickenBurger());
            meal.AddItems(new Pepsi());
            return meal;
        }
    }
}