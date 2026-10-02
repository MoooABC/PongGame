using System.IO;
using System.Media;

namespace Ball
{
    public static class Sfx
    {
        public static bool Enabled { get; set; } = true;

        private static readonly SoundPlayer hit = Load(Properties.Resources.hit);
        private static readonly SoundPlayer wall = Load(Properties.Resources.wall);
        private static readonly SoundPlayer score = Load(Properties.Resources.score);

        public static void PlayHit() => Play(hit);
        public static void PlayWall() => Play(wall);
        public static void PlayScore() => Play(score);

        private static SoundPlayer Load(Stream stream)
        {
            var player = new SoundPlayer(stream);
            player.Load();
            return player;
        }

        private static void Play(SoundPlayer player)
        {
            if (!Enabled || player == null) return;

            try { player.Play(); }  
            catch { }
        }
    }
}