using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class SNT : Form
    {
        int n;
        public SNT()
        {
            InitializeComponent();
        }

        // SNT
        bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }

        // SCP
        bool IsSquare(int n)
        {
            if (n < 0) return false;
            int x = (int)Math.Sqrt(n);
            return x * x == n;
        }

        // SHC
        bool IsPerfect(int n)
        {
            if (n < 1) return false;
            int sum = 0;
            for (int i = 1; i < n; i++)
                if (n % i == 0) sum += i;
            return sum == n;
        }
        private void lbNhapSo_Click(object sender, EventArgs e)
        {

        }

        private void lbNT_Click(object sender, EventArgs e)
        {

        }

        private void SNT_Load(object sender, EventArgs e)
        {

        }
        private void txtN_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtN.Text, out _) && txtN.Text != "")
            {
                MessageBox.Show("Vui lòng chỉ nhập số nguyên!");
                txtN.Clear();
            }
        }

        private void txtN_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtN.Text, out int n))
            {
                if (n <= 0 || n >= 1000)
                {
                    MessageBox.Show("Vui lòng nhập n trong khoảng (0 < n < 1000)");
                    txtN.Focus();
                }
            }
        }
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtN.Text, out int n)) return;

            string sNT = "Các số nguyên tố nhỏ hơn n: ";
            string sCP = "Các số chính phương nhỏ hơn n: ";
            string sHC = "Các số hoàn chỉnh nhỏ hơn n: ";

            for (int i = 1; i < n; i++)
            {
                if (IsPrime(i)) sNT += i + " ";
                if (IsSquare(i)) sCP += i + " ";
                if (IsPerfect(i)) sHC += i + " ";
            }

            lbNT.Text = sNT;
            lbCP.Text = sCP;
            lbHoanChinh.Text = sHC;
        }

        private void txtN_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lbCP_Click(object sender, EventArgs e)
        {

        }

        private void lbHoanChinh_Click(object sender, EventArgs e)
        {

        }
    }
}
