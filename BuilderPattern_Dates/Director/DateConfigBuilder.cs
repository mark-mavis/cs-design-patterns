using BuilderPattern_Dates.Product;
using BuilderPattern_Dates.Builder;

namespace BuilderPattern_Dates.Director
{
    public class DateConfigBuilder
    {
        public Date BuildDate(IDateObjectBuilder builder)
        {
            builder.AddDate(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));
            builder.AddType("Date");

            return builder.BuildDate();
        }

        public Date BuildHoliday(IDateObjectBuilder builder, string title, string datestring)
        {
            builder.AddTitle(title);
            builder.AddType("Holiday");
            builder.AddDate(DateTime.Parse(datestring));
            
            return builder.BuildDate();
        }

        public Date BuildEvent(IDateObjectBuilder builder, string title, string datestring)
        {
            builder.AddTitle(title);
            builder.AddType("Event");
            builder.AddDate(DateTime.Parse(datestring));

            return builder.BuildDate();
        }
    }
}
