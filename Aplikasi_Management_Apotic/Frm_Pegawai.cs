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
    public partial class Frm_Pegawai : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; UID=root; Pwd=; database=db_apotek;");
        public Frm_Pegawai()
        {
            InitializeComponent();
            try
            {
                conn.Open();
                var data = new MySqlCommand("SELECT * FROM tbl_pegawai", conn);
                MySqlDataReader read = data.ExecuteReader();
                while (read.Read())
                {
                    dataGridView1.Rows.Add(
                    read.GetString("id_pegawai"),
                    read.GetString("kode_pegawai"),
                    read.GetString("nama"),
                    read.GetString("alamat"),
                    read.GetString("no_telp"),
                    read.GetString("username"),
                    read.GetString("role")
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
                var data = new MySqlCommand("SELECT * FROM tbl_pegawai", conn);
                MySqlDataReader read = data.ExecuteReader();
                while (read.Read())
                {
                    dataGridView1.Rows.Add(
                    read.GetString("id_pegawai"),
                    read.GetString("kode_pegawai"),
                    read.GetString("nama"),
                    read.GetString("alamat"),
                    read.GetString("no_telp"),
                    read.GetString("username"),
                    read.GetString("role")
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

        private void button8_Click(object sender, EventArgs e)
        {
            char a;
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("INSERT INTO tbl_pegawai (id_pegawai, kode_pegawai,nama, alamat, no_telp, username,password, role) values ('" + txt_idpegawai.Text + "','" + txt_kodepegawai.Text + "', '" + txt_namapegawai.Text + "','" + rtxt_alamat.Text + "','" + txt_notelp.Text + "','" + txt_username.Text + "','" + txt_password.Text + "', '" + cmb_role.Text + "')");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil diTambah");
            refresh_data();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE tbl_pegawai SET id_pegawai = '" + txt_idpegawai.Text + "',kode_pegawai = '" + txt_kodepegawai.Text + "', nama ='" + txt_namapegawai.Text + "', alamat = '" + rtxt_alamat.Text + "', no_telp = '" + txt_notelp.Text + "',username ='" + txt_username.Text + "', password = '" + txt_password.Text + "',role = '"+cmb_role.Text+"' WHERE id_pegawai = '" + txt_idpegawai.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil diUpdate");
            refresh_data();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM tbl_pegawai WHERE `tbl_pegawai`.`id_pegawai` = '" + txt_idpegawai.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil dihapus", txt_idpegawai.Text);
            refresh_data();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.txt_idpegawai.Text = "";
            this.txt_kodepegawai.Text = "";
            this.txt_namapegawai.Text = "";
            this.rtxt_alamat.Text = "";
            this.txt_notelp.Text = "";
            this.txt_username.Text = "";
            this.txt_password.Text = "";
            this.cmb_role.Text = "";
        }

        private void txt_searchpegawai_TextChanged(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("SELECT * FROM tbl_pegawai where nama LIKE CONCAT('%" + txt_searchpegawai.Text + "%')");
            cmd.ExecuteNonQuery();
            MySqlDataReader read = cmd.ExecuteReader();

            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                while (read.Read())
                {
                    dataGridView1.Rows.Add(
                    read.GetString("id_pegawai"),
                    read.GetString("kode_pegawai"),
                    read.GetString("nama"),
                    read.GetString("alamat"),
                    read.GetString("no_telp"),
                    read.GetString("username"),
                    read.GetString("role")
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
            txt_idpegawai.Text = row.Cells["id_pegawai"].Value.ToString();
            txt_kodepegawai.Text = row.Cells["kode_pegawai"].Value.ToString();
            txt_namapegawai.Text = row.Cells["nama"].Value.ToString();
            rtxt_alamat.Text = row.Cells["alamat"].Value.ToString();
            txt_notelp.Text = row.Cells["no_telp"].Value.ToString();
            txt_username.Text = row.Cells["username"].Value.ToString();
            cmb_role.Text = row.Cells["role"].Value.ToString();
        }

        private void Frm_Pegawai_Load(object sender, EventArgs e)
        {

        }
    }
}
