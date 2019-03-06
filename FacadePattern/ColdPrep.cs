namespace FacadePattern
{
    public class ColdPrep : IKichenSection
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