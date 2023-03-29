using Creational.AbstractFactory.Vehicle;
using Creational.AbstractFactory.MobilePhone;
using Creational.AbstractFactory.Animal;
using Creational.AbstractFactory.GenericFactory;

class Program
{
    static void Main()
    {
        // Sport Vehicle Abstract Factory
        RegularVehicleFactory regularVehicleFactory = new();
        SportVehicleFactory sportsVehicleFactory = new();

        ICar regularCar = regularVehicleFactory.CreateCar();
        IBike regularBike = regularVehicleFactory.CreateBike();

        regularCar.GetDetails();
        regularBike.GetDetails();

        ICar sportsCar = sportsVehicleFactory.CreateCar();
        IBike sportsBike = sportsVehicleFactory.CreateBike();

        sportsCar.GetDetails();
        sportsBike.GetDetails();

        // Mobile Phone Abstract Factory
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


        // Animal World Abstract Factory
        AfricaFactory africa = new AfricaFactory();
        AmericaFactory america = new AmericaFactory();

        AnimalWorld americaEcosystem = new AnimalWorld(america);
        americaEcosystem.RunFoodChain();

        AnimalWorld africaEcosystem = new AnimalWorld(africa);
        africaEcosystem.RunFoodChain();

        AbstractFactory factory1 = new ConcreteFactory1();
        Client client1 = new Client(factory1);
        client1.Run();

        AbstractFactory factory2 = new ConcreteFactory2();
        Client client2 = new Client(factory2);
        client2.Run();


    }
}