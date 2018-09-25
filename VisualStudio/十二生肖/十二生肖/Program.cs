using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 十二生肖
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "牛", "豬", "鼠", "羊", "狗","貓","zz" };
            foreach (var item in list.OrderBy((x) => x, new zodiac()))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }

    public class zodiac : IComparer<string>
    {
        List<string> current = new List<string> { "鼠", "牛", "虎", "兔", "龍", "蛇", "馬", "羊", "猴", "雞", "狗", "豬" };

        public int Compare(string x, string y)
        {
            var get = current.IndexOf(x) - current.IndexOf(y);
            return get;
        }
    }
}