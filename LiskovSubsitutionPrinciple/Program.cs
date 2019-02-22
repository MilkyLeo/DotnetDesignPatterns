using System;

namespace LiskovSubsitutionPrinciple
{
    //we should be able to treat a child class as though it were the parent class. 
    //Essentially this means that all derived classes should retain the functionality of 
    //their parent class and cannot replace any functionality the parent provides.
    //Basically, any child class should be able to do anything the parent can do.

    public class Ellipse
    {
        public double MajorAxis { get; set; }
        public double MinorAxis { get; set; }

        public virtual void SetMajorAxis(double majorAxis)
        {
            MajorAxis = majorAxis;
        }

        public virtual void SetMinorAxis(double minorAxis)
        {
            MinorAxis = minorAxis;
        }

        public virtual double Area()
        {
            return MajorAxis * MinorAxis * Math.PI;
        }
    }

    public class Circle : Ellipse
    {
        public override void SetMajorAxis(double majorAxis)
        {
            base.SetMajorAxis(majorAxis);
            MinorAxis = majorAxis;
        }
    }

    public class CircleCorrectedLiskovSubstitutionPrinciple
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Radius * Radius * Math.PI;
        }

    }
    class Program
    {
        static void Main()
        {
        }
    }
}
