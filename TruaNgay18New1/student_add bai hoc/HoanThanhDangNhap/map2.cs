﻿using System;
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
    public partial class map2 : Form
    {
        public map2()
        {
            
            InitializeComponent();
            //  btNext.Visible = false;
            SetQuestion("Câu 4: Kiểm tra tín hiệu VG khi kết nối cảm biến.\r\n");
            SetQuestion1("...........................");
            exitsetting();
        }

        void exitsetting()
        {
            ControlBox = false;
        }
        private void SetQuestion(string question)
        {
            lbCauhoi.Text = question; // Đặt nội dung câu hỏi cho Label
        }
        private void SetQuestion1(string question)
        {
            label1.Text = question; // Đặt nội dung câu hỏi cho Label
        }
        private void map2_FormClosed(object sender, FormClosedEventArgs e)
        {
            formkt formkt = new formkt();
            this.Hide();
            formkt.ShowDialog();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            this.Close();
           // map f = new map();
          //  this.Hide();
          //  f.ShowDialog();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            map1 f = new map1();
             this.Hide();
              f.ShowDialog();
        }

        private void btcheck_Click(object sender, EventArgs e)
        {

        }
    }
}
