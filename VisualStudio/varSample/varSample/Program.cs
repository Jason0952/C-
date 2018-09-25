using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varSample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Class1> list = Createlist();

            var ppl = list.Where((x) => x.name == "jason");

            foreach (var person in ppl)
            {
                Console.WriteLine(person.name + "是" + person.age + "歲");
            }
            Console.ReadLine();
        }

        static List<Class1> Createlist()
        {
            List<Class1> list = new List<Class1>();
            list.Add(new Class1() { name = "jason", age = 22 });
            list.Add(new Class1() { name = "jaso", age = 21 });
            list.Add(new Class1() { name = "jas", age = 20 });
            list.Add(new Class1() { name = "ja", age = 19 });
            return list;
        }
    }
}
