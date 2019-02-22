namespace MediatorPattern
{
    /// <summary>
    /// The Mediator interface, which defines a send message method which the concrete mediators
    /// must implement.
    /// </summary>
    public interface IMediator
    {
        void SendMessage(string message, ConcessionStand concessionStand);
    }
}