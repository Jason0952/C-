using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 10;
            Console.WriteLine("i.equals(j) = " + i.Equals(j));
            //int 的 equal有多載，此處呼叫的是 int.equals(int) 而非object.equals(object)
            MyData r1 = new MyData() { Width = 10, Height = 10 };
            MyData r2 = new MyData() { Width = 10, Height = 10 };
            MyData r3 = r2;
            //1.把Class類別裡面的函式跟覆寫都刪除，即可顯示為true
            //2.刪除複寫的函式後，執行以下，即可變為false
            //   object o = r2;
            //   Console.WriteLine("r1.equals(o) = " + r1.Equals(o));
            //3.增加覆寫函式之後為true
            Console.WriteLine("r1.equals(r2) = " + r1.Equals(r2)); //加入雙函式後顯示為true
            Console.WriteLine("r2.equals(r3) = " + r2.Equals(r3));


            Console.ReadLine();
        }
    }
}
