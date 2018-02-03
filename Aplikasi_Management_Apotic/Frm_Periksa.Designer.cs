namespace Aplikasi_Management_Apotic
{
    partial class Frm_Periksa
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
            this.txt_idperiksa = new System.Windows.Forms.TextBox();
            this.txt_idpelanggan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxt_keluhan = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxt_keterangan = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_idperiksa
            // 
            this.txt_idperiksa.Location = new System.Drawing.Point(248, 29);
            this.txt_idperiksa.Name = "txt_idperiksa";
            this.txt_idperiksa.Size = new System.Drawing.Size(248, 26);
            this.txt_idperiksa.TabIndex = 0;
            // 
            // txt_idpelanggan
            // 
            this.txt_idpelanggan.Location = new System.Drawing.Point(248, 82);
            this.txt_idpelanggan.Name = "txt_idpelanggan";
            this.txt_idpelanggan.Size = new System.Drawing.Size(248, 26);
            this.txt_idpelanggan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Periksa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Pelanggan";
            // 
            // rtxt_keluhan
            // 
            this.rtxt_keluhan.Location = new System.Drawing.Point(248, 134);
            this.rtxt_keluhan.Name = "rtxt_keluhan";
            this.rtxt_keluhan.Size = new System.Drawing.Size(405, 96);
            this.rtxt_keluhan.TabIndex = 4;
            this.rtxt_keluhan.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Keluhan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Keterangan";
            // 
            // rtxt_keterangan
            // 
            this.rtxt_keterangan.Location = new System.Drawing.Point(248, 250);
            this.rtxt_keterangan.Name = "rtxt_keterangan";
            this.rtxt_keterangan.Size = new System.Drawing.Size(405, 96);
            this.rtxt_keterangan.TabIndex = 7;
            this.rtxt_keterangan.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Periksa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtxt_keterangan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtxt_keluhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_idpelanggan);
            this.Controls.Add(this.txt_idperiksa);
            this.Name = "Frm_Periksa";
            this.Text = "Frm_Periksa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_idperiksa;
        private System.Windows.Forms.TextBox txt_idpelanggan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxt_keluhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxt_keterangan;
        private System.Windows.Forms.Button button1;
    }
}