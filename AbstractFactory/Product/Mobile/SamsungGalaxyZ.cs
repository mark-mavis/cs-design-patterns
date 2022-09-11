using AbstractFactory.ProductInterface;

namespace AbstractFactory.Product.Mobile
{
    class SamsungGalaxyZ : IMobile
    {
        public void ShowMobile()
        {
            Console.WriteLine("Samsung Galaxy Z Create...");
        }
    }
}
