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
    public partial class nots : Form
    {
        public nots()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;database=gorsal;port=3306;username=root;password=");
        MySqlDataAdapter ad = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nots_Load(object sender, EventArgs e)
        {
            try
            {
                ad = new MySqlDataAdapter("SELECT * FROM nots",con);
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message");
            }

        }

        public DataTable LoadTableFromDatabase()
        {
            con.Open();
            DataTable dt = new DataTable();
            string query = "Select * From bilgi";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string str = "insert into nots values(@id , @not)";
            MySqlCommand cmd = new MySqlCommand(str, con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@not", textBox1.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Not eklendi");
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtnot.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE nots SET id=@id, not=@not where id=" + dataGridView1.CurrentRow.Cells[0].Value + "";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", txtid.Text);
                cmd.Parameters.AddWithValue("@not", txtnot.Text);

                cmd.ExecuteNonQuery();
                dataGridView1.DataSource = dt;
                con.Close();
                MessageBox.Show("bilgiler değiştirildi");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message");
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM nots WHERE id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("silindi");
            dataGridView1.DataSource = dt;
        }
    }
}
