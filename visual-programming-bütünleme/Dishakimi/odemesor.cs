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
    public partial class odemesor : Form
    {
        public odemesor()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;database=gorsal;port=3306;username=root;password=");
        MySqlDataAdapter ad;
        DataTable dt = new DataTable();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void odemesor_Load(object sender, EventArgs e)
        {
            try
            {
ad =new MySqlDataAdapter("Select * From odeme",con);
            ad.Fill(dt);
            con.Open();
            dataGridView1.DataSource = dt;
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Message");
            }
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            bunifuMetroTextbox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            bunifuMetroTextbox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            bunifuMetroTextbox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            
            
            
            
            
            try
            {
                con.Open();
                string qu = "UPDATE odeme SET adi=@adi,soyadi=@soyadi,odemeler=@odemeler,odemekkalan=@odemekkalan WHERE id="+dataGridView1.CurrentRow.Cells[4].Value+"";
                MySqlCommand cmd = new MySqlCommand(qu, con);
                cmd.Parameters.AddWithValue("@adi", bunifuMetroTextbox1.Text);
                cmd.Parameters.AddWithValue("@soyadi", bunifuMetroTextbox2.Text);
                cmd.Parameters.AddWithValue("@odemeler", bunifuMetroTextbox3.Text);
                cmd.Parameters.AddWithValue("@odemekkalan", bunifuMetroTextbox4.Text);
                cmd.ExecuteNonQuery();
                dataGridView1.DataSource = dt;
                con.Close();
                MessageBox.Show("Başarıyla değiştirildi");
        
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"message");
            }
           
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

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }
    }
    }
