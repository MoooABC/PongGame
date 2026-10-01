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
            this.button1 = new System.Windows.Forms.Button();
            this.btnFastVsSlow = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSpecial = new System.Windows.Forms.Label();
            this.btnBall = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanelSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.trackBarBallRadius = new System.Windows.Forms.TrackBar();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.labelBallSize = new System.Windows.Forms.Label();
            this.btnPaddleColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBallColor = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.flowLayoutPanel.SuspendLayout();
            this.flowLayoutPanelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBallRadius)).BeginInit();
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
            this.flowLayoutPanel.Controls.Add(this.button1);
            this.flowLayoutPanel.Controls.Add(this.btnFastVsSlow);
            this.flowLayoutPanel.Controls.Add(this.button2);
            this.flowLayoutPanel.Controls.Add(this.lblSpecial);
            this.flowLayoutPanel.Controls.Add(this.btnBall);
            this.flowLayoutPanel.Controls.Add(this.button3);
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(771, 554);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // lblNormal
            // 
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
            this.btn1Vs1.Location = new System.Drawing.Point(145, 4);
            this.btn1Vs1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn1Vs1.Name = "btn1Vs1";
            this.btn1Vs1.Size = new System.Drawing.Size(200, 57);
            this.btn1Vs1.TabIndex = 0;
            this.btn1Vs1.Tag = "1v1 Pong";
            this.btn1Vs1.Text = "1 Vs. 1";
            this.btn1Vs1.UseVisualStyleBackColor = true;
            this.btn1Vs1.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnSingleP
            // 
            this.btnSingleP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnSingleP.Location = new System.Drawing.Point(353, 4);
            this.btnSingleP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSingleP.Name = "btnSingleP";
            this.btnSingleP.Size = new System.Drawing.Size(200, 57);
            this.btnSingleP.TabIndex = 1;
            this.btnSingleP.Tag = "Single Player Pong";
            this.btnSingleP.Text = "Single Player";
            this.btnSingleP.UseVisualStyleBackColor = true;
            this.btnSingleP.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnOneVsAI
            // 
            this.btnOneVsAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnOneVsAI.Location = new System.Drawing.Point(561, 4);
            this.btnOneVsAI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOneVsAI.Name = "btnOneVsAI";
            this.btnOneVsAI.Size = new System.Drawing.Size(200, 57);
            this.btnOneVsAI.TabIndex = 2;
            this.btnOneVsAI.Tag = "Pong vs AI";
            this.btnOneVsAI.Text = "1 Vs. AI";
            this.btnOneVsAI.UseVisualStyleBackColor = true;
            this.btnOneVsAI.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnTwo.Location = new System.Drawing.Point(4, 69);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(200, 57);
            this.btnTwo.TabIndex = 3;
            this.btnTwo.Tag = "Two Players together";
            this.btnTwo.Text = "Two Players together";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblUnfair
            // 
            this.lblUnfair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnfair.Location = new System.Drawing.Point(212, 65);
            this.lblUnfair.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnfair.Name = "lblUnfair";
            this.lblUnfair.Size = new System.Drawing.Size(133, 31);
            this.lblUnfair.TabIndex = 7;
            this.lblUnfair.Text = "Unfair";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(353, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 57);
            this.button1.TabIndex = 4;
            this.button1.Tag = "Big vs. Small Pong";
            this.button1.Text = "Big vs. Small";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnFastVsSlow
            // 
            this.btnFastVsSlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnFastVsSlow.Location = new System.Drawing.Point(561, 69);
            this.btnFastVsSlow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFastVsSlow.Name = "btnFastVsSlow";
            this.btnFastVsSlow.Size = new System.Drawing.Size(200, 57);
            this.btnFastVsSlow.TabIndex = 6;
            this.btnFastVsSlow.Tag = "Fast vs. Slow";
            this.btnFastVsSlow.Text = "Fast vs. Slow";
            this.btnFastVsSlow.UseVisualStyleBackColor = true;
            this.btnFastVsSlow.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(4, 134);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 57);
            this.button2.TabIndex = 7;
            this.button2.Tag = "Pong vs. the greatest AI ever";
            this.button2.Text = "1 vs. The greatest AI ever";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblSpecial
            // 
            this.lblSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecial.Location = new System.Drawing.Point(212, 130);
            this.lblSpecial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecial.Name = "lblSpecial";
            this.lblSpecial.Size = new System.Drawing.Size(133, 31);
            this.lblSpecial.TabIndex = 5;
            this.lblSpecial.Text = "Special";
            // 
            // btnBall
            // 
            this.btnBall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnBall.Location = new System.Drawing.Point(353, 134);
            this.btnBall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBall.Name = "btnBall";
            this.btnBall.Size = new System.Drawing.Size(200, 57);
            this.btnBall.TabIndex = 8;
            this.btnBall.Tag = "Just Ball";
            this.btnBall.Text = "Only Ball";
            this.btnBall.UseVisualStyleBackColor = true;
            this.btnBall.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(561, 134);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 57);
            this.button3.TabIndex = 9;
            this.button3.Tag = "Single Player With X movement";
            this.button3.Text = "Single player were you can also move on the X axis";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // flowLayoutPanelSettings
            // 
            this.flowLayoutPanelSettings.Controls.Add(this.trackBarBallRadius);
            this.flowLayoutPanelSettings.Controls.Add(this.labelBallSize);
            this.flowLayoutPanelSettings.Controls.Add(this.btnBackColor);
            this.flowLayoutPanelSettings.Controls.Add(this.btnPaddleColor);
            this.flowLayoutPanelSettings.Controls.Add(this.label1);
            this.flowLayoutPanelSettings.Controls.Add(this.btnBallColor);
            this.flowLayoutPanelSettings.Location = new System.Drawing.Point(771, 0);
            this.flowLayoutPanelSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanelSettings.Name = "flowLayoutPanelSettings";
            this.flowLayoutPanelSettings.Padding = new System.Windows.Forms.Padding(7, 6, 0, 0);
            this.flowLayoutPanelSettings.Size = new System.Drawing.Size(295, 554);
            this.flowLayoutPanelSettings.TabIndex = 3;
            // 
            // trackBarBallRadius
            // 
            this.trackBarBallRadius.AutoSize = false;
            this.trackBarBallRadius.Location = new System.Drawing.Point(11, 10);
            this.trackBarBallRadius.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarBallRadius.Maximum = 100;
            this.trackBarBallRadius.Minimum = 10;
            this.trackBarBallRadius.Name = "trackBarBallRadius";
            this.trackBarBallRadius.Size = new System.Drawing.Size(117, 37);
            this.trackBarBallRadius.TabIndex = 10;
            this.trackBarBallRadius.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBallRadius.Value = 20;
            this.trackBarBallRadius.Scroll += new System.EventHandler(this.trackBarBallRadius_Scroll);
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(11, 55);
            this.btnBackColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(129, 28);
            this.btnBackColor.TabIndex = 11;
            this.btnBackColor.Text = "Back Color";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
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
            // btnPaddleColor
            // 
            this.btnPaddleColor.Location = new System.Drawing.Point(148, 55);
            this.btnPaddleColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPaddleColor.Name = "btnPaddleColor";
            this.btnPaddleColor.Size = new System.Drawing.Size(129, 28);
            this.btnPaddleColor.TabIndex = 12;
            this.btnPaddleColor.Text = "Paddle Color";
            this.btnPaddleColor.UseVisualStyleBackColor = true;
            this.btnPaddleColor.Click += new System.EventHandler(this.btnPaddleColor_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 37);
            this.label1.TabIndex = 12;
            // 
            // btnBallColor
            // 
            this.btnBallColor.Location = new System.Drawing.Point(136, 91);
            this.btnBallColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBallColor.Name = "btnBallColor";
            this.btnBallColor.Size = new System.Drawing.Size(129, 28);
            this.btnBallColor.TabIndex = 13;
            this.btnBallColor.Text = "Ball Color";
            this.btnBallColor.UseVisualStyleBackColor = true;
            this.btnBallColor.Click += new System.EventHandler(this.btnBallColor_Click);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(547, 543);
            this.Name = "MenuForm";
            this.Text = "menu";
            this.Resize += new System.EventHandler(this.MenuForm_Resize);
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanelSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBallRadius)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFastVsSlow;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
    }
}