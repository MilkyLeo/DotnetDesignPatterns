using System;

namespace MediatorPattern
{
    public class ConcessionStand
    {
        private readonly IMediator _mediator;
        private readonly string _consessionName;
         
        public ConcessionStand(IMediator mediator, string concessionName)
        {
            _mediator = mediator;
            _consessionName = concessionName;
        }

        public void Send(string message)
        {
            Console.WriteLine(_consessionName + " sends message: " + message);
            _mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine(_consessionName + " gets message: " + message);
        }
    }
}