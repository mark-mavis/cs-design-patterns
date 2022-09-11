using FactoryMethod.MobileInterface;

namespace FactoryMethod.Product
{
    public class XiaomiRedmi6 : IMobile
    {
        public void CreateMobile()
        {
            Console.WriteLine("Creating Xiaomi Redmi6");
        }
    }
}
