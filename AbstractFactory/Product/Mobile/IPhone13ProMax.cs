using AbstractFactory.ProductInterface;

namespace AbstractFactory.Product.Mobile
{
    public class IPhone13ProMax : IMobile
    {
        public void ShowMobile()
        {
            Console.WriteLine("IPhone 13 Pro Max Created...");

        }

    }
}
