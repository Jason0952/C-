using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 靜態
{
    public static class MyClass
    {
        private static int x = 100;
        public static void ex()
        {
            Console.WriteLine($"這是{x}");
        }
    }
}
