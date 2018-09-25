using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoopSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int[] array = new int[] { 10, 1, 20, 3, 40, 5 };


            for (int i = 0;i < array.Length;i+=1)
             {
                Console.WriteLine(array[i]);
             }
            
            /*
            foreach (int i in array)
            {
                result += i;
            }
            */
            Console.Write("結果:");
            Console.Write(result);
            Console.ReadLine();
        }
    }
}
