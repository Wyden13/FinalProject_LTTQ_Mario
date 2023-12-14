
namespace GameMario
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
            this.player = new System.Windows.Forms.PictureBox();
            this.mang1 = new System.Windows.Forms.PictureBox();
            this.mang3 = new System.Windows.Forms.PictureBox();
            this.mang2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mang1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mang3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mang2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::GameMario.Properties.Resources.mariodichuyen;
            this.player.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.player.Location = new System.Drawing.Point(498, 522);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(169, 117);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // mang1
            // 
            this.mang1.BackColor = System.Drawing.Color.Transparent;
            this.mang1.Image = global::GameMario.Properties.Resources.pngwing_com__1_;
            this.mang1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mang1.Location = new System.Drawing.Point(24, 14);
            this.mang1.Margin = new System.Windows.Forms.Padding(4);
            this.mang1.Name = "mang1";
            this.mang1.Size = new System.Drawing.Size(39, 32);
            this.mang1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mang1.TabIndex = 1;
            this.mang1.TabStop = false;
            // 
            // mang3
            // 
            this.mang3.BackColor = System.Drawing.Color.Transparent;
            this.mang3.Image = global::GameMario.Properties.Resources.pngwing_com__1_;
            this.mang3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mang3.Location = new System.Drawing.Point(93, 14);
            this.mang3.Margin = new System.Windows.Forms.Padding(4);
            this.mang3.Name = "mang3";
            this.mang3.Size = new System.Drawing.Size(39, 32);
            this.mang3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mang3.TabIndex = 2;
            this.mang3.TabStop = false;
            this.mang3.Click += new System.EventHandler(this.mang3_Click);
            // 
            // mang2
            // 
            this.mang2.BackColor = System.Drawing.Color.Transparent;
            this.mang2.ErrorImage = global::GameMario.Properties.Resources.pngwing_com__1_;
            this.mang2.Image = global::GameMario.Properties.Resources.pngwing_com__1_;
            this.mang2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mang2.Location = new System.Drawing.Point(59, 14);
            this.mang2.Margin = new System.Windows.Forms.Padding(4);
            this.mang2.Name = "mang2";
            this.mang2.Size = new System.Drawing.Size(39, 32);
            this.mang2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mang2.TabIndex = 3;
            this.mang2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Pixelify Sans", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score:0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Pixelify Sans", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(347, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(564, 105);
            this.label2.TabIndex = 5;
            this.label2.Text = "GAME OVER";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Pixelify Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(1012, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 68);
            this.label3.TabIndex = 6;
            this.label3.Text = "Highest Score \r\n0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Pixelify Sans", 13.8F);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(523, 255);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "Try again";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GameMario.Properties.Resources.pokeball;
            this.pictureBox1.Location = new System.Drawing.Point(323, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Pixelify Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "x 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1229, 652);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mang2);
            this.Controls.Add(this.mang3);
            this.Controls.Add(this.mang1);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mang1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mang3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mang2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

