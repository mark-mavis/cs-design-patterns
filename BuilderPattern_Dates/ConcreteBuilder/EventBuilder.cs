using BuilderPattern_Dates.Product;
using BuilderPattern_Dates.Builder;

namespace BuilderPattern_Dates.ConcreteBuilder
{
    public class EventBuilder : IDateObjectBuilder
    {
        private Date _event = new Date();
        public void AddTitle(string title)
        {
            _event.Title = title;
        }
        public void AddType(string type)
        {
            _event.Type = type;
        }
        public void AddDate(DateTime date)
        {
            _event.DateString = date;
        }

        public Date BuildDate()
        {
            return _event;
        }
    }
}
