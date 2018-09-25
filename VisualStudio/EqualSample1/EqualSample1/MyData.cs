using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSample1
{
    class MyData
    {
        public int Width { get; set; }
        public int Height { get; set; }
        //第一次未加第一個bool Equals(MyData other)
        //抓取object的


        public bool Equals(MyData other)
        {
            // 將r1的長和寬跟r2的長和寬比較後會回傳true
            return (this.Width == other.Width) && (this.Height == other.Height);
        }
        ////第二次加了第一個bool Equal(MyData other)
        ////抓取函式裡面的Equal(int)
        //
        //public override bool Equals(object obj) //覆寫為了維持型別一樣
        //{
        //    return this.Equals((MyData)obj);
        //}
        //第三次加了覆寫Equal
        //抓取object的
    }
}
