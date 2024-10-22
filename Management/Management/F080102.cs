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
    public partial class F080102 : UserControl
    {
        private static int index = -1;
        private static bool flag = false;
        MySqlConnection cnn;
        connection con = new connection();

        DataTable dataTable;
        private int a = 0;

        public F080102()
        {
            InitializeComponent();
        }

        private void fn_cari()
        {
            ds_data.Clear();
            connection c = new connection();
            MySqlDataAdapter ds = new MySqlDataAdapter("SELECT '' as Chk,`SALES_ID`, `NM_SALES`, `ALAMAT_SALES`, `TELP_SALES`, `IS_ACTIVE` FROM `sales` WHERE NM_SALES LIKE '%" + txtNamaSales.Text + "%' ", c.connetionString);
            ds.Fill(ds_data, "SALES");

            dataTable = ds_data.Tables["SALES"];

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
                    if (item.Name != "txtNamaSales")
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
            string query = "INSERT INTO `sales`(`SALES_ID`, `NM_SALES`, `ALAMAT_SALES`, `TELP_SALES`, `IS_ACTIVE`) " +
                "VALUES " +
                "('"+txtSalesID.Text+"','"+txtNamaSalesEdit.Text+"','"+txtNomorHp.Text+"','"+rtxAlamat.Text+"','"+(cbxIsActive.SelectedIndex==0?"1":"0")+"')";
            cnn = new MySqlConnection(con.connetionString);
            MySqlCommand cmd = cnn.CreateCommand();
            cnn.Open();
            cmd.CommandText = query;
            a += cmd.ExecuteNonQuery();
            cnn.Close();
        }
        private string getID()
        {
            string query = "SELECT (MAX(id) + 1) AS ID FROM SALES";
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
                    if (item.Name != "txtNamaSales")
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
                if(dataGridView1.Rows[i].Cells[0].Value.ToString() == "EDIT")
                {
                    if(i==0)
                    {
                        DialogResult dg =  MessageBox.Show("Apakah anda yakin ingin menyimpan data" +
                            "", "CONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if(dg != DialogResult.Yes)
                        {
                            a = 0;
                            break;
                        }
                    }
                    update = "";
                    update += "UPDATE SALES SET \n";
                    update += "NM_SALES = '" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "', ";
                    update += "TELP_SALES = '" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "', ";
                    update += "ALAMAT_SALES = '" + dataGridView1.Rows[i].Cells[5].Value.ToString() + "' ";
                    update += " WHERE ";
                    update += "SALES_ID = '" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "' ";

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
                    if (item.Name != "txtNamaSales" && item.Name != "txtSalesID")
                        item.Enabled = true;
                }
            }
            txtNamaSalesEdit.Text = dataGridView1.Rows[e.RowIndex].Cells["NM_SALES"].Value.ToString();
            rtxAlamat.Text = dataGridView1.Rows[e.RowIndex].Cells["ALAMAT_SALES"].Value.ToString();
            txtNomorHp.Text = dataGridView1.Rows[e.RowIndex].Cells["TELP_SALES"].Value.ToString();
            txtSalesID.Text = dataGridView1.Rows[e.RowIndex].Cells["SALES_ID"].Value.ToString();
        }

        private void textChanged(object sender, EventArgs e)
        {
            if (index == -1)
                return;
            var te = (TextBox)sender;
            // MessageBox.Show(index.ToString());
            
            flag = false;
            if (dataGridView1.Rows[index].Cells[3].Value.ToString() != txtNamaSalesEdit.Text)
            {
                dataGridView1.Rows[index].Cells[3].Value = txtNamaSalesEdit.Text;
                flag = true;
            }
            if (dataGridView1.Rows[index].Cells[4].Value.ToString() != txtNomorHp.Text)
            {
                dataGridView1.Rows[index].Cells[4].Value = txtNomorHp.Text;
                flag = true;
            }
            if(dataGridView1.Rows[index].Cells[5].Value.ToString() != rtxAlamat.Text)
            {
                dataGridView1.Rows[index].Cells[5].Value = rtxAlamat.Text;
                flag = true;
            }
            if(flag)
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
                    if (item.Name != "txtNamaSales" && item.Name != "txtSalesID")
                    {
                        item.Text = "";
                        item.Enabled = true;
                    }
                }
            }
            string salesId = getID();
            txtSalesID.Text = "S/" + DateTime.Now.ToString("MM") + DateTime.Now.Year.ToString() + "-" + salesId;

            flag = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = 0;
            if(txtSalesID.Text == "" )
            {
                MessageBox.Show("Sales ID Kosong!!");
                return;
            }
            DialogResult dg = MessageBox.Show("Apakah anda yakin ingin Menghapus data" +
                            "", "CONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dg == DialogResult.Yes)
            {
                string query = "DELETE FROM `sales` WHERE SALES_ID='"+txtSalesID.Text+"'";
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

        private void F080102_Load(object sender, EventArgs e)
        {
            cbxIsActive.SelectedIndex = 0;
            
        }
    }
}
