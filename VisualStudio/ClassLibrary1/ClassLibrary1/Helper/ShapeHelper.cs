using ClassLibrary1.Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Helper
{
    public static class ShaperHelper
    {
        public static double ComputerArea1(this Rectangle input)
        {
            return input.width * input.height;
        }

        public static double ComputerArea2(this Rectangle input)
        {
            return (input.width + input.height)*2;
        }

        public static double ComputerArea1(this Circle input)
        {
            return input.half * input.half * Math.PI;
        }

        public static double ComputerArea2(this Circle input)
        {
            return input.half * 2 * Math.PI;
        }
    }
}
