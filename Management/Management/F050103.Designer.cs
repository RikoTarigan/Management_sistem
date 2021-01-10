namespace Management
{
    partial class F050103
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoJaminan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.cbxJenisJaminan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTypeBarang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNamaAnggota = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCetak = new System.Windows.Forms.Button();
            this.ds_data = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.dataColumn19 = new System.Data.DataColumn();
            this.dataColumn20 = new System.Data.DataColumn();
            this.dataColumn21 = new System.Data.DataColumn();
            this.dataColumn22 = new System.Data.DataColumn();
            this.dataColumn23 = new System.Data.DataColumn();
            this.dataColumn24 = new System.Data.DataColumn();
            this.dataColumn25 = new System.Data.DataColumn();
            this.dataColumn26 = new System.Data.DataColumn();
            this.dataColumn27 = new System.Data.DataColumn();
            this.dataColumn36 = new System.Data.DataColumn();
            this.dataColumn35 = new System.Data.DataColumn();
            this.dataColumn34 = new System.Data.DataColumn();
            this.dataColumn33 = new System.Data.DataColumn();
            this.dataColumn32 = new System.Data.DataColumn();
            this.dataColumn31 = new System.Data.DataColumn();
            this.dataColumn30 = new System.Data.DataColumn();
            this.dataColumn29 = new System.Data.DataColumn();
            this.dataColumn28 = new System.Data.DataColumn();
            this.dataTable2 = new System.Data.DataTable();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ds_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(3, 200);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 36);
            this.button1.TabIndex = 52;
            this.button1.Text = "Keluarkan Barang";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 133);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Tgl Keluar";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_data, "JAMINAN.TANGGAL_MASUK", true));
            this.textBox5.Location = new System.Drawing.Point(84, 109);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(174, 20);
            this.textBox5.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Diregister";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_data, "JAMINAN.NAMA_COLLECTOR", true));
            this.textBox4.Location = new System.Drawing.Point(84, 85);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(174, 20);
            this.textBox4.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Diserahkan";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_data, "JAMINAN.NO_ANGGOTA", true));
            this.textBox2.Location = new System.Drawing.Point(84, 61);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 20);
            this.textBox2.TabIndex = 31;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "No Anggota";
            // 
            // txtNoJaminan
            // 
            this.txtNoJaminan.Enabled = false;
            this.txtNoJaminan.Location = new System.Drawing.Point(84, 9);
            this.txtNoJaminan.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoJaminan.Multiline = true;
            this.txtNoJaminan.Name = "txtNoJaminan";
            this.txtNoJaminan.Size = new System.Drawing.Size(229, 23);
            this.txtNoJaminan.TabIndex = 29;
            this.txtNoJaminan.TextChanged += new System.EventHandler(this.txtNoJaminan_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Jaminan Id";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(311, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 23);
            this.button3.TabIndex = 54;
            this.button3.Text = "Cari";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeterangan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_data, "JAMINAN.KET1", true));
            this.txtKeterangan.Location = new System.Drawing.Point(627, 59);
            this.txtKeterangan.Margin = new System.Windows.Forms.Padding(2);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKeterangan.Size = new System.Drawing.Size(151, 129);
            this.txtKeterangan.TabIndex = 55;
            // 
            // cbxJenisJaminan
            // 
            this.cbxJenisJaminan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_data, "JAMINAN.JENIS_JAMINAN", true));
            this.cbxJenisJaminan.FormattingEnabled = true;
            this.cbxJenisJaminan.Items.AddRange(new object[] {
            "Kendaraan",
            "Surat",
            "Barang",
            "Emas",
            "dll"});
            this.cbxJenisJaminan.Location = new System.Drawing.Point(399, 81);
            this.cbxJenisJaminan.Name = "cbxJenisJaminan";
            this.cbxJenisJaminan.Size = new System.Drawing.Size(224, 21);
            this.cbxJenisJaminan.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 132;
            this.label1.Text = "Type Barang";
            // 
            // txtTypeBarang
            // 
            this.txtTypeBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_data, "JAMINAN.TIPE_BARANG", true));
            this.txtTypeBarang.Location = new System.Drawing.Point(399, 168);
            this.txtTypeBarang.Margin = new System.Windows.Forms.Padding(2);
            this.txtTypeBarang.Name = "txtTypeBarang";
            this.txtTypeBarang.Size = new System.Drawing.Size(224, 20);
            this.txtTypeBarang.TabIndex = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 131;
            this.label8.Text = "Diterima Dari";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(399, 103);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 122;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(327, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 130;
            this.label9.Text = "Merk Barang";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(323, 123);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 129;
            this.label10.Text = "Nama Barang";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(399, 147);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(224, 20);
            this.textBox6.TabIndex = 124;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_data, "JAMINAN.NAMA_BARANG", true));
            this.txtNamaBarang.Location = new System.Drawing.Point(399, 125);
            this.txtNamaBarang.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(224, 20);
            this.txtNamaBarang.TabIndex = 123;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(322, 84);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 13);
            this.label20.TabIndex = 128;
            this.label20.Text = "Jenis Jaminan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(317, 65);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 126;
            this.label11.Text = "Nama Anggota";
            // 
            // txtNamaAnggota
            // 
            this.txtNamaAnggota.Location = new System.Drawing.Point(399, 60);
            this.txtNamaAnggota.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamaAnggota.Name = "txtNamaAnggota";
            this.txtNamaAnggota.Size = new System.Drawing.Size(224, 20);
            this.txtNamaAnggota.TabIndex = 120;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(3, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 1);
            this.panel1.TabIndex = 133;
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(111, 200);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(222, 36);
            this.btnCetak.TabIndex = 134;
            this.btnCetak.Text = "CETAK KONFIRMASI KELUAR BARANG";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // ds_data
            // 
            this.ds_data.DataSetName = "NewDataSet";
            this.ds_data.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1,
            this.dataTable2});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16,
            this.dataColumn17,
            this.dataColumn18,
            this.dataColumn19,
            this.dataColumn20,
            this.dataColumn21,
            this.dataColumn22,
            this.dataColumn23,
            this.dataColumn24,
            this.dataColumn25,
            this.dataColumn26,
            this.dataColumn27});
            this.dataTable1.TableName = "NASABAH";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "NAMA_COSTUMER";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "NO_KTP";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "NO_KK";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "AGAMA";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "TEMPAT_LAHIR";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "TANGGAL_LAHIR";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "JK";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "ALAMAT_KTP";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "ALAMAT_DOMISILI";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "TELP";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "PEKERJAAN";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "NAMA_IBU_KANDUNG";
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "TANGGAL_LAHIR_IBU";
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "NAMA_USAHA";
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "ALAMAT_UsAHA";
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "JENIS_USAHA";
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "NAMA_BANK";
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "NO_REKENING";
            // 
            // dataColumn19
            // 
            this.dataColumn19.ColumnName = "NAMA_REKENING";
            // 
            // dataColumn20
            // 
            this.dataColumn20.ColumnName = "NAMA_SALES";
            // 
            // dataColumn21
            // 
            this.dataColumn21.ColumnName = "WILAYAH_AREA_TAGIH";
            // 
            // dataColumn22
            // 
            this.dataColumn22.ColumnName = "STATUS_APPL";
            // 
            // dataColumn23
            // 
            this.dataColumn23.ColumnName = "STATUS_MENIKAH";
            // 
            // dataColumn24
            // 
            this.dataColumn24.ColumnName = "NAMA_PASANGAN";
            // 
            // dataColumn25
            // 
            this.dataColumn25.ColumnName = "NO_KTP_PASANGAN";
            // 
            // dataColumn26
            // 
            this.dataColumn26.ColumnName = "ALAMAT_PASANGAN";
            // 
            // dataColumn27
            // 
            this.dataColumn27.ColumnName = "TELP_PASANGAN";
            // 
            // dataColumn36
            // 
            this.dataColumn36.ColumnName = "NAMA_COLLECTOR";
            // 
            // dataColumn35
            // 
            this.dataColumn35.ColumnName = "KET2";
            // 
            // dataColumn34
            // 
            this.dataColumn34.ColumnName = "KET1";
            // 
            // dataColumn33
            // 
            this.dataColumn33.ColumnName = "TIPE_BARANG";
            // 
            // dataColumn32
            // 
            this.dataColumn32.ColumnName = "NAMA_BARANG";
            // 
            // dataColumn31
            // 
            this.dataColumn31.ColumnName = "TANGGAL_MASUK";
            // 
            // dataColumn30
            // 
            this.dataColumn30.ColumnName = "NO_ANGGOTA";
            // 
            // dataColumn29
            // 
            this.dataColumn29.ColumnName = "JENIS_JAMINAN";
            // 
            // dataColumn28
            // 
            this.dataColumn28.ColumnName = "NO_JAMINAN";
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn28,
            this.dataColumn29,
            this.dataColumn30,
            this.dataColumn31,
            this.dataColumn32,
            this.dataColumn33,
            this.dataColumn34,
            this.dataColumn35,
            this.dataColumn36});
            this.dataTable2.TableName = "JAMINAN";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 241);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(775, 176);
            this.richTextBox1.TabIndex = 135;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // F050103
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxJenisJaminan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTypeBarang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNamaAnggota);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNoJaminan);
            this.Controls.Add(this.label2);
            this.Name = "F050103";
            this.Size = new System.Drawing.Size(796, 433);
            this.Load += new System.EventHandler(this.F050103_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoJaminan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.ComboBox cbxJenisJaminan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTypeBarang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNamaAnggota;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCetak;
        public System.Data.DataSet ds_data;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataColumn dataColumn18;
        private System.Data.DataColumn dataColumn19;
        private System.Data.DataColumn dataColumn20;
        private System.Data.DataColumn dataColumn21;
        private System.Data.DataColumn dataColumn22;
        private System.Data.DataColumn dataColumn23;
        private System.Data.DataColumn dataColumn24;
        private System.Data.DataColumn dataColumn25;
        private System.Data.DataColumn dataColumn26;
        private System.Data.DataColumn dataColumn27;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn dataColumn28;
        private System.Data.DataColumn dataColumn29;
        private System.Data.DataColumn dataColumn30;
        private System.Data.DataColumn dataColumn31;
        private System.Data.DataColumn dataColumn32;
        private System.Data.DataColumn dataColumn33;
        private System.Data.DataColumn dataColumn34;
        private System.Data.DataColumn dataColumn35;
        private System.Data.DataColumn dataColumn36;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
