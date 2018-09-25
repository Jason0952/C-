using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建構式
{
    public class MyBaseClass
    {
        public int x { get;private set; }

        public MyBaseClass() 
        {
            x = 0;
        }
        //與上面相同的方法
        //public MyBaseClass() : this(0) 將0傳給下面的y
        //{ }

        public MyBaseClass(int y)
        {
            x = y;
        }
    }
}
