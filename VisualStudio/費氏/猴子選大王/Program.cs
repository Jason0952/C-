using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猴子選大王
{
    class Program
    {
        static void Main(string[] args)
        {
            Monkey king = new Monkey();
            Console.Write($"第{king.Monkeyking(10, 3)}是猴子王");
            Console.ReadLine();
        }
    }
}
