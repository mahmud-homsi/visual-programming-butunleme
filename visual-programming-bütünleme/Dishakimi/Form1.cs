using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dishakimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySql.Data.MySqlClient.MySqlDataAdapter apter;
        private void Form1_Load(object sender, EventArgs e)
        {
            bunifuMetroTextbox2.isPassword = true;
            bunifuCheckbox1.Checked = false;
       

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                bunifuMetroTextbox2.isPassword = false;
            }
            else
            {
                bunifuMetroTextbox2.isPassword = true;
            }
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("emin misiniz? ", "çıkmak mı istiyorsunuz? ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (x == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bunifuMetroTextbox1.Text) || string.IsNullOrEmpty(bunifuMetroTextbox2.Text))
            {
                MessageBox.Show("input data in textbox! ");
                bunifuMetroTextbox1.Focus();
                bunifuMetroTextbox1.Select();
            }
            else
            {
                DataTable dt = new DataTable();

                string str = "Select username,password From gorsal.login Where username='" + bunifuMetroTextbox1.Text + "'And password='" + bunifuMetroTextbox2.Text + "'";
                apter = new MySql.Data.MySqlClient.MySqlDataAdapter(str, conn);
                apter.Fill(dt);

                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Username or password are invalide! ", "Message");
                }
                else
                {
                    Home h = new Home();
                    h.ShowDialog();
                }

            }
        
    }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            olustur olu=new olustur();
            olu.ShowDialog();

        }
    }
}
