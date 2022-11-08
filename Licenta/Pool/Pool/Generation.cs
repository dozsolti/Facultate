using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool
{
    public class Generation
    {
        public int shootIndex;
        public List<float> angles;
        public List<float> forces;

        public bool isAlive = true;
        public bool isDone = false;

        public Ball whiteBall = null;
        public List<Ball> otherBalls;
        public List<Ball> allBalls;

        public Generation()
        {
            allBalls = new List<Ball>();
            InitWhiteBall();
            InitOtherBall();

            isAlive = true;
            shootIndex = 0;
            angles = new List<float>();
            forces = new List<float>();

            //Engine.setTimeout(() => { Dead(); }, 1);

            int numberOfShoots = Engine.rnd.Next(Prefs.minShootsCount, Prefs.maxShootsCount);
            for(int i = 0; i < numberOfShoots; i++)
            {
                angles.Add(Prefs.GetRandomAngle());
                forces.Add(Prefs.GetRandomForce());
            }
            Shoot();
        }
        public Generation(Generation old)
        {
            allBalls = new List<Ball>();
            InitWhiteBall();
            InitOtherBall();

            isAlive = true;
            shootIndex = 0;
            angles = new List<float>();
            forces = new List<float>();

            //Engine.setTimeout(() => { Dead(); }, 1);

            int numberOfShoots = old.angles.Count;
            for (int i = 0; i < numberOfShoots; i++)
            {
                angles.Add(old.angles[i]);
                forces.Add(old.forces[i]);
            }
            Shoot();
        }

        #region Ai
        public void Mutate()
        {
            for (int i = 0; i < angles.Count; i++)
            {
                if(Engine.rnd.Next(100)< Prefs.mutationChance)
                {
                    this.angles[i] = Prefs.GetRandomAngle();
                    this.forces[i] = Prefs.GetRandomForce();
                }
            }
        }

        public float GetFitness()
        {
            if (whiteBall.isInHole)
                return -1;

            int numberBallsInHoles = 0;

            for (int i = 0; i < allBalls.Count; i++)
                if (allBalls[i].isInHole)
                    numberBallsInHoles++;

            return numberBallsInHoles;//(float)Math.Pow(Math.E,numberBallsInHoles);
        }
        #endregion
        public void Shoot()
        {
            if (isAlive==false)
                return;

            if (shootIndex >= angles.Count || shootIndex >= forces.Count)
            {
                isAlive = false;
                return;
            }
            isDone = false;
            whiteBall.SetForce(angles[shootIndex], forces[shootIndex]);
            shootIndex++;
        }

        public void Update()
        {
            if (!isAlive)
                return;
            CheckIfIsAllStopped();
            //Updateing the balls
            whiteBall.Update();
            foreach (Ball ball in otherBalls)
                ball.Update();

            //Collisions
            for (int i = 0; i < allBalls.Count; i++)
            {

                for (int j = i + 1; j < allBalls.Count; j++)
                {
                    if (allBalls[i].IsColliding(allBalls[j]))
                        allBalls[i].Oncollide(allBalls[j]);
                }
                foreach (Hole hole in Engine.holes)
                {
                    if (allBalls[i].IsColliding(hole))
                        if (allBalls[i] == whiteBall)
                        {
                            whiteBall.isInHole = true;
                            Dead();
                            allBalls[i].RemoveForce();
                        }
                        else
                            allBalls[i].Oncollide(hole);

                }

            }
            
        }

        private void Dead()
        {
            isDone = true;
            isAlive = false;
            for (int i = 0; i < allBalls.Count; i++)
                allBalls[i].RemoveForce();
        }

        private void CheckIfIsAllStopped()
        {
            for (int i = 0; i < allBalls.Count; i++)
                if (allBalls[i].isMoving)
                    return;
            isDone = true;
        }

       
        public void Draw()
        {
            //Drawing the balls
            foreach (Ball ball in otherBalls)
                ball.Draw();
            whiteBall.Draw();
        }

        #region Initializare
        private void InitWhiteBall()
        {
            whiteBall = new Ball(Ross.Width / 3f, Ross.Height / 2f, Color.White);
            allBalls.Add(whiteBall);

        }
        private void CreateOtherBall(Vector2 position, Color color)
        {
            Ball ball = new Ball(position.x, position.y, color);
            otherBalls.Add(ball);
            allBalls.Add(ball);
        }
        private void InitOtherBall()
        {
            float xSpace = 1f, ySpace = 1f;
            otherBalls = new List<Ball>();
            Vector2[] positions =
            {
                //Col 1
                new Vector2(Ross.Width/4f*3f-2*Prefs.ballSize,Ross.Height/2),

                //Col 2
                new Vector2(Ross.Width/4f*3f-Prefs.ballSize+xSpace,Ross.Height/2-Prefs.ballSize/2-ySpace),
                new Vector2(Ross.Width/4f*3f-Prefs.ballSize+xSpace,Ross.Height/2+Prefs.ballSize/2+ySpace),

                //Col 3
                new Vector2(Ross.Width/4f*3f+xSpace*2,Ross.Height/2-Prefs.ballSize-ySpace*2),
                new Vector2(Ross.Width/4f*3f+xSpace*2,Ross.Height/2),
                new Vector2(Ross.Width/4f*3f+xSpace*2,Ross.Height/2+Prefs.ballSize+ySpace*2)

            };
            Color[] colors = {
                Color.Yellow,
                Color.Red, Color.Blue,
                Color.Orange, Color.Purple, Color.Coral
            };

            for (int i = 0; i < positions.Length; i++)
                CreateOtherBall(positions[i], colors[i]);

        }
        #endregion
    }
}
