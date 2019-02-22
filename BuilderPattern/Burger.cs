namespace BuilderPattern
{
    public abstract class Burger : IItem
    {
        public abstract string Name { get; }

        public IPacking Packing()
        {
            return new Wrapper();
        }

        public abstract float Price();
    }
}