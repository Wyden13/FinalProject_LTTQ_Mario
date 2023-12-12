namespace Practice
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
            this.btnTraloi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_cauhoi
            // 
            this.lb_cauhoi.BackColor = System.Drawing.Color.White;
            this.lb_cauhoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_cauhoi.Font = new System.Drawing.Font("Wide Latin", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cauhoi.Location = new System.Drawing.Point(0, 0);
            this.lb_cauhoi.Name = "lb_cauhoi";
            this.lb_cauhoi.Size = new System.Drawing.Size(719, 106);
            this.lb_cauhoi.TabIndex = 0;
            this.lb_cauhoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rad_A
            // 
            this.rad_A.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad_A.AutoSize = true;
            this.rad_A.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_A.Location = new System.Drawing.Point(54, 138);
            this.rad_A.Name = "rad_A";
            this.rad_A.Size = new System.Drawing.Size(146, 30);
            this.rad_A.TabIndex = 1;
            this.rad_A.Text = "radioButton1";
            this.rad_A.UseVisualStyleBackColor = true;
            // 
            // rad_B
            // 
            this.rad_B.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad_B.AutoSize = true;
            this.rad_B.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_B.Location = new System.Drawing.Point(54, 180);
            this.rad_B.Name = "rad_B";
            this.rad_B.Size = new System.Drawing.Size(146, 30);
            this.rad_B.TabIndex = 2;
            this.rad_B.Text = "radioButton2";
            this.rad_B.UseVisualStyleBackColor = true;
            // 
            // rad_C
            // 
            this.rad_C.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad_C.AutoSize = true;
            this.rad_C.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_C.Location = new System.Drawing.Point(54, 222);
            this.rad_C.Name = "rad_C";
            this.rad_C.Size = new System.Drawing.Size(146, 30);
            this.rad_C.TabIndex = 3;
            this.rad_C.Text = "radioButton3";
            this.rad_C.UseVisualStyleBackColor = true;
            // 
            // rad_D
            // 
            this.rad_D.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad_D.AutoSize = true;
            this.rad_D.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_D.Location = new System.Drawing.Point(54, 264);
            this.rad_D.Name = "rad_D";
            this.rad_D.Size = new System.Drawing.Size(146, 30);
            this.rad_D.TabIndex = 4;
            this.rad_D.Text = "radioButton4";
            this.rad_D.UseVisualStyleBackColor = true;
            // 
            // btnTraloi
            // 
            this.btnTraloi.BackColor = System.Drawing.Color.LawnGreen;
            this.btnTraloi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTraloi.Font = new System.Drawing.Font("Snap ITC", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraloi.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnTraloi.Location = new System.Drawing.Point(273, 299);
            this.btnTraloi.Name = "btnTraloi";
            this.btnTraloi.Size = new System.Drawing.Size(137, 39);
            this.btnTraloi.TabIndex = 5;
            this.btnTraloi.Text = "Trả lời";
            this.btnTraloi.UseVisualStyleBackColor = false;
            this.btnTraloi.Click += new System.EventHandler(this.btnTraloi_Click);
            // 
            // CauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 367);
            this.Controls.Add(this.btnTraloi);
            this.Controls.Add(this.rad_D);
            this.Controls.Add(this.rad_C);
            this.Controls.Add(this.rad_B);
            this.Controls.Add(this.rad_A);
            this.Controls.Add(this.lb_cauhoi);
            this.Name = "CauHoi";
            this.Text = "CauHoi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CauHoi_FormClosed);
            this.Load += new System.EventHandler(this.CauHoi_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CauHoi_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_cauhoi;
        private System.Windows.Forms.RadioButton rad_A;
        private System.Windows.Forms.RadioButton rad_B;
        private System.Windows.Forms.RadioButton rad_C;
        private System.Windows.Forms.RadioButton rad_D;
        private System.Windows.Forms.Button btnTraloi;
    }
}