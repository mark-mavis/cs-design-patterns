using BuilderPattern_Dates.Builder;
using BuilderPattern_Dates.Product;

namespace BuilderPattern_Dates.ConcreteBuilder
{
    class DateBuilder : IDateObjectBuilder
    {
        private Date _date = new Date();
        public void AddTitle(string title)
        {
            return;
        }
        public void AddType(string type)
        {
           _date.Type = type;
        }
        public void AddDate(DateTime date)
        {
            _date.DateString = date;
        }

        public Date BuildDate()
        {
            return _date;
        }
    }
}
