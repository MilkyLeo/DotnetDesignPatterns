namespace CommandPattern
{
    public class Patron
    {
        private OrderCommand _orderCommand;
        private MenuItem _menuItem;
        private readonly FastFoodOrder _order;

        public Patron()
        {
            _order = new FastFoodOrder();
        }

        public void MakeOneItemOrder(CommandOption commandOption, MenuItem item)
        {
            SetCommand(commandOption);
            SetMenuItem(item);

            ExecuteCommand();
        }
        private void SetCommand(CommandOption commandOption)
        {
            _orderCommand = new CommandFactory().GetCommand(commandOption);
        }

        private void SetMenuItem(MenuItem item)
        {
            _menuItem = item;
        }

        public void ExecuteCommand()
        {
            _order.ExcuteCommand(_orderCommand, _menuItem);
        }

        public void ShowCurrentOrder()
        {
            _order.ShowCurrentItems();
        }
    }
}