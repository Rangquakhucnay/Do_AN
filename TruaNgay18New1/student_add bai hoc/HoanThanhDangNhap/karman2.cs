using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoanThanhDangNhap
{
    public partial class karman2 : Form
    {
        public karman2()
        {
            InitializeComponent();
            SetQuestion("Câu 2: Đo điện trở cảm biến ở chân THA theo nhiệt độ môi trường\r\nYêu cầu: Ngắt kết nối cảm biến khỏi bảng mạch, tiến hành đo điện trở, \r\nsau đó kết nối lại bảng mạch và chọn Tiếp theo.\r\n");
        }
        private void SetQuestion(string question)
        {
            lbCauhoi.Text = question; // Đặt nội dung câu hỏi cho Label
        }

        private void btcheck_Click(object sender, EventArgs e)
        {

        }

        private void btNext_Click(object sender, EventArgs e)
        {   karman3 f = new karman3();
            this.Hide();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            karman1 f = new karman1();
            this.Hide();
            f.ShowDialog();
        }

        private void karman2_FormClosed(object sender, FormClosedEventArgs e)
        {
            formkt f = new formkt();
            this.Hide();
            f.ShowDialog();
        }
    } 

}
