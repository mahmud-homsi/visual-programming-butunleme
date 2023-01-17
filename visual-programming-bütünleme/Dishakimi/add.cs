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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;database=gorsal;port=3306;username=root;password=");

       
      
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Lutfen bilgi gir! ");
                }
                else
                {
                    string str = "insert into ekle values(@ılec,@turu,@adet,@yas,@id)";
                    MySqlCommand cmd = new MySqlCommand(str, con);
                    cmd.Parameters.AddWithValue("@ılec", textBox1.Text);
                    cmd.Parameters.AddWithValue("@turu", textBox2.Text);
                    cmd.Parameters.AddWithValue("@adet", textBox3.Text);
                    cmd.Parameters.AddWithValue("@yas", dateTimePicker1.Value.ToString("yyyy/MM/dd 00:00:00"));
                    cmd.Parameters.AddWithValue("@id", textBox4.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("tarih eklendi");
                    this.Close();
                }
       
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "message");
            }
            
        }

        private void add_Load(object sender, EventArgs e)
        {
            this.BackColor=Color.FromArgb(255,239,247,255);
        }

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

