using BuilderPattern_Dates.Product;
using BuilderPattern_Dates.Builder;

namespace BuilderPattern_Dates.ConcreteBuilder
{
    public class HolidayBuilder : IDateObjectBuilder
    {
        private Date _holiday = new Date();
        public void AddTitle(string title)
        {
           _holiday.Title = title;
        }
        public void AddType(string type)
        {
            _holiday.Type = type;
        }
        public void AddDate(DateTime date)
        {
            _holiday.DateString = date;
        }

        public Date BuildDate()
        {
            return _holiday;
        }
    }
}
