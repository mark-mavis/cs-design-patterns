namespace Creational.AbstractFactory.MobileFactory
{
    public class SamsungGalaxy : IMobile
    {
        public void CreateMobile()
        {
            Console.WriteLine("Creating Samsung Galaxy");
        }

        public void PrintDetails()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Network: GSM");
            Console.WriteLine("Display: Super AMOLED, 120Hz");
            Console.WriteLine("Camera: 48MP");
            Console.WriteLine("----------------------------");
        }
    }
}
