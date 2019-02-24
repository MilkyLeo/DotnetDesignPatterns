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

        public void AddOneMenuItemToOrder(MenuItem menuItem)
        {
            _orderCommand = new CommandFactory().CreateAddCommand();
            SetMenuItemAndExecuteMenuOrder(menuItem);
        }
        public void RemoveOneMenuItemFromOrder(MenuItem menuItem)
        {
            _orderCommand = new CommandFactory().CreateRemoveCommand();
            SetMenuItemAndExecuteMenuOrder(menuItem);
        }

        public void ModifyOneMenuItemInOrder(MenuItem menuItem)
        {
            _orderCommand = new CommandFactory().CreateModifyCommand();
            SetMenuItemAndExecuteMenuOrder(menuItem);
        }

        private void SetMenuItem(MenuItem item)
        {
            _menuItem = item;
        }

        public void ExecuteCommand()
        {
            _order.ExcuteCommand(_orderCommand, _menuItem);
        }

        private void SetMenuItemAndExecuteMenuOrder(MenuItem item)
        {
            SetMenuItem(item);

            ExecuteCommand();
        }

        public void ShowCurrentOrder()
        {
            _order.ShowCurrentItems();
        }
    }
}