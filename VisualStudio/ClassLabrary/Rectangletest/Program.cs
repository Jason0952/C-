using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLabrary;

namespace Rectangletest
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 0;
            int height = 0;
            Console.WriteLine("請輸入長方形的寬:");
            int.TryParse(Console.ReadLine(), out width);
            Console.WriteLine("請輸入長方形的高:");
            int.TryParse(Console.ReadLine(), out height);
            Rectangle rect = new Rectangle() { width = width, height = height };
            RectangleOperation operation = new RectangleOperation();
            operation.Target = rect;
            int area = operation.ComputerArea();
            Console.WriteLine($"長方形的面積為 {area}");

            Console.ReadLine();

        }
    }
}
