using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabrary
{
    public class Rectangle
    {
        public int width { get; set; }
        public int height { get; set; }
    }

    public class RectangleOperation
    {
        public Rectangle Target { get; set; }

        public int ComputerArea()
        {
            return Target.width * Target.height;
        }
    }

    public class RectangleOperationHelper
    {
        public static int Computer(Rectangle input)
        {
            return input.width * input.height;
        }
    }

    public static class RectangleOperationExtention
    {
        public static int ComputerArea(this Rectangle input)
        {
            return input.width * input.height;
        }
    }
}
