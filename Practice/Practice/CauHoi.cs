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
    public partial class CauHoi : Form
    {
        int i;
        List<CauHoiBus> list = CauHoiBus.LayDSCauHoi(1,1);
        public CauHoi()
        {
            InitializeComponent();
        }

        private void CauHoi_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.Background2,0,0);
        }
        private void CauHoi_Load(object sender, EventArgs e)
        {
            Random rd = new Random();
            i = rd.Next(0, list.Count);
            lb_cauhoi.Text = list[i].noidung;
            rad_A.Text = list[i].dapan1;
            rad_B.Text = list[i].dapan2;
            rad_C.Text = list[i].dapan3;
            rad_D.Text = list[i].dapan4;
        }

        private void btnTraloi_Click(object sender, EventArgs e)
        {
            if ((rad_A.Checked & list[i].dapan == "A") || (rad_B.Checked & list[i].dapan == "B") || (rad_C.Checked & list[i].dapan == "C") || (rad_D.Checked & list[i].dapan == "D"))
            {
                Mario.x.diem++;
                Mario.x.mang += 1;
                MessageBox.Show("Bạn trả lời đúng rồi.");
            }
            else
            {
                MessageBox.Show("Bạn trả lời sai rồi");
            }
            this.Close();
        }

        private void CauHoi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mario.x.mang--;
        }
    }
}
