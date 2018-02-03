namespace Aplikasi_Management_Apotic
{
    partial class frm_report
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
            this.dg_report = new System.Windows.Forms.DataGridView();
            this.id_transaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kode_pelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_report)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_report
            // 
            this.dg_report.AllowDrop = true;
            this.dg_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_transaksi,
            this.nama,
            this.kode_pelanggan,
            this.nama_obat,
            this.jumlah});
            this.dg_report.Location = new System.Drawing.Point(22, 12);
            this.dg_report.Name = "dg_report";
            this.dg_report.RowTemplate.Height = 28;
            this.dg_report.Size = new System.Drawing.Size(924, 561);
            this.dg_report.TabIndex = 0;
            this.dg_report.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_report_CellContentClick);
            // 
            // id_transaksi
            // 
            this.id_transaksi.HeaderText = "ID Transaksi";
            this.id_transaksi.Name = "id_transaksi";
            // 
            // nama
            // 
            this.nama.FillWeight = 350F;
            this.nama.HeaderText = "Nama Pegawai";
            this.nama.Name = "nama";
            // 
            // kode_pelanggan
            // 
            this.kode_pelanggan.HeaderText = "Kode Pelanggan";
            this.kode_pelanggan.Name = "kode_pelanggan";
            // 
            // nama_obat
            // 
            this.nama_obat.HeaderText = "Nama Obat";
            this.nama_obat.Name = "nama_obat";
            // 
            // jumlah
            // 
            this.jumlah.HeaderText = "Jumlah Obat";
            this.jumlah.Name = "jumlah";
            // 
            // frm_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 598);
            this.Controls.Add(this.dg_report);
            this.Name = "frm_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_report";
            this.Load += new System.EventHandler(this.frm_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_report;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_transaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_pelanggan;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
    }
}