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
    public partial class karman6 : Form
    {
        public karman6()
        {
            InitializeComponent();
            btNext.Visible = false;
            SetQuestion("   Câu 4: Kiểm tra tín hiệu KS khi thổi không khí qua bộ đo gió.\r\n");    
        }
        private void SetQuestion(string question)
        {
            lbCauhoi.Text = question; // Đặt nội dung câu hỏi cho Label
        }

        private void karman6_FormClosed(object sender, FormClosedEventArgs e)
        {
            formkt f = new formkt();
            this.Hide();
            f.ShowDialog();

        }

        private void btcheck_Click(object sender, EventArgs e)
        {
            string valueToCompare = "B. Lấy tín hiệu";
            List<string> selectedItems = new List<string>();

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                selectedItems.Add(checkedListBox1.CheckedItems[i].ToString());
            }

            if (selectedItems.Contains(valueToCompare))
            {
                MessageBox.Show("Đáp án Đúng.");
                btNext.Visible = true;
            }
            else
            {
                MessageBox.Show("Đáp án sai.vui lòng chọn lại!!! ");
                // btcheck.Visible = false ;
                // btNext.Visible = true ;
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            karman7 f = new karman7();
            this.Hide();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            karman5 f = new karman5();
            this.Hide();
            f.ShowDialog();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        { 
            // Đảm bảo rằng chỉ có một mục được chọn
            for (int i = 0; i < checkedListBox1.Items.Count; ++i)
            {
                if (i != e.Index)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }
    }
}
