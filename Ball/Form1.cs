using SkiaSharp;
using SkiaSharp.Views.Desktop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ball
{
    public partial class PongGame : Form
    {
        private readonly GameType mode;

        private Ball ball;
        private Paddle paddle1;
        private Paddle paddle2;
        private Paddle paddle3;

        private uint score1 = 0;
        private uint score2 = 0;

        private SKControl skControl1;

        private float targetBallY = 0;


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (this.mode)
            {
                case GameType.PongOneVsOne:
                case GameType.PongBigVsSmall:
                case GameType.PongFastVsSlow:
                case GameType.PongTwo:
                    break;

                default:
                    return false;
            }


            if (keyData == Keys.Up)
            {
                paddle2.Up();
                return true;
            }
            if (keyData == Keys.Down)
            {
                paddle2.Down();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        public PongGame(GameType mode)
        {
            this.mode = mode;
            InitializeComponent();

            this.Text = mode.DisplayName();
            skControl1 = new SKControl();
            skControl1.PaintSurface += new EventHandler<SKPaintSurfaceEventArgs>(skControl1_PaintSurface);
            Controls.Add(skControl1);
            
            Reset();
        }

        public void Reset()
        {
            timerUpdate.Enabled = false;

            toolStripStatusLabel1.Text = $"Score: {score1}";
            toolStripStatusLabel2.Text = $"Score: {score2}";

            skControl1.Size = new Size(ClientSize.Width, ClientSize.Height-statusStrip.Height);

            int w = skControl1.Width;
            int h = skControl1.Height;

            string ballColorHex = Properties.Settings.Default.BallSKColor;
            ball = new Ball(w / 2, h / 2, Properties.Settings.Default.BallRadius, SKColor.Parse(ballColorHex));

            string paddleColorHex = Properties.Settings.Default.PaddleSKColor;
            switch (this.mode)
            {
                case GameType.PongTwo:
                    paddle1 = new Paddle(new int[] { 15, h / 2 }, 5, SKColor.Parse(paddleColorHex), new ushort[] { 25, 100 });
                    paddle2 = new Paddle(new int[] { 150, h / 2 }, 5, SKColor.Parse(paddleColorHex), new ushort[] { 25, 100 });
                    paddle3 = new Paddle(new int[] { w - 40, h / 2 }, 5, SKColor.Parse(paddleColorHex), new ushort[] { 25, 100 });
                    break;

                case GameType.PongFastVsSlow:
                    paddle1 = new Paddle(new int[] { 15, h / 2 }, 10, SKColor.Parse(paddleColorHex), new ushort[] { 25, 100 });
                    paddle2 = new Paddle(new int[] { w - 40, h / 2 }, 3, SKColor.Parse(paddleColorHex), new ushort[] { 25, 100 });
                    break;

                case GameType.PongBigVsSmall:
                    paddle1 = new Paddle(new int[] { 15, h / 2 }, 5, SKColor.Parse(paddleColorHex), new ushort[] {25, 150});
                    paddle2 = new Paddle(new int[] { w - 40, h / 2 }, 5, SKColor.Parse(paddleColorHex), new ushort[] {25, 75});
                    break;

                case GameType.PongSinglePlayer:
                case GameType.SinglePlayerWithX:
                    paddle1 = new Paddle(new int[] { 15, h / 2 }, 5, SKColor.Parse(paddleColorHex), new ushort[] { 25, 100 });
                    break;

                case GameType.BallPong:
                    break;

                case GameType.PongVsAI:
                case GameType.PongVsGreatAI:
                case GameType.PongOneVsOne:
                    paddle1 = new Paddle(new int[] { 15, h / 2 }, 5, SKColor.Parse(paddleColorHex), new ushort[] { 25, 100 });
                    paddle2 = new Paddle(new int[] { w - 40, h / 2 }, 5, SKColor.Parse(paddleColorHex), new ushort[] { 25, 100 });
                    break;
            }

            timerUpdate.Enabled = true;
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            timerUpdate.Enabled = false;

            ball.Update(skControl1.Width, skControl1.Height);

            switch (this.mode)
            {
                case GameType.BallPong:
                    break; // I allready Updated the ball

                case GameType.PongTwo:
                    paddle1.Update(skControl1.Width, skControl1.Height);
                    paddle2.Update(skControl1.Width, skControl1.Height);

                    GameManager.DetectAndCareCollision(ball, paddle1);
                    GameManager.DetectAndCareCollision(ball, paddle2);
                    GameManager.DetectAndCareCollision(ball, paddle3);

                    paddle3.SetPosition(TheGreatestAIEver(paddle3));

                    CareScoreCollision("left");
                    CareScoreCollision("right");
                    break;

                case GameType.PongFastVsSlow:
                case GameType.PongBigVsSmall:
                case GameType.PongOneVsOne:
                    paddle1.Update(skControl1.Width, skControl1.Height);
                    paddle2.Update(skControl1.Width, skControl1.Height);

                    GameManager.DetectAndCareCollision(ball, paddle1);
                    GameManager.DetectAndCareCollision(ball, paddle2);

                    CareScoreCollision("left");
                    CareScoreCollision("right");
                    break;

                case GameType.PongVsGreatAI:
                    paddle1.Update(skControl1.Width, skControl1.Height);

                    GameManager.DetectAndCareCollision(ball, paddle1);
                    GameManager.DetectAndCareCollision(ball, paddle2);

                    paddle2.SetPosition(TheGreatestAIEver(paddle2));

                    CareScoreCollision("left");
                    CareScoreCollision("right");
                    break;

                case GameType.PongVsAI:
                    paddle1.Update(skControl1.Width, skControl1.Height);

                    int y = paddle2.GetPosition()[1];
                    int ballY = (int)ball.GetPos()[1];
                    paddle2.SetPosition(new int[] { paddle2.GetPosition()[0], y + Math.Sign(ballY - y) * paddle2.GetSpeed() });

                    GameManager.DetectAndCareCollision(ball, paddle1);
                    GameManager.DetectAndCareCollision(ball, paddle2);
                    CareScoreCollision("left");
                    CareScoreCollision("right");
                    break;

                case GameType.SinglePlayerWithX:
                case GameType.PongSinglePlayer:
                    paddle1.Update(skControl1.Width, skControl1.Height);
                    GameManager.DetectAndCareCollision(ball, paddle1);
                    CareScoreCollision("left");
                    break;


                default:
                    DialogResult result = MessageBox.Show("Sorry, this game mode is not implemented yet.\n Do you want to try again", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            break;

                        case DialogResult.No:
                            new MenuForm().Show();
                            this.Close();
                            return;

                        default:
                            DialogResult res = MessageBox.Show("Our bad, you click on a button that should have not been exist", "ERROR", MessageBoxButtons.OK);

                            new MenuForm().Show();
                            this.Close();
                            return;
                    }

                    break;
            }

            skControl1.Invalidate();

            timerUpdate.Enabled = true;
        }



        private int[] TheGreatestAIEver(Paddle paddle)
        {
            float radius = ball.GetRadius();

            float ballTopLeftX = ball.GetPos()[0] - radius;
            float ballTopLeftY = ball.GetPos()[1] - radius;

            targetBallY = AI.PredictBallLandingYRigth(
                ballTopLeftX, ballTopLeftY,
                ball.GetVelocity()[0], ball.GetVelocity()[1],
                paddle.GetPosition()[0],
                0, skControl1.Size.Height,
                radius * 2f
            );


            int botTopY = paddle.GetPosition()[1];
            int halfPaddleHeight = paddle.GetSize()[1] / 2;

            int botCenterY = botTopY + halfPaddleHeight;
            int speed = paddle.GetSpeed();

            if (botCenterY < (int)targetBallY - (speed / 2))
            {
                return new int[] { paddle.GetPosition()[0], botTopY + speed };
            }
            else if (botCenterY > (int)targetBallY + (speed / 2))
            {
                return new int[] { paddle.GetPosition()[0], botTopY - speed };
            }
            return paddle.GetPosition();
        }

        private void CareScoreCollision(string direction)
        {
            direction = direction.ToLower();

            if (direction == "left")
            {
                bool isLeftScore = GameManager.DetectAndCareScore(ball, 0, 0, 10, skControl1.Height);

                if (isLeftScore)
                {
                    Sfx.PlayScore();
                    score2++;
                    toolStripStatusLabel2.Text = $"Score: {score2}";
                    Reset();
                }
            }
            else if (direction == "right")
            {
                bool isRightScore = GameManager.DetectAndCareScore(ball, skControl1.Width - 10, 0, 10, skControl1.Height);

                if (isRightScore)
                {
                    Sfx.PlayScore();
                    score1++;
                    toolStripStatusLabel1.Text = $"Score: {score1}";
                    Reset();
                }
            }
            else
            {
                throw new ArgumentException("Direction must be either 'left' or 'right'.");
            }
        }

        private void skControl1_PaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            SKCanvas canvas = e.Surface.Canvas;

            string backColorHex = Properties.Settings.Default.BackSKColor;
            canvas.Clear(SKColor.Parse(backColorHex));

            ball.Render(canvas);

            switch (this.mode)
            {
                case GameType.BallPong:
                    break; // I allready Rendered the ball

                case GameType.PongBigVsSmall:
                case GameType.PongFastVsSlow:
                case GameType.PongVsAI:
                case GameType.PongVsGreatAI:
                case GameType.PongOneVsOne:
                    paddle1.Render(canvas);
                    paddle2.Render(canvas);
                    break;

                case GameType.SinglePlayerWithX:
                case GameType.PongSinglePlayer:
                    paddle1.Render(canvas);
                    break;

                case GameType.PongTwo:
                    paddle1.Render(canvas);
                    paddle2.Render(canvas);
                    paddle3.Render(canvas);
                    break;

            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                timerUpdate.Enabled = false;
                DialogResult result = MessageBox.Show("game is paused.\ndo you want to exit?", "++\t(-:\t++", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    this.Close();
                timerUpdate.Enabled = true;
            }

            switch (this.mode)
            {
                case GameType.PongOneVsOne:
                case GameType.PongVsAI:
                case GameType.PongBigVsSmall:
                case GameType.PongSinglePlayer:
                case GameType.PongVsGreatAI:
                case GameType.PongFastVsSlow:
                case GameType.PongTwo:
                case GameType.SinglePlayerWithX:
                    break;

                default:
                    return;
            }

            switch (e.KeyCode)
            {
                case Keys.W:
                    paddle1.Up();
                    break;
                case Keys.S:
                    paddle1.Down();
                    break;

                case Keys.A:
                    if (this.mode == GameType.SinglePlayerWithX)
                    {
                        paddle1.SetPosition(new int[] { paddle1.GetPosition()[0] - paddle1.GetSpeed(), paddle1.GetPosition()[1] });
                    }
                    break;

                case Keys.D:
                    if (this.mode == GameType.SinglePlayerWithX)
                    {
                        paddle1.SetPosition(new int[] { paddle1.GetPosition()[0] + paddle1.GetSpeed(), paddle1.GetPosition()[1] });
                    }
                    break;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Reset();
        }
        private void toolStripButtonBack_ButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            score1 = 0;
            score2 = 0;
            Reset();
        }
    }
}