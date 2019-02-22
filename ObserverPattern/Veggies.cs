using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public abstract class Veggies
    {
        private double _pricePerPound;
        private readonly List<IRestaurant> _restaurant = new List<IRestaurant>();
        public double Tolerance => 0.0001;
        protected Veggies(double pricePerPound)
        {
            _pricePerPound = pricePerPound;
        }

        public void Attach(IRestaurant restaurant)
        {
            _restaurant.Add(restaurant);
        }

        public void Detach(IRestaurant restaurant)
        {
            _restaurant.Remove(restaurant);
        }

        public void Notify()
        {
            foreach (var resuRestaurant in _restaurant)
            {
                resuRestaurant.Update(this);
            }
            Console.WriteLine("");
        }

        public double PricePerPound
        {
            get { return _pricePerPound; }
            set
            {
                if (!(Math.Abs(_pricePerPound - value) > Tolerance)) return;

                _pricePerPound = value;
                Notify(); //Automatically notify our observers of price changes
            }
        }
    }
}