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
            float topWall, float bottomWall,
            float ballHeight)
        {
            if (ballSpeedX <= 0) return (topWall + bottomWall) / 2f;

            float effectiveBottom = bottomWall - ballHeight;
            float fieldHeight = effectiveBottom - topWall;

            float distanceX = botX - ballX;

            float straightY = ballY + ((ballSpeedY / ballSpeedX) * distanceX) - topWall;

            float totalHeight = fieldHeight * 2f;
            float remainder = straightY % totalHeight;

            if (remainder < 0) remainder += totalHeight;

            if (remainder > fieldHeight)
            {
                return effectiveBottom - (remainder - fieldHeight);
            }
            else
            {
                return topWall + remainder;
            }
        }
        public static float PredictBallLandingYLeft(
            float ballX, float ballY,
            float ballSpeedX, float ballSpeedY,
            float botX,
            float topWall, float bottomWall,
            float ballHeight)
        {
            if (ballSpeedX == 0f) return (topWall + bottomWall) / 2f;

            float distanceX = botX - ballX;
            float time = distanceX / ballSpeedX;

            if (time < 0) return (topWall + bottomWall) / 2f;

            float effectiveBottom = bottomWall - ballHeight;
            float fieldHeight = effectiveBottom - topWall;

            float straightY = ballY + (ballSpeedY * time) - topWall;

            float totalHeight = fieldHeight * 2f;
            float remainder = straightY % totalHeight;

            if (remainder < 0) remainder += totalHeight;

            if (remainder > fieldHeight)
            {
                return effectiveBottom - (remainder - fieldHeight);
            }
            else
            {
                return topWall + remainder;
            }
        }
    }
}