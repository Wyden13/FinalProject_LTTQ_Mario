
namespace GameMario
{
	partial class CauHoi
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
            this.lb_cauhoi = new System.Windows.Forms.Label();
            this.rad_A = new System.Windows.Forms.RadioButton();
            this.rad_B = new System.Windows.Forms.RadioButton();
            this.rad_C = new System.Windows.Forms.RadioButton();
            this.rad_D = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_cauhoi
            // 
            this.lb_cauhoi.BackColor = System.Drawing.Color.Transparent;
            this.lb_cauhoi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_cauhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cauhoi.Location = new System.Drawing.Point(0, 1);
            this.lb_cauhoi.Name = "lb_cauhoi";
            this.lb_cauhoi.Size = new System.Drawing.Size(612, 98);
            this.lb_cauhoi.TabIndex = 0;
            // 
            // rad_A
            // 
            this.rad_A.AutoSize = true;
            this.rad_A.BackColor = System.Drawing.Color.Transparent;
            this.rad_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_A.Location = new System.Drawing.Point(15, 133);
            this.rad_A.Name = "rad_A";
            this.rad_A.Size = new System.Drawing.Size(145, 26);
            this.rad_A.TabIndex = 1;
            this.rad_A.TabStop = true;
            this.rad_A.Text = "radioButton1";
            this.rad_A.UseVisualStyleBackColor = false;
            // 
            // rad_B
            // 
            this.rad_B.AutoSize = true;
            this.rad_B.BackColor = System.Drawing.Color.Transparent;
            this.rad_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_B.Location = new System.Drawing.Point(15, 182);
            this.rad_B.Name = "rad_B";
            this.rad_B.Size = new System.Drawing.Size(145, 26);
            this.rad_B.TabIndex = 2;
            this.rad_B.TabStop = true;
            this.rad_B.Text = "radioButton2";
            this.rad_B.UseVisualStyleBackColor = false;
            // 
            // rad_C
            // 
            this.rad_C.AutoSize = true;
            this.rad_C.BackColor = System.Drawing.Color.Transparent;
            this.rad_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_C.Location = new System.Drawing.Point(15, 236);
            this.rad_C.Name = "rad_C";
            this.rad_C.Size = new System.Drawing.Size(145, 26);
            this.rad_C.TabIndex = 3;
            this.rad_C.TabStop = true;
            this.rad_C.Text = "radioButton3";
            this.rad_C.UseVisualStyleBackColor = false;
            // 
            // rad_D
            // 
            this.rad_D.AutoSize = true;
            this.rad_D.BackColor = System.Drawing.Color.Transparent;
            this.rad_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_D.Location = new System.Drawing.Point(15, 289);
            this.rad_D.Name = "rad_D";
            this.rad_D.Size = new System.Drawing.Size(145, 26);
            this.rad_D.TabIndex = 4;
            this.rad_D.TabStop = true;
            this.rad_D.Text = "radioButton4";
            this.rad_D.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Trả lời";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GameMario.Properties.Resources.pika_ques;
            this.pictureBox1.Location = new System.Drawing.Point(472, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 400);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rad_D);
            this.Controls.Add(this.rad_C);
            this.Controls.Add(this.rad_B);
            this.Controls.Add(this.rad_A);
            this.Controls.Add(this.lb_cauhoi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CauHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CauHoi_FormClosed);
            this.Load += new System.EventHandler(this.CauHoi_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CauHoi_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_cauhoi;
		private System.Windows.Forms.RadioButton rad_A;
		private System.Windows.Forms.RadioButton rad_B;
		private System.Windows.Forms.RadioButton rad_C;
		private System.Windows.Forms.RadioButton rad_D;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}