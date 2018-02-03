namespace Aplikasi_Management_Apotic
{
    partial class Frm_Obat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Obat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_kodeobat = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_searchobat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxt_keterangan = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_hargaobat = new System.Windows.Forms.TextBox();
            this.cmb_kategoriobat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_namaobat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idobat = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.id_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kode_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategori_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stok_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_kodeobat);
            this.panel1.Controls.Add(this.rtxt_keterangan);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_hargaobat);
            this.panel1.Controls.Add(this.cmb_kategoriobat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_stock);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_namaobat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_idobat);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 526);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Kode Obat";
            // 
            // txt_kodeobat
            // 
            this.txt_kodeobat.Location = new System.Drawing.Point(234, 76);
            this.txt_kodeobat.Name = "txt_kodeobat";
            this.txt_kodeobat.Size = new System.Drawing.Size(293, 26);
            this.txt_kodeobat.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.txt_searchobat);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(758, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(961, 71);
            this.panel3.TabIndex = 37;
            // 
            // txt_searchobat
            // 
            this.txt_searchobat.Location = new System.Drawing.Point(170, 19);
            this.txt_searchobat.Name = "txt_searchobat";
            this.txt_searchobat.Size = new System.Drawing.Size(728, 26);
            this.txt_searchobat.TabIndex = 39;
            this.txt_searchobat.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // rtxt_keterangan
            // 
            this.rtxt_keterangan.Location = new System.Drawing.Point(234, 290);
            this.rtxt_keterangan.Name = "rtxt_keterangan";
            this.rtxt_keterangan.Size = new System.Drawing.Size(457, 96);
            this.rtxt_keterangan.TabIndex = 32;
            this.rtxt_keterangan.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Keterangan";
            // 
            // txt_hargaobat
            // 
            this.txt_hargaobat.Location = new System.Drawing.Point(234, 249);
            this.txt_hargaobat.Name = "txt_hargaobat";
            this.txt_hargaobat.Size = new System.Drawing.Size(293, 26);
            this.txt_hargaobat.TabIndex = 30;
            // 
            // cmb_kategoriobat
            // 
            this.cmb_kategoriobat.FormattingEnabled = true;
            this.cmb_kategoriobat.Items.AddRange(new object[] {
            "Tablet",
            "Cair",
            "Kapsul"});
            this.cmb_kategoriobat.Location = new System.Drawing.Point(234, 122);
            this.cmb_kategoriobat.Name = "cmb_kategoriobat";
            this.cmb_kategoriobat.Size = new System.Drawing.Size(293, 28);
            this.cmb_kategoriobat.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Harga Obat";
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(234, 205);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(293, 26);
            this.txt_stock.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Stock";
            // 
            // txt_namaobat
            // 
            this.txt_namaobat.Location = new System.Drawing.Point(234, 163);
            this.txt_namaobat.Name = "txt_namaobat";
            this.txt_namaobat.Size = new System.Drawing.Size(293, 26);
            this.txt_namaobat.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nama Obat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kategori Obat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Obat";
            // 
            // txt_idobat
            // 
            this.txt_idobat.Location = new System.Drawing.Point(234, 33);
            this.txt_idobat.Name = "txt_idobat";
            this.txt_idobat.Size = new System.Drawing.Size(293, 26);
            this.txt_idobat.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_obat,
            this.kode_obat,
            this.kategori_obat,
            this.nama_obat,
            this.stok_obat,
            this.harga_obat,
            this.keterangan});
            this.dataGridView1.Location = new System.Drawing.Point(758, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1131, 428);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.panel2.Location = new System.Drawing.Point(105, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 115);
            this.panel2.TabIndex = 40;
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
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
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
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
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
            // id_obat
            // 
            this.id_obat.HeaderText = "ID Obat";
            this.id_obat.Name = "id_obat";
            // 
            // kode_obat
            // 
            this.kode_obat.HeaderText = "Kode Obat";
            this.kode_obat.Name = "kode_obat";
            // 
            // kategori_obat
            // 
            this.kategori_obat.HeaderText = "Kategori Obat";
            this.kategori_obat.Name = "kategori_obat";
            // 
            // nama_obat
            // 
            this.nama_obat.HeaderText = "Nama Obat";
            this.nama_obat.Name = "nama_obat";
            // 
            // stok_obat
            // 
            this.stok_obat.HeaderText = "Stock Obat";
            this.stok_obat.Name = "stok_obat";
            // 
            // harga_obat
            // 
            this.harga_obat.HeaderText = "Harga Obat";
            this.harga_obat.Name = "harga_obat";
            // 
            // keterangan
            // 
            this.keterangan.HeaderText = "Keterangan";
            this.keterangan.Name = "keterangan";
            this.keterangan.Width = 120;
            // 
            // Frm_Obat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1901, 552);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Frm_Obat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Frm_Obat";
            this.Load += new System.EventHandler(this.Frm_Obat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_namaobat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idobat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_searchobat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtxt_keterangan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_hargaobat;
        private System.Windows.Forms.ComboBox cmb_kategoriobat;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_kodeobat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategori_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn stok_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn keterangan;
    }
}