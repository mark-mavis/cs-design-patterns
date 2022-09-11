using SimpleFactory;
class Program
{
    public static void Main(string[] args)
    {
        IMobile device = MobileFactory.CreateMobile(BrandType.Apple);
        device.GetMobile();

        Console.ReadKey();
    }
}