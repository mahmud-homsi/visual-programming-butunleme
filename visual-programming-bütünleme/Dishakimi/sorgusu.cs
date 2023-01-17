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
    public partial class sorgusu : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;database=gorsal;port=3306;username=root;password=");
        MySqlDataAdapter ad;
        DataTable dt = new DataTable();
        public sorgusu()
        {
            InitializeComponent();
            try
            {
ad = new MySqlDataAdapter("Select * From ekle",conn);
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void sorgusu_Load(object sender, EventArgs e)
        {

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
    }
}
