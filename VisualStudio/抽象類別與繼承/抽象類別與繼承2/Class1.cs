using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象類別與繼承2
{
    public class baseclass
    {
        public virtual void ex()
        {
            Console.WriteLine("this is ex");
        }

        public virtual void bg()
        {
            Console.WriteLine("this is bg");
        }
    }

    public class class1 : baseclass
    {
        public override void ex()
        {
            Console.WriteLine("this is ex kuo");
        }

        public override void bg()
        {
            Console.WriteLine("this is bg kuo is bitch");
        }
    }

    public class class2 : class1
    {
        public override sealed void ex()
        {
            Console.WriteLine("kuo is bitch cannot change now");
        }

        public override void bg()
        {
            Console.WriteLine("kuo maybe is not a bitch");
        }
    }

    public class class3 : class2
    {
        public override sealed void bg()
        {
            Console.WriteLine("kuo is bitch confirm!!!");
        }
    }
}
