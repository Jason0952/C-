using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型練習
{
    public static class john
    {
        public static IEnumerable<T> list<T>(this IEnumerable<T> xyz, Func<T, bool> c)
        {
            List<T> a = new List<T>();
            foreach (var v in xyz)
            {
                if (c.Invoke(v))
                {
                    a.Add(v);
                }
            }
            return a;
        }
    }
}
