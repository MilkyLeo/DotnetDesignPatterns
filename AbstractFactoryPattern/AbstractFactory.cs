namespace AbstractFactoryPattern
{
    public abstract class AbstractFactory
    {
        public abstract IColor CreateColor(ColorType colorType);
        public abstract IShape CreateShape(ShapeType shapeType);
    }
}