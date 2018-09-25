using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLLSamples;

namespace DLLSample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRectangle rectangle = new MyRectangle();
            rectangle.Width = 10;
            rectangle.Height = 10;
            Console.WriteLine("長度:" + rectangle.Height + "\n" + "寬度:" + rectangle.Width);
            Console.WriteLine("面積為:" + rectangle.GetArea());
            Console.ReadLine();
        }
    }
}
