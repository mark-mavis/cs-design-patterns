using SimpleFactory_Dates.FactoryInterface;
using SimpleFactory_Dates.ProductInterface;
using SimpleFactory_Dates.Product;
using SimpleFactory_Dates.Enum;

namespace SimpleFactory_Dates.Factory
{
    public class DateFactory : IDatesFactory
    {
        public IDate CreateDate(DateType datetype, string s)
        {
            if(string.IsNullOrEmpty(s)) s = DateTime.Now.ToShortDateString();
            
            switch (datetype)
            {
                case DateType.Date:
                    return new Date(s);
                default:
                    throw new Exception("Invalid Date Type");
            }
        }
    }
}
