using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form1 : Form
    {
        int index1 = 0;
        int index2 = 0;
        int diem = 10;
        int b1 = 0, b2 = 960;
        bool right, hold = true;
        bool jumping = false;
        int jumpSpeed = 20;
        PictureBox c = null;
        PictureBox ghost=null;
        Random rand = new Random();
        //BatDau batDau = new BatDau();
        //Size size = new Size();
        //Rectangle rectangle1 = new Rectangle();
        //Rectangle rectangle2 = new Rectangle();
        public Form1()
        {
            InitializeComponent();
            //batDau.Close();
            this.DoubleBuffered = true;
            label3.Visible=false;
            btnRestart.Visible=false;
            btnGiveUp.Visible=false;
            //timer1.Interval=2;
        }
        Image layer_1 = Properties.Resources.background1_960;
        Image layer_2 = Properties.Resources.background2_960;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //rectangle1.X = b1;
            //rectangle2.X = b2;
            e.Graphics.DrawImage(layer_1, b1,0);
            e.Graphics.DrawImage(layer_2, b2,0);
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
                index1++;// khoảng cách để hiển thị câu hỏi
                index2++;
            }
            if (b2 < -955)
            {
                b2 = 960;
            }
            Invalidate();
        }
        public void GanThongTin(string TenDN)
        {
            player.BringToFront();
            lblTenDN.BringToFront();
            lblTenDN.Text = TenDN;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /*size = this.ClientSize;
            rectangle1.Y = 0;
            rectangle1.Size = size;
            rectangle2.Y = 0;
            rectangle2.Size = size;*/
        }
        class bongma
        {
            public int speed = 100;
            PictureBox gengar = new PictureBox();
            Timer bongma_movement = new Timer();
            public int vatcan_top;
            public int vatcan_left;
            public PictureBox GetBongMa(Form frm)
            {
                gengar.Size = new Size(165, 117);
                gengar.SizeMode = PictureBoxSizeMode.Zoom;
                gengar.Image = Properties.Resources.BongMa;
                gengar.BackColor = Color.Transparent;
                gengar.Left = vatcan_left;
                gengar.Top = vatcan_top;
                frm.Controls.Add(gengar);
                bongma_movement.Interval = speed;
                bongma_movement.Tick += new EventHandler(bongma_movement_tick);
                bongma_movement.Start();
                return gengar;
            }
            private void bongma_movement_tick(object sender, EventArgs e)
            {
                if (gengar.Left < 0)
                {
                    bongma_movement.Stop();
                    bongma_movement.Dispose();
                    gengar.Dispose();
                    bongma_movement = null;
                    gengar = null;

                }

            }

        }
        class vatcan
        {
            public int speed = 100;
            PictureBox cauhoi = new PictureBox();
            PictureBox bongma= new PictureBox();
            Timer bullet_movement = new Timer();
            public int vatcan_top;
            public int vatcan_left;

            public PictureBox GetVatCan(Form frm)
            {
                cauhoi.Size = new Size(140, 117);
                cauhoi.SizeMode = PictureBoxSizeMode.Zoom;
                cauhoi.Image = Properties.Resources.pokeball_spinning;
                cauhoi.BackColor = Color.Transparent;
                cauhoi.Left = vatcan_left;
                cauhoi.Top = vatcan_top;
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
        private PictureBox khoitaoQuaCau()
        {
            vatcan vc = new vatcan();
            vc.vatcan_left = this.ClientSize.Width + rand.Next(0, 800) + player.Width;
            vc.vatcan_top = 400;
            return vc.GetVatCan(this);
        }
        private PictureBox khoitaoBongMa()
        {
           bongma vc = new bongma();
			vc.vatcan_left = this.ClientSize.Width + rand.Next(0, 600) + player.Width ;
			vc.vatcan_top = 400;
			return vc.GetBongMa(this);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right & hold)
            {
                hold = false;
                right = true;
                player.Image = Properties.Resources.pikachu;

            }
            if (e.KeyCode == Keys.Up)
            {
                player.Image = Properties.Resources.pikachu;
                lblTenDN.Top=280;
                player.Top = 280;

            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                player.Image = Properties.Resources.pikachu;
                lblTenDN.Top=424;
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
            if(right & ghost!=null)
            {
                ghost.Left -= 15;
            }
            
        }
        private void HienDiem()
        {
            label1.Text = "Score: " + Mario.x.diem;
           /* if (Mario.x.diem > diem)
            {
                timer1.Interval += 1000;
                diem += 10;
            }*/
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index1 >= 50)
            {
                c = khoitaoQuaCau();
                index1 = 0;
            }
            if (index2 >= 70)
            {
                ghost = khoitaoBongMa();
                index2 = 0;
            }
           /* while(c!= null && index2>=70)
            {   
                ghost = khoitaoBongMa();
                Rectangle b = c.Bounds;
                if(!ghost.Bounds.IntersectsWith(b))
                {
                    index2 = 0;
                    break;
                }
            }*/
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
                    index1 = 0;
                }
                
            }
            if(ghost!=null)
            {
                if (ghost.Bounds.IntersectsWith(player.Bounds))
                {
                    this.Controls.Remove(ghost);
                    ghost.Dispose();
                    ghost = null;
                    right = false;
                    Mario.x.mang--;
                    index2 = 0;
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
                label3.Visible = true;
                btnGiveUp.Visible = true;
                btnRestart.Visible = true;
                timer1.Stop();
            } 
            HienDiem();
            dichuyen();
            
        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //batDau.Show();
            this.Close();
        }

      
       
    }
}
