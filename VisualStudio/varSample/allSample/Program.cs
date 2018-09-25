using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Createlist();
            bool isbill = list.All((x) => x.name == "David");
            if (isbill)
            {
                Console.WriteLine("全部都是bill");
            }
            else
            {
                Console.WriteLine("有些人不叫bill");
            }

            bool isalloverforty = list.All((x) => x.age >= 40)
            if (isalloverforty)
            {
                Console.Write("大家都超過40歲");
            }
            else
            {
                Console.Write("有人不到40歲");
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
