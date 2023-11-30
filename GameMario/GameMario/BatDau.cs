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
	public partial class BatDau : Form
	{
		public BatDau()
		{
			InitializeComponent();
		}

		private void BatDau_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawImage(Properties.Resources.nentroi1, 0, 0);
		}

		private void BatDau_Load(object sender, EventArgs e)
		{

		}

		private void comboBox2_Click(object sender, EventArgs e)
		{
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
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			doimau();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Mario.x= new nguoichoi(Convert.ToInt32(cmb_lop.Text), Convert.ToInt32((cmb_mon.SelectedItem as MonBus).id));
			Form1 frm = new Form1();
			frm.ShowDialog();
		}
		
		
	}
}
