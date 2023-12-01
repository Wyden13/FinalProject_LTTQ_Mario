﻿using Practice.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void BatDau_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.nentroi1,0,0);
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
            cmb_mon.Items.Clear();
            List<MonBus> list = MonBus.LayDSMon();
            foreach (MonBus item in list)
            {
                cmb_mon.Items.Add(item);
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            MonBus bus = cmb_mon.SelectedItem as MonBus;
            Mario.x = new nguoichoi(/*Convert.ToInt32(cmb_lop.SelectedItem.ToString()),*/ Convert.ToInt32(bus.id));
            Form1 frm = new Form1();
            frm.ShowDialog();
            Close();
        }
    }
}