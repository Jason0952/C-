using ClassLibrary1.service;
using ClassLibrary1.Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.shapeservice
{
    public class Rectangleservice : Shapeservice
    {
        public Rectangle Target { get; set; }
        public double ComputerArea1()
        {
            return Target.width * Target.height;
        }

        public double ComputerArea2()
        {
            return (Target.width + Target.height) * 2;
        }
    }
}
