
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
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mang1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mang3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mang2)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::GameMario.Properties.Resources.mariodichuyen;
            this.player.Location = new System.Drawing.Point(608, 670);
            this.player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(163, 129);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // mang1
            // 
            this.mang1.BackColor = System.Drawing.Color.Transparent;
            this.mang1.Image = global::GameMario.Properties.Resources.mang;
            this.mang1.Location = new System.Drawing.Point(3, 2);
            this.mang1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mang1.Name = "mang1";
            this.mang1.Size = new System.Drawing.Size(39, 32);
            this.mang1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mang1.TabIndex = 1;
            this.mang1.TabStop = false;
            // 
            // mang3
            // 
            this.mang3.BackColor = System.Drawing.Color.Transparent;
            this.mang3.Image = global::GameMario.Properties.Resources.mang;
            this.mang3.Location = new System.Drawing.Point(72, 2);
            this.mang3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mang3.Name = "mang3";
            this.mang3.Size = new System.Drawing.Size(39, 32);
            this.mang3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mang3.TabIndex = 2;
            this.mang3.TabStop = false;
            // 
            // mang2
            // 
            this.mang2.BackColor = System.Drawing.Color.Transparent;
            this.mang2.Image = global::GameMario.Properties.Resources.mang;
            this.mang2.Location = new System.Drawing.Point(37, 2);
            this.mang2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score:0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(697, 101);
            this.label2.TabIndex = 5;
            this.label2.Text = "GAME OVER";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1705, 814);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mang2);
            this.Controls.Add(this.mang3);
            this.Controls.Add(this.mang1);
            this.Controls.Add(this.player);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mang1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mang3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mang2)).EndInit();
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
	}
}

