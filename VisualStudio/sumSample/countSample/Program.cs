using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Createlist();

            var min = list.Where((x) => x.name == "jason").Min((x) => x.age);
            Console.WriteLine("年齡最小的:" + min);

            var sum = list.Where((x) => x.name == "jason").Sum((x) => x.age);
            Console.WriteLine("年齡總和" + sum);

            var average = list.Where((x) => x.name == "jason").Average((x) => x.age);
            Console.WriteLine("平均年齡為:" + average);

            
            var ppl = list.Where((x) => x.age == list.Min((y) => y.age));
            foreach (var a in ppl)
            {
                Console.Write("最小年齡的名字:" + a.name );
            }

            Console.ReadLine();
        }

        static List<Class1> Createlist()
        {
            List<Class1> list = new List<Class1>();
            list.Add(new Class1() { name = "aa", age = 90 });
            list.Add(new Class1() { name = "jason", age = 100 });
            list.Add(new Class1() { name = "jason", age = 1000 });
            list.Add(new Class1() { name = "jason", age = 10000 });
            return list;
        }
    }
}
