using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 改變字串
{
    class Program
    {
        static void Main(string[] args)
        {            
            numchange();
            Console.ReadLine();
        }
        private static void numchange()
        {
            for (int i = 1; i < 101; i++)
            {
                string value = i.ToString();
                value = value.Replace("3", "A").Replace("5","B").Replace("9","C").Replace("0","D");
                Display(value);
            }
        }
        private static void Display(string value)
        {
            Console.WriteLine(value);
        }
    }
}
