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
    public partial class Frm_Periksa : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; UID=root; Pwd=; database=db_apotek;");
        public Frm_Periksa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("INSERT INTO tbl_periksa (id_periksa, id_pelanggan,  keluhan, keterangan) values ('" + txt_idperiksa.Text + "','" + txt_idpelanggan.Text + "', '" + rtxt_keluhan.Text + "','" + rtxt_keterangan.Text + "')");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil diTambah");
            //refresh_data();

            conn.Close();
        }
    }
}
