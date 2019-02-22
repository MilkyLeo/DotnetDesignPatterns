using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    //High-level modules should not depend on low-level modules. Both should depend on abstractions;
    //Abstractions should not depend on details. Details should depend on abstractions.

    internal class Program
    {
        private static void Main()
        {
            var mail = new Email();
            var sms = new Sms();

            var messages = new Notification(new List<IMessage>{mail, sms});

            messages.Send();
        }
    }
}
