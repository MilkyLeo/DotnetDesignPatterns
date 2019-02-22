namespace AbstractFactoryPattern
{
    public class ShapeFactory : AbstractFactory
    {
        public override IColor CreateColor(ColorType colorType)
        {
            return null;
        }

        public override IShape CreateShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Circle: return new Circle();
                case ShapeType.Rectangle: return new Rectangle();
                case ShapeType.Square: return new Square();
            }
            return null;
        }
    }
}