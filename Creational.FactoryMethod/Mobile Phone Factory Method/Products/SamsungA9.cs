

namespace Creational.AbstractFactory.MobileFactory
{
    public class SamsungA9 : IMobile
    {
        public void CreateMobile()
        {
            Console.WriteLine("Creating Samsung A9");
        }
        public void PrintDetails()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Network: GSM");
            Console.WriteLine("Display: Super AMOLED");
            Console.WriteLine("Camera: 24MP");
            Console.WriteLine("----------------------------");
        }

    }
}
