using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 回文
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入字串:");
            string str1 = Console.ReadLine();
            StringBuilder a = new StringBuilder();
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                a.Append(str1[i]);
            }

            if (str1.Equals(a.ToString()))
            {
                Console.WriteLine("是回文");
            }
            else
            {
                Console.WriteLine("不是回文");
            }
            Console.ReadLine();
        }
    }
}
