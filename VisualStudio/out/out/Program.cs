using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @out
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            testx(ref x);
            int y;
            testy(out y);
        }

        static void testx(ref int x)
        {

        }

        static void testy(out int y)
        {
            y = 0;
        }
    }
}
