using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionarysample
{
    class dic
    {
        public int width { get; set; }
        public int height { get; set; }

        public int GetArea()
        {
            return width * height;
        }
    }
}
