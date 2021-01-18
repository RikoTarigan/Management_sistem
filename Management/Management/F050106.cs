using System;
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
    public partial class F050106 : UserControl
    {
        NumericUpDown nud = new NumericUpDown();
        public F050106()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fn_cari();
        }
        private void fn_cari()
        {
            ds_data.Clear();
            DataTable dataTable;
            connection c = new connection();
            MySqlDataAdapter ds = new MySqlDataAdapter("" +
                "SELECT  `id`,`NM_NASABAH`, `NM_SALES`, `NM_COLLECTOR`, `JLH_PINJAMAN`, `TIPE_PINJAMAN` FROM `pinjaman`" +
                " where NM_NASABAH LIKE '%"+txtNamaAnggota.Text+"%' ", c.connetionString);
            ds.Fill(ds_data, "PINJAMAN");

            dataTable = ds_data.Tables["PINJAMAN"];

            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToResizeRows = false;
        }
        private void F050106_Load(object sender, EventArgs e)
        {
            nud.Value = 0;
            nud.ValueChanged += new EventHandler(row_Affected);
        }
        private void row_Affected(object sender,EventArgs e)
        {
            MessageBox.Show("Data Tersimpan");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            ds_single1.Clear();
            DataGridViewRow dr = dataGridView1.Rows[e.RowIndex];
            connection c = new connection();
            MySqlDataAdapter ds = new MySqlDataAdapter("" +
                "SELECT  `id`,`NM_NASABAH`, `NM_SALES`, `NM_COLLECTOR`, `JLH_PINJAMAN`, `TIPE_PINJAMAN`,`JLH_TENOR` FROM `pinjaman`" +
                " where id = '" + dr.Cells["id"].Value.ToString() + "' ", c.connetionString);
            ds.Fill(ds_single1, "PINJAMAN");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection a = new connection();
            nud.Value = 0;
            //a.fn_IUD is insert Update Delete
            nud.Value = a.fn_IUD("UPDATE PINJAMAN SET JLH_TENOR=99 WHERE id=1"); //Change query update
        }
    }
}
