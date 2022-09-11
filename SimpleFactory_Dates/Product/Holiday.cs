using SimpleFactory_Dates.ProductInterface;

namespace SimpleFactory_Dates.Product
{
    class Holiday : IDate
    {
        public void Display()
        {
            Console.WriteLine("Creating Holiday...");
        }
    }
}
