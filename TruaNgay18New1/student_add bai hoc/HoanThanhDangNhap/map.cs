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
    public partial class map : Form
    {
        public map()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            map1 f = new map1();
            this.Hide();
            f.ShowDialog();
        }

        private void map_FormClosed(object sender, FormClosedEventArgs e)
        {
            formkt f = new formkt();
            this.Hide();
            f.ShowDialog();
        }
    }
}
