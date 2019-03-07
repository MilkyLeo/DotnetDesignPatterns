namespace FlyweightPattern
{
    /// <summary>
    /// Flyweight class
    /// </summary>
    abstract class Slider
    {
        protected string Name;
        protected string Toppings;
        protected string Cheese;
        protected decimal Price;

        public abstract void Display(int orderTotal);
    }
}