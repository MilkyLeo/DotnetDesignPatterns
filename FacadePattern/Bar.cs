namespace FacadePattern
{
    public class Bar : IKichenSection
    {
        public FoodItem PrepDish(int dishId)
        {
            return new FoodItem()
            {
                DishId = dishId
            };
        }
    }
}