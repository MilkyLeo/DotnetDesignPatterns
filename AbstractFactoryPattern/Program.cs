using System;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        private static void Main()
        {
            var shapeFactory = FactoryBuilder.CreateFactory(FactoryType.ShapeFactory);
            shapeFactory.CreateShape(ShapeType.Square).Draw();
            shapeFactory.CreateShape(ShapeType.Circle).Draw();
            shapeFactory.CreateShape(ShapeType.Rectangle).Draw();

            Console.WriteLine("\n");

            var colorFactory = FactoryBuilder.CreateFactory(FactoryType.ColorFactory);
            colorFactory.CreateColor(ColorType.Green).Fill();
            colorFactory.CreateColor(ColorType.Red).Fill();
        }
    }
}
