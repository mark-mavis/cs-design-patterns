namespace SimpleFactory
{
    public class MobileFactory
    {
        public static IMobile CreateMobile(BrandType brandtype)
        {
            switch (brandtype)
            {
                case BrandType.Samsung:
                    return new Samsung();
                case BrandType.Xiaomi:
                    return new Xiaomi();
                case BrandType.Apple:
                    return new Apple();
                default:
                    throw new ArgumentException("Invalid brand type... ");
            }            
        }
    }
}
