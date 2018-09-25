using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 銷售業績
{
    public class salesman
    {
        public string name { get; set; }
        public string Items { get; set; }
        public int sold { get; set; }
    }

    public class item
    {
        public string Itemname { get; set; }
        public int Itemprice { get; set; }
    }

    public static class product
    {
        public const string Ballpen = "原子筆";
        public const string pencil = "鉛筆";
        public const string eraser = "橡皮擦";
        public const string ruler = "尺";
        public const string RE = "立可白";
    }
}
