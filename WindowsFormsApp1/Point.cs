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
        public int zval;

        public Point(double x, double y, double z, double distance, Color color, bool zorder)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.distance = distance;
            this.color = color;
            if (zorder == true) {
                getZValue();
            }
        }

        //Convert to the binary representation for z-ordering
        public void getZValue()
        {
            //array to store the individual bits
            char[] bitArr = new char[48];

            //convert integers in point to binary
            string bx = Convert.ToString(Convert.ToInt32(x), 2).PadLeft(16, '0');
            string by = Convert.ToString(Convert.ToInt32(y), 2).PadLeft(16, '0');
            string bz = Convert.ToString(Convert.ToInt32(z), 2).PadLeft(16, '0');

            //interlock the bits
            int counter = 0;
            for (int i = 0; i < bx.Count(); i++)
            {
                bitArr[i + counter] = bz[i];
                bitArr[i + counter + 1] = by[i];
                bitArr[i + counter + 2] = bx[i];
                counter = counter + 2;
            }

            //convert to a complete string then integer
            string resStr = new string(bitArr);
            int ret = Convert.ToInt32(resStr, 2);

            zval = ret;
        }


    }
}