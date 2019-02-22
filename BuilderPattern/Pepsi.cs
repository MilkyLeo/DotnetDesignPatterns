namespace BuilderPattern
{
    public class Pepsi : ColdDrink
    {
        public override string Name => "Pepsi.";

        public override float Price()
        {
            return (float)3.20;
        }
    }
}