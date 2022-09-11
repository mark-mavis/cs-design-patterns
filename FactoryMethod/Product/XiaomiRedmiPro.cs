using FactoryMethod.MobileInterface;

namespace FactoryMethod.Product
{
    public class XiaomiRedmiPro : IMobile
    {
        public void CreateMobile()
        {
            Console.WriteLine("Creating Xiaomi Redmi Pro");
        }
    }
}
