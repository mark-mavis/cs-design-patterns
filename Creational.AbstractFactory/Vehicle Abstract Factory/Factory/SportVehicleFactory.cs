namespace Creational.AbstractFactory.Vehicle;
class SportVehicleFactory : IVehicleFactory
{
    public IBike CreateBike()
    {
        return new SportsBike();
    }
    public ICar CreateCar()
    {
        return new SportsCar();
    }

}

