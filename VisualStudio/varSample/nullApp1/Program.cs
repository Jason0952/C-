using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nullApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Createlist();
            var person1 = list.FirstOrDefault((x) => x.age < 37);
            Console.WriteLine("小於37歲且第一個被找到的人:" + person1.name);

            var person2 = list.First((x) => x.age < 30);
            Console.WriteLine("小於30歲且第一個被找到的人:" + person2.name);

            Console.ReadLine();
        }

        static List<Class1> Createlist()
        {
            List<Class1> list = new List<Class1>();
            list.Add(new Class1() { name = "jason", age = 90 });
            list.Add(new Class1() { name = "jaso", age = 100 });
            list.Add(new Class1() { name = "jas", age = 1000 });
            list.Add(new Class1() { name = "ja", age = 10000 });
            return list;
        }
    }
}
