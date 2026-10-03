using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball
{
    public static class GameManager
    {
        public static void DetectAndCareCollision(PongBall ball, Paddle paddle)
        {
            int radius = ball.GetRadius();
            int[] BallPos = ball.GetPos();

            int diameter = (int)(radius * 2);
            int left = (int)(BallPos[0] - radius);
            int top = (int)(BallPos[1] - radius);

            Rectangle ballBounds = new Rectangle(left, top, diameter, diameter);

            int[] PaddlePos = paddle.GetPosition();
            ushort[] PaddleSize = paddle.GetSize();

            Rectangle paddleBounds = new Rectangle(PaddlePos[0], PaddlePos[1], PaddleSize[0], PaddleSize[1]);


            if (ballBounds.IntersectsWith(paddleBounds))
            {
                Sfx.PlayHit();
                Rectangle intersection = Rectangle.Intersect(ballBounds, paddleBounds);
                float[] velocity = ball.GetVelocity();

                if (intersection.Width < intersection.Height)
                {
                    velocity[0] *= -1;

                    if (BallPos[0] < PaddlePos[0])
                        BallPos[0] = PaddlePos[0] - radius;
                    else
                        BallPos[0] = PaddlePos[0] + PaddleSize[0] + radius;
                }
                else
                {
                    velocity[1] *= -1;

                    if (BallPos[1] < PaddlePos[1])
                        BallPos[1] = PaddlePos[1] - radius;
                    else
                        BallPos[1] = PaddlePos[1] + PaddleSize[1] + radius;
                }

                ball.SetPosition(BallPos);
                ball.SetVelocity(velocity);
            }
        }
        public static bool DetectAndCareScore(PongBall ball, int x, int y, int width, int height)
        {
            int radius = ball.GetRadius();
            int[] ballPos = ball.GetPos();

            int diameter = (int)(radius * 2);
            int left = (int)(ballPos[0] - radius);
            int top = (int)(ballPos[1] - radius);

            Rectangle ballBounds = new Rectangle(left, top, diameter, diameter);
            Rectangle paddleBounds = new Rectangle(x, y, width, height);

            return ballBounds.IntersectsWith(paddleBounds);
        }
    }
}