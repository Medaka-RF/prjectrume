using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjectrume
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(
             "Data Source=MYPCPRO;Initial Catalog=db_rume;Integrated Security=True;TrustServerCertificate=True;"
             );
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                connection.Open();
                string query = "SELECT nama FROM tb_user WHERE username=@Username AND password=@Password";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader fl = cmd.ExecuteReader();
                if (fl.Read())
                {
                    string fullname = fl["nama"].ToString();
                    MessageBox.Show("Login berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HomePage home = new HomePage(username);
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                fl.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                connection.Open();
                string query = "SELECT nama FROM tb_user WHERE username=@Username AND password=@Password";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader fl = cmd.ExecuteReader();
                if (fl.Read())
                {
                    string fullname = fl["nama"].ToString();
                    MessageBox.Show("Login berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HomePage home = new HomePage(username);
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                fl.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
    }
}
