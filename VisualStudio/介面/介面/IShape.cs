using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 介面
{
    interface IShape
    {
        double ez();
    }

    public class MyRectangle : IShape
    {
        public int height { get; set; }
        public int width { get; set; }
        public double ez()
        {
            return height * width;
        }
    }

    public class MyCircle : IShape
    {
        public double Circlehalf { get; set; }
        public double ez()
        {
            return Math.PI * Math.Pow(Circlehalf, 2);
        }
    }
}
