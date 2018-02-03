using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Aplikasi_Management_Apotic
{
    public partial class Frm_Transaksi : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; UID=root; Pwd=; database=db_apotek;");
        public Frm_Transaksi()
        {
            InitializeComponent();
            // For Combobox DB Value
            try
            {
                conn.Open();
            //    // For Combobox Pegawai
            //        var data_pegawai = new MySqlCommand("SELECT * FROM tbl_pegawai", conn);
            //        MySqlDataReader read_pegawai = data_pegawai.ExecuteReader();
            //        // Set combobox with DB value
            //        while (read_pegawai.Read())
            //        {
            //            cb_pegawai.Items.Add(read_pegawai.GetString("nama"));
            //            cb_pegawai.ValueMember = read_pegawai.GetString("id_pegawai");
            //        }

                // For Combobox Obat
                    var data_obat = new MySqlCommand("SELECT * FROM tbl_obat", conn);
                    MySqlDataReader read_obat = data_obat.ExecuteReader();
                    // Set combobox with DB value
                    while (read_obat.Read())
                    {
                        cb_obat.Items.Add(read_obat.GetString("id_obat"));
                        cb_obat.ValueMember = read_obat.GetString("harga_obat");
                    }

                //    // For Combobox Pegawai
                //        var data_pelanggan = new MySqlCommand("SELECT * FROM tbl_pelanggan", conn);
                //        MySqlDataReader read_pelanggan= data_obat.ExecuteReader();
                //        // Set combobox with DB value
                //        while (read_pelanggan.Read())
                //        {
                //            cb_pelanggan.Items.Add(read_pelanggan.GetString("nama"));
                //            cb_pelanggan.ValueMember = read_pelanggan.GetString("id_pelanggan");
                //        }
                read_obat.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }

            rb_member.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rb_new_member.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);

        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (rb_member.Checked)
            {
                // Disable New Member Form
                txt_id_pelanggan_new.Enabled = false;
                txt_kodepelanggan.Enabled = false;
                txt_nama.Enabled = false;
                rtxt_alamat.Enabled = false;
                rd_lakilaki.Enabled = false;
                rd_perempuan.Enabled = false;
                txt_no_telp.Enabled = false;
                txt_id_pelanggan.Enabled = true;
            }
            else if (rb_new_member.Checked)
            {
                // Enable new member Forms
                txt_id_pelanggan_new.Enabled = true;
                txt_kodepelanggan.Enabled = true;
                txt_nama.Enabled = true;
                rtxt_alamat.Enabled = true;
                rd_lakilaki.Enabled = true;
                rd_perempuan.Enabled = true;
                txt_no_telp.Enabled = true;
                txt_id_pelanggan.Enabled = false;
            }
        }

        void refresh_form()
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("INSERT INTO tbl_transaksi (id_transaksi, id_pegawai, id_pelanggan, id_obat, jumlah, total) values ('" + txt_id_transaksi.Text + "','" + txt_id_pegawai.Text + "', '" + txt_id_pelanggan.Text + "','" + cb_obat.Text + "','" + txt_jumlah_obat.Text + "','" + txt_jumlah.Text + "')");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Transaksi Berhasil diTambah");
            refresh_form();
        }
    }
}
