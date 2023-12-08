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
    public partial class formThuchanh2 : Form
    {
        int i = 1;
        public formThuchanh2()
        {
            InitializeComponent();
            groupBox1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                textBox1.Text = "Toi bi ngu";

                i++;
            }else if (i == 2)
            {
                textBox1.Text = "Toi bi ngu 2";
                i++;
            }else if (i == 3)
            {
                //textBox1.Visible = false;
                groupBox1.Visible = true;
                
            }
          
        }

        
    }
}
