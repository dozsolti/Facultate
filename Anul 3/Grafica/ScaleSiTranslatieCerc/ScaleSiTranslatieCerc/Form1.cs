using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScaleSiTranslatieCerc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Engine.Init(pictureBox1);

            Engine.r = 100;
            Engine.k = 0;
            Engine.theta = Math.PI / (4 * Engine.n);

            Engine.InitValues();
            Engine.Calc();
            Engine.Draw();


        }

        public void Scale(float s)
        {
            Engine.r *= s;

            Engine.InitValues();
            Engine.Calc();
            Engine.Draw();

        }

        public void Translate(int[] d)
        {
            int[,] m = { { 1, 0, d[0] }, { 0, 1, d[1] }, { 0, 0, 1 } };
            int[] b = { Engine.center.X, Engine.center.Y, 1 };
            int[] newCenter = new int[3];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    newCenter[i] = 0;
                    for (int k = 0; k < b.Length; k++)
                        newCenter[i] += m[i, k] * b[k];
                }
            }
            Engine.center = new Point(newCenter[0], newCenter[1]);
            Engine.Draw();
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            Translate(new int[] { 50, 0 });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Translate(new int[] { -50, 0 });

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Translate(new int[] { 0, -50 });

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Translate(new int[] { 0, 50 });

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Scale( 1.2f );
            float left = Engine.center.X - Engine.r;
            float right = Engine.center.X + Engine.r;
            float top = Engine.center.Y - Engine.r;
            float bottom= Engine.center.Y + Engine.r;
            if(top<0) Translate(new int []{ 0,(int)-top});
            if(bottom>pictureBox1.Height) Translate(new int []{ 0,pictureBox1.Height-(int)bottom });
            if(left<0) Translate(new int []{ (int)-left,0});
            if(right>pictureBox1.Width) Translate(new int []{ pictureBox1.Width-(int)right,0});


        }

        private void button8_Click(object sender, EventArgs e)
        {
            Scale( 0.5f );

        }
    }
}
