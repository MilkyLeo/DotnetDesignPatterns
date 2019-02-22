using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    public class Notification
    {
        private readonly ICollection<IMessage> _messages;

        public Notification(ICollection<IMessage> messages)
        {
            _messages = messages;
        }

        public void Send()
        {
            foreach (var message in _messages)
            {
                message.SendMessage();
            }
        }
    }
}