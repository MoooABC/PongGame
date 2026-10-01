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

namespace Ball
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            flowLayoutPanel.Location = new Point(0, 0);
            Reset();

            labelBallSize.Text = $"Ball radius: {Properties.Settings.Default.BallRadius}";
            trackBarBallRadius.Value = Properties.Settings.Default.BallRadius;
        }

        private void MenuForm_Resize(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {

            flowLayoutPanel.Size = new Size(ClientSize.Width - flowLayoutPanelSettings.Size.Width, ClientSize.Height);

            // Force the layout to recalculate before accessing ClientSize
            flowLayoutPanel.PerformLayout();

            Label[] lbls = new Label[] { lblNormal, lblSpecial, lblUnfair };
            int fullWidth = flowLayoutPanel.ClientSize.Width - 15;
            foreach (Label lbl in lbls)
            {
                lbl.Width = fullWidth;
            }

            flowLayoutPanelSettings.Location = new Point(flowLayoutPanel.Right, 0);
            flowLayoutPanelSettings.Size = new Size(flowLayoutPanelSettings.Size.Width, ClientSize.Height);
        }

        private void ShowGame()
        {
            PongGame game = new PongGame();

            this.Hide();
            game.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GameType.curr = btn.Tag.ToString();

            ShowGame();
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
    }
}