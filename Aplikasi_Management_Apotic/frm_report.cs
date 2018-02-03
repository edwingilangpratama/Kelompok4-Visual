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
    public partial class frm_report : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; UID=root; Pwd=; database=db_apotek;");

        public frm_report()
        {
            InitializeComponent();
        }

        private void frm_report_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
               var data = new MySqlCommand("SELECT t.`id_transaksi`, pg.`nama`, pl.`kode_pelanggan`, o.`nama_obat`, t.`jumlah` FROM `tbl_transaksi` t LEFT JOIN `tbl_pegawai` pg ON t.`id_pegawai` = pg.`id_pegawai` LEFT JOIN `tbl_pelanggan` pl ON t.`id_pelanggan` = pl.`id_pelanggan` LEFT JOIN `tbl_obat` o ON t.`id_obat` = o.`id_obat`", conn);
                MySqlDataReader read = data.ExecuteReader();
                while (read.Read())
                {
                    dg_report.Rows.Add(
                        read.GetString("id_transaksi"),
                        read.GetString("nama"),
                        read.GetString("kode_pelanggan"),
                        read.GetString("nama_obat"),
                        read.GetString("jumlah")

                    );
                }
                read.Close();
                //MessageBox.Show("Connection Success");
            }
            catch
            {
                //MessageBox.Show("Connection Fail");
            }
        }

        private void dg_report_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
