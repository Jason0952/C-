using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委派2
{
    public delegate bool Mypredicate(string value);

    public class Myclass
    {
        public List<string> Dowhere(List<string> source, Mypredicate predicate)
                                                        //func<string,bool> <傳入的參數,傳回的參數> 
        {
            List<string> list = new List<string>();

            foreach (var v in list)
            {
                if (predicate.Invoke(v))
                {
                    list.Add(v);
                }
            }

            return list;
        }
    }
}
