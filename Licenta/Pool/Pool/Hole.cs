using System;

namespace Pool
{
    public class Hole
    {
        public Vector2 position;

        public Hole(float x, float y)
        {
            this.position = new Vector2(x,y);
        }

        public void Draw()
        {
            Ross.Draw(this);
        }
    }
}