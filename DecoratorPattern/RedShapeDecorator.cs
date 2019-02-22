using System;

namespace DecoratorPattern
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(Shape decoratedShape) : base(decoratedShape)
        {
        }

        public override void Draw()
        {
            DecoratorShape.Draw();
            SetRedBorder();
        }

        private void SetRedBorder()
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}