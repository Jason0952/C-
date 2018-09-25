using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listsample
{
    class list
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }


        public int GetNum()
        {
            return Width * Height;
        }

        public int GetWidth()
        {
            return Width;
        }
    }
}
