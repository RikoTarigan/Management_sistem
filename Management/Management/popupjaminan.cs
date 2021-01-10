using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Management
{
    public partial class popupjaminan : Form
    {
        string nojaminan = "";
        public popupjaminan(string nojaminan)
        {
            InitializeComponent();
            this.nojaminan = nojaminan;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            connection c = new connection();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM JAMINAN where NO_JAMINAN LIKE '" + txtNoJaminan.Text + "%' AND NO_ANGGOTA LIKE '" + textBox2.Text + "%'", c.connetionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "JAMINAN");
            dataGridView1.DataSource = ds.Tables["JAMINAN"].DefaultView;
        }

        private void popupjaminan_Load(object sender, EventArgs e)
        {
            txtNoJaminan.Text = nojaminan;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == dataGridView1.Rows.Count - 1)
                return;
            DataGridViewRow dr = dataGridView1.Rows[e.RowIndex];
            F050103.val = dr.Cells["NO_JAMINAN"].Value.ToString();
            F050103.cek = true;
            this.Close();
        }

        private void popupjaminan_FormClosed(object sender, FormClosedEventArgs e)
        {
            F050103.cek = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            connection c = new connection();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM JAMINAN where NO_JAMINAN LIKE '" + txtNoJaminan.Text + "%' AND NO_ANGGOTA LIKE '" + textBox2.Text + "%'", c.connetionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "JAMINAN");
            dataGridView1.DataSource = ds.Tables["JAMINAN"].DefaultView;
        }
    }
}
