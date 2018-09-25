using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 文字檔讀取.Models;

namespace 文字檔讀取
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splits = new char[] { ',' };
            bool isok = true;
            string filename = "test03.txt";

            if (File.Exists(filename))
            {
                string[] all = File.ReadAllLines(filename);
                foreach (var v in all)
                {

                    if (v.StartsWith("695") || v.StartsWith("525"))
                    {
                        if (DateTime.TryParseExact(v.Substring(13, 8), "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out DateTime result) &&
                         DateTime.TryParseExact(v.Substring(21, 8), "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out DateTime result1))
                        {
                            add d = new add()
                            {
                                TickNumber = v,
                                FlyingDay = result,
                                Birthday = result1
                            };

                            try
                            {
                                data context = new data();
                                context.add.Add(d);
                                context.SaveChanges();
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine("發生錯誤");
                            }
                        }
                    }
                }
            }
            var list = new data();
            var res = list.add.ToList();
            foreach (var n in res)
            {
                Console.WriteLine(n.Birthday);
            }
            Console.ReadLine();
        }
    }
}

