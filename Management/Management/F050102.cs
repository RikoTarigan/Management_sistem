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
    public partial class F050102 : UserControl
    {
        public static string val = "";
        public static string nama_customer = "";
        connection con = new connection();
        MySqlConnection cnn;

        public F050102()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            val = "";
            nama_customer = "";
            i = 0;
            timer1.Start();
            PopUp p = new PopUp("F050102");
            p.TopLevel = true;
            p.ShowDialog();
        }
        bool firstLoad = false;
        private void F050102_Load(object sender, EventArgs e)
        {
            
            cbxJenisJaminan.SelectedIndex = 0;
            firstLoad = true;
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    if (item.Name != "txtNoAnggota")
                    {
                        item.Enabled = false;
                        item.TextChanged += new EventHandler(item_Text);
                    }
                }
            }
            //comboBox1.SelectedIndex = 0;
            Clear();
        }
        private void Clear()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = "";    
            }
        }
        private void item_Text(object sender, EventArgs e)
        {
            TextBox item = (TextBox)sender;
            if (item.Text == "" && item.Name != "txtNoAnggota" &&
                            item.Name != "txtJaminan" &&
                            item.Name != "txtNamaAnggota")
            {
                item.BackColor = Color.FromArgb(255, 224, 192);
            }
            else
            {
                item.BackColor = Color.White;
            }
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtNoAnggota.Text = val;
            txtNamaAnggota.Text = nama_customer;
            i++;
        }

        private void txtNoAnggota_TextChanged(object sender, EventArgs e)
        {
            if (i > 10)
                timer1.Stop();
            string id = getID();
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if(item.Name != "txtNoAnggota" && item.Name!= "txtNamaAnggota" && item.Name != "txtJaminan")
                    {
                        if(txtNoAnggota.Text=="")
                            item.Enabled = false;
                        if (txtNoAnggota.Text != "")
                        {
                            item.Enabled = true;
                            txtJaminan.Text = "AG00"+id+"-" + txtNoAnggota.Text;
                        }
                    }
                }
            }
        }
        private string getID()
        {
            string query = "SELECT (MAX(id) + 1) AS ID FROM JAMINAN";
            cnn = new MySqlConnection(con.connetionString);
            MySqlCommand cmd = cnn.CreateCommand();
            cnn.Open();
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();
            string id = "";
            while (reader.Read())
            {
                id = reader[0].ToString();
            }
            cnn.Close();
            if (id == "")
            {
                id = "1";
            }
            return id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!Validation())
            {
                return;
            }
            insertData();
            generateNewJaminanID();
        }

        private void generateNewJaminanID()
        {
            string id = getID();
            txtJaminan.Text = "AG00" + id + "-" + txtNoAnggota.Text;
        }

        private bool Validation()
        {
            bool flag = true;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        if (item.Name != "txtNoAnggota" &&
                            item.Name != "txtJaminan" &&
                            item.Name != "txtNamaAnggota" &&
                            item.Name != "txtKeterangan")
                        {
                            item.BackColor = Color.FromArgb(255, 224, 192);
                            flag = false;
                        }
                    }
                }
            }
            if (flag)
                return true;
            else
                return false;
        }
        private void insertData()
        {
            string ket2 = "";
            string query = "INSERT INTO `jaminan`" +
                "(`NO_JAMINAN`, `JENIS_JAMINAN`, `NO_ANGGOTA`, `TANGGAL_MASUK`, `NAMA_BARANG`, `TIPE_BARANG`, `KET1`, `KET2`, `NAMA_COLLECTOR`) " +
                "VALUES " +
                "('"+txtJaminan.Text+"','"+cbxJenisJaminan.Text+"','"+txtNoAnggota.Text+"','"+dtmTanggalMasuk.Value.ToString()+"','"+txtNamaBarang.Text+"','"+txtTypeBarang.Text+"','"+txtKeterangan.Text+"','"+ket2+"','"+cbxCollector.Text+"')";
            cnn = new MySqlConnection(con.connetionString);
            MySqlCommand cmd = cnn.CreateCommand();
            cnn.Open();
            cmd.CommandText = query;
            int a = cmd.ExecuteNonQuery();
            if (a >= 0)
            {
                MessageBox.Show("Data Tersimpan!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cnn.Close();
        }

        private void Detail_VisibleChanged(object sender, EventArgs e)
        {
            if (firstLoad)
                return;
            if (Detail.Visible)
            {
                btnSave.Location = new Point(btnSave.Location.X, btnSave.Location.Y + Detail.Height);
            }
            else
            {
                btnSave.Location = new Point(btnSave.Location.X, btnSave.Location.Y - Detail.Height);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            firstLoad = false;
            if(cbxJenisJaminan.SelectedIndex==0)
            {
                Detail.Visible = true;
            }
            else
            {
                Detail.Visible = false;
            }
        }

        private void txtJaminan_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
