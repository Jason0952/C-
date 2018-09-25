using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建構式2
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass a = new BaseClass();
            display("a",a.x);

            BaseClass b = new BaseClass(99);
            display("b",b.x);

            Class1 c = new Class1(55, 77);
            display("c", c.x, c.k);

            Console.ReadLine();
        }

        static void display(string name,int I)
        {
            Console.WriteLine($"{name}的x是{I}");
        }

        static void display(string name, int x, int k)
        {
            Console.WriteLine($"{name}的x是{x},{name}的k是{k}");
        }
    }
}
