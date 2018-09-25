using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Createlist();
            var total = list.Sum((x) => x.age);
            Console.WriteLine("年齡為:" + total);

            var Min = list.Min((x) => x.age);
            Console.WriteLine("最小年齡為:" + Min);

            var Max = list.Max((x) => x.age);
            Console.WriteLine("最大年齡為:" + Max);

            int count = list.Count();
            Console.WriteLine("list總個數為:" + count);
            int countjason = list.Count((x) => x.name == "jason");
            Console.WriteLine("list中jason的總和為:" + countjason);

            var average = list.Average((x) => x.age);
            Console.WriteLine("年齡的平均值:" + average);

            Console.ReadLine();
        }

        static List<Class1> Createlist()
        {
            List<Class1> list = new List<Class1>();
            list.Add(new Class1() { name = "jason", age = 90 });
            list.Add(new Class1() { name = "jason", age = 100 });
            list.Add(new Class1() { name = "jas", age = 1000 });
            list.Add(new Class1() { name = "ja", age = 10000 });
            return list;
        }
    }
}
