using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入數字:");
            var a = Console.ReadLine();
            int b = int.Parse(a);
            for (int i = 1; i <= b; i++) //控制印出幾個
            {
                for (int j = b; j > b - i; j--) //控制直到零就跳出迴圈
                {
                    Console.Write(b - i + 1);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
