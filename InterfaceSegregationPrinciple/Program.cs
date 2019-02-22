using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    //No client code object should be forced to depend on method it does not use. 
    //Basically, each code object should only implement what it needs, and not be required to 
    //implement anything else.
    //https://exceptionnotfound.net/simply-solid-the-interface-segregation-principle/
    class Program
    {
        public interface IProduct
        {
            int Id { get; set; }
            double Weight { get; set; }
            int Stock { get; set; }
        }

        public interface IPants
        {
            int WaistSize { get; set; }
        }

        public interface IHat
        {
            int HatSize { get; set; }
        }

        public class Jeans : IProduct, IPants
        {
            public int Id { get; set; }
            public double Weight { get; set; }
            public int Stock { get; set; }
            public int WaistSize { get; set; }
        }

        public class BasketballCap : IProduct, IHat
        {
            public int Id { get; set; }
            public double Weight { get; set; }
            public int Stock { get; set; }
            public int HatSize { get; set; }
        }
        static void Main(string[] args)
        {
        }
    }
}
