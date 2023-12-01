namespace Practice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatDau));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmb_lop = new System.Windows.Forms.ComboBox();
            this.cmb_mon = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Môn:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 59);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mario";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.cmb_lop.Location = new System.Drawing.Point(327, 110);
            this.cmb_lop.Name = "cmb_lop";
            this.cmb_lop.Size = new System.Drawing.Size(222, 24);
            this.cmb_lop.TabIndex = 9;
            // 
            // cmb_mon
            // 
            this.cmb_mon.FormattingEnabled = true;
            this.cmb_mon.Location = new System.Drawing.Point(327, 161);
            this.cmb_mon.Name = "cmb_mon";
            this.cmb_mon.Size = new System.Drawing.Size(222, 24);
            this.cmb_mon.TabIndex = 10;
            this.cmb_mon.Click += new System.EventHandler(this.cmb_mon_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Practice.Properties.Resources.cầu_pokemon;
            this.pictureBox2.Location = new System.Drawing.Point(717, 245);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(350, 245);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(142, 60);
            this.btnStart.TabIndex = 8;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Practice.Properties.Resources.pikachu;
            this.pictureBox1.Location = new System.Drawing.Point(48, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BatDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 345);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cmb_mon);
            this.Controls.Add(this.cmb_lop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BatDau";
            this.Text = "BatDau";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BatDau_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmb_lop;
        private System.Windows.Forms.ComboBox cmb_mon;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

