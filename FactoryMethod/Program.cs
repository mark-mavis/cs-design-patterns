using FactoryMethod.FactoryInterface;
using FactoryMethod.ConcreteFactory;
using FactoryMethod.MobileInterface;
using FactoryMethod.Enum;
class Program
{
    public static void Main(string[] args)
    {
        //Both Factories return their own Mobile Phone Brands
        IMobileFactory samsungFactory = new SamsungFactory();
        IMobileFactory xiaomiFactory = new XiaomiFactory();

        //Using the Concrete Samsung Factory to create that factor
        IMobile galaxy = samsungFactory.CreateMobile(ModelType.Galaxy);
        galaxy.CreateMobile();
        
        IMobile a9 = samsungFactory.CreateMobile(ModelType.A9);
        a9.CreateMobile();

        IMobile redmi6 = xiaomiFactory.CreateMobile(ModelType.Redmi6);
        redmi6.CreateMobile();
        IMobile redmipro = xiaomiFactory.CreateMobile(ModelType.RedmiPro);
        redmipro.CreateMobile();

    }
}