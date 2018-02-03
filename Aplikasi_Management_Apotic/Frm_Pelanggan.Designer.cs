namespace Aplikasi_Management_Apotic
{
    partial class Frm_Pelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Pelanggan));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtxt_alamat = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_kodepelanggan = new System.Windows.Forms.TextBox();
            this.rd_perempuan = new System.Windows.Forms.RadioButton();
            this.rd_lakilaki = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_searchpelanggan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_no_telp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idpelanggan = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.id_pelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kode_pelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis_kelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_telp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pelanggan,
            this.kode_pelanggan,
            this.nama,
            this.alamat,
            this.jenis_kelamin,
            this.no_telp});
            this.dataGridView1.Location = new System.Drawing.Point(789, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 444);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rtxt_alamat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_kodepelanggan);
            this.panel1.Controls.Add(this.rd_perempuan);
            this.panel1.Controls.Add(this.rd_lakilaki);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_nama);
            this.panel1.Controls.Add(this.txt_no_telp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_idpelanggan);
            this.panel1.Location = new System.Drawing.Point(12, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 520);
            this.panel1.TabIndex = 2;
            // 
            // rtxt_alamat
            // 
            this.rtxt_alamat.Location = new System.Drawing.Point(264, 163);
            this.rtxt_alamat.Name = "rtxt_alamat";
            this.rtxt_alamat.Size = new System.Drawing.Size(461, 130);
            this.rtxt_alamat.TabIndex = 44;
            this.rtxt_alamat.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Kode Pelanggan";
            // 
            // txt_kodepelanggan
            // 
            this.txt_kodepelanggan.Location = new System.Drawing.Point(264, 76);
            this.txt_kodepelanggan.Name = "txt_kodepelanggan";
            this.txt_kodepelanggan.Size = new System.Drawing.Size(342, 26);
            this.txt_kodepelanggan.TabIndex = 42;
            // 
            // rd_perempuan
            // 
            this.rd_perempuan.AutoSize = true;
            this.rd_perempuan.Location = new System.Drawing.Point(384, 299);
            this.rd_perempuan.Name = "rd_perempuan";
            this.rd_perempuan.Size = new System.Drawing.Size(116, 24);
            this.rd_perempuan.TabIndex = 41;
            this.rd_perempuan.TabStop = true;
            this.rd_perempuan.Text = "Perempuan";
            this.rd_perempuan.UseVisualStyleBackColor = true;
            // 
            // rd_lakilaki
            // 
            this.rd_lakilaki.AutoSize = true;
            this.rd_lakilaki.Location = new System.Drawing.Point(264, 299);
            this.rd_lakilaki.Name = "rd_lakilaki";
            this.rd_lakilaki.Size = new System.Drawing.Size(97, 24);
            this.rd_lakilaki.TabIndex = 40;
            this.rd_lakilaki.TabStop = true;
            this.rd_lakilaki.Text = "Laki-Laki";
            this.rd_lakilaki.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Nama Pelanggan";
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(264, 121);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(342, 26);
            this.txt_nama.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.txt_searchpelanggan);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(789, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(908, 57);
            this.panel3.TabIndex = 37;
            // 
            // txt_searchpelanggan
            // 
            this.txt_searchpelanggan.Location = new System.Drawing.Point(170, 19);
            this.txt_searchpelanggan.Name = "txt_searchpelanggan";
            this.txt_searchpelanggan.Size = new System.Drawing.Size(728, 26);
            this.txt_searchpelanggan.TabIndex = 39;
            this.txt_searchpelanggan.TextChanged += new System.EventHandler(this.txt_searchobat_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Cari Nama Obat";
            // 
            // txt_no_telp
            // 
            this.txt_no_telp.Location = new System.Drawing.Point(264, 338);
            this.txt_no_telp.Name = "txt_no_telp";
            this.txt_no_telp.Size = new System.Drawing.Size(342, 26);
            this.txt_no_telp.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "No.Telp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Alamat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Pelanggan\r\n";
            // 
            // txt_idpelanggan
            // 
            this.txt_idpelanggan.Location = new System.Drawing.Point(264, 33);
            this.txt_idpelanggan.Name = "txt_idpelanggan";
            this.txt_idpelanggan.Size = new System.Drawing.Size(342, 26);
            this.txt_idpelanggan.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Location = new System.Drawing.Point(135, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 115);
            this.panel2.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(482, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Bersihkan";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(349, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Hapus";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(164, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Edit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tambah";
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(458, -1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 85);
            this.button5.TabIndex = 12;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(314, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 84);
            this.button6.TabIndex = 11;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(129, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 88);
            this.button7.TabIndex = 10;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 85);
            this.button8.TabIndex = 9;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // id_pelanggan
            // 
            this.id_pelanggan.HeaderText = "ID Pelanggan";
            this.id_pelanggan.Name = "id_pelanggan";
            // 
            // kode_pelanggan
            // 
            this.kode_pelanggan.HeaderText = "Kode Pelanggan";
            this.kode_pelanggan.Name = "kode_pelanggan";
            // 
            // nama
            // 
            this.nama.HeaderText = "Nama";
            this.nama.Name = "nama";
            this.nama.Width = 120;
            // 
            // alamat
            // 
            this.alamat.HeaderText = "Alamat";
            this.alamat.Name = "alamat";
            // 
            // jenis_kelamin
            // 
            this.jenis_kelamin.HeaderText = "Jenis Kelamin";
            this.jenis_kelamin.Name = "jenis_kelamin";
            // 
            // no_telp
            // 
            this.no_telp.HeaderText = "No.Telp";
            this.no_telp.Name = "no_telp";
            // 
            // Frm_Pelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1389, 545);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Frm_Pelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Frm_Pelanggan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rd_perempuan;
        private System.Windows.Forms.RadioButton rd_lakilaki;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_searchpelanggan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_no_telp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idpelanggan;
        private System.Windows.Forms.RichTextBox rtxt_alamat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_kodepelanggan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pelanggan;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_pelanggan;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis_kelamin;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_telp;
    }
}