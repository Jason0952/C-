using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型練習
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> a = new List<string> { "john", "bill", "mouse", "dann", "bill" };
            var v = a.list((x) => x == "dann");
            foreach (var e in v)
            {
                Console.WriteLine(e);
            }

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "kuo");
            dic.Add(2, "is");
            dic.Add(3, "bitch");

            Console.WriteLine("請輸入想要的數字:");
            var str = Console.ReadLine();
            int.TryParse(str, out int zoe);
            var Catchstring = dic.list((x) => x.Key == zoe);
            foreach (var catchword in Catchstring)
            {
                Console.WriteLine($"我抓到了{catchword}的字串");
            }

            Console.ReadLine();
        }
    }
}
