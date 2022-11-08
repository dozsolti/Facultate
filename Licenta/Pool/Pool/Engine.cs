using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Pool
{
    /**
     * 
     * {X} NOTA: Engineul (doar partea cu whiteBall, otherBalls/ Ramanand console si holes) trebuie mutat in Generation, fiindca fiecare generatie va avea bilele lui aproapre unice.
     * 
     * {X} Am nevoie de un TurnManager care sa contina toate solutiile curente
     * {X} Care va aplica turnul la fiecare generatie cand bilele s-au oprit
     * {X} si care Genereaza Generatie noua cand ultima tura s-a terminat
     * 
     * {X} sa tina cont de scorul fiecarei generatii
     * {X} o generatie poate sa moara intre timp (cand baga bila alba in gaura)
     * {X} Scorul sa varieze intre:
     *  0 - mort, a bagat bila alba
     *  x - e^nr de bile bagate
     */
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
            holes.Add(new Hole(Ross.Width-7, 5));

            holes.Add(new Hole(7, Ross.Height-5));
            holes.Add(new Hole(Ross.Width / 2f, Ross.Height-5));
            holes.Add(new Hole(Ross.Width-7, Ross.Height-5));
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
        public static void setTimeout(Action TheAction, int Timeout)
        {
            Thread t = new Thread(
                () =>
                {
                    Thread.Sleep(Timeout);
                    TheAction.Invoke();
                }
            );
            t.Start();
        }
    }
}
