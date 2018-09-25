using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 101;
            string b1 = "abc";

            int a2 = 10;
            string b2 = "abc";

            if (a1 != a2 && b1 != b2)
            {
                Console.WriteLine("完全正確!");
            }
            else
            {
                Console.WriteLine("至少一項不正確!");
            }

            if (a1 == a2 || b1 == b2)
            {
                Console.WriteLine("至少一項正確!");
            }
            else
            {
                Console.WriteLine("都不正確!");
            }
            Console.ReadLine();
        }
    }
}
