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

        Image MusicOn = Properties.Resources.music_ico;
        Image MusicOff = Properties.Resources.music_ico_n;
        private void btnNhacNen_Click(object sender, EventArgs e)
        {
            if(flagNhacNen) 
            {
                flagNhacNen=false;
                btnNhacNen.BackgroundImage = MusicOff;
                player.settings.volume = 0;

            }
            else
            {
                flagNhacNen = true;
                btnNhacNen.BackgroundImage= MusicOn;
                player.settings.volume = 60;

            }
        }

        Image AmthanhOn = Properties.Resources.DauTich;
        Image AmthanhOff = Properties.Resources.white_backgound;
        private void btnAmThanh_Click(object sender, EventArgs e)
        {
            if (flagAmThanh)
            {
                flagAmThanh=false;
                btnAmThanh.BackgroundImage = SoundOff;
            }
            else
            {
                flagAmThanh = true;
                btnAmThanh.BackgroundImage = SoundOn;
            }
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void btnBoCuoc_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        public bool SendSoundEffect()
        {
            return flagAmThanh;
        }

    }
}
