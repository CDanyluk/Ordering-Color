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
        public void generateColors()
        {
            myColors.Clear();
            Color randomColor = Color.White;
            for (int i = 0; i < 35; i++)
            {
                //Add the random colors to the stored color list
                randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                myColors.Add(randomColor);
            }
        }

        //sorts the color list the naive way
        public void naiveSort()
        {

        }
    }
}
