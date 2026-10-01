using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball
{
    public static class GameType
    {
        public const string PongOneVsOne = "1v1 Pong";
        public const string PongVsAI = "Pong vs AI";
        public const string PongSinglePlayer = "Single Player Pong";
        public const string PongTwo = "Two Players together";

        public const string PongBigVsSmall = "Big vs. Small Pong";
        public const string PongFastVsSlow = "Fast vs. Slow";
        public const string PongVsGreatAI = "Pong vs. the greatest AI ever";

        public const string BallPong = "Just Ball";
        public const string SinglePlayerWithX = "Single Player With X movement";


        public static string curr = PongOneVsOne;

        public static void SetGameType(string gameType)
        {
            curr = gameType;
        }
    }
}
