using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
		int index_point = 0;
		int b1 = 0, b2 = 960;
		PictureBox c=null;
		PictureBox ptn = null;
		bool right, hold = true;
		Random rand = new Random();
		int extra_point = 0;
		//private bool button1wasClicked = false;

        //SqlConnection conn = new SqlConnection("Data Source=WINLAPTOP\\MSSQLSERVER01;Initial Catalog=FTM;Integrated Security=True");
        public Form1()
		{
			InitializeComponent();			
			this.DoubleBuffered = true;

			GameReset();
			//this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			/*player.Image = Properties.Resources.pikachu_stand;
			label2.Visible = false;
			label3.Text = "Highest score:" + Mario.x.highest_score.ToString();*/
		}



        Image layer_1 = Properties.Resources.background1_960;
        Image layer_2 = Properties.Resources.background2_960;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(layer_1, b1, 0);
            e.Graphics.DrawImage(layer_2, b2, 0);

        }
        private void Background_move()
        {

            if (b1 < -955)
            {
                b1 = 960;
            }
            if (right)
            {
                b1 -= 15;
                b2 -= 15;
                index++;// khoảng cách để hiển thị câu hỏi
				index_point++;
			}
            if (b2 < -955)
            {
                b2 = 960;
            }
            Invalidate();
        }
		class pokeball
		{
            public int speed = 100;
            PictureBox point = new PictureBox();
            Timer bullet_movement = new Timer();
            public int pokeball_top;
            public int pokeball_left;

            public PictureBox GetPokeball()
            {
                //cauhoi.BackColor = Color.Aqua;
                point.Size = new Size(120, 120);
                point.SizeMode = PictureBoxSizeMode.StretchImage;
                point.Image = Properties.Resources.pokeball_spinning;
                point.BackColor = Color.Transparent;
				//point.Tag = "bullet";
				point.Left = pokeball_top;
				point.Top = pokeball_left;
                point.BringToFront();
                //frm.Controls.Add(point);
                /*bullet_movement.Interval = speed;
                bullet_movement.Tick += new EventHandler(bullet_movement_tick);
                bullet_movement.Start();*/
                return point;
            }

           /* private void bullet_movement_tick(object sender, EventArgs e)
            {
                if (point.Left < 0)
                {
                    bullet_movement.Stop();
                    bullet_movement.Dispose();
                    point.Dispose();
                    bullet_movement = null;
                    point = null;
                }
            }*/
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
				cauhoi.Size = new Size(165, 117);
			
				cauhoi.SizeMode = PictureBoxSizeMode.Zoom;
				cauhoi.Image = Properties.Resources.gengar;
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
			vc.vatcan_left = this.ClientSize.Width + rand.Next(0, 300) + player.Width ;
			//vc.vatcan_top = player.Top;
			vc.vatcan_top = 400;
			return vc.GetVatCan(this);
		}
        private PictureBox pokeball_khoitao()
        {
            pokeball point = new pokeball();
            point.pokeball_left = this.ClientSize.Width + rand.Next(0, 480) + player.Width;
			//vc.vatcan_top = player.Top;
			point.pokeball_top = player.Top;
            return point.GetPokeball();
        }
        private void Form1_Load(object sender, EventArgs e)
		{
			
		}
		

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Right & hold)
			{
				hold = false;
				right = true;
				player.Image = Properties.Resources.mariodichuyen;
			}
			if (e.KeyCode == Keys.Up)
			{   
				player.Image = Properties.Resources.mariodichuyen;
				player.Top = 280;

            }
        }


		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
                player.Image = Properties.Resources.mariodichuyen;
                player.Top = 424;

            }
            if (e.KeyCode == Keys.Right)
			{
				right = false;
				hold = true;
				player.Image = Properties.Resources.pikachu_stand;
			}
		
		}
		private void dichuyen()// di chuyển vật cản
		{
			if (right & c != null)
			{
				c.Left -= 15;
			}
			if(right & ptn !=null)
			{
				ptn.Left -= 15;
			}
		}
		private void HienDiem()
		{
			label1.Text = "Score: " + Mario.x.diem;
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (index >= 50)
			{
				c = khoitao();
				index = 0;
			}
			if(index_point >= 60)
			{
				ptn = pokeball_khoitao();
				index_point = 0;
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
                    player.Image = Properties.Resources.pikachu_stand;

                    CauHoi frm = new CauHoi();
					frm.Show();
					index = 0;
				}
			}
			if(ptn!=null)
			{
				if(ptn.Bounds.IntersectsWith(player.Bounds))
				{
					extra_point += 1;
					this.Controls.Remove(ptn);
					ptn.Dispose(); 
					ptn = null;
					label4.Text = "x " + extra_point;
					index_point = 0;
				}
			}
			if (Mario.x.mang == 2)
			{
				this.Controls.Remove(mang3);
				mang3 = null;
				//mang3.Visible = false;
			}
			else if (Mario.x.mang == 1)
			{
                this.Controls.Remove(mang2);
                mang2 = null;
                //mang2.Visible = false;

            }
            else if (Mario.x.mang == 0)
			{
                this.Controls.Remove(mang1);
				mang1 = null;
                //mang1.Visible = false;
                label2.Visible = true;
				button1.Visible = true;
				timer1.Stop();
               

			}
			HienDiem();
			if(Mario.x.diem > Mario.x.highest_score)
			{
				highestScore();
			}
			dichuyen();
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void highestScore()
        {
			label3.Text = "Highest score \n" + Mario.x.diem;
        }
		

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void button1_Click(object sender, EventArgs e)
        {
			//button1wasClicked = true;
			GameReset();
        }

        private void mang3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        
      
		private void GameReset()
		{

            bool button1wasClicked = false;

			int index = 0;

            int b1 = 0, b2 = 960;
            PictureBox c = null;
            bool right, hold = true;
			Mario.x.mang= 3;
			Mario.x.diem = 0;
			//timer1.Start();
            player.Image = Properties.Resources.pikachu_stand;
            label2.Visible = false;
            button1.Visible = false;
			mang1.Visible = true;
			mang2.Visible = true;
			mang3.Visible = true;
            //label3.Text = "Highest score:" + Mario.x.highest_score.ToString();
            //Random rand = new Random();
        }
	}
}
