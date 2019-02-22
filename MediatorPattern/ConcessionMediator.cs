namespace MediatorPattern
{
    class ConcessionMediator : IMediator
    {
        public ConcessionStand NorthConcessionStand { get; set; }
        public ConcessionStand SouthConcessionStand { get; set; }

        public void SendMessage(string message, ConcessionStand colleague)
        {
            if (colleague == NorthConcessionStand)
            {
                SouthConcessionStand.Notify(message);
            }
            else
            {
                NorthConcessionStand.Notify(message);
            }
        }
    }
}