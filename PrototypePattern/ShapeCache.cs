using System.Collections.Generic;

namespace PrototypePattern
{
    public class ShapeCache
    {
        private static readonly IDictionary<string, ShapePrototype> Dict = new Dictionary<string, ShapePrototype>();

        public static ShapePrototype GetShape(string shapeId)
        {
            var shape = Dict[shapeId];

            return shape?.Clone();
        }

        public static void LoadCache()
        {
            var circle = new Circle("1");
            Dict.Add(circle.Id, circle);

            var rectangle = new Rectangle("2");
            Dict.Add(rectangle.Id, rectangle);
        }
    }
}