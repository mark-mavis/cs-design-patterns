

namespace Creational.AbstractFactory.MobileFactory
{
    public class XiaomiRedmi6 : IMobile
    {
        public void CreateMobile()
        {
            Console.WriteLine("Creating Xiaomi Redmi6");
        }
        public void PrintDetails()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Network: GSM");
            Console.WriteLine("Display: OLED, 1B colors, 120Hz, Dolby Vision, HDR10+");
            Console.WriteLine("Camera: 50MP");
            Console.WriteLine("----------------------------");
        }
    }
}
