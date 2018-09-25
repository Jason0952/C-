using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件與事件委派函式
{
    public class MyClass
    {
        public event EventHandler Xchange;

        private void OXchange()
        {
            if(Xchange != null)
            {
                Xchange.Invoke(this,new EventArgs());
            }
        }

        private int _x;
        public int X
        {
            get { return _x; }
            set
            {
                if (_x != value)
                {
                    _x = value;
                    OXchange();
                    //OXchange?.invoke(this,new eventargs()) 上面的OXchange()都可以註解
                }
            }
        }
    }
}
