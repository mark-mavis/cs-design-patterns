

namespace Creational.AbstractFactory.MobileFactory
{
    abstract class MobileFactory
    {
        protected abstract IMobile MakeProduct(ModelType modelType);
        public IMobile GetProduct(ModelType modelType)
        {
            return this.MakeProduct(modelType);
        }
    }
}
