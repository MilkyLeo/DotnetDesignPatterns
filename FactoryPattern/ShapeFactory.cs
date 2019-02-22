using System;

namespace FactoryPattern
{
    public class ShapeFactory
    {
        public IShape CreateShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Circle:
                    return new Circle();
                case ShapeType.Rectangle:
                    return new Rectangle();
                case ShapeType.Square:
                    return new Square();
                default:
                    throw new ArgumentOutOfRangeException(nameof(shapeType), shapeType, null);
            }
        }
    }
}