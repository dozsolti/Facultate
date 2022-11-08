using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillAI
{
    public class Vector2
    {
        public float x, y;

        public static Vector2 Zero { get { return new Vector2(0, 0); } }
        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public Vector2() : this(0, 0) { }

        public bool isZero() => x == 0 && y == 0;

        public static Vector2 FromAngle(float angle)
        {
            double angleInRadian = (Math.PI / 180d) * -angle;
            return new Vector2((float)Math.Cos(angleInRadian), (float)Math.Sin(angleInRadian));
        }

        public Vector2 Abs() => new Vector2(Math.Abs(this.x), Math.Abs(this.y));

        public Vector2 ToUnit()
        {
            float threshold = 0.005f;
            int newX = 0, newY = 0;
            if (this.x >= -threshold && this.x <= threshold)
                newX = 0;
            if (this.x < -threshold)
                newX = -1;
            if (this.x > threshold)
                newX = 1;

            if (this.y >= -threshold && this.y <= threshold)
                newY = 0;
            if (this.y < -threshold)
                newY = -1;
            if (this.y > threshold)
                newY = 1;

            return new Vector2(newX, newY);
        }

        public override string ToString()
        {
            return String.Format("({0}, {1})", this.x, this.y);
        }

        #region Math
        public static float Dot(Vector2 A, Vector2 B)
        {
            return A.x * B.x + A.y * B.y;
        }
        public float GetLength()
        {
            return (float)Math.Sqrt(this.x * this.x + this.y * this.y);
        }
        public void Normalize()
        {
            this.x /= this.GetLength();
            this.y /= this.GetLength();
        }
        #endregion


        #region Operators
        public override bool Equals(object obj)
        {
            var vector = obj as Vector2;
            return vector != null &&
                   x == vector.x &&
                   y == vector.y;
        }
        public static bool operator !=(Vector2 A, Vector2 B)
        {
            return !(A.x == B.x && A.y == B.y);
        }

        public static bool operator ==(Vector2 A, Vector2 B)
        {
            return A.x == B.x && A.y == B.y;
        }

        public static Vector2 operator +(Vector2 A, Vector2 B)
        {
            return new Vector2(A.x + B.x, A.y + B.y);
        }
        public static Vector2 operator +(Vector2 original, float scale)
        {
            return new Vector2(original.x + scale, original.y + scale);
        }

        public static Vector2 operator -(Vector2 A, Vector2 B)
        {
            return new Vector2(A.x - B.x, A.y - B.y);
        }
        public static Vector2 operator -(Vector2 original, float scale)
        {
            return new Vector2(original.x - scale, original.y - scale);
        }

        public static Vector2 operator *(Vector2 original, float scale)
        {
            return new Vector2(original.x * scale, original.y * scale);
        }
        public static Vector2 operator *(Vector2 A, Vector2 B)
        {
            return new Vector2(A.x * B.x, A.y * B.y);
        }

        public static Vector2 operator /(Vector2 original, float scale)
        {
            return new Vector2(original.x / scale, original.y / scale);
        }
        #endregion
    }
}
