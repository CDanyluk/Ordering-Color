using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderColors
{
    class RGBPoint
    {
        private int r;
        private int g;
        private int b;

        public RGBPoint(int r, int g, int b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public int R { get; set; }

        public int G { get; set; }

        public int B { get; set; }

    }
}
