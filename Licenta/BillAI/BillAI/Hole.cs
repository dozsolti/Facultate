using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillAI
{
    public class Hole
    {
        public Vector2 position;

        public Hole(float x, float y)
        {
            this.position = new Vector2(x, y);
        }

        public void Draw()
        {
            Ross.Draw(this);
        }
    }
}
