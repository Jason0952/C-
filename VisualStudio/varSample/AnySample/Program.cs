using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Createlist();
            string name = "David";
            bool result = list.Any((x) => x.name == name);
            if (result)
            {
                Console.WriteLine("找到了!名字是:" + result);
            }
            else
            {
                Console.WriteLine("沒有找到" + result);
            }
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
