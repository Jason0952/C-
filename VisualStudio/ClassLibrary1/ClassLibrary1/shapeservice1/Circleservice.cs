using ClassLibrary1.service;
using ClassLibrary1.Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.shapeservice1
{
    public class Circleservice : Shapeservice
    {
        public Circle Target { get; set; }
        public double ComputerArea1()
        {
            return Target.half * Target.half * Math.PI;
        }
        public double ComputerArea2()
        {
            return (Target.half + Target.half) * Math.PI;
        }
    }
}
