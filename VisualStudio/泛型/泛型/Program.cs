using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1<int> o1 = new Class1<int>();
            string s1 = o1.Class.GetType().ToString();
            display("o1.data:", s1);

            Class1<bool> o2 = new Class1<bool>();
            string s2 = o2.Class.GetType().ToString();
            display("o2.data", s2);

            Console.ReadLine();
        }
        static void display(string str, string Str)
        {
            Console.WriteLine($"{str}的型別是{Str}");
        }
    }
}
