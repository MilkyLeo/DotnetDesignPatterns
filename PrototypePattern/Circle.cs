using System;

namespace PrototypePattern
{
    public class Circle : ShapePrototype
    {
        public Circle(string id) : base(id)
        {
            Type = "Circle";
        }

        public override ShapePrototype Clone()
        {
            return MemberwiseClone() as ShapePrototype;
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Circle.Draw() method.");
        }
    }
}