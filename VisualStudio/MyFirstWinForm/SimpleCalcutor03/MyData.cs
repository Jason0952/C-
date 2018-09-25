using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalcutor03
{
    class MyData
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int add()
        {
            return X + Y;
        }

        public int less()
        {
            return X - Y;
        }
        //public int X
        //{
        //    get { return _x; }  vaule = X
        //    /*
        //       public int GetX()
        //       {
        //           return _x;
        //       }
        //    */
        //    set { _x = value; } X = value
        //    /*
        //       public int GetX()
        //       {
        //           _x = value;
        //       }
        //    */
        //}

        //public int Y
        //{
        //    get { return _y; }  //= Y
        //    set { _y = value; }  // Y =
        //}
    }
}
