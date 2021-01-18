using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class F060101 : UserControl
    {
        connection c = new connection();
        public F060101()
        {
            InitializeComponent();
        }

        private void F060101_Load(object sender, EventArgs e)
        {
            //Collector load
            ds_data.Clear();
            DataTable dataTable;
            
            c.dataSetFill("SELECT `NM_COLLECTOR` FROM `collector`").Fill(ds_data,"collector");
            dataTable = ds_data.Tables["collector"];
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                cbxCollector.Items.Add(dataTable.Rows[i].Field<string>(0));
            }
            if (cbxCollector.Items.Count > 0)
                cbxCollector.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT `NM_NASABAH`, `NM_SALES`, " +
                "`NM_COLLECTOR`, `SALES_ID`, `COLLECTOR_ID`, `JLH_PINJAMAN`, " +
                "`TIPE_PINJAMAN`, `JLH_TENOR` " +
                "FROM `pinjaman`";
            c.dataSetFill(query).Fill(ds_data, "PINJAMAN");
            dataGridView1.DataSource = ds_data.Tables["PINJAMAN"].DefaultView;
            txtCount.Text = dataGridView1.Rows.Count.ToString();
        }
    }
}
