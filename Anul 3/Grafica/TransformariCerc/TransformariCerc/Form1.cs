using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformariCerc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Engine.Init(pictureBox1);
            Engine.r = 60;
            Engine.theta = Math.PI / (4 * Engine.n);

            trackBarX.Minimum = 0;
            trackBarX.Maximum = pictureBox1.Width;

            trackBarY.Minimum = 0;
            trackBarY.Maximum = pictureBox1.Height;

            trackBarR.Minimum = 0;
            trackBarR.Maximum = 200;


            trackBarX.Value = pictureBox1.Width / 2;

            trackBarY.Value = pictureBox1.Height / 2;
            trackBarR.Value = trackBarR.Maximum / 2;
            DrawCircle();
        }
        public void DrawCircle()
        {
            Engine.r = trackBarR.Value;
            Engine.theta = Math.PI / (4 * Engine.n);
            Engine.DrawSketch(new Point(trackBarX.Value, pictureBox1.Height - trackBarY.Value));
            Engine.InitValues();

            Engine.DrawCircle();
        }

        private void trackBarX_Scroll(object sender, EventArgs e)
        {
            DrawCircle();
        }

        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            DrawCircle();
        }
    }
}
