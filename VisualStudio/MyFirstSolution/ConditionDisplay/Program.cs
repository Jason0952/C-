using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b;
            Console.Write("請輸入一個數字:");
            string c = Console.ReadLine();
            b = int.Parse(c);  //轉換成int型態

            if (b > a)
            {
                Console.Write("輸入的數字大於10");
            }
            else if (b < a)
            {
                Console.Write("輸入的數字小於10");
            }
            else if (b != a)
            {
                Console.Write("輸入的數字不等於10");
            }
            else if (b == a)
            {
                Console.Write("輸入數字就是等於10");
            }
            else
            {
                Console.Write("輸入數字等於10");
            }
            Console.ReadLine();
        }
    }
}
