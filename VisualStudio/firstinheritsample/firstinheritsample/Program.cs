using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstinheritsample
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Class1 class2 = new Class1();
            bool equal = class1.Equals(class2); //記憶體位置不相同 => false
            Console.WriteLine(equal);

            //int是真的存進值
            int intx = 1;
            string s1 = intx.ToString();
            string s2 = intx.ToString();
            Console.WriteLine(s1 == s2); //java出來為false(java沒有多載)
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(object.ReferenceEquals(s1, s2));

            //string抓的是""的位址
            string s11 = "ABC";
            string s22 = "ABC";
            Console.WriteLine(object.ReferenceEquals(s11, s22));
            Console.ReadLine();
        }
    }
}
