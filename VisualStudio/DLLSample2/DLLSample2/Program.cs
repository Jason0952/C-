using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLLSamples;

namespace DLLSample2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRectangle rec = new MyRectangle();
            rec.Width = 10;
            rec.Height = 10;
            Console.WriteLine("長度:" + rec.Height + " \n" + "寬度:" + rec.Width);
            Console.WriteLine("面積為:" + rec.GetArea());
            Console.ReadLine();
        }
    }
}
