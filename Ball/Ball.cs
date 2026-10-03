using OpenTK;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ball
{
    public class PongBall
    {
        private int[] pos;
        private float[] vel;
        private float[] acceleration;
        private ushort timeforAcceleration;
        private ushort timer = 0;
        private int radius;

        private SKPaint paint;

        public PongBall(int _x, int _y, int _radius, SKColor color)
        {                                  
            Random rnd = new Random();

            pos = new int[2];
            vel = new float[2];
            acceleration = new float[2];
            this.pos[0] = _x;
            this.pos[1] = _y;

            float speedX = 5f;
            float speedY = 5f;

            float directionX = rnd.Next(0, 2) == 0 ? 1f : -1f;
            float directionY = rnd.Next(0, 2) == 0 ? 1f : -1f;

            this.vel[0] = speedX * directionX;
            this.vel[1] = speedY * directionY;

            this.acceleration[0] = 1f;
            this.acceleration[1] = 1;
            timeforAcceleration = 500;

            this.radius = _radius;

            this.paint = new SKPaint();
            paint.Style = SKPaintStyle.Fill;
            paint.Color = color;
            paint.IsAntialias = true;

        }

        public void Render(SKCanvas canvas)
        {
            canvas.DrawCircle(pos[0], pos[1], radius, paint);
        }

        public void Update(int screenWidth, int screenHeight)
        {
            timer++;
            if (timer >= timeforAcceleration)
            {
                vel[0] += Math.Sign(vel[0]) * acceleration[0];
                vel[1] += Math.Sign(vel[1]) * acceleration[1];
                timer = 0;
            }


            pos[0] = (int)(pos[0] + vel[0]);
            pos[1] = (int)(pos[1] + vel[1]);

            if (pos[1] - radius < 0)
            {
                pos[1] = radius;
                vel[1] = -vel[1];
            }
            else if (pos[1] + radius > screenHeight)
            {
                pos[1] = screenHeight - radius;
                vel[1] = -vel[1];
            }

            if (pos[0] + radius > screenWidth)
            {
                pos[0] = screenWidth - radius;
                vel[0] = -vel[0];
            }

            else if (pos[0] - radius < 0)
            {
                pos[0] = radius;
                vel[0] = -vel[0];
            }
        }

        public int[] GetPos() => pos;
        public int GetRadius() => radius;
        public float[] GetVelocity() => vel;

        public void AddForce(Vector2d vec)
        {
            vel[0] += (float)vec[0];
            vel[1] += (float)vec[1];
        }

        public void SetVelocity(float[] _vel)
        {
            vel = _vel;
        }

        public void SetPosition(int[] _pos)
        {
            pos = _pos;
        }

        public void FlipX() { vel[0] = -vel[0]; }
        public void FlipY() { vel[1] -= vel[1]; }
    }
}