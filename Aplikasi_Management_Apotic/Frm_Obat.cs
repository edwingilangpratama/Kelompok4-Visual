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
    public partial class Frm_Obat : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; UID=root; Pwd=; database=db_apotek;");
        public Frm_Obat()
        {
            InitializeComponent();
            try
            {
                conn.Open(); 
                var data = new MySqlCommand("SELECT * FROM tbl_obat", conn);
                MySqlDataReader read = data.ExecuteReader();
                while (read.Read())
                {
                    dataGridView1.Rows.Add(
                        read.GetString("id_obat"),
                        read.GetString("kode_obat"),
                        read.GetString("kategori_obat"),
                        read.GetString("nama_obat"),
                        read.GetString("stok_obat"),
                        read.GetString("harga_obat"),
                        read.GetString("keterangan")
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
                var data = new MySqlCommand("SELECT * FROM tbl_obat", conn);
                MySqlDataReader read = data.ExecuteReader();
                while (read.Read())
                {
                    dataGridView1.Rows.Add(
                        read.GetString("id_obat"),
                        read.GetString("kode_obat"),
                        read.GetString("kategori_obat"),
                        read.GetString("nama_obat"),
                        read.GetString("stok_obat"),
                        read.GetString("harga_obat"),
                        read.GetString("keterangan")
                    );
                }
                read.Close();
            }
            catch
            {
                MessageBox.Show("Connection Fail");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            txt_idobat.Text = row.Cells["id_obat"].Value.ToString();
            txt_kodeobat.Text = row.Cells["kode_obat"].Value.ToString();
            cmb_kategoriobat.Text = row.Cells["kategori_obat"].Value.ToString();
            txt_namaobat.Text = row.Cells["nama_obat"].Value.ToString();
            txt_stock.Text = row.Cells["stok_obat"].Value.ToString();
            txt_hargaobat.Text = row.Cells["harga_obat"].Value.ToString();
            rtxt_keterangan.Text = row.Cells["keterangan"].Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("SELECT * FROM tbl_obat where nama_obat LIKE CONCAT('%" + txt_searchobat.Text + "%')");
            cmd.ExecuteNonQuery();
            MySqlDataReader read = cmd.ExecuteReader();

            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                while (read.Read())
                {
                    dataGridView1.Rows.Add(
                    read.GetString("id_obat"),
                    read.GetString("kode_obat"),
                    read.GetString("kategori_obat"),
                    read.GetString("nama_obat"),
                    read.GetString("stok_obat"),
                    read.GetString("harga_obat"),
                    read.GetString("keterangan")
                );
                }
            }
            catch
            {
                MessageBox.Show("Data Teu Aya,hehe");
            }
            read.Close();

        }

        private void Frm_Obat_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.txt_idobat.Text = "";
            this.txt_kodeobat.Text = "";
            this.cmb_kategoriobat.Text = "";
            this.txt_namaobat.Text = "";
            this.txt_stock.Text = "";
            this.txt_hargaobat.Text = "";
            this.rtxt_keterangan.Text = "";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM `tbl_obat` WHERE `tbl_obat`.`id_obat` = '" + txt_idobat.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil dihapus", txt_idobat.Text);
            refresh_data();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE tbl_obat SET id_obat = '" + txt_idobat.Text + "',kode_obat = '" + txt_kodeobat.Text + "', kategori_obat ='" + cmb_kategoriobat.Text + "', nama_obat = '" + txt_namaobat.Text + "', stok_obat = '" + txt_stock.Text + "',harga_obat ='" + txt_hargaobat.Text + "', keterangan = '" + rtxt_keterangan.Text + "' WHERE id_obat = '" + txt_idobat.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil diUpdate");
            refresh_data();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("INSERT INTO tbl_obat (id_obat, kode_obat,  kategori_obat, nama_obat, stok_obat, harga_obat, keterangan) values ('" + txt_idobat.Text + "','" + txt_kodeobat.Text + "', '" + cmb_kategoriobat.Text + "','" + txt_namaobat.Text + "','" + txt_stock.Text + "','" + txt_hargaobat.Text + "', '" + rtxt_keterangan.Text + "')");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil diTambah");
            refresh_data();
        }
    }
}
