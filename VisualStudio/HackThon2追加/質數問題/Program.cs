using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 質數問題
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for (i = 101; i <= 200; i++)
            {
                k = 1;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        k = 0;
                        break;
                    }
                }
                if (k == 1)
                {
                    Console.Write(" {0:D3}", i);
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
