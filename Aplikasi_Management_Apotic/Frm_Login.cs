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
    public partial class Frm_Login : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; UID=root; Pwd=; database=db_apotek");
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string username = textBox1.Text;
            string password = textBox2.Text;

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_pegawai", conn);
            MySqlDataReader read = cmd.ExecuteReader();
            int suc = 0;
            while (read.Read())
            {
                string user = read.GetString("username");
                string pass = read.GetString("password");

                if (username == user && password == pass)
                {
                    suc = 1;
                    var home = new Frm_MenuUtama();
                    this.Visible = false;
                    home.Show();
                }
            }
            if (suc == 1)
            {
                MessageBox.Show("Login Success");
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
            conn.Close();
        }
    }
}
