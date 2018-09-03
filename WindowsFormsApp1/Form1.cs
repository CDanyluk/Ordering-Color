using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderColors;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private int height;
        private int width;
        private int upx;
        private int upy;
        Bitmap DrawArea;
        //private List<Color> myColors = new List<Color>();
        private ColorOrganizer co = new ColorOrganizer();

        public Form1()
        {
            InitializeComponent();

            DrawArea = new Bitmap(colorCanvas.Size.Width, colorCanvas.Size.Height);
            colorCanvas.Image = DrawArea;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SelRGB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SelNaive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ColorForm_Load(object sender, EventArgs e)
        {

        }

        private void colorCanvas_Click(object sender, EventArgs e)
        {
            //Clear prior stored bitmap
            colorCanvas.Image = null;
            //Initialize the graphics
            Graphics g;
            g = Graphics.FromImage(DrawArea);

            //Go through and create random colors to draw as rectangles on the bitmap using graphics g
            upx = 0;
            height = colorCanvas.Height;
            width = colorCanvas.Width;
            //call colororganizer to generate a new list of colors
            co.generateColors();
            List<Color> myColors = co.getColors();
            for (upy = 0; upy < (height - 10); upy += 10)
            {
                SolidBrush sb = new SolidBrush(myColors[(upy/10)]);
                g.FillRectangle(sb, upx, upy, width, upy + 10);
            }
            //Set the area drawn on to be used by the picturebox
            colorCanvas.Image = DrawArea;
            //Clean up
            g.Dispose();
            //Print colors included in color list now
            Console.WriteLine("--------");
            foreach (Color c in myColors)
            {
                Console.WriteLine("#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2"));
            }
            Console.WriteLine("--------");
        }
    }
}
