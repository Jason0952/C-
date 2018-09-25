using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猴子選大王
{
    class Monkey
    {
        public int Monkeyking(int M, int N)
        {
            int k = 0;
            for (int i = 2; i <= M; i++)
            {
                k = (k + N) % i;
            }
            return k++;
        }
    }
}
