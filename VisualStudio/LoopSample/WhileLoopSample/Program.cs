using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int i = 0;
            while (i < 11)
            {
                result += i;
                i++;
            }
            Console.Write("結果:");
            Console.Write(result);
            Console.ReadLine();
        }
    }
}
