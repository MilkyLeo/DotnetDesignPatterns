using System;

namespace ObserverPattern
{
    //https://exceptionnotfound.net/the-daily-design-pattern-observer/
    //The Observer pattern seeks to allow objects to notify their observers 
    //when their internal state changes.
    //This means that a single object will need to be aware of the objects that observe it, 
    //and need to be able to communicate to those observers that the subject's state changed. 
    //Further, the observers should be notified automatically.
    class Program
    {
        private static void Main()
        {
            //Create price watch for Carrots and attach restaurants that buy carrots from suppliers.
            var carrots = new Carrots(0.82);
            carrots.Attach(new Restaurant("Mackay's", 0.77));
            carrots.Attach(new Restaurant("Johnny's Sports Bar", 0.74));
            carrots.Attach(new Restaurant("Salad Kindom", 0.75));

            // Fluctuating carrot prices will notify subscribing restaurants.
            carrots.PricePerPound = 0.79;
            carrots.PricePerPound = 0.76;
            carrots.PricePerPound = 0.74;
            carrots.PricePerPound = 0.81;

            Console.ReadKey();
        }
    }
}
