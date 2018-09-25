using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 吃糖果
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入想吃的數量:");
            string a = Console.ReadLine();
            int n = 0;
            int x = int.Parse(a);
            int y = 0;
            while (x > 0)
            {
                y++;
                x--;
                n++;
                if (n == 3)
                {
                    x--;
                    n = 1;
                }
            }
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
