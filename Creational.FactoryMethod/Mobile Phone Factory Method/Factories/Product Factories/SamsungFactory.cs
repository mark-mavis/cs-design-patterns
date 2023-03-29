namespace Creational.AbstractFactory.MobileFactory
{
    class SamsungFactory : MobileFactory
    {
        protected override IMobile MakeProduct(ModelType modelType)
        {
            switch (modelType)
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
