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
        public void generateColors(int width)
        {
            myColors.Clear();
            Color randomColor = Color.White;
            //where pixelwidth sets how thick each color should be
            int pixelwidth = 3;
            for (int i = 0; i < (width/pixelwidth); i++)
            {
                //Add the random colors to the stored color list
                randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                myColors.Add(randomColor);
            }
        }

        //sorts the color list the naive way
        public void naiveRGB()
        {

            List<Color> newList = myColors;
            myColors = QuickSort(newList, 0, newList.Count - 1, "B");

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
            List<Color> newList = myColors;
            myColors = QuickSort(newList, 0, newList.Count - 1, "G");

        }

        public void naiveBGR()
        {
            List<Color> newList = myColors;
            myColors = QuickSort(newList, 0, newList.Count - 1, "R");

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

        public void Luminosity()
        {

            for (int i = 0; i < myColors.Count() - 1; i++)
            {
                for (int j = 0; j < myColors.Count() - i - 1; j++)
                {

                    double lum1 = Math.Sqrt(.241 * myColors[j].R + .691 * myColors[j].G + .068 * myColors[j].B);
                    double lum2 = Math.Sqrt(.241 * myColors[j+1].R + .691 * myColors[j+1].G + .068 * myColors[j+1].B);

                    if (lum1 > lum2)
                    {
                        Color temp = myColors[j];
                        myColors[j] = myColors[j + 1];
                        myColors[j + 1] = temp;
                    }

                }

            }

        }

        public void RGBSort()
        {
            List<Color> newList = myColors;
            myColors = QuickSort(newList, 0, newList.Count-1, "R");
        }

        public Tuple<double, double, double> ToYUV(double R, double G, double B)
        {
            double Y = (0.299 * R) + (0.587 * G) + (0.114 * B);
            double U = (-0.147 * R) + (-0.289 * G) + (0.436 * B);
            double V = (0.615 * R) + (-0.515 * G) + (-0.100 * B);
            return Tuple.Create(Y, U, V);
        }

        public List<Color> QuickSort(List<Color> listColor, int low, int high, string value)
        {
            if (low < high)
            {
                int index = Partition(listColor, low, high, value);

                QuickSort(listColor, low, index - 1, value);
                QuickSort(listColor, index + 1, high, value);
            }
            return listColor;
        }

        public int Partition(List<Color> listColor, int low, int high, string value)
        {
            //pivot element
            Color pivot = listColor[(low + high) / 2];

            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                // If current element is smaller than or
                // equal to pivot
                if (value == "R")
                {
                    if (listColor[j].R <= pivot.R)
                    {
                        i++;    // increment index of smaller element
                                //swap arr[i] and arr[j]
                        Color temp = listColor[i];
                        listColor[i] = listColor[j];
                        listColor[j] = temp;
                    }
                }else if (value == "G")
                {
                    if (listColor[j].G <= pivot.G)
                    {
                        i++;    // increment index of smaller element
                                //swap arr[i] and arr[j]
                        Color temp = listColor[i];
                        listColor[i] = listColor[j];
                        listColor[j] = temp;
                    }
                }else if (value == "B")
                {
                    if (listColor[j].B <= pivot.B)
                    {
                        i++;    // increment index of smaller element
                                //swap arr[i] and arr[j]
                        Color temp = listColor[i];
                        listColor[i] = listColor[j];
                        listColor[j] = temp;
                    }
                }
               
            }
            //swap arr[i + 1] and arr[high])
            Color temp2 = listColor[i + 1];
            listColor[i + 1] = listColor[high];
            listColor[high] = temp2;
            return i + 1;
        }
    }
}
