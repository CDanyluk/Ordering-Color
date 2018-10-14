using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace OrderColors
{
    class Point
    {
        public double x, y, z; //co-ordinate of point
        public double distance; //distance from test point
        public Color color;

        public Point(double x, double y, double z, double distance, Color color)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.distance = distance;
            this.color = color;
        }



        //public double X { get; set; }
        //public double Y { get; set; }
        //public double Z { get; set; }
        //public double Distance { get; set; }


    }
}
