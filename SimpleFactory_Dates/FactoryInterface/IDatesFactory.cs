using SimpleFactory_Dates.ProductInterface;
using SimpleFactory_Dates.Enum;


namespace SimpleFactory_Dates.FactoryInterface
{
    public interface IDatesFactory
    {
        IDate CreateDate(DateType dateType, string s);
    
    }
}
