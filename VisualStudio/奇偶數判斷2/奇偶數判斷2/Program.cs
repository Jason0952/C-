using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 奇偶數判斷2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入數字:");
            var a = Console.ReadLine().Split(',');

            List<int> addeven = new List<int>();
            List<int> addodd = new List<int>();

            foreach (var v in a)
            {
                int i;
                int.TryParse(v, out i);

                if (i % 2 == 0)
                {
                    addeven.Add(i);
                }
                else
                {
                    addodd.Add(i);
                }

            }
            displayeven(addeven);
            displayodd(addodd);
            Console.ReadLine();
        }

        private static void displayeven(List<int> Num)
        {
            string result = getNum(Num);
            Console.WriteLine($"偶數有:{result}");
            
        }

        private static void displayodd(List<int> list)
        {
            string result = getNum(list);
            Console.WriteLine($"奇數有:{result}");            
        }

        private static string getNum(List<int> Number)
        {
            string numtostring = "";
            var getnum = Number.OrderBy((x) => x);
            foreach (var v in getnum)
            {
                numtostring += $"{v},";
            }

            numtostring = numtostring.TrimEnd(',');
            return numtostring;
        }
    }
}
