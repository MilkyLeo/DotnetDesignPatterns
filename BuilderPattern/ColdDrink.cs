namespace BuilderPattern
{
    public abstract class ColdDrink : IItem
    {
        public abstract string Name { get; }

        public IPacking Packing()
        {
            return new Bottle();
        }

        public abstract float Price();
    }
}