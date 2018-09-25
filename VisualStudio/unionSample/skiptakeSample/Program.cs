using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skiptakeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<string> { "a", "b", "c", "d", "e", "f" };
            var b = a.Skip(3);
            Console.WriteLine("結果為:");
            display(b);

            var c = a.Take(3);
            Console.WriteLine("結果為:");
            display(c);

            var d = a.Skip(2).Take(2);
            Console.WriteLine("結果為:");
            display(d);

            Console.ReadLine();
        }

        static void display(IEnumerable<string> z)
        {
            foreach (var m in z)
            {
                Console.WriteLine(m);
            }
        }
    }
}
