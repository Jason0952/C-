using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象類別與繼承
{
    public abstract class Myshape
    {
        public abstract double GetArea();
    }

    public class MyRectangle : Myshape
    {
        public double width { get; set; }
        public double height{get; set;}
        public override double GetArea()
        {
            return width * height;
        }
    }

    public class MyCircle : Myshape
    {
        public double half { get; set; }

        public override double GetArea()
        {
            return Math.Pow(half, 2) * Math.PI;
        }
    }
}
