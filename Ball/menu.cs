using Ball;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using SkiaSharp;
using System.Windows.Forms;
using System.IO;

namespace Ball
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            Sfx.Initialize();

            labelBallSize.Text = $"Ball radius: {Properties.Settings.Default.BallRadius}";
            trackBarBallRadius.Value = Properties.Settings.Default.BallRadius;

            lblVolume.Text = $"Volume: {Properties.Settings.Default.Volume}";
            trackBarVolume.Value = Properties.Settings.Default.Volume;
        }

        private void ShowGame(GameType mode)
        {
            PongGame game = new PongGame(mode);
            game.FormClosed += (s, e) => this.Show();
            this.Hide();
            game.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            GameType mode = (GameType)((Button)sender).Tag;
            ShowGame(mode);
        }

        private void btnBallColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    SKColor selectedColor = new SKColor(colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);

                    Properties.Settings.Default.BallSKColor = selectedColor.ToString();
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    SKColor selectedColor = new SKColor(colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);

                    Properties.Settings.Default.BackSKColor = selectedColor.ToString();
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void btnPaddleColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    SKColor selectedColor = new SKColor(colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);

                    Properties.Settings.Default.PaddleSKColor = selectedColor.ToString();
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void trackBarBallRadius_Scroll(object sender, EventArgs e)
        {
            byte value = (byte)trackBarBallRadius.Value;

            Properties.Settings.Default.BallRadius = value;
            Properties.Settings.Default.Save();

            labelBallSize.Text = $"Ball radius: {value}";
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            byte value = (byte)trackBarVolume.Value;

            Properties.Settings.Default.Volume = value;
            Properties.Settings.Default.Save();

            lblVolume.Text = $"Volume: {value}";
            Sfx.SetVolume((int)(value / 2.55));
        }

        private void btnSounds_Click(object sender, EventArgs e)
        {
            if (cmbSounds.SelectedItem == null)
            {
                MessageBox.Show("Please select a sound from the dropdown list.", "No Sound Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sound = cmbSounds.SelectedItem.ToString();

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "WAV files (*.wav)|*.wav";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = dialog.FileName;

                    try
                    {
                        Properties.Settings.Default[sound+ "Sound"] = selectedFilePath;
                        Properties.Settings.Default.Save();
                        Sfx.Initialize();
                        MessageBox.Show($"Sound '{sound}' updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to update sound '{sound}'.\n Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSoundReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.hitSound = "";
            Properties.Settings.Default.scoreSound = "";
            Properties.Settings.Default.beepSound = "";
            Sfx.Initialize();
            Properties.Settings.Default.Save();
        }
    }
}