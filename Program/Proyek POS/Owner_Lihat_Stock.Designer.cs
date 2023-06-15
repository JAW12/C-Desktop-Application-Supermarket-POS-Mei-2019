namespace Proyek_POS
{
    partial class Owner_Lihat_Stock
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtmTanggalAwal = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRusak = new System.Windows.Forms.Label();
            this.lblStokBaik = new System.Windows.Forms.Label();
            this.lblKadaluarsa = new System.Windows.Forms.Label();
            this.lblHilang = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSCabang = new System.Windows.Forms.Label();
            this.dtmTanggalAkhir = new System.Windows.Forms.DateTimePicker();
            this.lblSampai = new System.Windows.Forms.Label();
            this.cbIdCabang = new System.Windows.Forms.ComboBox();
            this.lblSBerdasarkan = new System.Windows.Forms.Label();
            this.lblSSearch = new System.Windows.Forms.Label();
            this.tbSearchKeyword = new System.Windows.Forms.TextBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cbBerdasarkan = new System.Windows.Forms.ComboBox();
            this.lblSFilter = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblDateNow = new System.Windows.Forms.Label();
            this.lblDateShow = new System.Windows.Forms.Label();
            this.dgvStokRealita = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStok = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellKode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellStokHilang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellStokRusak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellStokKadaluarsa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.cbStok = new System.Windows.Forms.ComboBox();
            this.gbStok = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokRealita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).BeginInit();
            this.SuspendLayout();
            // 
            // dtmTanggalAwal
            // 
            this.dtmTanggalAwal.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmTanggalAwal.Location = new System.Drawing.Point(505, 11);
            this.dtmTanggalAwal.Name = "dtmTanggalAwal";
            this.dtmTanggalAwal.Size = new System.Drawing.Size(153, 26);
            this.dtmTanggalAwal.TabIndex = 3;
            this.dtmTanggalAwal.ValueChanged += new System.EventHandler(this.dtmTanggalAwal_ValueChanged);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(157)))));
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(174)))), ((int)(((byte)(65)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShow.Location = new System.Drawing.Point(301, 19);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(64, 62);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRusak);
            this.groupBox1.Controls.Add(this.lblStokBaik);
            this.groupBox1.Controls.Add(this.lblKadaluarsa);
            this.groupBox1.Controls.Add(this.lblHilang);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 459);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 89);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overview";
            // 
            // lblRusak
            // 
            this.lblRusak.AutoSize = true;
            this.lblRusak.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRusak.Location = new System.Drawing.Point(124, 52);
            this.lblRusak.Name = "lblRusak";
            this.lblRusak.Size = new System.Drawing.Size(18, 18);
            this.lblRusak.TabIndex = 25;
            this.lblRusak.Text = "0";
            // 
            // lblStokBaik
            // 
            this.lblStokBaik.AutoSize = true;
            this.lblStokBaik.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStokBaik.Location = new System.Drawing.Point(363, 52);
            this.lblStokBaik.Name = "lblStokBaik";
            this.lblStokBaik.Size = new System.Drawing.Size(18, 18);
            this.lblStokBaik.TabIndex = 23;
            this.lblStokBaik.Text = "0";
            // 
            // lblKadaluarsa
            // 
            this.lblKadaluarsa.AutoSize = true;
            this.lblKadaluarsa.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKadaluarsa.Location = new System.Drawing.Point(363, 24);
            this.lblKadaluarsa.Name = "lblKadaluarsa";
            this.lblKadaluarsa.Size = new System.Drawing.Size(18, 18);
            this.lblKadaluarsa.TabIndex = 23;
            this.lblKadaluarsa.Text = "0";
            // 
            // lblHilang
            // 
            this.lblHilang.AutoSize = true;
            this.lblHilang.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHilang.Location = new System.Drawing.Point(124, 24);
            this.lblHilang.Name = "lblHilang";
            this.lblHilang.Size = new System.Drawing.Size(18, 18);
            this.lblHilang.TabIndex = 21;
            this.lblHilang.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(59, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Lost :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Available Stock : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(265, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Expired : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Damaged :";
            // 
            // lblSCabang
            // 
            this.lblSCabang.AutoSize = true;
            this.lblSCabang.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSCabang.Location = new System.Drawing.Point(12, 16);
            this.lblSCabang.Name = "lblSCabang";
            this.lblSCabang.Size = new System.Drawing.Size(71, 18);
            this.lblSCabang.TabIndex = 23;
            this.lblSCabang.Text = "Branch :";
            // 
            // dtmTanggalAkhir
            // 
            this.dtmTanggalAkhir.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmTanggalAkhir.Location = new System.Drawing.Point(685, 11);
            this.dtmTanggalAkhir.Name = "dtmTanggalAkhir";
            this.dtmTanggalAkhir.Size = new System.Drawing.Size(153, 26);
            this.dtmTanggalAkhir.TabIndex = 4;
            this.dtmTanggalAkhir.ValueChanged += new System.EventHandler(this.dtmTanggalAkhir_ValueChanged);
            // 
            // lblSampai
            // 
            this.lblSampai.AutoSize = true;
            this.lblSampai.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSampai.Location = new System.Drawing.Point(664, 14);
            this.lblSampai.Name = "lblSampai";
            this.lblSampai.Size = new System.Drawing.Size(15, 18);
            this.lblSampai.TabIndex = 23;
            this.lblSampai.Text = "-";
            // 
            // cbIdCabang
            // 
            this.cbIdCabang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbIdCabang.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdCabang.FormattingEnabled = true;
            this.cbIdCabang.Location = new System.Drawing.Point(94, 11);
            this.cbIdCabang.Name = "cbIdCabang";
            this.cbIdCabang.Size = new System.Drawing.Size(181, 26);
            this.cbIdCabang.TabIndex = 1;
            this.cbIdCabang.SelectedIndexChanged += new System.EventHandler(this.cbIdCabang_SelectedIndexChanged);
            // 
            // lblSBerdasarkan
            // 
            this.lblSBerdasarkan.AutoSize = true;
            this.lblSBerdasarkan.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSBerdasarkan.Location = new System.Drawing.Point(31, 61);
            this.lblSBerdasarkan.Name = "lblSBerdasarkan";
            this.lblSBerdasarkan.Size = new System.Drawing.Size(91, 18);
            this.lblSBerdasarkan.TabIndex = 23;
            this.lblSBerdasarkan.Text = "Based On :";
            // 
            // lblSSearch
            // 
            this.lblSSearch.AutoSize = true;
            this.lblSSearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSearch.Location = new System.Drawing.Point(51, 24);
            this.lblSSearch.Name = "lblSSearch";
            this.lblSSearch.Size = new System.Drawing.Size(71, 18);
            this.lblSSearch.TabIndex = 23;
            this.lblSSearch.Text = "Search :";
            // 
            // tbSearchKeyword
            // 
            this.tbSearchKeyword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchKeyword.Location = new System.Drawing.Point(128, 21);
            this.tbSearchKeyword.Name = "tbSearchKeyword";
            this.tbSearchKeyword.Size = new System.Drawing.Size(144, 27);
            this.tbSearchKeyword.TabIndex = 5;
            this.tbSearchKeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchKeyword_KeyDown);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.cbBerdasarkan);
            this.gbSearch.Controls.Add(this.tbSearchKeyword);
            this.gbSearch.Controls.Add(this.lblSBerdasarkan);
            this.gbSearch.Controls.Add(this.lblSSearch);
            this.gbSearch.Controls.Add(this.btnShow);
            this.gbSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.Location = new System.Drawing.Point(450, 459);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(387, 89);
            this.gbSearch.TabIndex = 28;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // cbBerdasarkan
            // 
            this.cbBerdasarkan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBerdasarkan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBerdasarkan.FormattingEnabled = true;
            this.cbBerdasarkan.Location = new System.Drawing.Point(128, 58);
            this.cbBerdasarkan.Name = "cbBerdasarkan";
            this.cbBerdasarkan.Size = new System.Drawing.Size(144, 26);
            this.cbBerdasarkan.TabIndex = 6;
            this.cbBerdasarkan.SelectedIndexChanged += new System.EventHandler(this.cbBerdasarkan_SelectedIndexChanged);
            this.cbBerdasarkan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbBerdasarkan_KeyDown);
            // 
            // lblSFilter
            // 
            this.lblSFilter.AutoSize = true;
            this.lblSFilter.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSFilter.Location = new System.Drawing.Point(287, 14);
            this.lblSFilter.Name = "lblSFilter";
            this.lblSFilter.Size = new System.Drawing.Size(56, 18);
            this.lblSFilter.TabIndex = 34;
            this.lblSFilter.Text = "Filter :";
            // 
            // cbFilter
            // 
            this.cbFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFilter.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "All",
            "Retail Stock",
            "Warehouse Stock",
            "Conformable Stock",
            "Unconformable Stock"});
            this.cbFilter.Location = new System.Drawing.Point(349, 10);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(143, 26);
            this.cbFilter.TabIndex = 2;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lblDateNow
            // 
            this.lblDateNow.AutoSize = true;
            this.lblDateNow.Location = new System.Drawing.Point(568, 57);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.Size = new System.Drawing.Size(92, 13);
            this.lblDateNow.TabIndex = 38;
            this.lblDateNow.Text = "tanggal hari ini";
            // 
            // lblDateShow
            // 
            this.lblDateShow.AutoSize = true;
            this.lblDateShow.Location = new System.Drawing.Point(13, 57);
            this.lblDateShow.Name = "lblDateShow";
            this.lblDateShow.Size = new System.Drawing.Size(167, 13);
            this.lblDateShow.TabIndex = 37;
            this.lblDateShow.Text = "tanggal awal - tanggal akhir";
            // 
            // dgvStokRealita
            // 
            this.dgvStokRealita.AllowUserToAddRows = false;
            this.dgvStokRealita.AllowUserToDeleteRows = false;
            this.dgvStokRealita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStokRealita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column9,
            this.Column7});
            this.dgvStokRealita.Location = new System.Drawing.Point(573, 75);
            this.dgvStokRealita.Name = "dgvStokRealita";
            this.dgvStokRealita.ReadOnly = true;
            this.dgvStokRealita.RowTemplate.Height = 24;
            this.dgvStokRealita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStokRealita.Size = new System.Drawing.Size(265, 368);
            this.dgvStokRealita.TabIndex = 36;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Barcode";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Name";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "Qty/Box";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Available Stock";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // dgvStok
            // 
            this.dgvStok.AllowUserToAddRows = false;
            this.dgvStok.AllowUserToDeleteRows = false;
            this.dgvStok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.cellKode,
            this.cellNama,
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3,
            this.cellStokHilang,
            this.cellStokRusak,
            this.cellStokKadaluarsa});
            this.dgvStok.Location = new System.Drawing.Point(16, 76);
            this.dgvStok.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStok.Name = "dgvStok";
            this.dgvStok.ReadOnly = true;
            this.dgvStok.RowTemplate.Height = 24;
            this.dgvStok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStok.Size = new System.Drawing.Size(547, 367);
            this.dgvStok.TabIndex = 35;
            this.dgvStok.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStok_CellValueChanged);
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Date";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // cellKode
            // 
            this.cellKode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cellKode.FillWeight = 135.5502F;
            this.cellKode.HeaderText = "Barcode";
            this.cellKode.Name = "cellKode";
            this.cellKode.ReadOnly = true;
            // 
            // cellNama
            // 
            this.cellNama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cellNama.FillWeight = 197.9957F;
            this.cellNama.HeaderText = "Name";
            this.cellNama.Name = "cellNama";
            this.cellNama.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column1.HeaderText = "Purchase Price";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column4.HeaderText = "Retail Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column2.HeaderText = "Warehouse Stock";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column3.HeaderText = "Sold";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // cellStokHilang
            // 
            this.cellStokHilang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cellStokHilang.DefaultCellStyle = dataGridViewCellStyle19;
            this.cellStokHilang.HeaderText = "Lost";
            this.cellStokHilang.Name = "cellStokHilang";
            this.cellStokHilang.ReadOnly = true;
            // 
            // cellStokRusak
            // 
            this.cellStokRusak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cellStokRusak.DefaultCellStyle = dataGridViewCellStyle20;
            this.cellStokRusak.HeaderText = "Damaged";
            this.cellStokRusak.Name = "cellStokRusak";
            this.cellStokRusak.ReadOnly = true;
            // 
            // cellStokKadaluarsa
            // 
            this.cellStokKadaluarsa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cellStokKadaluarsa.DefaultCellStyle = dataGridViewCellStyle21;
            this.cellStokKadaluarsa.HeaderText = "Expired";
            this.cellStokKadaluarsa.Name = "cellStokKadaluarsa";
            this.cellStokKadaluarsa.ReadOnly = true;
            // 
            // gbDetail
            // 
            this.gbDetail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetail.Location = new System.Drawing.Point(844, 345);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(279, 205);
            this.gbDetail.TabIndex = 45;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Detail";
            this.gbDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.gbDetail_Paint);
            // 
            // cbStok
            // 
            this.cbStok.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStok.FormattingEnabled = true;
            this.cbStok.Items.AddRange(new object[] {
            "Highest Available Stock",
            "Lowest Available Stock"});
            this.cbStok.Location = new System.Drawing.Point(844, 10);
            this.cbStok.Name = "cbStok";
            this.cbStok.Size = new System.Drawing.Size(279, 26);
            this.cbStok.TabIndex = 8;
            this.cbStok.SelectedIndexChanged += new System.EventHandler(this.cbStok_SelectedIndexChanged);
            // 
            // gbStok
            // 
            this.gbStok.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStok.Location = new System.Drawing.Point(844, 42);
            this.gbStok.Name = "gbStok";
            this.gbStok.Size = new System.Drawing.Size(279, 297);
            this.gbStok.TabIndex = 43;
            this.gbStok.TabStop = false;
            this.gbStok.Text = "Highest Avail. Stock";
            this.gbStok.Paint += new System.Windows.Forms.PaintEventHandler(this.gbStok_Paint);
            // 
            // Owner_Lihat_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 560);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.cbStok);
            this.Controls.Add(this.gbStok);
            this.Controls.Add(this.lblDateNow);
            this.Controls.Add(this.lblDateShow);
            this.Controls.Add(this.dgvStokRealita);
            this.Controls.Add(this.dgvStok);
            this.Controls.Add(this.lblSFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.cbIdCabang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtmTanggalAkhir);
            this.Controls.Add(this.dtmTanggalAwal);
            this.Controls.Add(this.lblSampai);
            this.Controls.Add(this.lblSCabang);
            this.Controls.Add(this.gbSearch);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Owner_Lihat_Stock";
            this.Text = "Lihat Stock";
            this.Shown += new System.EventHandler(this.Owner_Lihat_Stock_Shown);
            this.VisibleChanged += new System.EventHandler(this.Owner_Lihat_Stock_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokRealita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtmTanggalAwal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRusak;
        private System.Windows.Forms.Label lblStokBaik;
        private System.Windows.Forms.Label lblKadaluarsa;
        private System.Windows.Forms.Label lblHilang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSCabang;
        private System.Windows.Forms.DateTimePicker dtmTanggalAkhir;
        private System.Windows.Forms.Label lblSampai;
        private System.Windows.Forms.ComboBox cbIdCabang;
        private System.Windows.Forms.Label lblSBerdasarkan;
        private System.Windows.Forms.Label lblSSearch;
        private System.Windows.Forms.TextBox tbSearchKeyword;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblSFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.ComboBox cbBerdasarkan;
        private System.Windows.Forms.Label lblDateNow;
        private System.Windows.Forms.Label lblDateShow;
        private System.Windows.Forms.DataGridView dgvStokRealita;
        private System.Windows.Forms.DataGridView dgvStok;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.ComboBox cbStok;
        private System.Windows.Forms.GroupBox gbStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellStokHilang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellStokRusak;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellStokKadaluarsa;
    }
}