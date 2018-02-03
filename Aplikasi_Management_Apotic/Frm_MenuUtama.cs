using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Management_Apotic
{
    public partial class Frm_MenuUtama : Form
    {
        public Frm_MenuUtama()
        {
            InitializeComponent();
        }

        private void daftarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int @null;
            Frm_Pegawai newMDIChild = new Frm_Pegawai();
            //Set the Parent Form of the Child Window
            newMDIChild.MdiParent = this;
            //Display the new form
            newMDIChild.Show();
        }

        private void obatToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Obat newMDIChild = new Frm_Obat();
            //Set the Parent Form of the Child Window
            newMDIChild.MdiParent = this;
            //Display the new form
            newMDIChild.Show();
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Pelanggan newMDIChild = new Frm_Pelanggan();
            //Set the Parent Form of the Child Window
            newMDIChild.MdiParent = this;
            //Display the new form
            newMDIChild.Show();
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Transaksi newMDIChild = new Frm_Transaksi();
            //Set the Parent Form of the Child Window
            newMDIChild.MdiParent = this;
            //Display the new form
            newMDIChild.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_report newMDIChild = new frm_report();
            //Set the Parent Form of the Child Window
            newMDIChild.MdiParent = this;
            //Display the new form
            newMDIChild.Show();
        }

        private void periksaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Periksa newMDIChild = new Frm_Periksa();
            newMDIChild.Show();
        }

        private void Frm_MenuUtama_Load(object sender, EventArgs e)
        {

        }

        private void menu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
