using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int choose;
            Console.Write("請選擇:");
            string chosen = Console.ReadLine();
            choose = int.Parse(chosen);

            switch (choose)
            {
                case 1:
                     Console.Write("選擇一");
                     break;
                case 2:
                    Console.Write("選擇二");
                    break;
                default:
                    Console.Write("選擇錯誤!");
                    break;
            }
            Console.ReadLine();
            */
            int choose, number = 1;
            Console.Write("請選擇:");
            string chosen = Console.ReadLine();
            choose = int.Parse(chosen);
            string resuilt = Getresult(choose);
            int a = getnum(number);
            Console.WriteLine(resuilt);
            Console.Write(a);
            Console.ReadLine();
        }

        private static string Getresult(int chooseone)
        {
            switch (chooseone)
            {
                case 1:
                    return "選擇一";
                case 2:
                    return "選擇二";
                default:
                    return "選擇錯誤!!";
            }
        }

        private static int getnum(int i)
        {
            i++;
            return i;
        }
    }
}
