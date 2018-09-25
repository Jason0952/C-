using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForBreakLoopSample
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("i =" + i);
                for (int j = 11; j < 20; j++)
                {
                    if (j == 15)
                    {
                        break;
                    }
                    Console.WriteLine("j =" + j);
                }
            }
            Console.ReadLine();
        }
    }
}
