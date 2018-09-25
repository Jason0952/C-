using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            week myweek = week.mon;
            string display = $"今天是 {myweek}";
            Console.WriteLine($"今天是 {myweek}");
            Console.WriteLine(display);

            if (myweek == week.mon)
            {
                Console.WriteLine(display);
            }
            else
            {
                Console.WriteLine("false");
            }

            int i = (int)myweek;
            Console.WriteLine($"myweek的數字是{i}");
            Console.ReadLine();
        }
    }
}
