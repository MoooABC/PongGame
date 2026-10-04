using System;
using System.IO;
using System.Windows.Forms;
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
            volume = (int)(Properties.Settings.Default.Volume / 2.55);
            string tmpPath = Path.GetTempPath();

            _hit = Load(Path.Combine(tmpPath, "pongHit.wav"), Properties.Resources.hit, Properties.Settings.Default.hitSound);
            _wall = Load(Path.Combine(tmpPath, "pongWall.wav"), Properties.Resources.wall, "");
            _score = Load(Path.Combine(tmpPath, "pongScore.wav"), Properties.Resources.score, Properties.Settings.Default.scoreSound);
            _beep = Load(Path.Combine(tmpPath, "pongBeep.wav"), Properties.Resources.beep, Properties.Settings.Default.beepSound);

        }

        private static WindowsMediaPlayer Load(string path, Stream resource, string setting)
        {
            string currentPath = setting;
            if (string.IsNullOrEmpty(setting) && !File.Exists(setting))
            {
                try
                {
                    using (var fs = File.Create(path))
                    {
                        resource.CopyTo(fs);
                    }
                }
                catch (IOException) { }
                currentPath = path;
            }

            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.settings.autoStart = false;
            player.settings.volume = 100;
            player.URL = currentPath;
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