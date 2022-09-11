using FactoryMethod.MobileInterface;

namespace FactoryMethod.Product
{
    public class SamsungA9 : IMobile
    {
        public void CreateMobile()
        {
            Console.WriteLine("Creating Samsung A9");
        }

    }
}
