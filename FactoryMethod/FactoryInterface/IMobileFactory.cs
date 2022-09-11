using FactoryMethod.MobileInterface;
using FactoryMethod.Enum;

namespace FactoryMethod.FactoryInterface
{
    public interface IMobileFactory
    {
        IMobile CreateMobile(ModelType modeltype); 
    }
}
