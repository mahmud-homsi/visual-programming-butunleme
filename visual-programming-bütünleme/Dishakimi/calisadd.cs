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
    public partial class calisadd : Form
    {
        public calisadd()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;database=gorsal;port=3306;username=root;passeord=");


        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Red;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text == "" || bunifuMetroTextbox2.Text == "" || bunifuMetroTextbox3.Text == "")
            {
                MessageBox.Show("lütfen bilgi gir!");
            }
            else
            {
                try
                {
                    string str = "INSERT INTO calis values(@id,@adi,@soyadi,@ucert)";
                    MySqlCommand cmd = new MySqlCommand(str, con);
                    cmd.Parameters.AddWithValue("@id", bunifuMetroTextbox4.Text);
                    cmd.Parameters.AddWithValue("@adi", bunifuMetroTextbox1.Text);
                    cmd.Parameters.AddWithValue("@soyadi", bunifuMetroTextbox2.Text);
                    cmd.Parameters.AddWithValue("@ucert", bunifuMetroTextbox3.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("çalışanlar eklendi");
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "message");
                    
                }
            }
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
