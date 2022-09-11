using BuilderPattern_Dates.Builder;
using BuilderPattern_Dates.ConcreteBuilder;
using BuilderPattern_Dates.Director;

public class Program
{
    public static void Main(string[] args)
    {
        IDateObjectBuilder datebuilder = new DateBuilder();
        IDateObjectBuilder holidaybuilder = new HolidayBuilder();
        IDateObjectBuilder eventbuilder = new EventBuilder();

        DateConfigBuilder dateconfig = new DateConfigBuilder();

        var date = dateconfig.BuildDate(datebuilder);
        var holiday = dateconfig.BuildHoliday(holidaybuilder, "Christmas", "12/25/2021");
        var event_dt = dateconfig.BuildEvent(eventbuilder, "Mark Birthday", "02/05/1984");
    }
}