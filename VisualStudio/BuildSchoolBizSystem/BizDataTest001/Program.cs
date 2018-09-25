using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizDataLibrary;
using BizDataLibrary.Models;

namespace BizDataTest001
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService service = new ProductService();
            List<Product> products = new List<Product>()
            {
                new Product() { PartNo = "A005", PartName = "小號一字起子"},
                new Product() { PartNo = "A006", PartName = "大號一字起子" },
                new Product() { PartNo = "B005", PartName = "小號十字起子" },
                new Product() { PartNo = "B006", PartName = "小號十字起子" },
            };

            foreach (var p in products)
            {
                service.Create(p);
            }
            Console.WriteLine("資料加入完成");

            var result = service.GetAll();
            Console.WriteLine("資料庫裡有資料的是...");
            foreach (var r in result)
            {
                Console.WriteLine($"料號 { r.PartNo} : 品名 { r.PartName}");
            }
            Console.WriteLine("==============");
            var product = service.GetByPartNo("B001");
            Console.WriteLine($"取得的品名為 {product.PartName }");
            Console.WriteLine("==============");

            Console.ReadLine();
        }
    }
}
