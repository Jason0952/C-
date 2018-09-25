using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建構式
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBaseClass o1 = new MyBaseClass();
            display("o1", o1.x);

            MyBaseClass o2 = new MyBaseClass(99);
            display("o2", o2.x);

            Console.ReadLine();
        }

        static void display(string name,int value)
        {
            Console.WriteLine($"這是{name}={value}");
        }
    }
}
