using System;

namespace SingletonPattern
{
    public sealed class SingletonObject
    {
        private static readonly Lazy<SingletonObject> Lazy =
            new Lazy<SingletonObject>(() => new SingletonObject());

        public static SingletonObject Instance => Lazy.Value;

        public void ShowMessage()
        {
            Console.WriteLine("Hello World!");
        }
    }
}