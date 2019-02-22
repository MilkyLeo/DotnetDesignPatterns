namespace AbstractFactoryPattern
{
    public class FactoryBuilder
    {
        public static AbstractFactory CreateFactory(FactoryType factoryType)
        {
            switch (factoryType)
            {
                case FactoryType.ColorFactory: return new ColorFactory();
                case FactoryType.ShapeFactory: return new ShapeFactory();
            }
            return null;
        }
    }
}