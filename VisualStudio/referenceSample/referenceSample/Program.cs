using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace referenceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 10;
            Console.WriteLine("reference(i,i) = " + object.ReferenceEquals(i, i));
            Console.WriteLine("reference(i,j) = " + object.ReferenceEquals(i, j));

            MyRectangle r1 = new MyRectangle() { Width = 10, Height = 10 };
            MyRectangle r2 = new MyRectangle() { Width = 10, Height = 10 };
            MyRectangle r3 = r2;
            Console.WriteLine("reference(r1,r2) = " + object.ReferenceEquals(r1, r2));
            Console.WriteLine("reference(r2,r3) = " + object.ReferenceEquals(r2, r3));
            Console.ReadLine();
        }
    }
}
