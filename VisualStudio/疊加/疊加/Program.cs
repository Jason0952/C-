using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 疊加
{
    class Program
    {
        static void Main(string[] args)
        {
            getmore a = getmore.read | getmore.write;
            if ((a & getmore.read) == getmore.read)
            {
                Console.WriteLine("有包含運算");
                Console.ReadLine();
            }
        }

        [Flags]

        public enum getmore
        {
            //byte的位置
            None = 0, 
            read = 1, //2的0次方的位置
            write = 2, //2的1次方的位置
            create = 4, //2的2次方的位置
            delete = 8, //2的3次方的位置
            cns = 16 //2的4次方的位置
        }
    }
}
