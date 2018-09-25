using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            var list2 = new List<int> { 2, 3, 4, 7, 8, 9 };
            var U = list1.Union(list2);
            foreach (var a in U)
            {
                Console.WriteLine("交集為:" + a);
            }

            var i = list1.Intersect(list2);
            foreach (var b in i)
            {
                Console.WriteLine("聯集為:" + b);
            }

            Console.ReadLine();

            var d = list1.Except(list2);
            foreach (var c in d)
            {
                Console.WriteLine("差集為:" + c);
            }

        }
    }
}
