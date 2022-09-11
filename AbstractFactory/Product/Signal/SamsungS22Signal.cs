using AbstractFactory.ProductInterface;

namespace AbstractFactory.Product.Signal
{
    class SamsungS22Signal : ISignal
    {
        public void ShowSignalStrength()
        {
            Console.WriteLine("Samsung S22 Signal strength is good");
        }
    }
}
