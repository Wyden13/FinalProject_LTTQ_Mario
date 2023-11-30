using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMario
{
	public partial class Form1 : Form
	{
		int index=0;
		int b1 = 0, b2 = 1280;
		PictureBox c=null;
		bool right, hold = true;
		public Form1()
		{
			InitializeComponent();
			this.DoubleBuffered = true;
			label2.Visible = false;
		}
		class vatcan
		{
			public int speed = 100;
			PictureBox cauhoi = new PictureBox();
			Timer bullet_movement = new Timer();
			public int vatcan_top;
			public int vatcan_left;

			public PictureBox GetVatCan(Form frm)
			{
				//cauhoi.BackColor = Color.Aqua;
				cauhoi.Size = new Size(80, 80);
				cauhoi.SizeMode = PictureBoxSizeMode.StretchImage;
				cauhoi.Image = Properties.Resources.qua;
				cauhoi.BackColor = Color.Transparent;
				cauhoi.Tag = "bullet";
				cauhoi.Left = vatcan_left;
				cauhoi.Top = vatcan_top;
				cauhoi.BringToFront();
				frm.Controls.Add(cauhoi);
				bullet_movement.Interval = speed;
				bullet_movement.Tick += new EventHandler(bullet_movement_tick);
				bullet_movement.Start();
				return cauhoi;
			}

			private void bullet_movement_tick(object sender, EventArgs e)
			{
				if (cauhoi.Left < 0)
				{
					bullet_movement.Stop();
					bullet_movement.Dispose();
					cauhoi.Dispose();
					bullet_movement = null;
					cauhoi = null;
				}
			}
		}
		private PictureBox khoitao()
		{
			vatcan vc = new vatcan();
			vc.vatcan_left = 1280;
			vc.vatcan_top = player.Top;
			return vc.GetVatCan(this);
		}
		private void Form1_Load(object sender, EventArgs e)
		{
		}
		

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Right)
			{
				hold = false;
				right = true;
			}
			if (e.KeyCode == Keys.Up)
			{
				player.Top = 490;
			}
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				player.Top = 544;
			}
			if (e.KeyCode == Keys.Right)
			{
				right = false;
				hold = true;
			}
		}
		private void dichuyen()// di chuyển vật cản
		{
			if (right & c != null)
			{
				c.Left -= 8;
			}
		}
		private void HienDiem()
		{
			label1.Text = "Score: " + Mario.x.diem;
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (index >= 50 & c == null)
			{
				c = khoitao();
				index = 0;
			}
			Background_move();
			if (c != null)
			{
				if (c.Bounds.IntersectsWith(player.Bounds))
				{
					this.Controls.Remove(c);
					c.Dispose();
					c = null;
					right = false;
					CauHoi frm = new CauHoi();
					frm.Show();
					index = 0;
				}
			}
			if (Mario.x.mang == 2)
			{
				this.Controls.Remove(mang3);
				mang3 = null;
			}
			else if (Mario.x.mang == 1)
			{
				this.Controls.Remove(mang2);
				mang2 = null;
			}
			else if (Mario.x.mang == 0)
			{
				this.Controls.Remove(mang1);
				mang1 = null;
				label2.Visible = true;
				timer1.Stop();
			}
			HienDiem();
			dichuyen();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawImage(Properties.Resources.nentroi, b1, 0);
			e.Graphics.DrawImage(Properties.Resources.nentroi, b2, 0);
		}
		private void Background_move()
		{
			if (b1 < -1275)
			{
				b1 = 1280;
			}
			if (right)
			{
				b1 -= 8;
				b2 -= 8;
				index++;// khoảng cách để hiển thị câu hỏi
			}
			if (b2 < -1275)
			{
				b2 = 1280;
			}
			Invalidate();
		}
	}
}
