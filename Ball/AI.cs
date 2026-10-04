using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball
{
    public static class AI
    {
        public static float PredictBallLandingYRigth(
            float ballX, float ballY,
            float ballSpeedX, float ballSpeedY,
            float botX,
            float bottomWall,
            float ballHeight)
        {
            float bottom = bottomWall - ballHeight;
            float height = bottom;

            if (ballSpeedX <= 0 || height <= 0)
                return bottom / 2f;

            float time = (botX - ballX) / ballSpeedX;
            float y = ballY + ballSpeedY * time;

            y = Math.Abs(y) % (2 * height);
            if (y > height) y = 2 * height - y;
            return y;
        }
    }
}