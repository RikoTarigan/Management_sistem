using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Management
{
    public partial class Form1 : Form
    {
        string[] menuTop;
        private static int maxTabPage;
        private static string nameSpace;
        public Form1()
        {
            InitializeComponent();
        }
        private bool findLastNode(TreeNode T)
        {
            if (T.GetNodeCount(true) == 0)
                return true;
            return false;
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (findLastNode(e.Node))
            {
                // MessageBox.Show(e.Node.ToString());
                bool chek = false;
                TabPage temp = new TabPage();
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (e.Node.Text == tabControl1.TabPages[i].Text)
                    {
                        temp = tabControl1.TabPages[i];
                        chek = true;
                    }

                }
                if (chek)
                {
                    tabControl1.SelectedTab = temp;
                    lblScreenName.Text = temp.Text;
                    return;
                }
                if (tabControl1.TabPages.Count >= maxTabPage)
                {
                    MessageBox.Show("Maximum tab : " + tabControl1.TabPages.Count.ToString(), "TAB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                TabPage Apple = new TabPage(e.Node.Text);

                Apple.Controls.Clear();
                string queryExe = "";
                if (e.Node.Level == 0)
                {
                    queryExe = "SELECT DISTINCT(FORM_NM) FROM MENUDEPARTMENT WHERE GROUP_NM='" + e.Node.Text + "'";
                }
                else if (e.Node.Level == 1)
                {
                    queryExe = "SELECT DISTINCT(FORM_NM) FROM MENUDEPARTMENT WHERE MAPVAL1='" + e.Node.Text + "'";
                }
                else if (e.Node.Level == 2)
                {
                    queryExe = "SELECT DISTINCT(FORM_NM) FROM MENUDEPARTMENT WHERE MAPVAL2='" + e.Node.Text + "'";
                }
                else
                {
                    MessageBox.Show("Erorr Occured");
                    return;
                }

                string connetionString = null;
                MySqlConnection cnn;
                connection con = new connection();
                connetionString = con.connetionString;

                cnn = new MySqlConnection(connetionString);
                MySqlCommand cmd = cnn.CreateCommand();
                cnn.Open();
                cmd.CommandText = queryExe;
                MySqlDataReader reader = cmd.ExecuteReader();
                string form_nm = "";
                while (reader.Read())
                {
                    form_nm = reader[0].ToString();
                }
                cnn.Close();



                FlowLayoutPanel pn = new FlowLayoutPanel();
                pn.Dock = DockStyle.Fill;
                string formToCall = form_nm;

                var type = Type.GetType(nameSpace + "." + formToCall);
                if (type != null)
                {
                    var userControl = Activator.CreateInstance(type) as UserControl;
                    if (Activator.CreateInstance(type) as UserControl != null)
                    {
                        userControl.Parent = pn;
                        userControl.Dock = DockStyle.Fill;
                        userControl.Anchor = AnchorStyles.Right;
                        userControl.Width = tabControl1.Width - 10;
                        userControl.Height = tabControl1.Height - 10;
                        userControl.Show();
                        pn.Controls.Add(userControl);
                    }
                }
                pn.AutoScroll = true;
                Apple.Controls.Add(pn);
                lblScreenName.Text = Apple.Text;
                Apple.Parent = tabControl1;
                Apple.Padding = new Padding(0);
                tabControl1.SelectedTab = Apple;
                return;
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            treeView1.Nodes.Clear();
           // MessageBox.Show(menuStrip1.Text); 
            //return;
            string ItemName = "MTP/2 -3-PLY";
            string subitemname = "op 1";

            TreeNode node = new TreeNode(ItemName);
            node.Nodes.Add("1");

            //treeView1.Nodes["Uno"].Nodes.Add("1");
            treeView1.Nodes.Add(node);
            treeView1.Nodes[0].Nodes.Add("2");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("contoh");

            string[] child = new string[] { "user", "approval" };
            string[] root = new string[] { "User Management","Form Management" };
            string[] child1 = new string[] { "Users","Update","Delete","Register" };
            foreach (string item in root)
            {
                TreeNode nodes = new TreeNode(item);
                foreach (string item1 in child)
                {
                    nodes.Nodes.Add(item1);
                }
                treeView1.Nodes.Add(nodes);
                foreach (string ch3 in child1)
                {
                    nodes.Nodes[0].Nodes.Add(ch3);
                }
            }
            */
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            treeView1.Nodes.Clear();
            Dictionary<string, string[]> X = new Dictionary<string, string[]>();
            Dictionary<string, Dictionary<string, string[]>> Y = new Dictionary<string, Dictionary<string, string[]>>();
            string[] rootParent = new string[0];

            string connetionString = null;
            MySqlConnection cnn;
            connection con = new connection();
            connetionString = con.connetionString;

            cnn = new MySqlConnection(connetionString);
            MySqlCommand cmd = cnn.CreateCommand();

            cnn.Open();
            cmd.CommandText = "SELECT DISTINCT(GROUP_NM) FROM MENUDEPARTMENT where MENUTOP_NM='" + e.ClickedItem.Text + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            int loop = 0;
            while (reader.Read())
            {
                Array.Resize(ref rootParent, rootParent.Length + 1);
                rootParent[loop] = reader[0].ToString();
                loop += 1;
            }
            loop = 0;
            cnn.Close();

            Dictionary<string, string[]> rtpar = new Dictionary<string, string[]>();
            for (int i = 0; i < rootParent.Length; i++)
            {
                cnn.Open();
                cmd.CommandText = "SELECT DISTINCT(MAPVAL1) FROM MENUDEPARTMENT WHERE GROUP_NM='" + rootParent[i] + "'";
                reader = cmd.ExecuteReader();
                loop = 0;
                string[] ch = new string[0];
                int chk = -1;
                while (reader.Read())
                {
                    Array.Resize(ref ch, ch.Length + 1);
                    ch[loop] = reader[0].ToString();
                    loop += 1;
                    chk = i;
                }
                cnn.Close();
                if (chk == i)
                {
                    rtpar.Add(rootParent[i], ch);
                }
                ch = null;
            }


            Dictionary<string, Dictionary<string, string[]>> allValue = new Dictionary<string, Dictionary<string, string[]>>();
            TreeNode TR = null;
            bool flag = false;
            for (int i = 0; i < rootParent.Length; i++)
            {
                if (rootParent[i] != "")
                {
                    flag = true;
                    TR = new TreeNode(rootParent[i]);
                    treeView1.Nodes.Add(TR);
                    //string x = rootParent[i] + ":";
                    for (int j = 0; j < rtpar[rootParent[i]].Length; j++)
                    {
                        // x += "" + rtpar[rootParent[i]][j].ToString();
                        if (rtpar[rootParent[i]][j] != "")
                            treeView1.Nodes[i].Nodes.Add(rtpar[rootParent[i]][j].ToString());
                        cnn.Open();
                        cmd.CommandText = "SELECT DISTINCT(MAPVAL2) FROM MENUDEPARTMENT WHERE GROUP_NM='" + rootParent[i] + "' AND MAPVAL1 = '" + rtpar[rootParent[i]][j] + "'";
                        reader = cmd.ExecuteReader();
                        loop = 0;
                        string[] ch = new string[0];
                        int chk = -1;
                        while (reader.Read())
                        {
                            if (reader[0].ToString() != "")
                                treeView1.Nodes[i].Nodes[j].Nodes.Add(reader[0].ToString());
                            //x += reader[0].ToString();
                        }
                        cnn.Close();
                    }
                }
                //x += "END";
                //MessageBox.Show(x);

            }
            if (!flag)
            {
                bool chek = false;
                TabPage temp = new TabPage();
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    if (tabControl1.TabPages[i].Text == e.ClickedItem.Text)
                    {
                        chek = true;
                        temp = tabControl1.TabPages[i];
                        break;
                    }
                }

                if (chek)
                {
                    tabControl1.SelectedTab = temp;
                    lblScreenName.Text = e.ClickedItem.Text;
                    return;
                }
                TabPage Apple = new TabPage(e.ClickedItem.Text);
                Apple.Controls.Clear();
                string connetionString1 = null;
                MySqlConnection cnn1;
                connection con1 = new connection();
                connetionString1 = con1.connetionString;

                cnn1 = new MySqlConnection(connetionString1);
                MySqlCommand cmd1 = cnn1.CreateCommand();
                cnn1.Open();
                cmd1.CommandText = "SELECT DISTINCT(FORM_NM) FROM MENUDEPARTMENT WHERE MENUTOP_NM='" + e.ClickedItem.Text + "'";
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                string form_nm = "";
                while (reader1.Read())
                {
                    form_nm = reader1[0].ToString();
                }
                cnn1.Close();

                // MessageBox.Show(e.ClickedItem.Text);
                FlowLayoutPanel pn = new FlowLayoutPanel();
                pn.Dock = DockStyle.Fill;
                string formToCall = form_nm;

                var type = Type.GetType(nameSpace + "." + formToCall);
                if (type != null)
                {
                    var userControl = Activator.CreateInstance(type) as UserControl;
                    if (Activator.CreateInstance(type) as UserControl != null)
                    {
                        userControl.Parent = pn;
                        userControl.Dock = DockStyle.Fill;
                        userControl.Anchor = AnchorStyles.Right;
                        userControl.Width = tabControl1.Width - 10;
                        userControl.Height = tabControl1.Height - 10;
                        userControl.Show();
                        pn.Controls.Add(userControl);
                    }
                }
                pn.AutoScroll = true;
                Apple.Controls.Add(pn);
                lblScreenName.Text = Apple.Text;
                Apple.Parent = tabControl1;
                Apple.Padding = new Padding(0);
                tabControl1.SelectedTab = Apple;
                return;
            }
        }

        Image CloseImage;

        public static string NIP = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            menuStrip1.Items.Clear();
            menuTop = new string[0];
            tabControl1.TabPages.Clear();
            treeView1.Nodes.Clear();
            maxTabPage = 15;
            nameSpace = "Management";

            if(NIP=="")
            {
                MessageBox.Show("NOT LOGIN");
                return;
            }

            string connetionString = null;
            MySqlConnection cnn;
            connection con = new connection();
            connetionString = con.connetionString;
            cnn = new MySqlConnection(connetionString);
            try
            {
                MySqlCommand command = cnn.CreateCommand();
                command.CommandText = "SELECT MENUACCES FROM USERS WHERE NIP='" + NIP + "' LIMIT 1";
                cnn.Open();
                string menuacces = "";
                MySqlDataReader READ = command.ExecuteReader();
                while (READ.Read())
                {
                    menuacces = READ[0].ToString();
                }
                cnn.Close();


                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = "SELECT NAME FROM MENUTOP WHERE id in(" + menuacces + ")";
                // cmd.CommandText = "SELECT NAME from menutop";
                cnn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Array.Resize(ref menuTop, menuTop.Length + 1);
                    menuTop[menuTop.Length - 1] = reader[0].ToString();
                }
                cnn.Close();
                for (int i = 0; i < menuTop.Length; i++)
                {
                    menuStrip1.Items.Add(menuTop[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }

            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.DrawItem += tabControl1_DrawItem;
            CloseImage = Management.Properties.Resources.icons8_close_window_14px;
            tabControl1.Padding = new Point(10);

            tabControl1.Padding = new System.Drawing.Point(21, 3);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    foreach (Control item in tabControl1.TabPages[i].Controls)
                    {
                        if (item is FlowLayoutPanel)
                        {
                            foreach (Control USR in item.Controls)
                            {
                                if (USR is UserControl)
                                {
                                    if(USR.Width < tabControl1.TabPages[i].Width)
                                    {
                                        USR.Width = tabControl1.TabPages[i].Width - 10;
                                       // USR.Height = tabControl1.TabPages[i].Height - 10;
                                    }
                                    if (USR.Height < tabControl1.TabPages[i].Height)
                                    {
                                       // USR.Width = tabControl1.TabPages[i].Width - 10;
                                        USR.Height = tabControl1.TabPages[i].Height - 10;
                                    }


                                    //USR.Width = tabControl1.TabPages[i].Width - 10;
                                    //USR.Height = tabControl1.TabPages[i].Height - 10;
                                    //USR.Dock = DockStyle.Fill;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erorr", ex.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("sda");
            this.tabPage1.AutoScroll = true;
        }
        const int LEADING_SPACE = 12;
        const int CLOSE_SPACE = 15;
        const int CLOSE_AREA = 15;
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                //This code will render a "x" mark at the end of the Tab caption. 
                var rectTab = this.tabControl1.GetTabRect(e.Index);
                rectTab.Inflate(-2, -2);
                var ImageRect = new Rectangle(rectTab.Right - CloseImage.Width, rectTab.Top + (rectTab.Height - CloseImage.Height) / 2, CloseImage.Width, CloseImage.Height);
                var sf = new StringFormat(StringFormat.GenericDefault);
                if (tabControl1.RightToLeft == System.Windows.Forms.RightToLeft.Yes &&
                    tabControl1.RightToLeftLayout == true
                    )
                {
                    rectTab = getClose(tabControl1.ClientRectangle, rectTab);
                    ImageRect = getClose(tabControl1.ClientRectangle, ImageRect);
                    sf.FormatFlags = StringFormatFlags.DirectionRightToLeft;
                }


                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text, this.Font, Brushes.Black, rectTab, sf);
                e.Graphics.DrawImage(CloseImage, ImageRect.Location);
            }
            catch
            {

            }
        }

        private static Rectangle getClose(Rectangle container, Rectangle drawRec)
        {
            return new Rectangle(
                container.Width - drawRec.Width - drawRec.X, drawRec.Y, drawRec.Width, drawRec.Height
                );

        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                var rectTab = tabControl1.GetTabRect(i);
                rectTab.Inflate(-2, -2);
                var Image = new Rectangle(rectTab.Right - CloseImage.Width, rectTab.Top + (rectTab.Height - CloseImage.Height) / 2, CloseImage.Width, CloseImage.Height);

                if (Image.Contains(e.Location))
                {
                    tabControl1.TabPages[i].Controls.Clear();
                    tabControl1.TabPages.RemoveAt(i);
                    break;
                }
                else
                {
                    if (tabControl1.TabPages[i].Text == tabControl1.SelectedTab.Text)
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[i];
                        lblScreenName.Text = tabControl1.SelectedTab.Text;
                        break;
                    }
                }
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(tabControl1.SelectedTab.Text);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(tabControl1.SelectedTab!=null)
            {
                bool flag = false;
                foreach (Control item in tabControl1.SelectedTab.Controls)
                {
                    if(item is FlowLayoutPanel)
                    {
                        foreach (Control txt in item.Controls)
                        {
                            if (txt is UserControl)
                            {
                                foreach (Control x in txt.Controls)
                                {
                                    if (x is TextBox)
                                    {
                                        if (x.Text != "")
                                        {
                                            flag = true;
                                            break;
                                        }
                                    }
                                }
                            }
                            
                        }
                    }    
                    
                }
                if (flag)
                {
                    DialogResult dg = MessageBox.Show("Apakah anda yakin ingin menghapus data ? ", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dg == DialogResult.Yes)
                    {
                        foreach (Control item in tabControl1.SelectedTab.Controls)
                        {
                            if (item is FlowLayoutPanel)
                            {
                                foreach (Control txt in item.Controls)
                                {
                                    if (txt is UserControl)
                                    {
                                        foreach (Control x in txt.Controls)
                                        {
                                            if (x is TextBox)
                                            {
                                                if (x.Text != "")
                                                {
                                                    x.Text = "";
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");
        }
    }
}