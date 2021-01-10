﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Management
{
    public partial class F050105 : UserControl
    {
        public static F050105 Self;
        public F050105()
        {
            InitializeComponent();
            Self = this;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // val = "";
            i = 0;
            timer1.Start();
            PopUp p = new PopUp("F050105");
            p.TopLevel = true;
            p.ShowDialog();
        }

        private void F050105_Load(object sender, EventArgs e)
        {

        }
        public static string val="";

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtNoAnggota.Text = val;
            i++;
        }

        private void txtNoAnggota_TextChanged(object sender, EventArgs e)
        {
            if(i>10)
                timer1.Stop();
            ds_data.Clear();
            connection c = new connection();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT `NAMA_COSTUMER`, `NO_KTP`, `NO_KK`, `AGAMA`, `TEMPAT_LAHIR`, `TANGGAL_LAHIR`, `JK`, `ALAMAT_KTP`, `ALAMAT_DOMISILI`, `TELP`, `PEKERJAAN`, `NAMA_IBU_KANDUNG`, `TANGGAL_LAHIR_IBU`, `NAMA_USAHA`, `ALAMAT_UsAHA`, `JENIS_USAHA`, `NAMA_BANK`, `NO_REKENING`, `NAMA_REKENING`, `NAMA_SALES`, `WILAYAH_AREA_TAGIH`, `STATUS_APPL`, `STATUS_MENIKAH`, `NAMA_PASANGAN`, `NO_KTP_PASANGAN`, `ALAMAT_PASANGAN`, `TELP_PASANGAN` FROM NASABAH WHERE NO_ANGGOTA = '" + txtNoAnggota.Text + "' LIMIT 1", c.connetionString);
            da.Fill(ds_data, "NASABAH");

            MySqlDataAdapter ds = new MySqlDataAdapter("SELECT `id`, `NO_JAMINAN`, `JENIS_JAMINAN`, `NO_ANGGOTA`, `TANGGAL_MASUK`, `NAMA_BARANG`, `TIPE_BARANG`, `KET1`, `KET2`, `NAMA_COLLECTOR` FROM `jaminan` WHERE NO_ANGGOTA='"+txtNoAnggota.Text+"'", c.connetionString);
            ds.Fill(ds_data, "JAMINAN");
            dataGridView1.DataSource = ds_data.Tables["JAMINAN"].DefaultView;

        }

        private void txtNamaCustomer_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
