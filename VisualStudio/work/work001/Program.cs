using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work001
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Nstring = new List<string>();
            string type;
            string[] getnum = new string[50];
            Console.Write("請輸入一串數字:");
            type = Console.ReadLine();
            for (int i = 1; i <= type.Length; i++)
            {
                Console.Write(i + ',');
                Console.ReadLine();
            }
        }
    }
}
