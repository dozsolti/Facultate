﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillAI
{
    public partial class Ball
    {
        public Vector2 position;
        public Vector2 direction;
        public Vector2 force;

        public Color color;
        public bool isMoving;

        public Ball(float x, float y, Color color)
        {
            position = new Vector2(x, y);
            direction = new Vector2(0, 0);
            force = new Vector2(0, 0);

            isMoving = false;
            this.color = color;
        }
        public void SetForce(Vector2 v)
        {

            isMoving = true;

            //Speed becomes direction which is only a unit vector( poate fii -1,0,1 pe x si y)
            direction = v.ToUnit();
            //Force will Speed * v.Abs() 
            force = v.Abs();
            // public Vector2 GetDirection() { return new Vector2 (Math.Abs(this.x),Math.Abs(this.y)) }
        }
        public void RemoveForce()
        {
            direction = new Vector2(0, 0);
            force = new Vector2(0, 0);
            isMoving = false;

        }
        public void SetForce(float angle, float force)
        {
            Vector2 v = Vector2.FromAngle(angle) * force;
            this.SetForce(v);
            //isMoving = true;
        }
        
        public void Move()
        {
            if (direction.isZero() || force.isZero())
            {
                isMoving = false;
                return;
            }
            isMoving = true;
            position += direction * force;


            // Bounceing from wall
            if (position.x - Prefs.ballSize / 2 <= 0 || position.x + Prefs.ballSize / 2 >= Ross.Width)
            {
                this.force.x -= Prefs.friction * 2;
                direction.x *= -1;
            }

            if (position.y - Prefs.ballSize / 2 <= 0 || position.y + Prefs.ballSize / 2 >= Ross.Height)
            {
                this.force.y -= Prefs.friction * 2;
                direction.y *= -1;
            }

            // Appling friction
            if (this.force.x > 0.005f)
                this.force.x -= Prefs.friction;
            else
                this.force.x = 0;

            if (this.force.y > 0.005f)
                this.force.y -= Prefs.friction;
            else
                this.force.y = 0;
        }

        public void Draw()
        {
            /*if(isMoving)
                color = Color.Red;
            else
                color = Color.Gray;*/
            if (isInHole == false)
                Ross.Draw(this);
        }
    }
}
