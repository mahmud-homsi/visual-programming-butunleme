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
    public partial class odeme : Form
    {
        public odeme()
        {
            InitializeComponent();
        
        }
    MySqlConnection conn = new MySqlConnection("Server=localhost;database=gorsal;port=3306;username=root;password=");
        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                string m = "insert into odeme values(@adi,@soyadi,@odemeler,@odemekkalan,@id)";
                MySqlCommand c = new MySqlCommand(m, conn);
                c.Parameters.AddWithValue("@adi", textBox1.Text);
                c.Parameters.AddWithValue("@soyadi", textBox2.Text);
                c.Parameters.AddWithValue("@odemeler", textBox3.Text);
                c.Parameters.AddWithValue("@odemekkalan", textBox4.Text);
                c.Parameters.AddWithValue("@id", textBox5.Text);
                conn.Open();
                c.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Veritabanına eklendi");
                textBox1.Focus();
                this.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message");
            }
            
        }
    }
}
