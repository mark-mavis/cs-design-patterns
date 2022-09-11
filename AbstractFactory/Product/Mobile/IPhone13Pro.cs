using AbstractFactory.ProductInterface;

namespace AbstractFactory.Product.Mobile
{
    public class IPhone13Pro : IMobile
    {
        public void ShowMobile()
        {
            Console.WriteLine("IPhone 13 Pro Created...");

        }

    }
}
