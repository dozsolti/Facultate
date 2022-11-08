using System.Drawing;

namespace Pool
{
    public partial class Ball
    {
        public bool isInHole = false;

        public bool IsColliding(Ball other)
        {
            if (isInHole || other.isInHole)
                return false;

            if(other.position == this.position)
                return false;

            //caci uneori bilele se lipesc una de alta si atunci sa nu se i-a in considerare
            if (this.isMoving == false && other.isMoving == false)
                return false;

            return ((other.position.x - this.position.x) * (other.position.x - this.position.x) +
                (other.position.y - this.position.y) * (other.position.y - this.position.y))
                <= Prefs.ballSize * Prefs.ballSize+20;
        }
        public void Oncollide(Ball other)
        {
            Vector2 collision = this.position - other.position;
            float distance = collision.GetLength();
            if (distance == 0.0)
            {
                // hack to avoid div by zero
                collision = new Vector2(1, 0);
                distance = 1;
                Engine.CW("Distance was 0");
            }

            // Get the components of the velocity vectors which are parallel to the collision.
            // The perpendicular component remains the same for both fish
            collision = collision / distance;
            float aci = Vector2.Dot(this.Speed*this.force, collision);
            float bci = Vector2.Dot(other.Speed * other.force, collision);

            // Solve for the new velocities using the 1-dimensional elastic collision equations.
            // Turns out it's really simple when the masses are the same.
            float acf = bci;
            float bcf = aci;

            // Replace the collision velocity components with the new ones
            this.SetForce(this.Speed * this.force + collision * (acf - aci));
            other.SetForce(other.Speed * other.force + collision * (bcf - bci));

        }


        public bool IsColliding(Hole other)
        {
            if (isInHole)
                return true;
            if (other.position == this.position)
                return false;
            return ((other.position.x - this.position.x) * (other.position.x - this.position.x) +
                (other.position.y - this.position.y) * (other.position.y - this.position.y))
                <= Prefs.ballSize * Prefs.ballSize/2;
            // E Prefs.ballSize * Prefs.ballSize/2 fiindca o gaura nu este pe afara in totalitate
        }
        public void Oncollide(Hole hole)
        {
            isInHole = true;
            this.RemoveForce();

        }

    }
}
