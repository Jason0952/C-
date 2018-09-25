using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> source = new List<string> { "Bill", "John", "paul", "Bill" };
            var result = source.dowhere((x) => x == "Bill");
            foreach (var v in result)
            {
                Console.WriteLine(v);
            }

            Dictionary<int, string> a = new Dictionary<int, string>();
            a.Add(1, "A");
            a.Add(2, "B");

            var result1 = a.dowhere((x) => x.Key == 1);
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
