namespace BuilderPattern
{
    public class VegBurger : Burger
    {
        public override string Name => "Vegitable Burger.";

        public override float Price()
        {
            return (float) 25.00;
        }
    }
}