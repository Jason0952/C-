using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadThanDisplay
{
    /// <概要>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string input,s; /*宣告變數*/
            Console.Write("請輸入數字:");
            s = Console.ReadLine();
            Console.WriteLine("請輸入文字:");  //直接出現在執行後(Line = 換行)
            input = Console.ReadLine();  //讓input讀入剛剛輸入的字(按下enter結束->輸入完成)
            Console.Write("你輸入的文字是:");
            Console.Write(input);
            Console.Write(s);  //印出剛剛輸入的字
            Console.ReadLine();  //輸出剛剛使用者輸入的字

            if (input == s)
            {
                Console.Write("輸入一樣的東西!!");
            }
            else
            {
                Console.Write("輸入不一樣的文字!!");
            }
        }
    }
}
