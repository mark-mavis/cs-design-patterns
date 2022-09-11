using FactoryMethod.FactoryInterface;
using FactoryMethod.MobileInterface;
using FactoryMethod.Product;
using FactoryMethod.Enum;

namespace FactoryMethod.ConcreteFactory
{
    class SamsungFactory : IMobileFactory
    {
        public IMobile CreateMobile(ModelType modeltype)
        {
            switch (modeltype)
            {
                case ModelType.A9:
                    return new SamsungA9();
                case ModelType.Galaxy:
                    return new SamsungGalaxy();
                default:
                    throw new Exception("Incorrect Samesung Model...");
            }
        }
    }
}
