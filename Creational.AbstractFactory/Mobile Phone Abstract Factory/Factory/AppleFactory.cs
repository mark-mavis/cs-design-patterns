namespace Creational.AbstractFactory.MobilePhone
{
    class AppleFactory : IMobileFactory
    {
        public IMobile CreateMobile(MobileType mobiletype)
        {
            switch (mobiletype)
            {
                case MobileType.IPhone13Pro:
                    return new IPhone13Pro();
                case MobileType.IPhone13ProMax:
                    return new IPhone13ProMax();
                default:
                    throw new Exception("Invalid Apple mobile");
            }
        }
        public ISignal CreateSignalStrength(MobileType mobiletype)
        {
            switch (mobiletype)
            {
                case MobileType.IPhone13Pro:
                    return new IPhone13ProSignal();
                case MobileType.IPhone13ProMax:
                    return new IPhone13ProMaxSignal();
                default:
                    throw new Exception("Invalid Apple mobile");
            }
        }
    }
}
