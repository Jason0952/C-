using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象類別與繼承2
{
    class Program
    {
        static void Main(string[] args)
        {
            baseclass class1 = new class1();
            class1.ex();
            class1.bg();
            Console.ReadLine();

            baseclass classmate = new class2();
            classmate.ex();
            classmate.bg();
            Console.ReadLine();

            baseclass bigclass = new class2();
            bigclass.ex();
            bigclass.bg();
            Console.ReadLine();

            baseclass smallclass = new class3();
            smallclass.bg();
            Console.ReadLine();
        }
    }
}
