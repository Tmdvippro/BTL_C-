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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void nguyênTốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SNT f  = new SNT();
                this.Hide();
                f.ShowDialog();
                this.Show();
        }

        
        private void tiềnKhámRăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KR s = new KR();
            this.Hide();
            s.ShowDialog();
            this.Show();
        }

        private void chứcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
