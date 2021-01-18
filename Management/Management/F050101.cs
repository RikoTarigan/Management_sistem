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
    public partial class F050101 : UserControl
    {
        bool firstLoad = false;
        connection con;
        public F050101()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validation())
            {
                 return;
            }

            string query = string.Format("INSERT INTO NASABAH " +
                "(`id`,`NO_ANGGOTA`, `NAMA_COSTUMER`, `NO_KTP`, `NO_KK`, `AGAMA`, `TEMPAT_LAHIR`, `TANGGAL_LAHIR`, `JK`, `ALAMAT_KTP`, `ALAMAT_DOMISILI`, `TELP`, `PEKERJAAN`, `NAMA_IBU_KANDUNG`, `TANGGAL_LAHIR_IBU`, `NAMA_USAHA`, `ALAMAT_UsAHA`, `JENIS_USAHA`, `NAMA_BANK`, `NO_REKENING`, `NAMA_REKENING`, `NAMA_SALES`, `WILAYAH_AREA_TAGIH`, `STATUS_APPL`, `STATUS_MENIKAH`, `NAMA_PASANGAN`, `NO_KTP_PASANGAN`, `ALAMAT_PASANGAN`, `TELP_PASANGAN`) " +
                "VALUES " +
                "('"+getID()+"','{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}')"
                , getNoAnggota(), txtNamaCustomer.Text, txtNomorKTP.Text,
                txtNomorKK.Text, cbxAgama.Text, txtTempatLahir.Text, dtmTanggalLahir.Value.ToString(), getJenisKelamin(),
                txtAlamatKTp.Text, txtAlamatDomisili.Text, txtTelp.Text,
                txtPekerjaan.Text, txtNamaIbuKandung.Text, txtTanggalLahirIbu.Text,txtNamaUsaha.Text,txtAlamatUsaha.Text,
                txtJenisUsaha.Text,txtNamaBank.Text,txtNoRek.Text,txtNamarek.Text,namasales.Text,areatagis.Text, getsttsapppl(), getStatus(), txtnamapasangan.Text, txtnoktppasangan.Text,
                txtalamatpasangan.Text, txtnotelppasangan.Text
                );
            string connetionString = null;
            MySqlConnection cnn;
            connection con = new connection();
            connetionString = con.connetionString;

            cnn = new MySqlConnection(connetionString);
            MySqlCommand cmd = cnn.CreateCommand();
            cnn.Open();
            cmd.CommandText = query;
            int a = cmd.ExecuteNonQuery();
            if (a>=0)
            {
                MessageBox.Show("Data Tersimpan!","INFORMATION",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            cnn.Close();

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
                            item.Name!= "txtNamaBank" &&
                            item.Name != "txtNoRek" &&
                            item.Name != "txtNamarek" &&
                            item.Name != "txtJenisUsaha" &&
                            item.Name != "txtNomorTelepon" &&
                            item.Name != "Prov" &&
                            item.Name != "Kab" &&
                            item.Name != "Kec")
                        {
                            item.BackColor = Color.FromArgb(255, 224, 192);
                            flag = false;
                        }
                    }
                }
            }
            if (radioButton3.Checked)
            {
                foreach (Control item in DetailPasangan.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item.Text == ""  && item.Name != "txtNoAnggota" &&
                            item.Name != "txtNamaBank" &&
                            item.Name != "txtNoRek" &&
                            item.Name != "txtNamarek" &&
                            item.Name != "txtJenisUsaha" &&
                            item.Name != "txtNomorTelepon" &&
                            item.Name != "Prov" &&
                            item.Name != "Kab" &&
                            item.Name != "Kec")
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
        private string getID()
        {
            string query = "SELECT (MAX(id) + 1) AS ID FROM NASABAH";
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
            if(id=="")
            {
                id = "1";
            }
            return id;
        }

        private string getsttsapppl()
        {
            if (rdbsttsaplnew.Checked)
                return rdbsttsaplnew.Text;
            else
                return rdbsttsaplro.Text;
        }
        private string getNoAnggota()
        {
            string id = "";
            string now = DateTime.Now.ToString("yyyyMM");
            id = "P0001-" + now + getID();
            return id;
        }
        private string getJenisKelamin()
        {
            if (radioButton1.Checked)
                return radioButton1.Text;
            else
                return radioButton2.Text;
        }
        private string getStatus()
        {
            if (radioButton3.Checked)
                return radioButton3.Text;
            else
                return radioButton4.Text;
        } 

        private void F050101_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton3.Checked = true;
            rdbsttsaplnew.Checked = true;
            cbxAgama.SelectedIndex = 0;
            firstLoad = true;

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.TextChanged += new EventHandler(item_Text);
                }
                if(item is GroupBox)
                {
                    if(item.Name== "DetailPasangan")
                    {
                        foreach (Control t in item.Controls)
                        {
                            if(t is TextBox)
                            {
                                t.TextChanged += new EventHandler(item_Text);
                            }
                        }
                    }
                }    
            }

            ds_data.Clear();
            DataTable dataTable;
            connection c = new connection();
            MySqlDataAdapter ds = new MySqlDataAdapter("SELECT  `SALES_ID`, `NM_SALES`, `ALAMAT_SALES`, `TELP_SALES`, `IS_ACTIVE` FROM `sales`", c.connetionString);
            ds.Fill(ds_data, "SALES");

            dataTable = ds_data.Tables["SALES"];
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                namasales.Items.Add(dataTable.Rows[i].Field<string>(1));
            }
            if (namasales.Items.Count > 0)
                namasales.SelectedIndex = 0;

        }

        private void item_Text(object sender, EventArgs e)
        {
            TextBox item = (TextBox)sender;
            if(item.Text=="" && item.Name != "txtNoAnggota" &&
                            item.Name != "txtNamaBank" &&
                            item.Name != "txtNoRek" &&
                            item.Name != "txtNamarek" &&
                            item.Name != "txtJenisUsaha" &&
                            item.Name != "txtNomorTelepon" &&
                            item.Name != "Prov" &&
                            item.Name != "Kab" &&
                            item.Name != "Kec")
            {
                item.BackColor = Color.FromArgb(255, 224, 192);
            }
            else
            {
                item.BackColor = Color.White;
            }
        }
        private void radioButton4_Click(object sender, EventArgs e)
        {
            firstLoad = false;
            if(radioButton3.Checked)
            {
                DetailPasangan.Visible = true;
            }
            else
            {
                DetailPasangan.Visible = false;
                foreach (Control item in DetailPasangan.Controls)
                {
                    if(item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void DetailPasangan_VisibleChanged(object sender, EventArgs e)
        {
            if (firstLoad)
                return;
            if(DetailPasangan.Visible)
            {
                btnSave.Location = new Point(btnSave.Location.X, btnSave.Location.Y + DetailPasangan.Height);
            }
            else
            {
                btnSave.Location = new Point(btnSave.Location.X, btnSave.Location.Y - DetailPasangan.Height);
            }
        }


        private void txtNoAnggota_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
