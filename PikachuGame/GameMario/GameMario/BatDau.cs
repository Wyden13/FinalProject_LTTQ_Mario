using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using WMPLib;

namespace GameMario
{
	public partial class BatDau : Form
	{
		//System.Media.SoundPlayer player = new System.Media.SoundPlayer("YOASOBIBiri-Biri Official Music Video.mp3");
		WindowsMediaPlayer player = new WindowsMediaPlayer();
		const string path= "YOASOBIBiri-Biri Official Music Video.mp3";
        public BatDau()
		{
			InitializeComponent();

			player.URL = path;
			player.settings.setMode ("loop",true);
			player.controls.play();

            if (cmb_mon.Items.Count <= 0)
            {
                List<MonBus> list = MonBus.LayDSMon();
                foreach (MonBus item in list)
                {
                    cmb_mon.Items.Add(item);
                }
            }
        }
        

        private void BatDau_Paint(object sender, PaintEventArgs e)
		{  
			//this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//e.Graphics.DrawImage(Properties.Resources.pixel_art_background_5785, 0, 0);

        }

        private void BatDau_Load(object sender, EventArgs e)
		{
			
		}

		private void comboBox2_Click(object sender, EventArgs e)
		{
			/*if (cmb_mon.Items.Count <= 0)
			{
				List<MonBus> list = MonBus.LayDSMon();
				foreach (MonBus item in list)
				{
					cmb_mon.Items.Add(item);
				}
			}*/
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
		//SqlConnection conn = new SqlConnection("Data Source=WINLAPTOP\\MSSQLSERVER01;Initial Catalog=FTM;Integrated Security=True");	
		private void button1_Click(object sender, EventArgs e)
		{
			//conn.Open();
			if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(cmb_mon.Text))
			{
				MessageBox.Show("Nhap day du thong tin truoc khi bat dau !");
			} else
			{ 
				Mario.x = new nguoichoi(textBox1.Text, Convert.ToInt32((cmb_mon.SelectedItem as MonBus).id));
				Form1 frm = new Form1();
				frm.ShowDialog();
				if(frm.ShowDialog()==DialogResult.OK)
					{
						this.Hide();
					}
				else
					{
						Close();
					}
			}

		}

        private void lb_title_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
			Menu mn = new Menu();
			DialogResult res= mn.ShowDialog();
			if(res==DialogResult.OK)
			{
				Close();
			}
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
