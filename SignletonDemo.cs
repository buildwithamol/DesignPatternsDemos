namespace SingletonDemo
{
    public sealed class SingletonDemo
    {
       
        private static readonly Lazy<SingletonDemo> _instance =
        new Lazy<SingletonDemo>(() => new SingletonDemo());


        private static readonly Lazy<SingletonDemo> singletonDemo = new Lazy<SingletonDemo>(()=>new SingletonDemo());

        private SingletonDemo()
        {
            // Private constructor to prevent instantiation from outside
        }

        public static SingletonDemo GetInstance()
        {

            return _instance.Value;
        }

        public void DisplayMessage()
        {
            Console.WriteLine("Hello from Singleton Demo!");
        }
    }
}
