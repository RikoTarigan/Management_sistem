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
    public partial class F050102 : UserControl
    {
        public static string val = "";
        public F050102()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            val = "";
            i = 0;
            timer1.Start();
            PopUp p = new PopUp("F050102");
            p.TopLevel = true;
            p.ShowDialog();
        }

        private void F050102_Load(object sender, EventArgs e)
        {

        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtNoAnggota.Text = val;
            i++;
        }

        private void txtNoAnggota_TextChanged(object sender, EventArgs e)
        {
            if (i > 60)
                timer1.Stop();
        }
    }
}
