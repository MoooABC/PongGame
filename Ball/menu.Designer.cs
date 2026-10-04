namespace Ball
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNormal = new System.Windows.Forms.Label();
            this.btn1Vs1 = new System.Windows.Forms.Button();
            this.btnSingleP = new System.Windows.Forms.Button();
            this.btnOneVsAI = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.lblUnfair = new System.Windows.Forms.Label();
            this.btnBigVsSmall = new System.Windows.Forms.Button();
            this.btnFastVsSlow = new System.Windows.Forms.Button();
            this.btnOneVsGoodAI = new System.Windows.Forms.Button();
            this.lblSpecial = new System.Windows.Forms.Label();
            this.btnBall = new System.Windows.Forms.Button();
            this.btnXAxis = new System.Windows.Forms.Button();
            this.btnTwoWithX = new System.Windows.Forms.Button();
            this.flowLayoutPanelSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.trackBarBallRadius = new System.Windows.Forms.TrackBar();
            this.labelBallSize = new System.Windows.Forms.Label();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnBallColor = new System.Windows.Forms.Button();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.btnPaddleColor = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.flowLayoutPanel.SuspendLayout();
            this.flowLayoutPanelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBallRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Controls.Add(this.lblNormal);
            this.flowLayoutPanel.Controls.Add(this.btn1Vs1);
            this.flowLayoutPanel.Controls.Add(this.btnSingleP);
            this.flowLayoutPanel.Controls.Add(this.btnOneVsAI);
            this.flowLayoutPanel.Controls.Add(this.btnTwo);
            this.flowLayoutPanel.Controls.Add(this.lblUnfair);
            this.flowLayoutPanel.Controls.Add(this.btnBigVsSmall);
            this.flowLayoutPanel.Controls.Add(this.btnFastVsSlow);
            this.flowLayoutPanel.Controls.Add(this.btnOneVsGoodAI);
            this.flowLayoutPanel.Controls.Add(this.lblSpecial);
            this.flowLayoutPanel.Controls.Add(this.btnBall);
            this.flowLayoutPanel.Controls.Add(this.btnXAxis);
            this.flowLayoutPanel.Controls.Add(this.btnTwoWithX);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(772, 554);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // lblNormal
            // 
            this.flowLayoutPanel.SetFlowBreak(this.lblNormal, true);
            this.lblNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormal.Location = new System.Drawing.Point(4, 0);
            this.lblNormal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNormal.Name = "lblNormal";
            this.lblNormal.Size = new System.Drawing.Size(133, 31);
            this.lblNormal.TabIndex = 4;
            this.lblNormal.Text = "Normal";
            // 
            // btn1Vs1
            // 
            this.btn1Vs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn1Vs1.Location = new System.Drawing.Point(4, 69);
            this.btn1Vs1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1Vs1.Name = "btn1Vs1";
            this.btn1Vs1.Size = new System.Drawing.Size(200, 57);
            this.btn1Vs1.TabIndex = 0;
            this.btn1Vs1.Tag = Ball.GameType.PongOneVsOne;
            this.btn1Vs1.Text = "1 Vs. 1";
            this.btn1Vs1.UseVisualStyleBackColor = true;
            this.btn1Vs1.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnSingleP
            // 
            this.btnSingleP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnSingleP.Location = new System.Drawing.Point(212, 69);
            this.btnSingleP.Margin = new System.Windows.Forms.Padding(4);
            this.btnSingleP.Name = "btnSingleP";
            this.btnSingleP.Size = new System.Drawing.Size(200, 57);
            this.btnSingleP.TabIndex = 1;
            this.btnSingleP.Tag = Ball.GameType.PongSinglePlayer;
            this.btnSingleP.Text = "Single Player";
            this.btnSingleP.UseVisualStyleBackColor = true;
            this.btnSingleP.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnOneVsAI
            // 
            this.btnOneVsAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnOneVsAI.Location = new System.Drawing.Point(420, 69);
            this.btnOneVsAI.Margin = new System.Windows.Forms.Padding(4);
            this.btnOneVsAI.Name = "btnOneVsAI";
            this.btnOneVsAI.Size = new System.Drawing.Size(200, 57);
            this.btnOneVsAI.TabIndex = 2;
            this.btnOneVsAI.Tag = Ball.GameType.PongVsAI;
            this.btnOneVsAI.Text = "1 Vs. AI";
            this.btnOneVsAI.UseVisualStyleBackColor = true;
            this.btnOneVsAI.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnTwo
            // 
            this.flowLayoutPanel.SetFlowBreak(this.btnTwo, true);
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnTwo.Location = new System.Drawing.Point(4, 134);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(4);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(200, 57);
            this.btnTwo.TabIndex = 3;
            this.btnTwo.Tag = Ball.GameType.PongTwo;
            this.btnTwo.Text = "Two Players together";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblUnfair
            // 
            this.flowLayoutPanel.SetFlowBreak(this.lblUnfair, true);
            this.lblUnfair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnfair.Location = new System.Drawing.Point(4, 195);
            this.lblUnfair.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnfair.Name = "lblUnfair";
            this.lblUnfair.Size = new System.Drawing.Size(133, 31);
            this.lblUnfair.TabIndex = 7;
            this.lblUnfair.Text = "Unfair";
            // 
            // btnBigVsSmall
            // 
            this.btnBigVsSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnBigVsSmall.Location = new System.Drawing.Point(4, 264);
            this.btnBigVsSmall.Margin = new System.Windows.Forms.Padding(4);
            this.btnBigVsSmall.Name = "btnBigVsSmall";
            this.btnBigVsSmall.Size = new System.Drawing.Size(200, 57);
            this.btnBigVsSmall.TabIndex = 4;
            this.btnBigVsSmall.Tag = Ball.GameType.PongBigVsSmall;
            this.btnBigVsSmall.Text = "Big vs. Small";
            this.btnBigVsSmall.UseVisualStyleBackColor = true;
            this.btnBigVsSmall.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnFastVsSlow
            // 
            this.btnFastVsSlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnFastVsSlow.Location = new System.Drawing.Point(212, 264);
            this.btnFastVsSlow.Margin = new System.Windows.Forms.Padding(4);
            this.btnFastVsSlow.Name = "btnFastVsSlow";
            this.btnFastVsSlow.Size = new System.Drawing.Size(200, 57);
            this.btnFastVsSlow.TabIndex = 6;
            this.btnFastVsSlow.Tag = Ball.GameType.PongFastVsSlow;
            this.btnFastVsSlow.Text = "Fast vs. Slow";
            this.btnFastVsSlow.UseVisualStyleBackColor = true;
            this.btnFastVsSlow.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnOneVsGoodAI
            // 
            this.flowLayoutPanel.SetFlowBreak(this.btnOneVsGoodAI, true);
            this.btnOneVsGoodAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnOneVsGoodAI.Location = new System.Drawing.Point(420, 264);
            this.btnOneVsGoodAI.Margin = new System.Windows.Forms.Padding(4);
            this.btnOneVsGoodAI.Name = "btnOneVsGoodAI";
            this.btnOneVsGoodAI.Size = new System.Drawing.Size(200, 57);
            this.btnOneVsGoodAI.TabIndex = 7;
            this.btnOneVsGoodAI.Tag = Ball.GameType.PongVsGreatAI;
            this.btnOneVsGoodAI.Text = "1 vs. The greatest AI ever";
            this.btnOneVsGoodAI.UseVisualStyleBackColor = true;
            this.btnOneVsGoodAI.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblSpecial
            // 
            this.flowLayoutPanel.SetFlowBreak(this.lblSpecial, true);
            this.lblSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecial.Location = new System.Drawing.Point(4, 325);
            this.lblSpecial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecial.Name = "lblSpecial";
            this.lblSpecial.Size = new System.Drawing.Size(133, 31);
            this.lblSpecial.TabIndex = 5;
            this.lblSpecial.Text = "Special";
            // 
            // btnBall
            // 
            this.btnBall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnBall.Location = new System.Drawing.Point(4, 394);
            this.btnBall.Margin = new System.Windows.Forms.Padding(4);
            this.btnBall.Name = "btnBall";
            this.btnBall.Size = new System.Drawing.Size(200, 57);
            this.btnBall.TabIndex = 8;
            this.btnBall.Tag = Ball.GameType.BallPong;
            this.btnBall.Text = "Only Ball";
            this.btnBall.UseVisualStyleBackColor = true;
            this.btnBall.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnXAxis
            // 
            this.btnXAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold);
            this.btnXAxis.Location = new System.Drawing.Point(212, 394);
            this.btnXAxis.Margin = new System.Windows.Forms.Padding(4);
            this.btnXAxis.Name = "btnXAxis";
            this.btnXAxis.Size = new System.Drawing.Size(200, 57);
            this.btnXAxis.TabIndex = 9;
            this.btnXAxis.Tag = Ball.GameType.SinglePlayerWithX;
            this.btnXAxis.Text = "Single player were you can also move on the X axis";
            this.btnXAxis.UseVisualStyleBackColor = true;
            this.btnXAxis.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnTwoWithX
            // 
            this.btnTwoWithX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnTwoWithX.Location = new System.Drawing.Point(420, 394);
            this.btnTwoWithX.Margin = new System.Windows.Forms.Padding(4);
            this.btnTwoWithX.Name = "btnTwoWithX";
            this.btnTwoWithX.Size = new System.Drawing.Size(200, 57);
            this.btnTwoWithX.TabIndex = 10;
            this.btnTwoWithX.Tag = Ball.GameType.TwoPlayersWithX;
            this.btnTwoWithX.Text = "Two players with X";
            this.btnTwoWithX.UseVisualStyleBackColor = true;
            this.btnTwoWithX.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // flowLayoutPanelSettings
            // 
            this.flowLayoutPanelSettings.Controls.Add(this.trackBarBallRadius);
            this.flowLayoutPanelSettings.Controls.Add(this.labelBallSize);
            this.flowLayoutPanelSettings.Controls.Add(this.trackBarVolume);
            this.flowLayoutPanelSettings.Controls.Add(this.lblVolume);
            this.flowLayoutPanelSettings.Controls.Add(this.btnBallColor);
            this.flowLayoutPanelSettings.Controls.Add(this.btnBackColor);
            this.flowLayoutPanelSettings.Controls.Add(this.btnPaddleColor);
            this.flowLayoutPanelSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelSettings.Location = new System.Drawing.Point(772, 0);
            this.flowLayoutPanelSettings.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelSettings.Name = "flowLayoutPanelSettings";
            this.flowLayoutPanelSettings.Padding = new System.Windows.Forms.Padding(7, 6, 0, 0);
            this.flowLayoutPanelSettings.Size = new System.Drawing.Size(295, 554);
            this.flowLayoutPanelSettings.TabIndex = 3;
            // 
            // trackBarBallRadius
            // 
            this.trackBarBallRadius.AutoSize = false;
            this.trackBarBallRadius.Location = new System.Drawing.Point(11, 10);
            this.trackBarBallRadius.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarBallRadius.Maximum = 100;
            this.trackBarBallRadius.Minimum = 10;
            this.trackBarBallRadius.Name = "trackBarBallRadius";
            this.trackBarBallRadius.Size = new System.Drawing.Size(117, 37);
            this.trackBarBallRadius.TabIndex = 10;
            this.trackBarBallRadius.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBallRadius.Value = 20;
            this.trackBarBallRadius.Scroll += new System.EventHandler(this.trackBarBallRadius_Scroll);
            // 
            // labelBallSize
            // 
            this.labelBallSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.labelBallSize.Location = new System.Drawing.Point(136, 6);
            this.labelBallSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBallSize.Name = "labelBallSize";
            this.labelBallSize.Size = new System.Drawing.Size(117, 37);
            this.labelBallSize.TabIndex = 7;
            this.labelBallSize.Text = "Ball radius: 20";
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(10, 54);
            this.trackBarVolume.Maximum = 255;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(118, 56);
            this.trackBarVolume.TabIndex = 14;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // lblVolume
            // 
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblVolume.Location = new System.Drawing.Point(135, 51);
            this.lblVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(117, 37);
            this.lblVolume.TabIndex = 15;
            this.lblVolume.Text = "Volume: 0";
            // 
            // btnBallColor
            // 
            this.btnBallColor.Location = new System.Drawing.Point(11, 117);
            this.btnBallColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnBallColor.Name = "btnBallColor";
            this.btnBallColor.Size = new System.Drawing.Size(129, 28);
            this.btnBallColor.TabIndex = 13;
            this.btnBallColor.Text = "Ball Color";
            this.btnBallColor.UseVisualStyleBackColor = true;
            this.btnBallColor.Click += new System.EventHandler(this.btnBallColor_Click);
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(148, 117);
            this.btnBackColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(129, 28);
            this.btnBackColor.TabIndex = 11;
            this.btnBackColor.Text = "Back Color";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // btnPaddleColor
            // 
            this.btnPaddleColor.Location = new System.Drawing.Point(11, 153);
            this.btnPaddleColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaddleColor.Name = "btnPaddleColor";
            this.btnPaddleColor.Size = new System.Drawing.Size(129, 28);
            this.btnPaddleColor.TabIndex = 12;
            this.btnPaddleColor.Text = "Paddle Color";
            this.btnPaddleColor.UseVisualStyleBackColor = true;
            this.btnPaddleColor.Click += new System.EventHandler(this.btnPaddleColor_Click);
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 23);
            this.label.TabIndex = 0;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.flowLayoutPanelSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(547, 543);
            this.Name = "MenuForm";
            this.Text = "menu";
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanelSettings.ResumeLayout(false);
            this.flowLayoutPanelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBallRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btn1Vs1;
        private System.Windows.Forms.Button btnSingleP;
        private System.Windows.Forms.Button btnOneVsAI;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSettings;
        private System.Windows.Forms.Button btnBallColor;
        private System.Windows.Forms.Button btnPaddleColor;
        private System.Windows.Forms.TrackBar trackBarBallRadius;
        private System.Windows.Forms.Label labelBallSize;
        private System.Windows.Forms.Button btnBall;
        private System.Windows.Forms.Label lblNormal;
        private System.Windows.Forms.Label lblSpecial;
        private System.Windows.Forms.Label lblUnfair;
        private System.Windows.Forms.Button btnBigVsSmall;
        private System.Windows.Forms.Button btnFastVsSlow;
        private System.Windows.Forms.Button btnOneVsGoodAI;
        private System.Windows.Forms.Button btnXAxis;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnTwoWithX;
    }
}