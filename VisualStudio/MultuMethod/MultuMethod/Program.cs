using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultuMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入第一個數字:");
            string a = Console.ReadLine();
            var b = double.Parse(a);

            Console.WriteLine("請輸入第二個數字:");
            string c = Console.ReadLine();
            var d = double.Parse(c);
            Add(a, c);            
            Add(b, d);
            Console.Write("字串結果是:" + Add(a, c));            
            Console.Write("數字結果是:" + Add(b, d));
            
            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static double Add(double x, int y)
        {
            return x + y;
        }

        static string Add(string x, int y)
        {
            return x + y.ToString();
        }

        static string Add(string x, string y)
        {
            return x + "," + y;
        }

        static double Add(double x, double y)
        {
            return x + y;
        }
        
    }
}
