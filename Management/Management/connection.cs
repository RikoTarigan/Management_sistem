using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    class connection
    {
        public string connetionString = "server=localhost;database=dbmngtdev;uid=root;pwd='';";
        public int fn_IUD(string query)
        {
            int a = 0;
            try
            {
                MySqlConnection cnn;
                connection con = new connection();
                cnn = new MySqlConnection(con.connetionString);
                MySqlCommand cmd = cnn.CreateCommand();
                cnn.Open();
                cmd.CommandText = query;
                a = cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan!\n" + "Detail: \n" + ex.StackTrace);
            }
            return a;
        }
        public MySqlDataAdapter dataSetFill(string query)
        {
            MySqlDataAdapter ds = new MySqlDataAdapter(query, connetionString);
            return ds;
        }
    }
}
