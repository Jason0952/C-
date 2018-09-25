using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSample1
{
    class Rec
    {
        public string name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetArea
        {
            get { return Width * Height; }
        }
    }
}
