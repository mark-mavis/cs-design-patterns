using AbstractFactory.ProductInterface;
using AbstractFactory.Enum;

namespace AbstractFactory.FactoryInterface
{
    public interface IMobileFactory
    {
        IMobile CreateMobile(MobileType mobiletype);
        ISignal CreateSignalStrength(MobileType mobiletype);
    }
}
