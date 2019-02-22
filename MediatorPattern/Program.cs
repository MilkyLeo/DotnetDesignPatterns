namespace MediatorPattern
{
    //The Mediator design pattern defines an object which encapsulates 
    //how a set of objects interact with each other.

    //You can think of a Mediator object as a kind of traffic-coordinator; 
    //it directs traffic to appropriate parties based on its own state or outside values. 
    //Further, Mediator promotes loose coupling (a good thing!) by keeping objects 
    //from referring to each other explicitly.

    //The Mediator pattern encapsulates an object which represents 
    //how other objects communicate with one another. By doing so, 
    //it enables the Mediator to "stand between" communicating objects and 
    //control their communications.

    internal class Program
    {
        private static void Main()
        {
            var mediator = new ConcessionMediator();

            var northStand = new ConcessionStand(mediator, "North Concession Stand");
            var southStand = new ConcessionStand(mediator, "South Concession Stand");
            mediator.NorthConcessionStand = northStand;
            mediator.SouthConcessionStand = southStand;

            northStand.Send("Can you send some popcorn?");
            southStand.Send("Sure thing, Kenny's on his way.");

            southStand.Send("Do you have any extra hot dogs ? We've had a rush on them over here.");
            northStand.Send("Just a couple, we\'ll send Kenny back with them.");
        }
    }
}
