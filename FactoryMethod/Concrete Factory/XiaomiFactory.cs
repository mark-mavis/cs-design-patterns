using FactoryMethod.FactoryInterface;
using FactoryMethod.MobileInterface;
using FactoryMethod.Product;
using FactoryMethod.Enum;

namespace FactoryMethod.ConcreteFactory
{
    public class XiaomiFactory : IMobileFactory
    {
        public IMobile CreateMobile(ModelType modeltype)
        {
            switch (modeltype)
            {
                case ModelType.Redmi6:
                    return new XiaomiRedmi6();
                case ModelType.RedmiPro:
                    return new XiaomiRedmiPro();
                default:
                    throw new Exception("Incorrect Xiaomi Model...");
            }
        }
    }
}
