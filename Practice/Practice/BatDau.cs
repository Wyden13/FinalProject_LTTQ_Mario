using Practice.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class BatDau : Form
    {
        public BatDau()
        {
            InitializeComponent();
        }
        private void Doimau()
        {
            Random rd= new Random();
            label3.ForeColor=Color.FromArgb(rd.Next(0,255),rd.Next(0,255),rd.Next(0,256));
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Doimau();
        }
        private void cmb_mon_Click(object sender, EventArgs e)
        {
            cmb_mon.Text = "";
            cmb_mon_SelectedIndexChanged(sender, e);
            cmb_mon.Items.Clear();
            MonBus bus = new MonBus();
            bus.Ten = "Tất cả các môn";
            bus.id = 0;
            cmb_mon.Items.Add(bus);
            List<MonBus> list = MonBus.LayDSMon();
            foreach (MonBus item in list)
            {
                cmb_mon.Items.Add(item);
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDN.Text) || txtTenDN.Text == "Nhập tên" || cmb_mon.Text == "Chọn môn học")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            else
            {
                MonBus bus = cmb_mon.SelectedItem as MonBus; 
                Mario.x = new nguoichoi(/*Convert.ToInt32(cmb_lop.SelectedItem.ToString()),*/ Convert.ToInt32(bus.id));
                Form1 frm = new Form1();
                frm.GanThongTin(txtTenDN.Text);
                frm.ShowDialog();
                this.Close();
            }
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            DialogResult ret= menu.ShowDialog();
            if(ret==DialogResult.OK)
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

        private void btnMaxscore_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }
    }
}
