namespace prjectrume
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtdeskripsi = new System.Windows.Forms.TextBox();
            this.cmbstok = new System.Windows.Forms.ComboBox();
            this.cmbharga = new System.Windows.Forms.ComboBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnGambar = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtnamagambar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nama produk";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(488, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 189);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(57, 89);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(312, 20);
            this.txtnama.TabIndex = 2;
            // 
            // txtdeskripsi
            // 
            this.txtdeskripsi.Location = new System.Drawing.Point(57, 183);
            this.txtdeskripsi.Name = "txtdeskripsi";
            this.txtdeskripsi.Size = new System.Drawing.Size(312, 20);
            this.txtdeskripsi.TabIndex = 3;
            // 
            // cmbstok
            // 
            this.cmbstok.FormattingEnabled = true;
            this.cmbstok.Location = new System.Drawing.Point(57, 138);
            this.cmbstok.Name = "cmbstok";
            this.cmbstok.Size = new System.Drawing.Size(312, 21);
            this.cmbstok.TabIndex = 4;
            // 
            // cmbharga
            // 
            this.cmbharga.FormattingEnabled = true;
            this.cmbharga.Location = new System.Drawing.Point(57, 237);
            this.cmbharga.Name = "cmbharga";
            this.cmbharga.Size = new System.Drawing.Size(312, 21);
            this.cmbharga.TabIndex = 5;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Chartreuse;
            this.btnTambah.Location = new System.Drawing.Point(57, 314);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(152, 313);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Red;
            this.btnHapus.Location = new System.Drawing.Point(280, 314);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 8;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "stok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "deskripsi";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(64, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(572, 20);
            this.textBox3.TabIndex = 11;
            // 
            // btnGambar
            // 
            this.btnGambar.Location = new System.Drawing.Point(490, 290);
            this.btnGambar.Name = "btnGambar";
            this.btnGambar.Size = new System.Drawing.Size(225, 23);
            this.btnGambar.TabIndex = 12;
            this.btnGambar.Text = "Tambah Gambar";
            this.btnGambar.UseVisualStyleBackColor = true;
            this.btnGambar.Click += new System.EventHandler(this.btnGambar_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(383, 314);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 23);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "harga";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 190);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtnamagambar
            // 
            this.txtnamagambar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtnamagambar.Location = new System.Drawing.Point(57, 287);
            this.txtnamagambar.Name = "txtnamagambar";
            this.txtnamagambar.Size = new System.Drawing.Size(312, 20);
            this.txtnamagambar.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "namagambar";
            // 
            // btnForm
            // 
            this.btnForm.Location = new System.Drawing.Point(490, 334);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(225, 23);
            this.btnForm.TabIndex = 18;
            this.btnForm.Text = "bersihkan form";
            this.btnForm.UseVisualStyleBackColor = true;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click_1);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prjectrume.Properties.Resources.rumenige;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.btnForm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnamagambar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnGambar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.cmbharga);
            this.Controls.Add(this.cmbstok);
            this.Controls.Add(this.txtdeskripsi);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtdeskripsi;
        private System.Windows.Forms.ComboBox cmbstok;
        private System.Windows.Forms.ComboBox cmbharga;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnGambar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtnamagambar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnForm;
    }
}