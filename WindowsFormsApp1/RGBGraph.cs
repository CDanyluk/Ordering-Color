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
        public List<Color> colorlist = new List<Color>();

        public RGBGraph(List<Color> myColors)
        {
            this.colorlist = myColors;
        }

        public void NearestNeighbor()
        {
            //Create a list of all the points based off of the colors in colorlist
            List<Point> pointlist = CreatePointList();

            //Find the next closest point to the first point in the pointlist
            Point curpoint = pointlist[0];

            //chosenlist is a list of points that already have found the closest neighbor
            //it is a list of the points in order of closest to furthest
            List<Point> chosenlist = new List<Point>();
            chosenlist.Add(curpoint);

            //Keep track of the amount of distance
            double totalDistance = 0;

            while ((chosenlist.Count) != (pointlist.Count))
            {
                Point closest = closestPoint(pointlist, chosenlist, pointlist[0]);
                chosenlist.Add(closest);
                totalDistance += closest.distance;
                curpoint = closest;
            }


            //print the list to check
            //print the new sorted list to check
            //foreach (Point e in chosenlist)
            //{
            //    Console.WriteLine(e.distance);
            //}

            //Turn the list of points back into a list of colors
            CreateColorList(chosenlist);


        }

        public List<Point> CreatePointList()
        {
            List<Point> pointlist = new List<Point>();
            for (int i = 0; i < colorlist.Count; i++)
            {
                double x = colorlist[i].R;
                double y = colorlist[i].G;
                double z = colorlist[i].B;
                //Console.WriteLine(x + "," + y + "," + z);
                Point tempPoint = new Point(x, y, z, Double.MaxValue);
                pointlist.Add(tempPoint);
            }
            return pointlist;
        }

        public void CreateColorList(List<Point> pointlist)
        {
            List<Color> tempcolorlist = new List<Color>();
            for (int i = 0; i < pointlist.Count; i++)
            {
                double R = pointlist[i].x;
                double G = pointlist[i].y;
                double B = pointlist[i].z;
                Color tempcolor = Color.FromArgb(255, (byte)(R * 255.0), (byte)(G * 255.0), (byte)(B * 255.0));
                Console.WriteLine("tempcolor = " + tempcolor.R + "," + tempcolor.G + "," + tempcolor.B);
                tempcolorlist.Add(tempcolor);
            }
            foreach (Color c in tempcolorlist)
            {
                Console.WriteLine(c.R + "," + c.G + "," + c.B);
            }
            colorlist = tempcolorlist;

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

        //Nearest Neighbor the closest point finder
        public Point closestPoint(List<Point> pointlist, List<Point> chosen, Point p)
        {
            int n = pointlist.Count;
            double totalDistance = 0;

            //Find the distance of all points from p
            for (int i = 0; i < n; i++)
            {
                pointlist[i].distance = GetDistance(pointlist[i], p);
            }

            //Sort the points by distance from p
            List<Point> SortedList = pointlist.OrderBy(d=>d.distance).ToList();

            //return the closest point
            //provided it is not already in the chosen list
            foreach (Point e in SortedList)
            {
                if (chosen.Contains(e) == false)
                {
                    return e;
                }
            }
            return SortedList[0];

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

