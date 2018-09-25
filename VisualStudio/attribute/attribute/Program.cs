using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string s = "aaa";
                int i = int.Parse(s);
            }
            catch (Exception ex)
            {
                Console.WriteLine("例外發生");
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("全部執行完畢");
            }
            Console.ReadLine();
        }
    }
}
