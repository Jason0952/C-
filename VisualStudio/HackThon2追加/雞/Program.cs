using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 雞
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 16; i++)
            {
                for (int j = 1; j <= 32; j++)
                {
                    for (int k = 2; k <= 100; k++)
                    {
                        if (i + j + k == 100 && 60 * i + 30 * j + k == 1000)
                        {
                            Console.WriteLine($"公雞:{i},母雞:{j},小雞:{k}");
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
