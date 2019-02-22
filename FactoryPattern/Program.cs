namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeFactory = new ShapeFactory();

            shapeFactory.CreateShape(ShapeType.Square).Draw();

            shapeFactory.CreateShape(ShapeType.Rectangle).Draw();

            shapeFactory.CreateShape(ShapeType.Circle).Draw();
        }
    }
}
