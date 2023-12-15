using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Practice
{
    public partial class Menu : Form

    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        const string path = "YOASOBIBiri-Biri Official Music Video.mp3";
        SoundPlayer pikaClick_Sound = new SoundPlayer("Pikachu_SE.wav");
        bool flagNhacNen = true;
        bool flagAmThanh=true;
        Image background = Properties.Resources.menu_background;
        
        public Menu()
        {
            InitializeComponent();
            player.URL = path;
            player.settings.setMode("loop", true);
            player.controls.play();

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
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }
        Image SoundOff = Properties.Resources.music_n;
        Image SoundOn = Properties.Resources.music_y;
        private void btnNhacNen_Click(object sender, EventArgs e)
        {
            if(flagNhacNen) 
            {
                //btnNhacNen.BackgroundImage = null;
                flagNhacNen=false;
                btnNhacNen.BackgroundImage = SoundOff;
                player.settings.volume = 0;

            }
            else
            {
                //btnNhacNen.BackgroundImage = Properties.Resources.DauTich;
                flagNhacNen = true;
                btnNhacNen.BackgroundImage= SoundOn;
                player.settings.volume = 60;

            }
        }

        Image AmthanhOn = Properties.Resources.DauTich;
        Image AmthanhOff = Properties.Resources.white_backgound;
        //Image dautichOff = Properties.Resources;
        private void btnAmThanh_Click(object sender, EventArgs e)
        {
            if (flagAmThanh)
            {
                //btnAmThanh.BackgroundImage = null;
                flagAmThanh=false;
                btnAmThanh.BackgroundImage = AmthanhOff;
                //player.controls.pause();
            }
            else
            {
                //btnAmThanh.BackgroundImage = Properties.Resources.DauTich;
                flagAmThanh = true;
                btnAmThanh.BackgroundImage = AmthanhOn;
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

        private void Menu_Load(object sender, EventArgs e)
        {
           /* player.URL = path;
            player.settings.setMode("loop", true);
            player.controls.play();
*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        public bool SendData()
        {
            return flagAmThanh;
        }
        
        

        private void Menu_Paint(object sender, PaintEventArgs e)
        {
/*            e.Graphics.DrawImage(BackgroundImage, 0, 0);
*/        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
