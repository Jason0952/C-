using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThenBySample
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<MyData> list = createdata();
            var order1 = list.OrderBy((x) => x.age);
            Display(order1);
            Console.WriteLine("--------");
            var order2 = list.OrderByDescending((x) => x.age);
            Display(order2);
            Console.WriteLine("--------");
            var order3 = list.OrderBy((x) => x.name).ThenBy((x) => x.age);
            Display(order3);
            Console.WriteLine("--------");
            var order4 = list.OrderBy((x) => x.name).ThenByDescending((x) => x.age);
            Display(order4);
            Console.WriteLine("--------");

            Console.ReadLine();

        }

        static List<MyData> createdata()
        {
            var a = new List<MyData>();
            {
                a.Add(new MyData() { name = "bill", age = 100 });
                a.Add(new MyData() { name = "jason", age = 22 });
                a.Add(new MyData() { name = "john", age = 27 });
                a.Add(new MyData() { name = "lear", age = 56 });
                a.Add(new MyData() { name = "osas", age = 31 });
            };
            return a;
        }

        static void Display(IOrderedEnumerable<MyData> source)
        {
            foreach (var item in source) { Console.WriteLine(item.name + " : " + item.age); }
            Console.WriteLine("-------------");
        }
    }
}
