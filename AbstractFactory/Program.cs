using AbstractFactory.Factory;
using AbstractFactory.FactoryInterface;
using AbstractFactory.Enum;
using AbstractProductFactory;
using AbstractContinentFactory;

public class Program
{
    public static void Main(string[] args)
    {
        IMobileFactory applemobilefactory = new AppleFactory();
        applemobilefactory.CreateMobile(MobileType.IPhone13Pro).ShowMobile();
        applemobilefactory.CreateSignalStrength(MobileType.IPhone13Pro).ShowSignalStrength();
        applemobilefactory.CreateMobile(MobileType.IPhone13ProMax).ShowMobile();
        applemobilefactory.CreateSignalStrength(MobileType.IPhone13ProMax).ShowSignalStrength();

        IMobileFactory samsungmobilefactory = new SamsungFactory();
        samsungmobilefactory.CreateMobile(MobileType.GalaxyZ).ShowMobile();
        samsungmobilefactory.CreateSignalStrength(MobileType.GalaxyZ).ShowSignalStrength();
        samsungmobilefactory.CreateMobile(MobileType.S22).ShowMobile();
        samsungmobilefactory.CreateSignalStrength(MobileType.S22).ShowSignalStrength();

        IAbstractFactory factory1 = new ConcreteFactory1();
        Client client1 = new Client(factory1);
        client1.Run();

        IAbstractFactory factory2 = new ConcreteFactory2();
        Client client2 = new Client(factory2);
        client2.Run();

        ContinentFactory africa = new AfricaFactory();
        AnimalWorld world = new AnimalWorld(africa);
        world.RunFoodChain();

        // Create and run the American animal world
        ContinentFactory america = new AmericaFactory();
        world = new AnimalWorld(america);
        world.RunFoodChain();

    }
}
