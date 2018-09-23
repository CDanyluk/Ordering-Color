using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;


namespace OrderColors
{
    class RGBGraph
    {

        private List<RGBPoint> points = new List<RGBPoint>();

        public RGBGraph(List<Color> colorlist)
        {
            //go through the colorlist
            for (int i = 0; i < colorlist.Count; i++)
            {
                //get r
                int r = colorlist[i].R;
                //get g
                int g = colorlist[i].G;
                //get b
                int b = colorlist[i].B;
                //create point
                RGBPoint singlepoint = new RGBPoint(r, g, b);
                //put it in points
                points.Add(singlepoint);

            }
        }

        public RGBPoint Get(int i)
        {
            return points[i];
        }

        public int Size()
        {
            return points.Count();
        }

        public void Swap(int first, int second)
        {
            RGBPoint temp = points[first];
            points[first] = points[second];
            points[second] = temp;
        }


    }
}
