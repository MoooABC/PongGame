using SkiaSharp.Views.Desktop;
using System;

namespace Ball
{
    static class Womp
    {
        public const int HiddenY = -75;

        private static bool falling = false;
        private static float targetY = 0f;
        private static float fallSpeed = 0f;

        public static void UpdateWompWomp(Paddle paddle3, Ball ball, int wompWarningFrames, SKControl skControl)
        {
            int[] p3pos = paddle3.GetPosition();

            float ballX = ball.GetPos()[0];
            float ballVX = ball.GetVelocity()[0];
            int paddle3X = p3pos[0];

            bool movingTowardPaddle3 =
                (ballVX > 0 && ballX < paddle3X) || (ballVX < 0 && ballX > paddle3X);

            if (!falling)
            {
                if (movingTowardPaddle3 && ballVX != 0)
                {
                    float framesToArrival = Math.Abs(paddle3X - ballX) / Math.Abs(ballVX);

                    if (framesToArrival <= wompWarningFrames && framesToArrival > 0)
                    {
                        StartWompWompFall(framesToArrival, paddle3, ball, skControl);
                    }
                }
                else if (p3pos[1] != HiddenY)
                {
                    paddle3.SetPosition(new int[] { paddle3X, HiddenY });
                }
            }
            else
            {
                int newY = (int)Math.Round(p3pos[1] + fallSpeed);

                bool reachedTarget = newY + paddle3.GetSize()[1] >= skControl.Size.Height;

                if (reachedTarget)
                {
                    newY = (int)targetY;
                    falling = false;
                }

                paddle3.SetPosition(new int[] { p3pos[0], newY });
            }
        }

        private static void StartWompWompFall(float framesToArrival, Paddle paddle3, Ball ball, SKControl skControl)
        {
            float radius = ball.GetRadius();
            float ballTopLeftX = ball.GetPos()[0] - radius;
            float ballTopLeftY = ball.GetPos()[1] - radius;

            float predictedY = AI.PredictBallLandingYLeft(
                ballTopLeftX, ballTopLeftY,
                ball.GetVelocity()[0], ball.GetVelocity()[1],
                paddle3.GetPosition()[0],
                0, skControl.Height,
                radius * 2f
            );

            int halfPaddleHeight = paddle3.GetSize()[1] / 2;
            targetY = predictedY - halfPaddleHeight;

            int paddleHeight = paddle3.GetSize()[1];
            targetY = Math.Max(0, Math.Min(targetY, skControl.Height - paddleHeight));

            int startY = paddle3.GetPosition()[1];
            fallSpeed = (targetY - startY) / framesToArrival;

            falling = true;
        }

        public static void ResetState(Paddle paddle3)
        {
            falling = false;
            targetY = 0f;
            fallSpeed = 0f;
            paddle3.SetPosition(new int[] { paddle3.GetPosition()[0], HiddenY });
        }
    }
}