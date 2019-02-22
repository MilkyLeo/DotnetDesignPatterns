using System;

namespace DependencyInversionPrinciple
{
    public class Sms : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendMessage()
        {
            Console.WriteLine("Sending short text message...");
        }
    }
}