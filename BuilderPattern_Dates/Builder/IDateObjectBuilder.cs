using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern_Dates.Product;

namespace BuilderPattern_Dates.Builder
{
    public interface IDateObjectBuilder
    {
        void AddTitle(string title);
        void AddDate(DateTime date);
        void AddType(string type);
        Date BuildDate();

    }
}
