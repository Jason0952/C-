using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 10;
            Console.WriteLine("(i,j) = " + object.Equals(i,j));

            Myrectangle r1 = new Myrectangle() { Width = 5, Height = 5 };
            Myrectangle r2 = new Myrectangle() { Width = 5, Height = 5 };
            Myrectangle r3 = r2;

            Console.WriteLine("r1,r2 = " + object.Equals(r1,r2));
            Console.WriteLine("r2,r3 = " + object.Equals(r2,r3));
            Console.WriteLine("r1,r3 = " + object.Equals(r1, r3));
            Console.ReadLine();
        }
    }
}
