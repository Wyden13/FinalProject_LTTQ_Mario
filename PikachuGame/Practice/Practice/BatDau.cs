using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using WMPLib;

namespace Practice
{
    public partial class BatDau : Form
    {

        /*  WindowsMediaPlayer player = new WindowsMediaPlayer();
          const string path = "YOASOBIBiri-Biri Official Music Video.mp3";*/
        System.Media.SoundPlayer pikaClick_Sound = new System.Media.SoundPlayer("Pikachu_SE.wav");
        Menu menu;
        public BatDau()
        {
            InitializeComponent();
            panel1.BackgroundImage = SetImageOpacity(panel1.BackgroundImage, 0.7F);
            menu = new Menu();
            pikaClick_Sound.Stream = Practice.Properties.Resources.Pikachu_SE;

            if (cmb_mon.Items.Count <= 0)
            {
                List<MonBus> list = MonBus.LayDSMon();
                foreach (MonBus item in list)
                {
                    cmb_mon.Items.Add(item);
                }
            }

        }
        private void doimau()
        {
            Random rd = new Random();
            lb_title.ForeColor = Color.FromArgb(rd.Next(0, 256), rd.Next(0, 256), rd.Next(0, 256));
            lb_title.ForeColor = Color.FromArgb(rd.Next(0, 256), rd.Next(0, 256), rd.Next(0, 256));
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            doimau();
        }
        private void cmb_mon_Click(object sender, EventArgs e)
        {
            cmb_mon.Text = "";
            cmb_mon_SelectedIndexChanged(sender, e);
            cmb_mon.Items.Clear();
            List<MonBus> list = MonBus.LayDSMon();
            foreach (MonBus item in list)
            {
                cmb_mon.Items.Add(item);
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {

            if(menu.SendSoundEffect())
                pikaClick_Sound.Play();
            if (string.IsNullOrEmpty(txtTenDN.Text) || txtTenDN.Text == "Nhập tên" || cmb_mon.Text == "Chọn môn học")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            else
            {
                MonBus bus = cmb_mon.SelectedItem as MonBus; 
                Mario.x = new nguoichoi(Convert.ToInt32(bus.id));
                Form1 frm = new Form1(this);
                frm.GanThongTin(txtTenDN.Text);
                frm.ShowDialog();
                Controls.Remove(this);
                this.Close();


            }
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (menu.SendSoundEffect())
                pikaClick_Sound.Play();
            DialogResult ret= menu.ShowDialog();
            if (ret == DialogResult.OK)
                Close();
        }
        private void txtTenDN_Click(object sender, EventArgs e)
        {
            txtTenDN.Text = "";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTenDN_TextChanged(object sender, EventArgs e)
        {
            txtTenDN.ForeColor = Color.Black;
        }

        private void cmb_mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_mon.ForeColor = Color.Black;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (menu.SendSoundEffect())
                pikaClick_Sound.Play();
            Help help = new Help();
            help.ShowDialog();
        }

        private void BatDau_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }
    }
}
