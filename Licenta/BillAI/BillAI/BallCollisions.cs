using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillAI
{
    public partial class Ball
    {
        public bool isInHole = false;

        public bool IsColliding(Ball other)
        {
            if (isInHole || other.isInHole)
                return false;

            //caci uneori bilele se lipesc una de alta si atunci sa nu se i-a in considerare
            if (this.isMoving == false && other.isMoving == false)
                return false;

            return ((other.position.x - this.position.x) * (other.position.x - this.position.x) +
                (other.position.y - this.position.y) * (other.position.y - this.position.y))
                <= Prefs.ballSize * Prefs.ballSize + 20;
        }
        public void Oncollide(Ball other)
        {
            Vector2 collision = this.position - other.position;
            float distance = collision.GetLength();

            // Get the components of the velocity vectors which are parallel to the collision.
            // The perpendicular component remains the same for both fish
            collision /= distance;
            float aci = Vector2.Dot(this.direction * this.force, collision);
            float bci = Vector2.Dot(other.direction * other.force, collision);


            // Replace the collision velocity components with the new ones
            this.SetForce(this.direction * this.force + collision * (bci - aci));
            other.SetForce(other.direction * other.force + collision * (aci - bci));

        }


        public bool IsColliding(Hole other)
        {
            if (isInHole)
                return true;
            if (other.position == this.position)
                return false;
            return ((other.position.x - this.position.x) * (other.position.x - this.position.x) +
                (other.position.y - this.position.y) * (other.position.y - this.position.y))
                <= Prefs.ballSize * Prefs.ballSize / 2;
            // E Prefs.ballSize * Prefs.ballSize/2 fiindca o gaura nu este pe afara in totalitate
        }
        public void Oncollide(Hole hole)
        {
            isInHole = true;
            this.RemoveForce();
        }

    }
}
