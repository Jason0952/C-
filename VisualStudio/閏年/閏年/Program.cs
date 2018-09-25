using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 閏年
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入中華民國年份:");
            var a = Console.ReadLine();
            int b = int.Parse(a);

            if (b % 4 == 0 && b % 100 != 0 || b %　400 == 0)
            {
                Console.Write(b + "為閏年");
            }
            if (b % 4 != 0 || b % 100 == 0 && b % 400 != 0)
            {
                Console.Write(b + "為平年");
            }
            Console.ReadLine();
        }
    }
}
