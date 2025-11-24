using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjectrume
{
    public partial class HomePage : Form
    {
        SqlConnection conn = new SqlConnection(
           @"Data Source=MYPCPRO;Initial Catalog=db_rume;Integrated Security=True;TrustServerCertificate=True;");

        public HomePage(string username)
        {
            InitializeComponent();
            textBox3.Text = "Login sebagai: " + username;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // =============================
        // LOAD DATA
        // =============================
        void LoadData()
        {
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT id_produk, nama_produk, stok, deskripsi, harga, gambar_produk FROM tb_produk", conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            dataGridView1.ClearSelection();
        }

        // =============================
        // PILIH BARIS GRID
        // =============================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                txtnama.Text = row.Cells["nama_produk"].Value.ToString();
                cmbstok.Text = row.Cells["stok"].Value.ToString();
                txtdeskripsi.Text = row.Cells["deskripsi"].Value.ToString();
                cmbharga.Text = row.Cells["harga"].Value.ToString();
                txtnamagambar.Text = row.Cells["gambar_produk"].Value.ToString();

                LoadImage(txtnamagambar.Text);
            }
        }

        void LoadImage(string fileName)
        {
            string path = Application.StartupPath + @"\Images\" + fileName;

            if (File.Exists(path))
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(path)));
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        // =============================
        // TAMBAH
        // =============================
        private void btnTambah_Click_1(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO tb_produk (nama_produk, stok, deskripsi, harga, gambar_produk) VALUES (@n,@s,@d,@h,@g)", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@n", txtnama.Text);
                cmd.Parameters.AddWithValue("@s", cmbstok.Text);
                cmd.Parameters.AddWithValue("@d", txtdeskripsi.Text);
                cmd.Parameters.AddWithValue("@h", cmbharga.Text);
                cmd.Parameters.AddWithValue("@g", txtnamagambar.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Data berhasil ditambahkan!");
            LoadData();
        }

        // =============================
        // UPDATE
        // =============================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            using (SqlCommand cmd = new SqlCommand(
                "UPDATE tb_produk SET nama_produk=@n, stok=@s, deskripsi=@d, harga=@h, gambar_produk=@g WHERE id_produk=@id", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["id_produk"].Value);
                cmd.Parameters.AddWithValue("@n", txtnama.Text);
                cmd.Parameters.AddWithValue("@s", cmbstok.Text);
                cmd.Parameters.AddWithValue("@d", txtdeskripsi.Text);
                cmd.Parameters.AddWithValue("@h", cmbharga.Text);
                cmd.Parameters.AddWithValue("@g", txtnamagambar.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Data berhasil diperbarui!");
            LoadData();
        }

        // =============================
        // HAPUS
        // =============================
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Silahkan pilih data yang akan dihapus!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TAMPILKAN KONFIRMASI
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin menghapus data ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return; // batal hapus

            using (SqlCommand cmd = new SqlCommand(
                "DELETE FROM tb_produk WHERE id_produk=@id", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@id",
                    dataGridView1.CurrentRow.Cells["id_produk"].Value);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Data berhasil dihapus!");
            LoadData();
        }

        // =============================
        // PILIH GAMBAR
        // =============================
        private void btnGambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string folder = Application.StartupPath + @"\Images\";

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                string namaFile = Path.GetFileName(ofd.FileName);
                string tujuan = folder + namaFile;

                File.Copy(ofd.FileName, tujuan, true);

                txtnamagambar.Text = namaFile;
                pictureBox1.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(ofd.FileName)));

                MessageBox.Show("Gambar ditambahkan!");
            }
        }

        // =============================
        // CLEAR FORM
        // =============================
        private void btnForm_Click_1(object sender, EventArgs e)
        {
            txtnama.Clear();
            cmbstok.SelectedIndex = -1;
            txtdeskripsi.Clear();
            cmbharga.SelectedIndex = -1;
            txtnamagambar.Clear();
            pictureBox1.Image = null;
            dataGridView1.ClearSelection();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Yakin ingin logout?",
               "Logout",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 login = new Form1();
                login.Show();

                // tutup form sekarang
                this.Hide();
            }
        }
    }
}


