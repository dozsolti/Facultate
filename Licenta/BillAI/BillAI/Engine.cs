using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace BillAI
{
    public static class Engine
    {
        public static ListBox console;

        public static List<Hole> holes;

        public static Random rnd = new Random();

        public static void Init(ListBox _console)
        {
            console = _console;
            InitHoles();
            TurnManager.Start();
        }
        private static void InitHoles()
        {
            holes = new List<Hole>();
            holes.Add(new Hole(7, 5));
            holes.Add(new Hole(Ross.Width / 2f, 5));
            holes.Add(new Hole(Ross.Width - 7, 5));

            holes.Add(new Hole(7, Ross.Height - 5));
            holes.Add(new Hole(Ross.Width / 2f, Ross.Height - 5));
            holes.Add(new Hole(Ross.Width - 7, Ross.Height - 5));
        }


        public static void Update()
        {
            TurnManager.Update();

            //Drawing the balls
            Ross.BeginDraw();
            TurnManager.Draw();
            foreach (Hole hole in holes)
                hole.Draw();
            Ross.EndDraw();

        }

        public static void CW(object v)
        {
            console.Items.Add(v.ToString());
        }
        public static void ClearConsole()
        {
            console.Items.Clear();
        }
    }

}
