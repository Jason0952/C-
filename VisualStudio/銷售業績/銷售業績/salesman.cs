using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 銷售業績
{
    public class Salesmaninfo
    {
        public List<salesman> People { get; set; }

        public Salesmaninfo()
        {
            People = new List<salesman>();
        }

        public static Salesmaninfo getsalesman()
        {
            var salesmans = new Salesmaninfo();
            salesmans.People.Add(new salesman { name = "Bill", Items = product.Ballpen, sold = 33 });
            salesmans.People.Add(new salesman { name = "Bill", Items = product.pencil, sold = 32 });
            salesmans.People.Add(new salesman { name = "Bill", Items = product.eraser, sold = 56 });
            salesmans.People.Add(new salesman { name = "Bill", Items = product.ruler, sold = 45 });
            salesmans.People.Add(new salesman { name = "Bill", Items = product.RE, sold = 33 });

            salesmans.People.Add(new salesman { name = "John", Items = product.Ballpen, sold = 77 });
            salesmans.People.Add(new salesman { name = "John", Items = product.pencil, sold = 33 });
            salesmans.People.Add(new salesman { name = "John", Items = product.eraser, sold = 68 });
            salesmans.People.Add(new salesman { name = "John", Items = product.ruler, sold = 45 });
            salesmans.People.Add(new salesman { name = "John", Items = product.RE, sold = 23 });

            salesmans.People.Add(new salesman { name = "David", Items = product.Ballpen, sold = 43 });
            salesmans.People.Add(new salesman { name = "David", Items = product.pencil, sold = 55 });
            salesmans.People.Add(new salesman { name = "David", Items = product.eraser, sold = 43 });
            salesmans.People.Add(new salesman { name = "David", Items = product.ruler, sold = 67 });
            salesmans.People.Add(new salesman { name = "David", Items = product.RE, sold = 65 });

            return salesmans;
        }
    }
}
