namespace Creational.AbstractFactory.MobileFactory
{
    class XiaomiFactory : MobileFactory
    {
        protected override IMobile MakeProduct(ModelType modeltype)
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
