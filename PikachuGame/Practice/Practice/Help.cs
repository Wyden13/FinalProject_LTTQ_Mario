using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Xin chào người chơi đáng yêu của tựa game đến từ FTM," +
                            " \r\n\r\nVì là một đội ngũ còn thiếu kinh nghiệm nên chúng tôi mong nhận được sự thông cảm của bạn nếu có vấn đề trong quá trình trải nghiệm sản phẩm." +
                            "\r\n\r\nBạn đang cần trợ giúp đúng không?" +
                            "\r\nCó thể đã có sai xót xảy ra trong quá trình vận hành trò chơi, hay bạn đang có thắc mắc cần giải đáp, dù là gì thì xin hãy liên hệ với chúng tôi qua các emails sau đây:" +
                            "\r\n\r\n22521505@gm.uit.edu.vn (Trân)" +
                            "\r\n22521717@gm.uit.edu.vn (Yến)" +
                            "\r\n22521642@gm.uit.edu.vn (Uyên)" +
                            "\r\n\r\nChúng tôi sẽ hỗ trợ giải quyết vấn đề của bạn nhanh nhất có thể." +
                            "\r\n\r\nTrân trọng,\r\nFTM.";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
