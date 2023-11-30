
namespace GameMario
{
	partial class BatDau
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.cmb_lop = new System.Windows.Forms.ComboBox();
			this.cmb_mon = new System.Windows.Forms.ComboBox();
			this.lb_title = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::GameMario.Properties.Resources.mariodichuyen;
			this.pictureBox1.Location = new System.Drawing.Point(71, 210);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(90, 73);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = global::GameMario.Properties.Resources.qua;
			this.pictureBox2.Location = new System.Drawing.Point(662, 225);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(58, 58);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// cmb_lop
			// 
			this.cmb_lop.FormattingEnabled = true;
			this.cmb_lop.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
			this.cmb_lop.Location = new System.Drawing.Point(350, 99);
			this.cmb_lop.Name = "cmb_lop";
			this.cmb_lop.Size = new System.Drawing.Size(94, 21);
			this.cmb_lop.TabIndex = 2;
			this.cmb_lop.Text = "1";
			// 
			// cmb_mon
			// 
			this.cmb_mon.FormattingEnabled = true;
			this.cmb_mon.Location = new System.Drawing.Point(350, 147);
			this.cmb_mon.Name = "cmb_mon";
			this.cmb_mon.Size = new System.Drawing.Size(159, 21);
			this.cmb_mon.TabIndex = 3;
			this.cmb_mon.Click += new System.EventHandler(this.comboBox2_Click);
			// 
			// lb_title
			// 
			this.lb_title.BackColor = System.Drawing.Color.Transparent;
			this.lb_title.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_title.Location = new System.Drawing.Point(63, 9);
			this.lb_title.Name = "lb_title";
			this.lb_title.Size = new System.Drawing.Size(612, 71);
			this.lb_title.TabIndex = 4;
			this.lb_title.Text = "PIKACHU DAU DAT";
			this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(262, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Chọn lớp:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(262, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Chọn môn học:";
			// 
			// button1
			// 
			this.button1.Image = global::GameMario.Properties.Resources.start1;
			this.button1.Location = new System.Drawing.Point(291, 199);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(247, 84);
			this.button1.TabIndex = 7;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// BatDau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(768, 307);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lb_title);
			this.Controls.Add(this.cmb_mon);
			this.Controls.Add(this.cmb_lop);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BatDau";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BatDau";
			this.Load += new System.EventHandler(this.BatDau_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.BatDau_Paint);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ComboBox cmb_lop;
		private System.Windows.Forms.ComboBox cmb_mon;
		private System.Windows.Forms.Label lb_title;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer timer1;
	}
}