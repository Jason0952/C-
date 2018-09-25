using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED燈
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.Write("請輸入數字:");
            string s = Console.ReadLine();
            display(s);
        }

        public static void display(string list)
        {            
            Dictionary<int, string> line1 = new Dictionary<int, string>();
            Dictionary<int, string> line2 = new Dictionary<int, string>();
            Dictionary<int, string> line3 = new Dictionary<int, string>();
            line1.Add(0, " _ ");
            line2.Add(0, "| |");
            line3.Add(0, "|_|");

            line1.Add(1, "  ");
            line2.Add(1, " |");
            line3.Add(1, " |");

            line1.Add(2, " _ ");
            line2.Add(2, " _|");
            line3.Add(2, "|_ ");

            line1.Add(3, " _ ");
            line2.Add(3, " _|");
            line3.Add(3, " _|");

            line1.Add(4, "   ");
            line2.Add(4, "|_|");
            line3.Add(4, "  |");

            line1.Add(5, " _ ");
            line2.Add(5, "|_ ");
            line3.Add(5, " _|");

            line1.Add(6, " _ ");
            line2.Add(6, "|_ ");
            line3.Add(6, "|_|");

            line1.Add(7, " _ ");
            line2.Add(7, "| |");
            line3.Add(7, "  |");

            line1.Add(8, " _ ");
            line2.Add(8, "|_|");
            line3.Add(8, "|_|");

            line1.Add(9, " _ ");
            line2.Add(9, "|_|");
            line3.Add(9, "  |");

            foreach (var v in list)
            {
                int.TryParse(v.ToString(), out int a);
                Console.Write(line1[a]);
            }
            Console.WriteLine();
            foreach (var v in list)
            {
                int.TryParse(v.ToString(), out int a);
                Console.Write(line2[a]);
            }
            Console.WriteLine();
            foreach (var v in list)
            {
                int.TryParse(v.ToString(), out int a);
                Console.Write(line3[a]);
            }

            Console.ReadLine();
        }
    }
}
