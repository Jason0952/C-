using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoopSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int i = 12;

            do
            {
                result += i;
                i++;
            } while (i < 11);

            Console.Write("結果:");
            Console.Write(result);
            Console.ReadLine();
        }
    }
}
