namespace BuilderPattern
{
    public class ChickenBurger : Burger
    {
        public override string Name => "Chicken Burger.";

        public override float Price()
        {
            return (float)30.00;
        }
    }
}