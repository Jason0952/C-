using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 費氏
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 1 };
            int tmp = 1;

            while (tmp <= 1836311903 && tmp >= 0)
            {
                if (tmp == 1)
                {
                    Console.Write(tmp.ToString() + ",");
                    tmp += 1;
                }
                else
                {
                    tmp = array[0] + array[1];
                    Console.Write(tmp.ToString() + ",");
                    array[0] = array[1];
                    array[1] = tmp;
                    if (tmp == 1836311903)
                    {
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}


