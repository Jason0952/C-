using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 數值判斷
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> getNum = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 != 0)
                {
                    getNum.Add(i);
                }
            }
            string result = display(getNum);
            Console.Write("不會被3和5整除的有:");
            Console.Write(result);
            Console.ReadLine();
        }

        private static string display(List<int> Num)
        {
            string getstring = "";

            foreach (var v in Num)
            {
                getstring += $"{v},";
            }

            getstring = getstring.TrimEnd(',');
            return getstring;
        }
    }
}
