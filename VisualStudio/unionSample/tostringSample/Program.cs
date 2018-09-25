using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tostringSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = createlist();
            var result1 = list.Where((x) => x.age > 40).ToList();
            foreach (var item in result1)
            {                
                Console.WriteLine(item.name + "--" + item.age);
            }
            var result2 = list.Where((x) => x.age > 40).ToArray();
            foreach (var item in result2)
            {
                Console.WriteLine(item.name + "--" + item.age);
            }

            var result3 = list.Where((x) => x.age > 40).ToDictionary((x) => x.name);
            foreach (var item in result3)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value.name + "--" +item.Value.age);
            }
            Console.WriteLine("--------------");

            var result4 = list.ToDictionary((x) => x.name, (y) => y.age); //逗號前為key 逗號後為值(皆為參數)
            foreach (var item in result4)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            Console.ReadLine();

        }

        static List<class1> createlist()
        {
            var list = new List<class1>();
            list.Add(new class1() { name = "Bill", age = 47 });
            list.Add(new class1() { name = "John", age = 37 });
            list.Add(new class1() { name = "Tom", age = 48 });
            list.Add(new class1() { name = "David", age = 36 });
            return list;
        }


    }
}
