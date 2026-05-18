using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class KR : Form
    {
        public KR()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
                return;
            }

            double tongMoi = 0;

            if (cbCaoVoi.Checked) tongMoi += 100000;
            if (cbTayTrang.Checked) tongMoi += 1200000;
            if (cbChupHinh.Checked) tongMoi += 150000;
            if (cbLayCao.Checked) tongMoi += 100000;
            
            if (numHanRang.Value > 0 )
            {
                tongMoi += (double)numHanRang.Value * 90000;
            }
            
            txtTong.Text = tongMoi.ToString("N0");
        }

        private void lbBangGia_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cbLayCao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbChupHinh_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbHanRang_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbHR_Click(object sender, EventArgs e)
        {

        }

        private void txtTong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
