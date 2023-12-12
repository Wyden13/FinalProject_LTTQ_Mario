namespace Practice
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAmThanh = new System.Windows.Forms.Button();
            this.btnNhacNen = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnTroGiup = new System.Windows.Forms.Button();
            this.btnBoCuoc = new System.Windows.Forms.Button();
            this.btnKyLuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(165, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 59);
            this.label1.TabIndex = 12;
            this.label1.Text = "STM Setting";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Practice.Properties.Resources.AmThanh;
            this.pictureBox2.Location = new System.Drawing.Point(111, 275);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Practice.Properties.Resources.NhacNen;
            this.pictureBox1.Location = new System.Drawing.Point(111, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnAmThanh
            // 
            this.btnAmThanh.BackColor = System.Drawing.Color.White;
            this.btnAmThanh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAmThanh.BackgroundImage")));
            this.btnAmThanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAmThanh.Location = new System.Drawing.Point(48, 287);
            this.btnAmThanh.Name = "btnAmThanh";
            this.btnAmThanh.Size = new System.Drawing.Size(46, 43);
            this.btnAmThanh.TabIndex = 9;
            this.btnAmThanh.UseVisualStyleBackColor = false;
            this.btnAmThanh.Click += new System.EventHandler(this.btnAmThanh_Click);
            // 
            // btnNhacNen
            // 
            this.btnNhacNen.BackColor = System.Drawing.Color.White;
            this.btnNhacNen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNhacNen.BackgroundImage")));
            this.btnNhacNen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNhacNen.Location = new System.Drawing.Point(48, 188);
            this.btnNhacNen.Name = "btnNhacNen";
            this.btnNhacNen.Size = new System.Drawing.Size(46, 43);
            this.btnNhacNen.TabIndex = 8;
            this.btnNhacNen.UseVisualStyleBackColor = false;
            this.btnNhacNen.Click += new System.EventHandler(this.btnNhacNen_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.White;
            this.btnQuayLai.BackgroundImage = global::Practice.Properties.Resources.QuayLai;
            this.btnQuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(463, 179);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(76, 64);
            this.btnQuayLai.TabIndex = 7;
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnTroGiup
            // 
            this.btnTroGiup.BackColor = System.Drawing.Color.White;
            this.btnTroGiup.BackgroundImage = global::Practice.Properties.Resources.Help;
            this.btnTroGiup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTroGiup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroGiup.Location = new System.Drawing.Point(284, 275);
            this.btnTroGiup.Name = "btnTroGiup";
            this.btnTroGiup.Size = new System.Drawing.Size(73, 61);
            this.btnTroGiup.TabIndex = 6;
            this.btnTroGiup.UseVisualStyleBackColor = false;
            this.btnTroGiup.Click += new System.EventHandler(this.btnTroGiup_Click);
            // 
            // btnBoCuoc
            // 
            this.btnBoCuoc.BackColor = System.Drawing.Color.White;
            this.btnBoCuoc.BackgroundImage = global::Practice.Properties.Resources.BoCuoc;
            this.btnBoCuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBoCuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoCuoc.Location = new System.Drawing.Point(463, 275);
            this.btnBoCuoc.Name = "btnBoCuoc";
            this.btnBoCuoc.Size = new System.Drawing.Size(76, 61);
            this.btnBoCuoc.TabIndex = 5;
            this.btnBoCuoc.UseVisualStyleBackColor = false;
            this.btnBoCuoc.Click += new System.EventHandler(this.btnBoCuoc_Click);
            // 
            // btnKyLuc
            // 
            this.btnKyLuc.BackColor = System.Drawing.Color.White;
            this.btnKyLuc.BackgroundImage = global::Practice.Properties.Resources.Ky_Luc;
            this.btnKyLuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKyLuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKyLuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKyLuc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKyLuc.Location = new System.Drawing.Point(284, 174);
            this.btnKyLuc.MinimumSize = new System.Drawing.Size(2, 2);
            this.btnKyLuc.Name = "btnKyLuc";
            this.btnKyLuc.Size = new System.Drawing.Size(73, 64);
            this.btnKyLuc.TabIndex = 3;
            this.btnKyLuc.UseVisualStyleBackColor = false;
            this.btnKyLuc.Click += new System.EventHandler(this.btnKyLuc_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(598, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAmThanh);
            this.Controls.Add(this.btnNhacNen);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnTroGiup);
            this.Controls.Add(this.btnBoCuoc);
            this.Controls.Add(this.btnKyLuc);
            this.Name = "Menu";
            this.Text = "Setting";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKyLuc;
        private System.Windows.Forms.Button btnBoCuoc;
        private System.Windows.Forms.Button btnTroGiup;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnNhacNen;
        private System.Windows.Forms.Button btnAmThanh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}