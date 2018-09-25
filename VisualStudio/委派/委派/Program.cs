using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委派
{
    public delegate void SomeAction(string message);

    class Program
    {
        static void Main(string[] args)
        {
            SomeAction action1 = new SomeAction(Showtext);
            action1.Invoke("好的");
            action1("原來如此");

            SomeAction action2 = ShowMessage;
            action2("第二個");

            action1("原來如此");

            Console.ReadLine();
        }

        static void Showtext(string msg)
        {
            Console.WriteLine($"Show text:{msg}");
        }

        static void ShowMessage(string str)
        {
            Console.WriteLine($"Show Message:{str}");
        }
    }
}
