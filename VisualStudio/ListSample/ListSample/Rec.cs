using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSample
{
    class Rec
    {
        public String name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetRec
        {
            get { return Width * Height; }
        }
    }
}
