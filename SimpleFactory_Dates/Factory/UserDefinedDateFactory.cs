//using SimpleFactory_Dates.FactoryInterface;
//using SimpleFactory_Dates.ProductInterface;
//using SimpleFactory_Dates.Product;
//using SimpleFactory_Dates.Enum;

//namespace SimpleFactory_Dates.Factory
//{
//    public class UserDefinedDateFactory : IDatesFactory
//    {
//        public IDate CreateDate(DateType datetype)
//        {
//            switch (datetype)
//            {
//                case DateType.Event:
//                    return new Event();
//                case DateType.Holiday:
//                    return new Holiday();
//                default:
//                    throw new Exception("Invalid Date Type Input");
//            }
//        }
//    }
//}
