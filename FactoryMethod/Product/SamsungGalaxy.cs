using FactoryMethod.MobileInterface;

namespace FactoryMethod.Product
{
    public class SamsungGalaxy : IMobile
    {
        public void CreateMobile()
        {
            Console.WriteLine("Creating Samsung Galaxy");
        }
    }
}
