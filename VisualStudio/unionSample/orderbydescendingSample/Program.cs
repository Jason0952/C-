using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderbydescendingSample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mydata> list = CreateList();
            var order1 =
                from o in list
                orderby o.Name, o.Age
                select o;
            Display(order1);

            var order2 =
                from o in list
                orderby o.Name descending, o.Age descending
                select o;
            Display(order2);

            Console.ReadLine();
        }

        static List<Mydata> CreateList()
        {
            var a = new List<Mydata>();
            {
                a.Add(new Mydata() { Name = "bill", Age = 100 });
                a.Add(new Mydata() { Name = "jason", Age = 22 });
                a.Add(new Mydata() { Name = "lear", Age = 30 });
                a.Add(new Mydata() { Name = "apple", Age = 2000000 });
                a.Add(new Mydata() { Name = "baba", Age = 40 });
            }
            return a;
        }

        public static void Display(IOrderedEnumerable<Mydata> sorcer)
        {
            foreach (var sorc in sorcer)
            {
                Console.WriteLine(sorc.Name + "的年齡是:" + sorc.Age);
            }
            Console.WriteLine("--------");
        }
    }
}
