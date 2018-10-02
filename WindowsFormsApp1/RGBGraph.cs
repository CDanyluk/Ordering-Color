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
        private List<Color> colorlist = new List<Color>();

        public RGBGraph(List<Color> myColors)
        {
            this.colorlist = myColors;
            //go through the colorlist
            //for (int i = 0; i < colorlist.Count; i++)
            //{
            //}
        }

        public void CreatePointList()
        {
            List<Point> pointlist = new List<Point>();
            for (int i = 0; i < colorlist.Count; i++)
            {
                double x = colorlist[i].R;
                double y = colorlist[i].G;
                double z = colorlist[i].B;
                Console.WriteLine(x + "," + y + "," + z);
                Point tempPoint = new Point(x, y, z, Double.MaxValue);
                pointlist.Add(tempPoint);
            }
            Console.WriteLine("pointlist --------");
            for (int j = 0; j < pointlist.Count; j++)
            {
                Console.WriteLine(j);
                Console.WriteLine(pointlist[j]);
            }

            classifyAPoint(pointlist, pointlist.Count, 3, pointlist[0]);
        }

        //sort array of points by increasing order of distance
        public bool Comparison(Point a, Point b)
        {
            return (a.distance < b.distance);
        }

        public double GetDistance(Point first, Point second)
        {
            //First point values
            double x1 = first.x;
            double y1 = first.y;
            double z1 = first.z;
            //second point values
            double x2 = second.x;
            double y2 = second.y;
            double z2 = second.z;
            //Calculate the distances between the three points
            double point1 = Math.Abs(x2 - x1);
            point1 *= point1;
            double point2 = Math.Abs(y2 - y1);
            point2 *= point2;
            double point3 = Math.Abs(z2 - z1);
            point3 *= point3;
            //return the total distance
            return Math.Sqrt((point1 + point2 + point3));

        }

        //the function that does it
        //finds classification of point p?
        //groups and returns 0 if p belongs to group 0 else return 1 (belongs to group 1)
        public int classifyAPoint(List<Point> pointlist, int n, int k, Point p)
        {
            //Fill the distance of all points from p
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("pointlist[i]" + pointlist[i]);
                pointlist[i].distance = GetDistance(pointlist[i], p);
            }

            //Sort the points by distance from p
            //Pesudocode from C++
            //sort(arr, arr+n, comparison);
            List<Point> SortedList = pointlist.OrderBy(d=>d.distance).ToList();
            //print the new sorted list to check
            foreach (Point e in SortedList)
            {
                Console.WriteLine(e.distance);
            }

            return 0;

            }

        }

        //public void Swap(int first, int second)
        //{
        //    Point temp = points[first];
        //    points[first] = points[second];
        //    points[second] = temp;
        //}

        

        //First point values
        //double x1 = c1.R;
        //double y1 = c1.G;
        //double z1 = c1.B;
        //second point values
        //double x2 = c2.R;
        //double y2 = c2.G;
        //double z2 = c2.B;

    }

