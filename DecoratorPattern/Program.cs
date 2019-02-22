using System;

namespace DecoratorPattern
{
    //Allows a user to add new functionality to an existing object without altering its structure.
    //This pattern creates a decorator class which wraps the original class and provides additional 
    //functionality keeping class methods signature intact.

    class Program
    {       
        static void Main()
        {
            Console.WriteLine("Circle with normal border");
            var circle = new Circle();
            circle.Draw();

            Console.WriteLine("Circle with red border");
            var redCircle = new RedShapeDecorator(new Circle());
            redCircle.Draw();

            Console.WriteLine("Rectangle with red border");
            var redRectangle = new RedShapeDecorator(new Rectangle());
            redRectangle.Draw();
        }
    }
}
