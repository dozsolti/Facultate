using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillAI
{
    public static class Prefs
    {
        #region About game
        public static float ballSize = 30;
        public static Color tableColor = Color.SeaGreen;
        public static float friction = 0.002f;

        public static int timeScale = 1;
        #endregion

        #region About AI
        public static int countInGeneration = 50;
        public static int mutationChance = 30;
        public static int minShootsCount = 5;
        public static int maxShootsCount = 7;
        #endregion

        public static int GetRandomAngle()
        {
            return Engine.rnd.Next(360);
        }
        public static float GetRandomForce()
        {
            return 0.7f + (float)Engine.rnd.NextDouble() * 7f;
        }
    }
}
