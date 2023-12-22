namespace Practice
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblTenDN = new System.Windows.Forms.Label();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.mang2 = new System.Windows.Forms.PictureBox();
            this.mang3 = new System.Windows.Forms.PictureBox();
            this.mang1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mang2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mang3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mang1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Pixelify Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score:0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Pixelify Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(228, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(697, 93);
            this.label3.TabIndex = 6;
            this.label3.Text = "GAME OVER";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenDN
            // 
            this.lblTenDN.AutoSize = true;
            this.lblTenDN.BackColor = System.Drawing.Color.Transparent;
            this.lblTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDN.ForeColor = System.Drawing.Color.Lime;
            this.lblTenDN.Location = new System.Drawing.Point(572, 503);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(80, 29);
            this.lblTenDN.TabIndex = 7;
            this.lblTenDN.Text = "Label";
            this.lblTenDN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGiveUp.BackgroundImage = global::Practice.Properties.Resources.Quit;
            this.btnGiveUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiveUp.Font = new System.Drawing.Font("Pixelify Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiveUp.ForeColor = System.Drawing.Color.Crimson;
            this.btnGiveUp.Location = new System.Drawing.Point(663, 286);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(140, 41);
            this.btnGiveUp.TabIndex = 9;
            this.btnGiveUp.Text = "Give Up";
            this.btnGiveUp.UseVisualStyleBackColor = false;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRestart.BackgroundImage = global::Practice.Properties.Resources.Start;
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestart.Font = new System.Drawing.Font("Pixelify Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Green;
            this.btnRestart.Location = new System.Drawing.Point(307, 286);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(138, 41);
            this.btnRestart.TabIndex = 8;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // mang2
            // 
            this.mang2.BackColor = System.Drawing.Color.Transparent;
            this.mang2.Image = ((System.Drawing.Image)(resources.GetObject("mang2.Image")));
            this.mang2.Location = new System.Drawing.Point(37, 2);
            this.mang2.Margin = new System.Windows.Forms.Padding(4);
            this.mang2.Name = "mang2";
            this.mang2.Size = new System.Drawing.Size(39, 32);
            this.mang2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mang2.TabIndex = 3;
            this.mang2.TabStop = false;
            // 
            // mang3
            // 
            this.mang3.BackColor = System.Drawing.Color.Transparent;
            this.mang3.Image = ((System.Drawing.Image)(resources.GetObject("mang3.Image")));
            this.mang3.Location = new System.Drawing.Point(72, 2);
            this.mang3.Margin = new System.Windows.Forms.Padding(4);
            this.mang3.Name = "mang3";
            this.mang3.Size = new System.Drawing.Size(39, 32);
            this.mang3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mang3.TabIndex = 2;
            this.mang3.TabStop = false;
            // 
            // mang1
            // 
            this.mang1.BackColor = System.Drawing.Color.Transparent;
            this.mang1.Image = ((System.Drawing.Image)(resources.GetObject("mang1.Image")));
            this.mang1.Location = new System.Drawing.Point(3, 2);
            this.mang1.Margin = new System.Windows.Forms.Padding(4);
            this.mang1.Name = "mang1";
            this.mang1.Size = new System.Drawing.Size(39, 32);
            this.mang1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mang1.TabIndex = 1;
            this.mang1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Practice.Properties.Resources.pikachu;
            this.player.Location = new System.Drawing.Point(498, 522);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(169, 117);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1229, 652);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblTenDN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mang2);
            this.Controls.Add(this.mang3);
            this.Controls.Add(this.mang1);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTM";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mang2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mang3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mang1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox mang1;
        private System.Windows.Forms.PictureBox mang3;
        private System.Windows.Forms.PictureBox mang2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTenDN;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnGiveUp;
    }
}