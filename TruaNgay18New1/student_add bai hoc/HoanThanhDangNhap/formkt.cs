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
    public partial class formkt : Form
    {
        public formkt()
        {
            InitializeComponent();
        }

        

        private void btDaynhiet_Click(object sender, EventArgs e)
        {
            daynhiet1 k1 = new daynhiet1();
            this.Close();
            k1.ShowDialog();
        }

        private void btKarman_Click(object sender, EventArgs e)
        {
            karman f = new karman();
            this.Close();
            f.ShowDialog();
        }

        private void btMap_Click(object sender, EventArgs e)
        {
            map f = new map();
            this.Close( );
            f.ShowDialog();
        }

        private void btDelcodientu_Click(object sender, EventArgs e)
        {
            delcodientu f = new delcodientu();
              this.Close();
            f.ShowDialog();
        }

        private void btDelcohall_Click(object sender, EventArgs e)
        {
            delcohall f = new delcohall();
            this.Close(); 
            f.ShowDialog();
        }

        private void btTHW_Click(object sender, EventArgs e)
        {
           thw f = new thw();
            this.Close();
            f.ShowDialog();
        }

        private void btVTAtiepdiem_Click(object sender, EventArgs e)
        {
            vtatiepdiem f = new vtatiepdiem();
            this.Close();
            f.ShowDialog();
        }

        private void btVTAcoIDL_Click(object sender, EventArgs e)
        {
            VTAcoIDL f = new VTAcoIDL();
            this.Close();
            f.ShowDialog();
        }

        private void btVTAkoIDL_Click(object sender, EventArgs e)
        {
            VTAkhongIDL f = new VTAkhongIDL();
            this.Close();
            f.ShowDialog();
        }

        private void btVTAhall_Click(object sender, EventArgs e)
        {
           VTAhall f = new VTAhall();
            this.Close();
            f.ShowDialog();    
        }

        private void btVPAtuyentinh_Click(object sender, EventArgs e)
        {
            VPAtuyentinh f = new VPAtuyentinh();
            this.Close(); 
            f.ShowDialog();
        }

        private void formkt_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginStudent f = new LoginStudent();
            this.Close();
            f.ShowDialog();
        }

        private void btVPAhall_Click(object sender, EventArgs e)
        {
            VPAhall f = new VPAhall();
            this.Close();
            f.ShowDialog();
        }

       
    }
    }

