using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建構式2
{
    public class BaseClass
    {
        public int x { get; set; }

        public BaseClass()
        {
            x = 0;
        }

        public BaseClass(int y)
        {
            x = y;
        }
    }

    public class Class1 : BaseClass
    {
        public int k { get; set; }

        public Class1(int x, int y) : base(y)
        {
            k = x;
        }
    }
}
