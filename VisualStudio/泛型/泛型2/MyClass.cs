using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型2
{
    public static class Class1
    {
        public static List<T> dowhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();
            foreach (var v in source)
            {
                if (predicate.Invoke(v))
                {
                    result.Add(v);
                }
            }
            return result;
        }
    }
}
