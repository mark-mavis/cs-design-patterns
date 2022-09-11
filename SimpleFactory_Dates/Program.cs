using SimpleFactory_Dates.Factory;
using SimpleFactory_Dates.FactoryInterface;
using SimpleFactory_Dates.ProductInterface;
using SimpleFactory_Dates.Enum;

class Program
{
    public static void Main(string[] args)
    {
        IDatesFactory datefactory = new DateFactory();
        //IDatesFactory userdefineddatefactory = new UserDefinedDateFactory();

        IDate date = datefactory.CreateDate(DateType.Date, "");
        date.Display();

        //IDate user_event = userdefineddatefactory.CreateDate(DateType.Event);
        //user_event.Display();
        
        //IDate holiday = userdefineddatefactory.CreateDate(DateType.Holiday);
        //holiday.Display();
    }
}