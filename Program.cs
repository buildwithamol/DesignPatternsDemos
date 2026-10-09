
namespace SingletonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingletonDemo singletonDemo = SingletonDemo.GetInstance();

            singletonDemo.DisplayMessage();


        }
    }
}
