using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopSample
{
    class Program
    {
        //從1加總到10
        static void Main(string[] args)
        {
            int result = 0;
            for (int i = 1; i < 11; i++)
            {
                result = result + i;              
            }
            Console.Write("結果:" + result);
            Console.ReadLine();
        }
    }
}
