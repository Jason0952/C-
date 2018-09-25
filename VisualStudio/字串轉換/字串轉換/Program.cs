using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字串轉換
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一串數字:");
            var getstring = Console.ReadLine().Split(',');
            string[] chinese = { "一", "二","三", "四", "五", "六", "七", "八", "九" };
            string[] Num = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            foreach (var b in getstring)
            {
                string result = b;
                result = result.Replace(Num[0], chinese[0]).Replace(Num[1], chinese[1]).Replace(Num[2], chinese[2]).Replace(Num[3], chinese[3]).Replace(Num[4], chinese[4]).Replace(Num[5], chinese[5]).Replace(Num[6], chinese[6]).Replace(Num[7], chinese[7]).Replace(Num[8], chinese[8]);
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }

        
        }
    }
}
