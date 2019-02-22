namespace AbstractFactoryPattern
{
    public class ColorFactory : AbstractFactory
    {
        public override IColor CreateColor(ColorType colorType)
        {
            switch (colorType)
            {
                case ColorType.Green: return new Green();
                case ColorType.Red: return new Red();
            }
            return null;
        }

        public override IShape CreateShape(ShapeType shapeType)
        {
            return null;
        }
    }
}