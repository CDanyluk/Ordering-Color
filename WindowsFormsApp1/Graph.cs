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

        public void ShortestPath(String colortype)
        {
            //Create a list of all the points based off of the colors in colorlist
            List<Point> pointlist = new List<Point>();
            if (colortype == "RGB")
            {
                pointlist = CreatePointListRGB();
            }
            else if (colortype == "HSB")
            {
                pointlist = CreatePointListHSB();
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

        ////test function
        //public bool ChangedPoint(Color c)
        //{
        //    //convert color to point
        //    double x = c.R;
        //    double y = c.G;
        //    double z = c.B;
        //    string color = x + "," + y + "," + z;
        //    Console.WriteLine("RGB: " + color);
        //    Point p = new Point(x, y, z, Double.MaxValue);
        //    //convert point to color
        //    double R = p.x;
        //    double G = p.y;
        //    double B = p.z;
        //    string point = R + "," + G + "," + B;
        //    Color tempcolor = Color.FromArgb(255, (byte)(R * 255.0), (byte)(G * 255.0), (byte)(B * 255.0));
        //    Console.WriteLine("point = " + point);
        //    return c == tempcolor;

        //}

        ////test function
        //public bool ChangedColorList(List<Color> colorlist1, List<Color> colorlist2)
        //{
        //    for (int i = 0; i < colorlist1.Count; i++)
        //    {
        //        if (colorlist2.Contains(colorlist1[i]) == false)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        ////test function
        //public bool ChangedPointList(List<Point> pointlist1, List<Point> pointlist2)
        //{
        //    for (int i = 0; i < pointlist1.Count; i++)
        //    {
        //        //set temp to be false
        //        bool temp = false;
        //        for (int j = 0; j < pointlist2.Count; j++)
        //        {
        //            double x1 = pointlist1[i].x;
        //            double y1 = pointlist1[i].y;
        //            double z1 = pointlist1[i].z;

        //            double x2 = pointlist2[j].x;
        //            double y2 = pointlist2[j].y;
        //            double z2 = pointlist2[j].z;

        //            //only if it finds the points are equal will it let temp be true
        //            if ((x1 == x2) && (y1 == y2) && (z1 == z2))
        //            {
        //                temp = true;
        //            }
        //        }
        //        //if it doesn't find a match at the end of the for loop
        //        //then return false
        //        if (temp == false)
        //        {
        //            return false;
        //        }

        //    }
        //    //otherwise absolutely return true
        //    return true;
        //}

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

        public List<Point> CreatePointListRGB()
        {
            List<Point> pointlist = new List<Point>();
            for (int i = 0; i < colorlist.Count; i++)
            {
                double x = colorlist[i].R;
                double y = colorlist[i].G;
                double z = colorlist[i].B;
                //Console.WriteLine(x + "," + y + "," + z);
                Point tempPoint = new Point(x, y, z, Double.MaxValue, colorlist[i]);
                pointlist.Add(tempPoint);
            }
            return pointlist;
        }

        public List<Point> CreatePointListHSB()
        {
            List<Point> pointlist = new List<Point>();
            for (int i = 0; i < colorlist.Count; i++)
            {
                double x = colorlist[i].GetHue();
                double y = colorlist[i].GetSaturation();
                double z = colorlist[i].GetBrightness();
                //Console.WriteLine(x + "," + y + "," + z);
                Point tempPoint = new Point(x, y, z, Double.MaxValue, colorlist[i]);
                pointlist.Add(tempPoint);
            }
            return pointlist;
        }

        //public List<Color> CreateColorListRGB(List<Point> pointlist)
        //{
        //    List<Color> tempcolorlist = new List<Color>();
        //    for (int i = 0; i < pointlist.Count; i++)
        //    {
        //        double R = pointlist[i].x;
        //        double G = pointlist[i].y;
        //        double B = pointlist[i].z;
        //        Color tempcolor = Color.FromArgb(255, Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B));
        //        tempcolorlist.Add(tempcolor);
        //    }

        //    return tempcolorlist;

        //}

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

        //public List<Color> CreateColorListHSB(List<Point> pointlist)
        //{
        //    List<Color> tempcolorlist = new List<Color>();
        //    for (int i = 0; i < pointlist.Count; i++)
        //    {
        //        double Hue = pointlist[i].x;
        //        double Saturation = pointlist[i].y;
        //        double Brightness = pointlist[i].z;
        //        Color tempcolor = HSBtoRGB(Hue, Saturation, Brightness);
        //        tempcolorlist.Add(tempcolor);
        //    }

        //    return tempcolorlist;

        //}

        ////code copied from:
        ////https://stackoverflow.com/questions/4106363/converting-rgb-to-hsb-colors
        //public static Color HSBtoRGB(double hue, double saturation, double brightness)
        //{
        //    int r = 0, g = 0, b = 0;
        //    if (saturation == 0)
        //    {
        //        r = g = b = (int)(brightness * 255.0f + 0.5f);
        //    }
        //    else
        //    {
        //        double h = (hue - Math.Floor(hue)) * 6.0f;
        //        double f = h - Math.Floor(h);
        //        double p = brightness * (1.0f - saturation);
        //        double q = brightness * (1.0f - saturation * f);
        //        double t = brightness * (1.0f - (saturation * (1.0f - f)));
        //        switch ((int)h)
        //        {
        //            case 0:
        //                r = (int)(brightness * 255.0f + 0.5f);
        //                g = (int)(t * 255.0f + 0.5f);
        //                b = (int)(p * 255.0f + 0.5f);
        //                break;
        //            case 1:
        //                r = (int)(q * 255.0f + 0.5f);
        //                g = (int)(brightness * 255.0f + 0.5f);
        //                b = (int)(p * 255.0f + 0.5f);
        //                break;
        //            case 2:
        //                r = (int)(p * 255.0f + 0.5f);
        //                g = (int)(brightness * 255.0f + 0.5f);
        //                b = (int)(t * 255.0f + 0.5f);
        //                break;
        //            case 3:
        //                r = (int)(p * 255.0f + 0.5f);
        //                g = (int)(q * 255.0f + 0.5f);
        //                b = (int)(brightness * 255.0f + 0.5f);
        //                break;
        //            case 4:
        //                r = (int)(t * 255.0f + 0.5f);
        //                g = (int)(p * 255.0f + 0.5f);
        //                b = (int)(brightness * 255.0f + 0.5f);
        //                break;
        //            case 5:
        //                r = (int)(brightness * 255.0f + 0.5f);
        //                g = (int)(p * 255.0f + 0.5f);
        //                b = (int)(q * 255.0f + 0.5f);
        //                break;
        //        }
        //    }
        //    return Color.FromArgb(Convert.ToByte(255), Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b));
        //}

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

