using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distinctSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<string> { "台北", "台北", "洛杉磯", "紐約", "紐約", "台北" };
            var b = a.Distinct();
            foreach (var c in b)
            {
                Console.WriteLine("有:" + c);
            }
            Console.ReadLine();
        }
    }
}
