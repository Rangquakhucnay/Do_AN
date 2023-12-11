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
    public partial class karman4 : Form
    {
        public karman4()
        {
            InitializeComponent();
            btNext.Visible = false;
            SetQuestion("Câu 3: Đo điện áp tín hiệu THA theo nhiệt độ môi trường.\r\n"); // Gọi phương thức SetQuestion và truyền nội dung câu hỏi
        }
        private void SetQuestion(string question)
        {
            lbCauhoi.Text = question; // Đặt nội dung câu hỏi cho Label
        }

        private void karman4_FormClosed(object sender, FormClosedEventArgs e)
        {
            formkt f = new formkt();
            this.Hide();
            f.ShowDialog();
        }

        private void btcheck_Click(object sender, EventArgs e)
        {
            string valueToCompare = "D.Lấy tín hiệu THA";
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
            karman5 f = new karman5();
            this.Hide();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            karman3 f = new karman3();
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
