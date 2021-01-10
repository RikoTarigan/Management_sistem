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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        static int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            bool login = false;
            string nip = "";
            try
            {
                string connetionString = null;
                MySqlConnection cnn;
                connection con = new connection();
                connetionString = con.connetionString;
                cnn = new MySqlConnection(connetionString);
                MySqlCommand cmd = cnn.CreateCommand();
                cnn.Open();
                cmd.CommandText = "SELECT NIP FROM USERS WHERE NIP='" + textBox1.Text + "' AND PASSWORD='" + textBox2.Text + "' LIMIT 1";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    nip = reader[0].ToString();
                    login = true;
                }
                cnn.Close();
            }
            catch(Exception ex)
            {
                DialogResult dg =  MessageBox.Show("Database Erorr\n\nDetail : \n"+ex.Message, "Erorr", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if(dg == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
            if (login)
            {
                this.Hide();
                Form1 main = new Form1();
                Form1.NIP = nip;
                main.Show();
            }
            else
            {
                string notif = count == 0 ? "ID dan Password tidak cocok" : "ID dan Password tidak cocok(" + count + ")";
                label3.Text = notif;
                label3.Visible = true;
                count++;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            button1.TabIndex = 0;
        }
    }
}
