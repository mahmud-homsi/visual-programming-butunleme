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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
         

        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;

        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MinimizeBox = true;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            add a = new add();
            a.ShowDialog();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            sorgusu sor = new sorgusu();
            sor.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sorgusu sor = new sorgusu();
            sor.ShowDialog();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            odeme od = new odeme();
            od.ShowDialog();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            odemesor od = new odemesor();
            od.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            odemesor od = new odemesor();
            od.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            add a = new add();
            a.ShowDialog();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            odeme od = new odeme();
            od.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            adminpage ad = new adminpage();
            ad.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            adminpage ad = new adminpage();
            ad.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            nobace noc = new nobace();
            noc.ShowDialog();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            nobace noc = new nobace();
            noc.ShowDialog();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            nots not = new nots();
            not.ShowDialog();
        }
    }
}
