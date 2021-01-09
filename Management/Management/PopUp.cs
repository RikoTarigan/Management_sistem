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
    public partial class PopUp : Form
    {
        string formname;
        public PopUp(string form)
        {
            InitializeComponent();
            this.formname = form;
        }

        private void PopUp_Load(object sender, EventArgs e)
        {
            connection c = new connection();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM NASABAH", c.connetionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Nasabah");
            dataGridView1.DataSource = ds.Tables["Nasabah"].DefaultView;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == dataGridView1.Rows.Count - 1)
                return;
            DataGridViewRow dr = dataGridView1.Rows[e.RowIndex];
            if (formname == "F050105")
            {
                F050105.val = dr.Cells["NO_ANGGOTA"].Value.ToString();
            }
            else if(formname == "F050102")
            {
                F050102.val = dr.Cells["NO_ANGGOTA"].Value.ToString();
            }
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            connection c = new connection();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM NASABAH where NAMA_COSTUMER LIKE '" + textBox1.Text+"%'", c.connetionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Nasabah");
            dataGridView1.DataSource = ds.Tables["Nasabah"].DefaultView;
        }
    }
}
