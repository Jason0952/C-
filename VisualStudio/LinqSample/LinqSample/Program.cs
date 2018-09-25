using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<data> list = Createdata();
            //IEnumerable 可列舉的(一串)
            IEnumerable<data> ppl =
                from data in list
                where data.name == "jason"
                select data;

            foreach (data person in ppl)
            {
                Console.WriteLine(person.name + "是" + person.age + "歲");
            }
            Console.ReadLine();
        }

        static List<data> Createdata()
        {
            List<data> list = new List<data>();
            list.Add(new data() { name = "jason", age = 22});
            list.Add(new data() { name = "paul", age = 66 });
            list.Add(new data() { name = "jass", age = 55 });
            list.Add(new data() { name = "real", age = 44 });
            list.Add(new data() { name = "riot", age = 33 });
            list.Add(new data() { name = "jk", age = 11 });
            return list;
        }
    }
}
