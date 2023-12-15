using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Practice
{
    public partial class CauHoi : Form
    {
        int i;
        List<CauHoiBus> list = CauHoiBus.LayDSCauHoi(1);
        SoundPlayer pikaClick_Sound = new SoundPlayer("Pikachu_SE.wav");
        Random rd = new Random();


        Image background = Properties.Resources.question_background1;
        public CauHoi()
        {
            InitializeComponent();
            BackgroundImage = SetImageOpacity(background, 0.3F);

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
        private void CauHoi_Paint(object sender, PaintEventArgs e)
        {
         //   e.Graphics.DrawImage(Properties.Resources.question_background1,0,0);
        }
        private void CauHoi_Load(object sender, EventArgs e)
        {
            i = rd.Next(0, list.Count);
            lb_cauhoi.Text = list[i].noidung;
            rad_A.Text = list[i].dapan1;
            rad_B.Text = list[i].dapan2;
            rad_C.Text = list[i].dapan3;
            rad_D.Text = list[i].dapan4;
        }

        private void btnTraloi_Click(object sender, EventArgs e)
        {
            pikaClick_Sound.Play();
            SystemSounds.Question.Play();
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

        private void rad_A_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
