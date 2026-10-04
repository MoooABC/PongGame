using System.IO;
using WMPLib;

namespace Ball
{

    public static class Sfx
    {
        private static WMPLib.WindowsMediaPlayer _hit, _wall, _score, _beep;

        private static string hit;
        private static string wall;
        private static string score;
        private static string beep;

        public static int volume;

        public static void Initialize()
        {
            string tmpPath = Path.GetTempPath();

            _hit = Load(Path.Combine(tmpPath, "pongHit.wav"), Properties.Resources.hit);
            _wall = Load(Path.Combine(tmpPath, "pongWall.wav"), Properties.Resources.wall);
            _score = Load(Path.Combine(tmpPath, "pongScore.wav"), Properties.Resources.score);
            _beep = Load(Path.Combine(tmpPath, "pongBeep.wav"), Properties.Resources.beep);

        }

        private static WMPLib.WindowsMediaPlayer Load(string path, Stream resource)
        {
            try
            {
                using (var fs = File.Create(path))
                {
                    resource.CopyTo(fs);
                }
            }
            catch (IOException) { }

            WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.settings.autoStart = false;
            player.settings.volume = volume;
            player.URL = path;
            return player;
        }

        public static void SetVolume(int vol)
        {
            volume = vol;
            _hit.settings.volume = volume;
            _wall.settings.volume = volume;
            _score.settings.volume = volume;
            _beep.settings.volume = volume;
        }


        private static void Play(WMPLib.WindowsMediaPlayer p)
        {
            p.controls.stop();
            p.controls.play();
        }

        public static void PlayHit() => Play(_hit);
        public static void PlayWall() => Play(_wall);
        public static void PlayScore() => Play(_score);
        public static void PlayBeep() => Play(_beep);
    }
}