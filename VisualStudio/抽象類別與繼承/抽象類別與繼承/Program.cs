using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象類別與繼承
{
    class Program
    {
        static void Main(string[] args)
        {
            Myshape rec = new MyRectangle { width = 10, height = 10 };
            Console.WriteLine($"正方形面積為:{rec.GetArea()}");
            Myshape circle = new MyCircle { half = 3 };
            Console.WriteLine($"圓形面積為:{circle.GetArea()}");
            // Myshape shape = new Myshape();
            Console.ReadLine();
        }
    }
}
