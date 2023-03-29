namespace Creational.AbstractFactory.MobilePhone
{
    public interface IMobileFactory
    {
        IMobile CreateMobile(MobileType mobiletype);
        ISignal CreateSignalStrength(MobileType mobiletype);
    }
}
