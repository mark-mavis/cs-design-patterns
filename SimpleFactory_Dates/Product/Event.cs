using SimpleFactory_Dates.ProductInterface;
using SimpleFactory_Dates.Enum;

namespace SimpleFactory_Dates.Product
{
    class Event : IDate
    {
        public void Display()
        {
            Console.WriteLine("Creating Event...");
        }
    }
}
