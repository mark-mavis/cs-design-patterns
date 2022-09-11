using AbstractFactory.ProductInterface;

namespace AbstractFactory.Product.Signal
{
    class IPhone13ProSignal : ISignal
    {
        public void ShowSignalStrength()
        {
            Console.WriteLine("Apple 13 Pro Signal is strong!!");
        }
    }
}
