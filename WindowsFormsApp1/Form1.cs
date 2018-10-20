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

            width = colorCanvas.Width;
            //call colororganizer to generate a new list of colors
            co.generateColors(width);
            List<Color> myColors = co.getColors();
            ViewColorList(myColors);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SelRGB_CheckedChanged(object sender, EventArgs e)
        {
            SelNaiveFirst.Text = "Naive (RGB)";
            SelNaiveMid.Text = "Naive (BGR)";
            SelNaiveLast.Text = "Naive (RBG)";
            SelNeighbor.Text = "Nearest Neighbor (RGB)";
        }

        //RGB or HSV
        private void SelNaiveFirst_CheckedChanged(object sender, EventArgs e)
        {
            //RGB - HSV - YUV
            if (SelNaiveFirst.Checked == true)
            {
                if (SelRGB.Checked == true)
                {
                    //Call to sort  RGB
                    co.naiveRGB();
                }
                else if (SelHSV.Checked == true)
                {
                    //Call to sort  HSV
                    co.naiveHSB();
                }else if (SelYUV.Checked == true)
                {
                    //call to sort YUV
                    co.naiveYUV();
                }
                List<Color> myColors = co.getColors();
                ViewColorList(myColors);
            }
        }

        private void ColorForm_Load(object sender, EventArgs e)
        {

        }

        private void colorCanvas_Click(object sender, EventArgs e)
        {
            height = colorCanvas.Height;
            //call colororganizer to generate a new list of colors
            co.generateColors(height);
            List<Color> myColors = co.getColors();
            ViewColorList(myColors);
            SelNaiveFirst.Checked = false;
            SelNaiveMid.Checked = false;
            SelNaiveLast.Checked = false;
        }

        private void ViewColorList(List<Color> colorlist)
        {
            //Clear prior stored bitmap
            colorCanvas.Image = null;
            //Initialize the graphics
            Graphics g;
            g = Graphics.FromImage(DrawArea);

            //Go through and create random colors to draw as rectangles on the bitmap using graphics g
            upy = 0;
            height = colorCanvas.Height;
            width = colorCanvas.Width;
            int pixelwidth = 3;
            //Go through canvas and draw colorlist
            for (upx = 0; upx < (width - pixelwidth); upx += pixelwidth)
            {
                SolidBrush sb = new SolidBrush(colorlist[(upx / pixelwidth)]);
                g.FillRectangle(sb, upx, upy, upx + pixelwidth, height);
                //g.FillRectangle(sb, upx, upy, height, upy + pixelwidth);
            }
            //Set the area drawn on to be used by the picturebox
            colorCanvas.Image = DrawArea;
            //Clean up
            g.Dispose();
        }

        private void selHSV_CheckedChanged(object sender, EventArgs e)
        {
            SelNaiveFirst.Text = "Naive (HSV)";
            SelNaiveMid.Text = "Naive (VSH)";
            SelNaiveLast.Text = "Naive (HVS)";
            SelNeighbor.Text = "Nearest Neighbor (HSV)";
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            //Call to sort it 
            co.naiveYUV();
            List<Color> myColors = co.getColors();
            ViewColorList(myColors);
        }

        private void SelNaiveMid_CheckedChanged(object sender, EventArgs e)
        {
            //BGR - BSH - UVY
            if (SelNaiveMid.Checked == true)
            {
                if (SelRGB.Checked == true)
                {
                    //Call to sort BGR
                    co.naiveBGR();
                }
                else if (SelHSV.Checked == true)
                {
                    //Call to srt BSH
                    co.naiveBSH();
                }else if (SelYUV.Checked == true)
                {
                    //call to sort UVY
                    co.naiveUVY();
                }
                List<Color> myColors = co.getColors();
                ViewColorList(myColors);
            }
        }

        private void SelNaiveLast_CheckedChanged(object sender, EventArgs e)
        {
            //RBG - HBS - VYU
            if (SelNaiveLast.Checked == true)
            {
                if (SelRGB.Checked == true)
                {
                    //Call to sort RBG
                    co.naiveRBG();
                }
                else if (SelHSV.Checked == true)
                {
                    //Call to sort HBS
                    co.naiveHBS();
                }else if (SelYUV.Checked == true)
                {
                    //call to sort VYU
                    co.naiveVYU();
                }
                List<Color> myColors = co.getColors();
                ViewColorList(myColors);

            }
        }

        private void SelLum_CheckedChanged(object sender, EventArgs e)
        {
            co.Luminosity();
            List<Color> myColors = co.getColors();
            ViewColorList(myColors);
        }

        private void SelYUV_CheckedChanged(object sender, EventArgs e)
        {
            SelNaiveFirst.Text = "Naive (YUV)";
            SelNaiveMid.Text = "Naive (UVY)";
            SelNaiveLast.Text = "Naive (YVU)";
        }

        private void SelNeighbor_CheckedChanged(object sender, EventArgs e)
        {
            //create a new graph to run nearest neighbor on
            Graph graph = new Graph(co.getColors());

            //depending on hsv or rgb being selected pass the appropraite string
            //so that the nearest neighbor algorithm can run on those values
            if (SelRGB.Checked == true)
            {
                graph.ShortestPath("RGB");
            }
            else if (SelHSV.Checked == true)
            {
                graph.ShortestPath("HSB");
            }
            //Get the sorted colorlist from graph
            List<Color> myColors = graph.colorlist;
            ViewColorList(myColors);
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
