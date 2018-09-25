using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 介面
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape Rectangle = new MyRectangle() { height = 10,width = 10 };
            displayrec(Rectangle);
            IShape Circle = new MyCircle() { Circlehalf = 10 };
            displaycircle(Circle);
            Console.ReadLine();
        }

        private static void displaycircle(IShape circle)
        {
            Console.WriteLine($"圓形面積為:{circle.ez()}");
        }

        private static void displayrec(IShape rectangle)
        {
            Console.WriteLine($"正方形面積為:{rectangle.ez()}");
        }


    }
}
