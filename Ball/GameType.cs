using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball
{

    public enum GameType
    {
        PongOneVsOne,
        PongVsAI,
        PongSinglePlayer,
        PongTwo,
        PongBigVsSmall,
        PongFastVsSlow,
        PongVsGreatAI,
        BallPong,
        SinglePlayerWithX,
    }



    public static class GameTypeExtensions
    {
        public static string DisplayName(this GameType type)
        {
            switch (type)
            {
                case GameType.PongOneVsOne: return "1v1 Pong";
                case GameType.PongVsAI: return "Pong vs AI";
                case GameType.PongSinglePlayer: return "Single Player Pong";
                case GameType.PongTwo: return "Two Players together";
                case GameType.PongBigVsSmall: return "Big vs. Small Pong";
                case GameType.PongFastVsSlow: return "Fast vs. Slow";
                case GameType.PongVsGreatAI: return "Pong vs. the greatest AI ever";
                case GameType.BallPong: return "Just Ball";
                case GameType.SinglePlayerWithX: return "Single Player With X movement";
                default: return type.ToString();
            }
        }
    }

    /*public static class GameType
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
    }*/
}
