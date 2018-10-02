using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderColors
{
    class ColorOrganizer
    {
        private Random rnd = new Random();
        private List<Color> myColors = new List<Color>();

        public ColorOrganizer()
        {
        }

        //returns the current colorlist
        public List<Color> getColors()
        {
            return myColors;
        }

        //generates the random color list needed
        public void generateColors(int height)
        {
            myColors.Clear();
            Color randomColor = Color.White;
            for (int i = 0; i < (height/10); i++)
            {
                //Add the random colors to the stored color list
                randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                myColors.Add(randomColor);
            }
        }

        //sorts the color list the naive way
        public void naiveRGB()
        {
            //Bubblesort naive implementation
            for (int i = 0; i < myColors.Count()-1; i++)
            {
                for (int j = 0; j < myColors.Count()-i-1; j++)
                {
                    if (myColors[j].R > myColors[j + 1].R)
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j+1];
                        myColors[j+1] = temp;
                    }

                    if (myColors[j].G > myColors[j + 1].G)
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                    if (myColors[j].B > myColors[j + 1].B)
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                }
                
            }

        }

        //sorts the color list the naive way
        public void naiveHSB()
        {
            for (int i = 0; i < myColors.Count() - 1; i++)
            {
                for (int j = 0; j < myColors.Count() - i - 1; j++)
                {
                    if (myColors[j].GetHue() > myColors[j + 1].GetHue())
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                    if (myColors[j].GetSaturation() > myColors[j + 1].GetSaturation())
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                    if (myColors[j].GetBrightness() > myColors[j + 1].GetBrightness())
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                }

            }

        }

        public void naiveBSH()
        {
            for (int i = 0; i < myColors.Count() - 1; i++)
            {
                for (int j = 0; j < myColors.Count() - i - 1; j++)
                {
                    if (myColors[j].GetBrightness() > myColors[j + 1].GetBrightness())
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                    if (myColors[j].GetSaturation() > myColors[j + 1].GetSaturation())
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                    if (myColors[j].GetHue() > myColors[j + 1].GetHue())
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                }

            }

        }

        public void naiveHBS()
        {
            for (int i = 0; i < myColors.Count() - 1; i++)
            {
                for (int j = 0; j < myColors.Count() - i - 1; j++)
                {
                    if (myColors[j].GetHue() > myColors[j + 1].GetHue())
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                    if (myColors[j].GetBrightness() > myColors[j + 1].GetBrightness())
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                    if (myColors[j].GetSaturation() > myColors[j + 1].GetSaturation())
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                }

            }

        }

        public void naiveRBG()
        {
            //Bubblesort naive implementation
            for (int i = 0; i < myColors.Count() - 1; i++)
            {
                for (int j = 0; j < myColors.Count() - i - 1; j++)
                {
                    if (myColors[j].R > myColors[j + 1].R)
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                    if (myColors[j].B > myColors[j + 1].B)
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                    if (myColors[j].G > myColors[j + 1].G)
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                }

            }

        }

        public void naiveBGR()
        {
            //Bubblesort naive implementation
            for (int i = 0; i < myColors.Count() - 1; i++)
            {
                for (int j = 0; j < myColors.Count() - i - 1; j++)
                {
                    if (myColors[j].B > myColors[j + 1].B)
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                    if (myColors[j].G > myColors[j + 1].G)
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                    if (myColors[j].R > myColors[j + 1].R)
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                }

            }

        }

        public void naiveYUV()
        {
            //Bubblesort naive implementation
            for (int i = 0; i < myColors.Count() - 1; i++)
            {
                for (int j = 0; j < myColors.Count() - i - 1; j++)
                {

                    //Get YUV value for first color
                    Tuple<double, double, double> YUV1 = ToYUV(myColors[j].R, myColors[j].G, myColors[j].B);
                    //Get YUV value for second color
                    Tuple<double, double, double> YUV2 = ToYUV(myColors[j + 1].R, myColors[j + 1].G, myColors[j + 1].B);


                    if (YUV1.Item1 > YUV2.Item1)
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                    if (YUV1.Item2 > YUV2.Item2)
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                    if (YUV1.Item3 > YUV2.Item3)
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                }

            }

        }

        public void naiveUVY()
        {
            //Bubblesort naive implementation
            for (int i = 0; i < myColors.Count() - 1; i++)
            {
                for (int j = 0; j < myColors.Count() - i - 1; j++)
                {

                    //Get YUV value for first color
                    Tuple<double, double, double> YUV1 = ToYUV(myColors[j].R, myColors[j].G, myColors[j].B);
                    //Get YUV value for second color
                    Tuple<double, double, double> YUV2 = ToYUV(myColors[j + 1].R, myColors[j + 1].G, myColors[j + 1].B);

                    if (YUV1.Item2 > YUV2.Item2)
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                    if (YUV1.Item3 > YUV2.Item3)
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                    if (YUV1.Item1 > YUV2.Item1)
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                }

            }

        }

        public void naiveVYU()
        {
            //Bubblesort naive implementation
            for (int i = 0; i < myColors.Count() - 1; i++)
            {
                for (int j = 0; j < myColors.Count() - i - 1; j++)
                {

                    //Get YUV value for first color
                    Tuple<double, double, double> YUV1 = ToYUV(myColors[j].R, myColors[j].G, myColors[j].B);
                    //Get YUV value for second color
                    Tuple<double, double, double> YUV2 = ToYUV(myColors[j + 1].R, myColors[j + 1].G, myColors[j + 1].B);

                    if (YUV1.Item3 > YUV2.Item3)
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                    if (YUV1.Item1 > YUV2.Item1)
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                    if (YUV1.Item2 > YUV2.Item2)
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                }

            }

        }

        public Tuple<double, double, double> ToYUV(double R, double G, double B)
        {
            double Y = (0.299 * R) + (0.587 * G) + (0.114 * B);
            double U = (-0.147 * R) + (-0.289 * G) + (0.436 * B);
            double V = (0.615 * R) + (-0.515 * G) + (-0.100 * B);
            return Tuple.Create(Y, U, V);
        }

        //public void quickSort(RGBGraph graph, int left, int right)
        //{
        //    //notes
        //    int i = left;
        //    int j = right;

        //    //Get pivot in the middle
        //    Point pivot = graph.Get((left + right) / 2);

        //    while (i <= j)
        //    {
        //        while (graph.Get(i).R < pivot.R)
        //        {
        //            i++;
        //        }

        //        while (graph.Get(i).R > pivot.R)
        //        {
        //            j--;
        //        }

        //        if (i <= j)
        //        {
        //            //Swap
        //            graph.Swap(i, j);

        //            i++;
        //            j--;
        //        }
        //    }

        //    //Recursive call
        //    if (left < j)
        //    {
        //        quickSort(graph, left, j);
        //    }

        //    if (i < right)
        //    {
        //        quickSort(graph, i, right);
        //    }
        //}
    }
}
