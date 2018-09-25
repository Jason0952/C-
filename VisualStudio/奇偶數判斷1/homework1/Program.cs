using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string s;
            Console.Write("請輸入數字:");
            s = Console.ReadLine();
            a = int.Parse(s);

            if (a % 2 == 0)
            {
                Console.WriteLine("這個數是偶數!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("這個數是奇數!");
                Console.ReadLine();
            }
        }
    }
}
