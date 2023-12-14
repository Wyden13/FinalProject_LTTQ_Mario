<<<<<<< HEAD:GameMario/GameMario/Menu.Designer.cs
﻿namespace GameMario
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MusicSoundlbl = new System.Windows.Forms.Label();
            this.Achievlbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Helplbl = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Soundlbl = new System.Windows.Forms.Label();
            this.Soundbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Pixelify Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = global::GameMario.Properties.Resources.music_y;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(26, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 55);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.BackgroundImageChanged += new System.EventHandler(this.button1_BackgroundImageChanged);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MusicSoundlbl
            // 
            this.MusicSoundlbl.AutoSize = true;
            this.MusicSoundlbl.Font = new System.Drawing.Font("Pixelify Sans Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicSoundlbl.Location = new System.Drawing.Point(101, 122);
            this.MusicSoundlbl.Name = "MusicSoundlbl";
            this.MusicSoundlbl.Size = new System.Drawing.Size(182, 34);
            this.MusicSoundlbl.TabIndex = 2;
            this.MusicSoundlbl.Text = "Music Sound";
            // 
            // Achievlbl
            // 
            this.Achievlbl.AutoSize = true;
            this.Achievlbl.Font = new System.Drawing.Font("Pixelify Sans Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Achievlbl.Location = new System.Drawing.Point(495, 122);
            this.Achievlbl.Name = "Achievlbl";
            this.Achievlbl.Size = new System.Drawing.Size(192, 34);
            this.Achievlbl.TabIndex = 3;
            this.Achievlbl.Text = "Achievement";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::GameMario.Properties.Resources.goldcup;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(416, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 55);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Helplbl
            // 
            this.Helplbl.AutoSize = true;
            this.Helplbl.Font = new System.Drawing.Font("Pixelify Sans Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helplbl.Location = new System.Drawing.Point(495, 211);
            this.Helplbl.Name = "Helplbl";
            this.Helplbl.Size = new System.Drawing.Size(71, 34);
            this.Helplbl.TabIndex = 5;
            this.Helplbl.Text = "Help";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::GameMario.Properties.Resources.help_icon1;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(407, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 59);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Soundlbl
            // 
            this.Soundlbl.AutoSize = true;
            this.Soundlbl.Font = new System.Drawing.Font("Pixelify Sans Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soundlbl.Location = new System.Drawing.Point(105, 211);
            this.Soundlbl.Name = "Soundlbl";
            this.Soundlbl.Size = new System.Drawing.Size(98, 34);
            this.Soundlbl.TabIndex = 7;
            this.Soundlbl.Text = "Sound";
            // 
            // Soundbtn
            // 
            this.Soundbtn.BackgroundImage = global::GameMario.Properties.Resources.sound_icon;
            this.Soundbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Soundbtn.FlatAppearance.BorderSize = 0;
            this.Soundbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Soundbtn.Location = new System.Drawing.Point(38, 202);
            this.Soundbtn.Name = "Soundbtn";
            this.Soundbtn.Size = new System.Drawing.Size(61, 59);
            this.Soundbtn.TabIndex = 8;
            this.Soundbtn.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(726, 410);
            this.Controls.Add(this.Soundbtn);
            this.Controls.Add(this.Soundlbl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Helplbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Achievlbl);
            this.Controls.Add(this.MusicSoundlbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label MusicSoundlbl;
        private System.Windows.Forms.Label Achievlbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Helplbl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Soundlbl;
        private System.Windows.Forms.Button Soundbtn;
    }
=======
﻿namespace GameMario
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MusicSoundlbl = new System.Windows.Forms.Label();
            this.Achievlbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Helplbl = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Soundlbl = new System.Windows.Forms.Label();
            this.Soundbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Pixelify Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = global::GameMario.Properties.Resources.music_y;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(26, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 55);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.BackgroundImageChanged += new System.EventHandler(this.button1_BackgroundImageChanged);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MusicSoundlbl
            // 
            this.MusicSoundlbl.AutoSize = true;
            this.MusicSoundlbl.Font = new System.Drawing.Font("Pixelify Sans Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicSoundlbl.Location = new System.Drawing.Point(101, 122);
            this.MusicSoundlbl.Name = "MusicSoundlbl";
            this.MusicSoundlbl.Size = new System.Drawing.Size(182, 34);
            this.MusicSoundlbl.TabIndex = 2;
            this.MusicSoundlbl.Text = "Music Sound";
            // 
            // Achievlbl
            // 
            this.Achievlbl.AutoSize = true;
            this.Achievlbl.Font = new System.Drawing.Font("Pixelify Sans Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Achievlbl.Location = new System.Drawing.Point(495, 122);
            this.Achievlbl.Name = "Achievlbl";
            this.Achievlbl.Size = new System.Drawing.Size(192, 34);
            this.Achievlbl.TabIndex = 3;
            this.Achievlbl.Text = "Achievement";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::GameMario.Properties.Resources.goldcup;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(416, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 55);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Helplbl
            // 
            this.Helplbl.AutoSize = true;
            this.Helplbl.Font = new System.Drawing.Font("Pixelify Sans Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helplbl.Location = new System.Drawing.Point(495, 211);
            this.Helplbl.Name = "Helplbl";
            this.Helplbl.Size = new System.Drawing.Size(71, 34);
            this.Helplbl.TabIndex = 5;
            this.Helplbl.Text = "Help";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::GameMario.Properties.Resources.help_icon1;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(407, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 59);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Soundlbl
            // 
            this.Soundlbl.AutoSize = true;
            this.Soundlbl.Font = new System.Drawing.Font("Pixelify Sans Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soundlbl.Location = new System.Drawing.Point(105, 211);
            this.Soundlbl.Name = "Soundlbl";
            this.Soundlbl.Size = new System.Drawing.Size(98, 34);
            this.Soundlbl.TabIndex = 7;
            this.Soundlbl.Text = "Sound";
            // 
            // Soundbtn
            // 
            this.Soundbtn.BackgroundImage = global::GameMario.Properties.Resources.sound_icon;
            this.Soundbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Soundbtn.FlatAppearance.BorderSize = 0;
            this.Soundbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Soundbtn.Location = new System.Drawing.Point(38, 202);
            this.Soundbtn.Name = "Soundbtn";
            this.Soundbtn.Size = new System.Drawing.Size(61, 59);
            this.Soundbtn.TabIndex = 8;
            this.Soundbtn.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(726, 410);
            this.Controls.Add(this.Soundbtn);
            this.Controls.Add(this.Soundlbl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Helplbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Achievlbl);
            this.Controls.Add(this.MusicSoundlbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label MusicSoundlbl;
        private System.Windows.Forms.Label Achievlbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Helplbl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Soundlbl;
        private System.Windows.Forms.Button Soundbtn;
    }
>>>>>>> 061aa2bb68e35f8f1ca9690b87dcf623e192f233:PikachuGame/GameMario/GameMario/Menu.Designer.cs
}