using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Createlist();
            var person1 = list.SingleOrDefault((x) => x.name == "jason");
            if (person1 == null)
            {
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine("找到唯一的:" + person1.name);
            }
            

            var person2 = list.Single((x) => x.name == "ja");
            if (person1 == null)
            {
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine("找到唯一的:" + person2.name);
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
