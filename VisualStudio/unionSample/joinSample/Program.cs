using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joinSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var listt = Createteacher();
            var lists = Createstudent();
            var result =
                from t in listt
                join s in lists
                on t.classnum equals s.classnum
                select
                new result
                { classnum = t.classnum, teachername = t.teachername, studentname = s.studentname };

            foreach (var item in result)
            {
                Console.WriteLine(item.classnum + "," + item.teachername + "," + item.studentname);
            }

            Console.ReadLine();
        }

        static List<teacherinformation> Createteacher()
        {
            var a = new List<teacherinformation>()
            {
                new teacherinformation() { classnum = "A1", teachername = "bill" } ,
                new teacherinformation() { classnum = "B1", teachername = "david" }
            };
            return a;
        }

        static List<studentinformation> Createstudent()
        {
            var a = new List<studentinformation>()
            {
                new studentinformation() { classnum = "A1", studentname = "bii" },
                new studentinformation() { classnum = "A1", studentname = "biil" },
                new studentinformation() { classnum = "B1", studentname = "biii" },
                new studentinformation() { classnum = "A1", studentname = "biill" },
                new studentinformation() { classnum = "B1", studentname = "biiii" },
            };
            return a;
        }
    }
}
