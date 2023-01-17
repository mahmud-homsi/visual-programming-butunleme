using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dishakimi
{
    public partial class adminpage : Form
    {
        public adminpage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            calisadd ad = new calisadd();
            ad.ShowDialog();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            calisadd ad = new calisadd();
            ad.ShowDialog();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            calisgoster ad = new calisgoster();
            ad.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            calisgoster ad = new calisgoster();
            ad.ShowDialog();
        }
    }
}
