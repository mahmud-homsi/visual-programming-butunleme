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
    public partial class olustur : Form
    {
        public olustur()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;database=gorsal;port=3306;username=root;password=");

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Lutfen bilgi gir");
                }
                else
                {
string str = "insert into login values(@username,@password,@id)";
            MySqlCommand cmd = new MySqlCommand(str,con);
            cmd.Parameters.AddWithValue("@username",textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
                    cmd.Parameters.AddWithValue("@id", textBox3.Text);
                    con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("hesap oluşturuldu");
                    
                }
   
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "message");
            }
            con.Close();
            this.Close();
            

        }
    }
}
