using AbstractFactory.ProductInterface;

namespace AbstractFactory.Product.Signal
{
    class SamsungGalaxyZSignal : ISignal
    {
        public void ShowSignalStrength()
        {
            Console.WriteLine("Samsung Galaxy Z Signal Created...");
        }
    }
}
