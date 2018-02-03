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
    public partial class Frm_Pelanggan : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; UID=root; Pwd=; database=db_apotek;");
        public Frm_Pelanggan()
        {
            InitializeComponent();
            try
            {
                conn.Open();
                var data = new MySqlCommand("SELECT * FROM tbl_pelanggan", conn);
                MySqlDataReader read = data.ExecuteReader();
                while (read.Read())
                {
                    dataGridView1.Rows.Add(
                    read.GetString("id_pelanggan"),
                    read.GetString("kode_pelanggan"),
                    read.GetString("nama"),
                    read.GetString("alamat"),
                    read.GetString("jenis_kelamin"),
                    read.GetString("no_telp")
                );
                }
                read.Close();
            }
            catch
            {
                MessageBox.Show("Connection Fail");
            }
        }

        public void refresh_data()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            try
            {
                var data = new MySqlCommand("SELECT * FROM tbl_pelanggan", conn);
                MySqlDataReader read = data.ExecuteReader();
                while (read.Read())
                {
                    dataGridView1.Rows.Add(
                    read.GetString("id_pelanggan"),
                    read.GetString("kode_pelanggan"),
                    read.GetString("nama"),
                    read.GetString("alamat"),
                    read.GetString("jenis_kelamin"),
                    read.GetString("no_telp")
                );
                }
                read.Close();
            }
            catch
            {
                MessageBox.Show("Connection Fail");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.txt_idpelanggan.Text = "";
            this.txt_kodepelanggan.Text = "";
            this.txt_nama.Text = "";
            this.rtxt_alamat.Text = "";
            this.rd_lakilaki.Checked= false;
            this.rd_perempuan.Checked=false;
            this.txt_no_telp.Text = "";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            String Gender = "";
            if (rd_lakilaki.Checked == true)
                Gender = rd_lakilaki.Text;
            else if (rd_perempuan.Checked == true)
                Gender = rd_perempuan.Text;

            cmd.CommandText = ("INSERT INTO tbl_pelanggan (id_pelanggan,kode_pelanggan,nama,alamat,jenis_kelamin, no_telp) values ('" + txt_idpelanggan.Text + "','" + txt_kodepelanggan.Text + "', '" + txt_nama.Text + "','" + rtxt_alamat.Text + "','" + Gender + "','" + txt_no_telp.Text + "')");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil diTambah");
            refresh_data();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            String Gender = "";
            if (rd_lakilaki.Checked == true)
                Gender = rd_lakilaki.Text;
            else if (rd_perempuan.Checked == true)
                Gender = rd_perempuan.Text;

            cmd.CommandText = "UPDATE tbl_pelanggan SET id_pelanggan = '" + txt_idpelanggan.Text + "',kode_pelanggan = '" + txt_kodepelanggan.Text + "', nama ='" + txt_nama.Text + "', alamat = '" + rtxt_alamat.Text + "', jenis_kelamin = '" + Gender + "',no_telp ='" + txt_no_telp.Text + "' WHERE id_pelanggan = '" + txt_idpelanggan.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil diUpdate");
            refresh_data();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM `tbl_pelanggan` WHERE `tbl_pelanggan`.`id_pelanggan` = '" + txt_idpelanggan.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil dihapus", txt_idpelanggan.Text);
            refresh_data();
        }

        private void txt_searchobat_TextChanged(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("SELECT * FROM tbl_pelanggan where nama LIKE CONCAT('%" + txt_searchpelanggan.Text + "%')");
            cmd.ExecuteNonQuery();
            MySqlDataReader read = cmd.ExecuteReader();

            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                while (read.Read())
                {
                    dataGridView1.Rows.Add(
                    read.GetString("id_pelanggan"),
                    read.GetString("kode_pelanggan"),
                    read.GetString("nama"),
                    read.GetString("alamat"),
                    read.GetString("jenis_kelamin"),
                    read.GetString("no_telp")
                );
                }
            }
            catch
            {
                MessageBox.Show("Data Teu Aya,hehe");
            }
            read.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            txt_idpelanggan.Text = row.Cells["id_pelanggan"].Value.ToString();
            txt_kodepelanggan.Text = row.Cells["kode_pelanggan"].Value.ToString();
            txt_nama.Text = row.Cells["nama"].Value.ToString();
            rtxt_alamat.Text = row.Cells["alamat"].Value.ToString();
           // Gender = row.Cells["jenis_kelamin"].Value.ToString();
            //Gender = row.Cells["jenis_kelamin"].Value.ToString();
            txt_no_telp.Text = row.Cells["no_telp"].Value.ToString();
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.txt_idpelanggan.Text = "";
            this.txt_kodepelanggan.Text = "";
            this.txt_nama.Text = "";
            this.rtxt_alamat.Text = "";
            this.rd_lakilaki.Checked = false;
            this.rd_perempuan.Checked = false;
            this.txt_no_telp.Text = "";
        }
    }
}
