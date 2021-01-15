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
    public partial class F080101 : UserControl
    {
        private static int index = -1;
        private static bool flag = false;
        MySqlConnection cnn;
        connection con = new connection();

        DataTable dataTable;
        private int a = 0;

        public F080101()
        {
            InitializeComponent();
        }
        private void fn_cari()
        {
            ds_data.Clear();
            connection c = new connection();
            MySqlDataAdapter ds = new MySqlDataAdapter("SELECT '' as Chk,`collector_ID`, `NM_collector`, `ALAMAT_collector`, `TELP_collector`, `IS_ACTIVE` FROM `collector` WHERE NM_collector LIKE '%" + txtNamacollector.Text + "%' ", c.connetionString);
            ds.Fill(ds_data, "collector");

            dataTable = ds_data.Tables["collector"];

            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToResizeRows = false;

            if (dataGridView1.Columns is null)
            {
                return;
            }
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Name != "txtNamacollector")
                    {
                        item.Text = "";
                        item.Enabled = false;
                    }
                }
            }
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[1].Width = 30;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            fn_cari();

        }

        private void fn_save()
        {
            string query = "INSERT INTO `collector`(`collector_ID`, `NM_collector`, `ALAMAT_collector`, `TELP_collector`, `IS_ACTIVE`) " +
                "VALUES " +
                "('" + txtcollectorID.Text + "','" + txtNamacollectorEdit.Text + "','" + txtNomorHp.Text + "','" + rtxAlamat.Text + "','" + (cbxIsActive.SelectedIndex == 0 ? "1" : "0") + "')";
            cnn = new MySqlConnection(con.connetionString);
            MySqlCommand cmd = cnn.CreateCommand();
            cnn.Open();
            cmd.CommandText = query;
            a += cmd.ExecuteNonQuery();
            cnn.Close();
        }
        private string getID()
        {
            string query = "SELECT (MAX(id) + 1) AS ID FROM collector";
            string connetionString = null;
            MySqlConnection cnn;
            connection con = new connection();
            connetionString = con.connetionString;

            cnn = new MySqlConnection(connetionString);
            MySqlCommand cmd = cnn.CreateCommand();
            cnn.Open();
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();
            string id = "";
            while (reader.Read())
            {
                id = reader[0].ToString();
            }
            string now = DateTime.Now.ToString("yyyyMM");
            cnn.Close();
            if (id == "")
            {
                id = "1";
            }
            return id;
        }

        private bool fn_Validation()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Name != "txtNamacollector")
                    {
                        if (item.Text == "")
                            return false;
                    }
                }
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            a = 0;
            string update = "";
            if (flag)
            {
                if (!fn_Validation())
                {
                    MessageBox.Show("Cek Input Value");
                    return;
                }
                fn_save();
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "EDIT")
                {
                    if (i == 0)
                    {
                        DialogResult dg = MessageBox.Show("Apakah anda yakin ingin menyimpan data" +
                            "", "CONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dg != DialogResult.Yes)
                        {
                            a = 0;
                            break;
                        }
                    }
                    update = "";
                    update += "UPDATE collector SET \n";
                    update += "NM_collector = '" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "', ";
                    update += "TELP_collector = '" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "', ";
                    update += "ALAMAT_collector = '" + dataGridView1.Rows[i].Cells[5].Value.ToString() + "' ";
                    update += " WHERE ";
                    update += "collector_ID = '" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "' ";

                    cnn = new MySqlConnection(con.connetionString);
                    MySqlCommand cmd = cnn.CreateCommand();
                    cnn.Open();
                    cmd.CommandText = update;
                    a += cmd.ExecuteNonQuery();
                    cnn.Close();


                }
            }
            if (a > 0)
            {
                MessageBox.Show("Data Tersimpan!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fn_cari();
            }

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // MessageBox.Show(e.Control.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = false;
            index = e.RowIndex;
            if (e.RowIndex == -1)
                return;

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Name != "txtNamacollector" && item.Name != "txtcollectorID")
                        item.Enabled = true;
                }
            }
            txtNamacollectorEdit.Text = dataGridView1.Rows[e.RowIndex].Cells["NM_collector"].Value.ToString();
            rtxAlamat.Text = dataGridView1.Rows[e.RowIndex].Cells["ALAMAT_collector"].Value.ToString();
            txtNomorHp.Text = dataGridView1.Rows[e.RowIndex].Cells["TELP_collector"].Value.ToString();
            txtcollectorID.Text = dataGridView1.Rows[e.RowIndex].Cells["collector_ID"].Value.ToString();
        }

        private void textChanged(object sender, EventArgs e)
        {
            if (index == -1)
                return;
            var te = (TextBox)sender;
            // MessageBox.Show(index.ToString());

            flag = false;
            if (dataGridView1.Rows[index].Cells[3].Value.ToString() != txtNamacollectorEdit.Text)
            {
                dataGridView1.Rows[index].Cells[3].Value = txtNamacollectorEdit.Text;
                flag = true;
            }
            if (dataGridView1.Rows[index].Cells[4].Value.ToString() != txtNomorHp.Text)
            {
                dataGridView1.Rows[index].Cells[4].Value = txtNomorHp.Text;
                flag = true;
            }
            if (dataGridView1.Rows[index].Cells[5].Value.ToString() != rtxAlamat.Text)
            {
                dataGridView1.Rows[index].Cells[5].Value = rtxAlamat.Text;
                flag = true;
            }
            if (flag)
            {
                dataGridView1.Rows[index].Cells[0].Value = "EDIT";
                dataGridView1.Rows[index].Cells[0].Style.BackColor = Color.DarkOrange;
            }
            flag = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            index = -1;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Name != "txtNamacollector" && item.Name != "txtcollectorID")
                    {
                        item.Text = "";
                        item.Enabled = true;
                    }
                }
            }
            string collectorId = getID();
            txtcollectorID.Text = "C/" + DateTime.Now.ToString("MM") + DateTime.Now.Year.ToString() + "-" + collectorId;

            flag = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = 0;
            if (txtcollectorID.Text == "")
            {
                MessageBox.Show("collector ID Kosong!!");
                return;
            }
            DialogResult dg = MessageBox.Show("Apakah anda yakin ingin Menghapus data" +
                            "", "CONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dg == DialogResult.Yes)
            {
                string query = "DELETE FROM `collector` WHERE collector_ID='" + txtcollectorID.Text + "'";
                cnn = new MySqlConnection(con.connetionString);
                MySqlCommand cmd = cnn.CreateCommand();
                cnn.Open();
                cmd.CommandText = query;
                a += cmd.ExecuteNonQuery();
                cnn.Close();
            }
            if (a > 0)
            {
                MessageBox.Show("Data Tersimpan!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fn_cari();
            }
        }

        private void F080101_Load(object sender, EventArgs e)
        {
            cbxIsActive.SelectedIndex = 0;
        }
    }
}
