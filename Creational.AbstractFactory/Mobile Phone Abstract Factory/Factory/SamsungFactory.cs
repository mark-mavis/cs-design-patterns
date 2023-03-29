namespace Creational.AbstractFactory.MobilePhone
{
    class SamsungFactory : IMobileFactory
    {
        public IMobile CreateMobile(MobileType mobiletype)
        {
            switch (mobiletype)
            {
                case MobileType.GalaxyZ:
                    return new SamsungGalaxyZ();
                case MobileType.S22:
                    return new SamsungS22();
                default:
                    throw new Exception("Invalid Samsung mobile type");
            }
        }
        public ISignal CreateSignalStrength(MobileType mobiletype)
        {
            switch (mobiletype)
            {
                case MobileType.GalaxyZ:
                    return new SamsungGalaxyZSignal();
                case MobileType.S22:
                    return new SamsungS22Signal();
                default:
                    throw new Exception("Invalid Samsung signal type");
            }
        }
    }
}
