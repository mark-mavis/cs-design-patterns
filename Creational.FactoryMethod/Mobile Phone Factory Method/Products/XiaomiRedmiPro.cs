

namespace Creational.AbstractFactory.MobileFactory
{
    public class XiaomiRedmiPro : IMobile
    {
        public void CreateMobile()
        {
            Console.WriteLine("Creating Xiaomi Redmi Pro");
        }
        public void PrintDetails()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Network: GSM");
            Console.WriteLine("Display: LTPO AMOLED, 1B colors, 120Hz, Dolby Vision, HDR10+");
            Console.WriteLine("Camera: 50.3MP");
            Console.WriteLine("----------------------------");
        }
    }
}
