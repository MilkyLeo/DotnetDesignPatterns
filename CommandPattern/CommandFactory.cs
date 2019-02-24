namespace CommandPattern
{
    public class CommandFactory
    {
        public OrderCommand CreateAddCommand()
        {
            return new AddCommand();
        }

        public OrderCommand CreateRemoveCommand()
        {
            return new RemoveCommand();
        }

        public OrderCommand CreateModifyCommand()
        {
            return new ModifyCommand();
        }
    }
}