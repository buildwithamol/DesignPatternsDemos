namespace SingletonDemo
{
    public sealed class SingletonDemo
    {
        private static readonly object lockObj = new();
        private static SingletonDemo? objsingletonDemo;
        private static readonly Lazy<SingletonDemo> _instance =
        new Lazy<SingletonDemo>(() => new SingletonDemo());


        private SingletonDemo()
        {
            // Private constructor to prevent instantiation from outside
        }

        public static SingletonDemo GetInstance()
        {
            if (objsingletonDemo == null)
            {
                lock (lockObj)
                {
                    if (objsingletonDemo == null)
                    {
                        objsingletonDemo = new SingletonDemo();
                    }
                }
            }
            return objsingletonDemo;
        }

        public void DisplayMessage()
        {
            Console.WriteLine("Hello from Singleton Demo!");
        }
    }
}
