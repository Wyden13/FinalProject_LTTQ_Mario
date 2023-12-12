using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        int Diem = 10;
        int b1 = 0, b2 = 1140;
        bool right, hold = true;
        PictureBox c = null;
        PictureBox d=null;
        Random random = new Random();
        BatDau batDau = new BatDau();
        Size size = new Size();
        Rectangle rectangle1 = new Rectangle();
        Rectangle rectangle2 = new Rectangle();
        public Form1()
        {
            InitializeComponent();
            batDau.Close();
            this.DoubleBuffered = true;
            label3.Visible=false;
            btnRestart.Visible=false;
            btnGiveUp.Visible=false;
            timer1.Interval=2;
        }
        public void GanThongTin(string TenDN)
        {
            player.BringToFront();
            lblTenDN.BringToFront();
            lblTenDN.Text = TenDN;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            size = this.ClientSize;
            rectangle1.Y = 0;
            rectangle1.Size = size;
            rectangle2.Y = 0;
            rectangle2.Size = size;
        }
        class vatcan
        {
            public int speed = 1000;
            PictureBox cauhoi = new PictureBox();
            PictureBox Bongma= new PictureBox();
            Timer bullet_movement = new Timer();
            public int vatcan_top;
            public int vatcan_left;

            public PictureBox GetVatCan(Form frm)
            {
                cauhoi.Size = new Size(80, 80);
                cauhoi.SizeMode = PictureBoxSizeMode.Zoom;
                cauhoi.Image = Properties.Resources.cau_pokemon;
                cauhoi.BackColor = Color.Transparent;
                cauhoi.Left = vatcan_left;
                cauhoi.Top = vatcan_top;
                frm.Controls.Add(cauhoi);
                bullet_movement.Interval = speed;
                bullet_movement.Tick += new EventHandler(bullet_movement_tick);
                bullet_movement.Start();
                return cauhoi;
            }
            public PictureBox BongMa(Form frm)
            {
                Bongma.Size = new Size(110, 110);
                Bongma.SizeMode = PictureBoxSizeMode.Zoom;
                Bongma.Image = Properties.Resources.BongMa;
                Bongma.BackColor = Color.Transparent;
                Bongma.Location = new Point(800, 500);
                Bongma.Left = vatcan_left;
                Bongma.Top = vatcan_top;
                frm.Controls.Add(Bongma);
                bullet_movement.Interval = speed;
                bullet_movement.Tick += new EventHandler(bullet_movement_tick);
                bullet_movement.Start();
                return Bongma;
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
            vc.vatcan_left = 1000;
            vc.vatcan_top = player.Top;
            return vc.GetVatCan(this);
        }
        private PictureBox khoitaoBongMa()
        {
            vatcan vc = new vatcan();
            vc.vatcan_left = 1000;
            vc.vatcan_top = player.Top;
            return vc.BongMa(this);
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
                lblTenDN.Top=400;
                player.Top = 400;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                lblTenDN.Top=525;
                player.Top = 525;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = false;
                hold = true;
            }
        }
        private void dichuyen(PictureBox c)// di chuyển vật cản
        {
            if (right && c != null)
            {
                c.Left -= 25;
            } 
        }
        private void HienDiem()
        {
            label1.Text = "Score: " + Mario.x.diem;
            if (Mario.x.diem > Diem)
            {
                timer1.Interval += 1000;
                Diem += 10;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index1 >= 60)
            {
                c = khoitaoQuaCau();
                index1 = 0;
            }
            if(index2>=100)
            {
                
                d = khoitaoBongMa();
                index2 = 0;
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
                    index1 = 0;
                }
                    
            }
            if(d!=null)
            {

                if (d.Bounds.IntersectsWith(player.Bounds))
                {
                    this.Controls.Remove(d);
                    d.Dispose();
                    d = null;
                    right = false;
                    Mario.x.mang--;
                    index1 = 0;
                }
                dichuyen(d); 
                if (d!=null&&d.Left<=0)
                    {
                        this.Controls.Remove(d);
                        d.Dispose();
                        d = null;
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
            dichuyen(c);
            
        }
        
        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            batDau.Show();
            this.Close();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            rectangle1.X= b1;
            rectangle2.X= b2;
            e.Graphics.DrawImage(Properties.Resources.Background1, rectangle1);
            e.Graphics.DrawImage(Properties.Resources.Background2, rectangle2);
        }
        private void Background_move()
        {
            if (b1 < -1140)
            {
                b1 = 1145;
            }
            if (right)
            {
                b1 -= 25;
                b2 -= 25;
                index1++;// khoảng cách để hiển thị câu hỏi
                index2++;
            }
            if (b2 < -1140)
            {
                b2 = 1145;
            }
            Invalidate();
        }
    }
}
