using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupbySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            var result = list.GroupBy((x) => x.City); //以城市為一群
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
