using System;

namespace PrototypePattern
{
    //This pattern involves implementing a prototype interface which tells to 
    //create a clone of the current object. This pattern is used when creation of object directly is costly. 
    //For example, an object is to be created after a costly database operation. 
    //We can cache the object, returns its clone on next request and update the database as and 
    //when needed thus reducing database calls.

    internal class Program
    {
        private static void Main()
        {
            ShapeCache.LoadCache();

            var clonedShape1 = ShapeCache.GetShape("1");
            Console.WriteLine("Shape : " + clonedShape1.Type);
            clonedShape1.Draw();

            Console.WriteLine("\n");

            var clonedShape2 = ShapeCache.GetShape("2");
            Console.WriteLine("Shape : " + clonedShape2.Type);
            clonedShape2.Draw();
        }
    }
}
