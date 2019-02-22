namespace BuilderPattern
{
    public class Coke : ColdDrink
    {
        public override string Name => "Coke.";

        public override float Price()
        {
            return (float)3.00;
        }
    }
}