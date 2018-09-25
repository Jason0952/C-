using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = 10;
            string test = $"i = {i}";

            if (i.HasValue)
            {
                Console.WriteLine(test);
            }

            i = null;
            if (!i.HasValue) //i == null
            {
                Console.WriteLine(i.GetValueOrDefault());
            }

            if (i == null)
            {
                Console.WriteLine("i is null");
            }

            Console.ReadLine();
        }
    }
}
