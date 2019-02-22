namespace DecoratorPattern
{
    public abstract class ShapeDecorator : Shape
    {
        protected Shape DecoratorShape;

        protected ShapeDecorator(Shape decoratedShape)
        {
            DecoratorShape = decoratedShape;
        }

        public override void Draw()
        {
            DecoratorShape.Draw();
        }
    }
}