using SimpleFactory_Dates.ProductInterface;

namespace SimpleFactory_Dates.Product
{
    class Date : IDate
    {
        private DateTime _datetime;
        public DateTime DateTime
        {
            get { return _datetime; }
        }
        public Date()
        {
            this._datetime = DateTime.Now;
        }
       public Date(string s)
        {
            this._datetime = DateTime.Parse(s);
        }
        public void Display()
        {
            Console.WriteLine(_datetime.ToLongDateString());
        }
    }
}
