using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillAI
{
    public static class Ross
    {

        public static float Width { get { return canvas.Width; } }
        public static float Height { get { return canvas.Height; } }

        static Graphics grp;
        static Bitmap bmp;
        static PictureBox canvas;

        public static void Init(PictureBox pictureBox)
        {
            canvas = pictureBox;
            bmp = new Bitmap(canvas.Width, canvas.Height);
            grp = Graphics.FromImage(bmp);
            Clear();
        }
        public static void Draw(Hole hole)
        {
            grp.FillEllipse(Brushes.Black, hole.position.x - Prefs.ballSize / 2, hole.position.y - Prefs.ballSize / 2, Prefs.ballSize, Prefs.ballSize);
        }
        public static void Draw(Ball ball)
        {
            grp.FillEllipse(new SolidBrush(ball.color), ball.position.x - Prefs.ballSize / 2, ball.position.y - Prefs.ballSize / 2, Prefs.ballSize, Prefs.ballSize);
            //grp.DrawString("Speed: " + ball.Speed.ToString(), new Font("Arial", 10f),Brushes.Black, ball.position.x, ball.position.y-20);
            //grp.DrawString("Force: "+ball.force.ToString(), new Font("Arial", 10f),Brushes.Black, ball.position.x, ball.position.y);
        }
        public static void Clear()
        {
            BeginDraw();
            EndDraw();
        }

        public static void BeginDraw()
        {
            grp.Clear(Prefs.tableColor);
        }
        public static void EndDraw()
        {
            canvas.Image = bmp;
        }
    }
}
