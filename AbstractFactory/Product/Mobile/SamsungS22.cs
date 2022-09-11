using AbstractFactory.ProductInterface;

namespace AbstractFactory.Product.Mobile
{
    class SamsungS22 : IMobile
    {
        public void ShowMobile()
        {
            Console.WriteLine("Samsung S22 Created...");

        }

    }
}
