using System;
using System.Collections.Generic;
using System.IO;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace Ball
{
    public static class Sfx
    {
        public static bool Enabled { get; set; } = true;

        private static float volume = 1f;
        public static float Volume
        {
            get { return volume; }
            set { volume = Math.Max(0f, Math.Min(1f, value)); }
        }

        // כל הצלילים והמיקסר באותו פורמט, כדי שהמיקסר יעבוד
        private static readonly WaveFormat Format =
            WaveFormat.CreateIeeeFloatWaveFormat(44100, 2);

        private static CachedSound hit;
        private static CachedSound wall;
        private static CachedSound score;

        private static WaveOutEvent output;
        private static MixingSampleProvider mixer;

        public static void Initialize()
        {
            hit = new CachedSound(Properties.Resources.hit, Format);
            wall = new CachedSound(Properties.Resources.wall, Format);
            score = new CachedSound(Properties.Resources.score, Format);

            mixer = new MixingSampleProvider(Format) { ReadFully = true };

            output = new WaveOutEvent { DesiredLatency = 60 };
            output.Init(mixer);
            output.Play();
        }

        public static void PlayHit() { Play(hit); }
        public static void PlayWall() { Play(wall); }
        public static void PlayScore() { Play(score); }

        private static void Play(CachedSound sound)
        {
            if (!Enabled || sound == null || mixer == null) return;

            try
            {
                var provider = new VolumeSampleProvider(new CachedSoundProvider(sound))
                {
                    Volume = volume
                };
                mixer.AddMixerInput(provider);
            }
            catch { }
        }

        public static void Shutdown()
        {
            if (output != null)
            {
                output.Dispose();
                output = null;
            }
        }

        // ---- מחלקות עזר ----

        private class CachedSound
        {
            public float[] Samples { get; private set; }

            public CachedSound(Stream wavStream, WaveFormat targetFormat)
            {
                using (var reader = new WaveFileReader(wavStream))
                {
                    ISampleProvider source = reader.ToSampleProvider();

                    // התאמת ערוצים
                    if (source.WaveFormat.Channels == 1 && targetFormat.Channels == 2)
                        source = new MonoToStereoSampleProvider(source);

                    // התאמת קצב דגימה
                    if (source.WaveFormat.SampleRate != targetFormat.SampleRate)
                        source = new WdlResamplingSampleProvider(source, targetFormat.SampleRate);

                    var all = new List<float>();
                    var buffer = new float[source.WaveFormat.SampleRate * source.WaveFormat.Channels];
                    int read;
                    while ((read = source.Read(buffer, 0, buffer.Length)) > 0)
                        all.AddRange(new ArraySegment<float>(buffer, 0, read));

                    Samples = all.ToArray();
                }
            }
        }

        private class CachedSoundProvider : ISampleProvider
        {
            private readonly CachedSound sound;
            private int position;

            public CachedSoundProvider(CachedSound sound) { this.sound = sound; }

            public WaveFormat WaveFormat { get { return Format; } }

            public int Read(float[] buffer, int offset, int count)
            {
                int available = sound.Samples.Length - position;
                int toCopy = Math.Min(available, count);
                if (toCopy > 0)
                {
                    Array.Copy(sound.Samples, position, buffer, offset, toCopy);
                    position += toCopy;
                }
                return toCopy;
            }
        }
    }
}