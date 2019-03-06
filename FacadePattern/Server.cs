using System;

namespace FacadePattern
{
    /// <summary>
    /// The actual "Facade" class, which hides the complexity of the KitchenSection classes.
    /// After all, there's no reason a patron should order each part of their meal individually.
    /// </summary>
    public class Server
    {
        private readonly ColdPrep _codePrep = new ColdPrep();
        private readonly HotPrep _hotPrep = new HotPrep();
        private readonly Bar _bar = new Bar();

        public Order PlaceOrder(Patron patron, int coldAppId, int hotEntreeId, int drinkId)
        {
            Console.WriteLine("{0} places order for cold app #" + coldAppId.ToString()
                              + ", hot entree #" + hotEntreeId.ToString()
                              + ", and drink #" + drinkId.ToString() + ".", patron.Name);

            return new Order()
            {
                Appetizer = _codePrep.PrepDish(coldAppId),
                Entree = _hotPrep.PrepDish(hotEntreeId),
                Drink = _bar.PrepDish(drinkId)
            };
        }
    }
}