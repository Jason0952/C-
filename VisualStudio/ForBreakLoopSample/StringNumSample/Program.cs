using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringNumSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 5;
            int i2 = 3;
            double d = 9.8;
            string s1 = "the";
            string s2 = "end";

            Console.WriteLine(i1+i2);
            Console.WriteLine(i1+d);
            Console.WriteLine(s1+s2);
            Console.WriteLine(s1+i1);
            Console.WriteLine(d+s2);
            Console.ReadLine();
        }
    }
}
