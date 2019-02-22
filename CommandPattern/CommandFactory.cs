namespace CommandPattern
{
    public class CommandFactory
    {
        public OrderCommand GetCommand(CommandOption commandOption)
        {
            switch (commandOption)
            {
                case CommandOption.Add:
                    return new AddCommand();
                case CommandOption.Modify:
                    return new ModifyCommand();
                case CommandOption.Remove:
                    return new RemoveCommand();
                default:
                    return new AddCommand();
            }

        }
    }
}