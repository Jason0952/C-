using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委派2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "bill", "john", "david", "tom", "david" };

            Myclass obj = new Myclass();
            var result = obj.Dowhere(list, (x) => x == "david");

            //1.Mypredicate predicate = searchdavid;  
            //  var result = obj.Dowhere(list, predicate);    
            
            //2.var result = obj.Dowhere(list,delegate (string x){return x == "david";});

            //3.var result = obj.Dowhere(list, (x) => {return x =="david"});

            //4.var result = obj.Dowhere(list, (x) => x == "david");

            foreach (var v in result)
            {
                Console.WriteLine(v);
            }
            Console.ReadLine();
        }

        static bool searchdavid(string value)
        {
            return value == "david";
        }
    }
}
