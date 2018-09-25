using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqGroupSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            var result =
                from o in list
                group o by o.City;
            foreach (var item in result) //以city分群
            {
                Console.WriteLine("住在" + item.Key);
                foreach (var p in item) //群裡面有哪些東西
                {
                    Console.WriteLine(p.Name);
                }
                Console.WriteLine("------");
            }

            Console.ReadLine();
        }

        static List<Mydata> CreateList()
        {
            List<Mydata> list = new List<Mydata>();
            list.Add(new Mydata() { Name = "bill", City = "台南" });
            list.Add(new Mydata() { Name = "john", City = "台北" });
            list.Add(new Mydata() { Name = "jason", City = "高雄" });
            list.Add(new Mydata() { Name = "bb", City = "台南" });
            list.Add(new Mydata() { Name = "beat", City = "台北" });
            return list;
        }
    }
}
