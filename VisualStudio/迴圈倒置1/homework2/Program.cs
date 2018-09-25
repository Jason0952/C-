using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入數字:");
            var x = Console.ReadLine();
            char[] a = x.ToCharArray();
            Array.Reverse(a);
            Console.Write(a);
            Console.ReadLine();
        }
    }
}
