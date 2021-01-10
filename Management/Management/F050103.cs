using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using MySql.Data.MySqlClient;

namespace Management
{
    public partial class F050103 : UserControl
    {
        public static string val = "";
        private static string KetJaminanKeluar = "";
        public static bool cek = false;

        private Font printFont;
        private StreamReader streamToPrint;



        public F050103()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //val = "";
            cek = false;
            timer1.Start();
            popupjaminan p = new popupjaminan(txtNoJaminan.Text);
            p.TopLevel = true;
            p.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtNoJaminan.Text = val;
            if (cek)
                timer1.Stop();
        }

        private void txtNoJaminan_TextChanged(object sender, EventArgs e)
        {
            // timer1.Start();
            ds_data.Clear();
            connection c = new connection();
            MySqlDataAdapter ds = new MySqlDataAdapter("SELECT `id`, `NO_JAMINAN`, `JENIS_JAMINAN`, `NO_ANGGOTA`, `TANGGAL_MASUK`, `NAMA_BARANG`, `TIPE_BARANG`, `KET1`, `KET2`, `NAMA_COLLECTOR` FROM `jaminan` WHERE NO_JAMINAN='" + txtNoJaminan.Text + "'", c.connetionString);
            ds.Fill(ds_data, "JAMINAN");
            button1.Enabled = true;
            //KetJaminanKeluar = textBox2.Text;
            //KetJaminanKeluar += "\n===========================================";


        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Apakah anda yakin?", "CONFIRMATION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if(dg == DialogResult.Yes)
            {
                KetJaminanKeluar += "\n" + txtNoJaminan.Text;
                btnCetak.Enabled = true;
                richTextBox1.Visible = true;
                richTextBox1.Text = KetJaminanKeluar;
                button1.Enabled = false;
            }
        }
       
        private void F050103_Load(object sender, EventArgs e)
        {
            btnCetak.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(!richTextBox1.Text.Contains(textBox2.Text))
            {
                richTextBox1.Text = "";
                KetJaminanKeluar = "";
            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {

        }
    }
}
