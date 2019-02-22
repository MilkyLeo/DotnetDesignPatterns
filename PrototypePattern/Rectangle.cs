using System;

namespace PrototypePattern
{
    public class Rectangle : ShapePrototype
    {
        public Rectangle(string id) : base(id)
        {
            Type = "Rectangle";
        }

        public override ShapePrototype Clone()
        {
            return MemberwiseClone() as ShapePrototype;
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Rectangle.Draw() method.");
        }
    }
}