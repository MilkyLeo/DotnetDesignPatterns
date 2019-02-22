namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var singletonObj = SingletonObject.Instance;

            singletonObj.ShowMessage();
        }
    }
}
