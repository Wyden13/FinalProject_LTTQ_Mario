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
    public partial class Menu : Form
    {
        bool flagNhacNen = true;
        bool flagAmThanh=true;
        public Menu()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNhacNen_Click(object sender, EventArgs e)
        {
            if(flagNhacNen)
            {
                btnNhacNen.BackgroundImage = null;
                flagNhacNen=false;
            }
            else
            {
                btnNhacNen.BackgroundImage = Properties.Resources.DauTich;
            }    
        }

        private void btnAmThanh_Click(object sender, EventArgs e)
        {
            if (flagAmThanh)
            {
                btnAmThanh.BackgroundImage = null;
                flagAmThanh=false;
            }
            else
            {
                btnAmThanh.BackgroundImage = Properties.Resources.DauTich;
            }
        }

        private void btnKyLuc_Click(object sender, EventArgs e)
        {

        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {

        }

        private void btnBoCuoc_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
