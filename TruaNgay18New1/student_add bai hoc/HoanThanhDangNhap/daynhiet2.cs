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
    public partial class daynhiet2 : Form
    {
        public daynhiet2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            daynhiet3 f = new daynhiet3();
            f.ShowDialog();
        }
    }
}
