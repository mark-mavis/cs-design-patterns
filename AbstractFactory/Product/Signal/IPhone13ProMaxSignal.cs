using AbstractFactory.ProductInterface;

namespace AbstractFactory.Product.Signal
{
    class IPhone13ProMaxSignal : ISignal
    {
        public void ShowSignalStrength()
        {
            Console.WriteLine("Apple 13 Pro Max Signal Created...");
        }
    }
}
