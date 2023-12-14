using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMario
{
    public partial class Menu : Form
    {
        bool notMusSound = false;
        public Menu()
        {
            InitializeComponent();
            bool notMusSound = false;

        }
        /*class ImageTransparency
        {
            public static Bitmap ChangeOpacity(Image img, float opacityvalue)
            {
                Bitmap bmp = new Bitmap(img.Width, img.Height); // Determining Width and Height of Source Image
                Graphics graphics = Graphics.FromImage(bmp);
                ColorMatrix colormatrix = new ColorMatrix();
                colormatrix.Matrix33 = opacityvalue;
                ImageAttributes imgAttribute = new ImageAttributes();
                imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
                graphics.Dispose();   // Releasing all resource used by graphics 
                return bmp;
            }
        }*/
        public Image SetImageOpacity(Image image,float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix= new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix,ColorMatrixFlag.Default,ColorAdjustType.Bitmap);
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),0,0,image.Width,image.Height,GraphicsUnit.Pixel,attributes);
            }
            return bmp;
        }
        Image background = Properties.Resources.menu_background;
        private void Menu_Load(object sender, EventArgs e)
        {
            BackgroundImage = SetImageOpacity(background, 0.1F);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        
        Image SoundOff = Properties.Resources.music_n;
        Image SoundOn = Properties.Resources.music_y;
        private void button1_Click(object sender, EventArgs e)
        {
            if (notMusSound == false)
                notMusSound = true;
            else
                notMusSound = false;
        }

        private void button1_BackgroundImageChanged(object sender, EventArgs e)
        {
            if(notMusSound==false)
            {
                button1.BackgroundImage = SoundOn;
            }
            else
                button1.BackgroundImage= SoundOff;
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason==CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();

            }
        }
    }
}
