using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParalelZooming
{
    public partial class Form1 : Form
    {
        Color[,] oldColors, newColors;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bmp, pictureBox1.ClientRectangle);

            oldColors = new Color[bmp.Width, bmp.Height];
            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                    oldColors[x, y] = bmp.GetPixel(x, y);

            bmp.Dispose();

            newColors = new Color[2 * pictureBox1.Width - 1, pictureBox1.Height];

            for (int y = 0; y < pictureBox2.Height; y++)
            {
                Task.Factory.StartNew((object line) => ZoomLine((int)line), y);
                //ZoomLine(y);
            }
        }

        private void ShowResults()
        {
            Bitmap bitmap = new Bitmap(pictureBox2.Width, pictureBox2.Height);

            for (int x = 0; x < bitmap.Width; x++)
                for (int y = 0; y < bitmap.Height; y++)
                    bitmap.SetPixel(x, y, newColors[x, y]);

            pictureBox2.Image = bitmap;
        }

        private void ZoomLine(int y)
        {
            int k = 1;
            for (int x = 0; x < pictureBox2.Width; x++)
            {
                if (x % 2 == 0)
                    newColors[x, y] = oldColors[k, y];
                else
                {
                    Color colorLeft = oldColors[k - 1, y];
                    Color colorRight = oldColors[k + 1, y];

                    int a = (colorLeft.A + colorRight.A) / 2;
                    int r = (colorLeft.R + colorRight.R) / 2;
                    int g = (colorLeft.G + colorRight.G) / 2;
                    int b = (colorLeft.B + colorRight.B) / 2;

                    Color color = Color.FromArgb(a, r, g, b);

                    k++;
                    newColors[x, y] = color;
                }
            }
            ShowResults();
        }
    }
}
