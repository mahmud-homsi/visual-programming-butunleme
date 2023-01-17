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
    public partial class calisgoster : Form
    {
        public calisgoster()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;database=gorsal;port=3306;username=root;password=");
        MySqlDataAdapter ad = new MySqlDataAdapter();
        DataTable de = new DataTable();
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

        private void calisgoster_Load(object sender, EventArgs e)
        {
            try
            {
                ad = new MySqlDataAdapter("SELECT * FROM calis",con);
                ad.Fill(de);
                dataGridView1.DataSource = de;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "message");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string ed = "UPDATE calis SET adi=@adi,soyadi=@soyadi,ucert=@ucert WHERE id="+dataGridView1.CurrentRow.Cells[0].Value+"";
                MySqlCommand cmd = new MySqlCommand(ed, con);
                cmd.Parameters.AddWithValue("@adi", textBox1.Text);
                cmd.Parameters.AddWithValue("@soyadi", textBox2.Text);
                cmd.Parameters.AddWithValue("@ucert", textBox3.Text);
                cmd.ExecuteNonQuery();
                dataGridView1.DataSource = de;
                con.Close();
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "message");
            }
        }
    }
}
