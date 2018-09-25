using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = PriceList.GetTicketList();
            var distinct = list.Distinct(new TicketFare());
            foreach (var item in distinct)
            {
                Console.WriteLine(item);
            }
        }
    }
}
