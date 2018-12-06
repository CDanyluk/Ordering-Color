using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;

namespace OrderColors
{
    class Graph
    {
        public List<Color> colorlist = new List<Color>();

        public Graph(List<Color> myColors)
        {
            this.colorlist = myColors;
        }

        //z Order curve implementation
        public void zOrdering(String colortype)
        {
            //Create a list of all the points based off of the colors in colorlist
            List<Point> pointlist = new List<Point>();
            if (colortype == "RGB")
            {
                pointlist = CreatePointListRGB(true);
            }
            else if (colortype == "HSB")
            {
                pointlist = CreatePointListHSB(true);
            }

            //Sort on the zval of pointlist
            pointlist.Sort((first, second) => first.zval.CompareTo(second.zval));

            //Now turn it back into a colorlist
            colorlist = CreateColorList(pointlist);

        }

        //hilbert curve implementation
        public void hOrdering(string colortype, string hilbert)
        {
            //Create a list of all the points based off of the colors in colorlist
            List<Point> pointlist = new List<Point>();
            if (colortype == "RGB")
            {

                for (int i = 0; i < colorlist.Count; i++)
                {
                    double x = colorlist[i].R;
                    double y = colorlist[i].G;
                    double z = colorlist[i].B;
                    //Console.WriteLine(x + "," + y + "," + z);
                    Point tempPoint = new Point(x, y, z, Double.MaxValue, colorlist[i], false, true, hilbert);
                    pointlist.Add(tempPoint);
                    Console.WriteLine("reg poin = " + x + "," + y + "," + z);
                    Console.WriteLine("tempPoint = " + tempPoint.x + "," + tempPoint.y + "," + tempPoint.z);
                }
            }else
            {
                for (int i = 0; i < colorlist.Count; i++)
                {
                    double x = colorlist[i].GetHue();
                    double y = colorlist[i].GetSaturation();
                    double z = colorlist[i].GetBrightness();
                    //Console.WriteLine(x + "," + y + "," + z);
                    Point tempPoint = new Point(x, y, z, Double.MaxValue, colorlist[i], false, true, hilbert);
                    pointlist.Add(tempPoint);
                    Console.WriteLine("reg poin = " + x + "," + y + "," + z);
                    Console.WriteLine("tempPoint = " + tempPoint.x + "," + tempPoint.y + "," + tempPoint.z);
                }
            }

            //Sort on the hilbert value or hval of pointlist
            pointlist.Sort((first, second) => first.hval.CompareTo(second.hval));

            //Now turn it back into a colorlist
            colorlist = CreateColorList(pointlist);
        }



        public void ShortestPath(String colortype)
        {
            //Create a list of all the points based off of the colors in colorlist
            List<Point> pointlist = new List<Point>();
            if (colortype == "RGB")
            {
                pointlist = CreatePointListRGB(false);
            }
            else if (colortype == "HSB")
            {
                pointlist = CreatePointListHSB(false);
            }

            //Create a dictionary to keep track of the colorlists distances
            Dictionary<double, List<Color>> colorDistances = new Dictionary<double, List<Color>>();

            //Go through the pointlist calling nearest neighbor in each point
            for (int i = 0; i < pointlist.Count; i ++)
            {
                //Call nearest neighbor on point
                Tuple<double, List<Color>> returnedDistance = NearestNeighbors(pointlist[i], pointlist, colortype);

                //Keep track of the total distance related to color list
                colorDistances[returnedDistance.Item1] = returnedDistance.Item2;
            }

            //Find the colorlist with the shortest distance
            double minimumKey = colorDistances.Keys.Min();
            colorlist = colorDistances[minimumKey];

        }


        public Tuple<double, List<Color>> NearestNeighbors(Point p, List<Point> pointlist, String colortype)
        {
            //Set the current point to the given point
            Point curpoint = p;

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

            //Turn the list of points back into a list of colors
            List<Color> newColorList = new List<Color>();
            if (colortype == "RGB")
            {
                newColorList = CreateColorList(chosenlist);
            }
            else if (colortype == "HSB")
            {
                newColorList = CreateColorList(chosenlist);
            }

            //Return both the colorlist and it's corresponding total distance
            return Tuple.Create(totalDistance, newColorList);

        }

        public List<Point> CreatePointListRGB(bool zorder)
        {
            List<Point> pointlist = new List<Point>();
            for (int i = 0; i < colorlist.Count; i++)
            {
                double x = colorlist[i].R;
                double y = colorlist[i].G;
                double z = colorlist[i].B;
                //Console.WriteLine(x + "," + y + "," + z);
                Point tempPoint = new Point(x, y, z, Double.MaxValue, colorlist[i], zorder, false, "none");
                pointlist.Add(tempPoint);
            }
            return pointlist;
        }

        public List<Point> CreatePointListHSB(bool zorder)
        {
            List<Point> pointlist = new List<Point>();
            for (int i = 0; i < colorlist.Count; i++)
            {
                double x = colorlist[i].GetHue();
                double y = colorlist[i].GetSaturation();
                double z = colorlist[i].GetBrightness();
                //Console.WriteLine(x + "," + y + "," + z);
                Point tempPoint = new Point(x, y, z, Double.MaxValue, colorlist[i], zorder, false, "none");
                pointlist.Add(tempPoint);
            }
            return pointlist;
        }


        public List<Color> CreateColorList(List<Point> pointlist)
        {
            List<Color> tempcolorlist = new List<Color>();
            for (int i = 0; i < pointlist.Count; i++)
            {
                Color tempcolor = pointlist[i].color;
                tempcolorlist.Add(tempcolor);
            }

            return tempcolorlist;

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
    

    }

