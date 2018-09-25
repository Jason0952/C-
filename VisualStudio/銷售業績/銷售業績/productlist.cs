using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 銷售業績
{
    public class productlist
    {
        public List<item> Item { get; set; }

        public productlist()
        {
            Item = new List<item>();
        }

        public static productlist getallitem()
        {
            var list = new productlist();
            list.Item.Add(new item { Itemname = product.Ballpen, Itemprice = 12 });
            list.Item.Add(new item { Itemname = product.pencil, Itemprice = 16 });
            list.Item.Add(new item { Itemname = product.eraser, Itemprice = 10 });
            list.Item.Add(new item { Itemname = product.ruler, Itemprice = 14 });
            list.Item.Add(new item { Itemname = product.RE, Itemprice = 15 });
            return list;
        }
    }
}
