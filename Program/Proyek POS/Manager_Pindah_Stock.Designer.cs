namespace Proyek_POS
{
    partial class Manager_Pindah_Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnKirim = new System.Windows.Forms.Button();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKodeBarang = new System.Windows.Forms.TextBox();
            this.lblNamaBarang = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.btnPindah = new System.Windows.Forms.Button();
            this.dgvStokPengirim = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSJumlahPemindahan = new System.Windows.Forms.Label();
            this.lblJumlahPembelian = new System.Windows.Forms.Label();
            this.gbOverview = new System.Windows.Forms.GroupBox();
            this.btnKanan = new System.Windows.Forms.Button();
            this.btnKiri = new System.Windows.Forms.Button();
            this.lblSNama = new System.Windows.Forms.Label();
            this.lblSNama2 = new System.Windows.Forms.Label();
            this.dgvStokPenerima = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudJumlahPindah = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPemindahan = new System.Windows.Forms.ComboBox();
            this.lblSPemindahan = new System.Windows.Forms.Label();
            this.gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokPengirim)).BeginInit();
            this.gbOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokPenerima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahPindah)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKirim
            // 
            this.btnKirim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(157)))));
            this.btnKirim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKirim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(174)))), ((int)(((byte)(65)))));
            this.btnKirim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKirim.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKirim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKirim.Location = new System.Drawing.Point(1050, 14);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(83, 107);
            this.btnKirim.TabIndex = 7;
            this.btnKirim.Text = "Update Data";
            this.btnKirim.UseVisualStyleBackColor = false;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.label1);
            this.gbDetail.Controls.Add(this.tbKodeBarang);
            this.gbDetail.Controls.Add(this.lblNamaBarang);
            this.gbDetail.Controls.Add(this.label4);
            this.gbDetail.Location = new System.Drawing.Point(11, 40);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(401, 81);
            this.gbDetail.TabIndex = 41;
            this.gbDetail.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Barcode :";
            // 
            // tbKodeBarang
            // 
            this.tbKodeBarang.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKodeBarang.Location = new System.Drawing.Point(97, 14);
            this.tbKodeBarang.Name = "tbKodeBarang";
            this.tbKodeBarang.Size = new System.Drawing.Size(297, 26);
            this.tbKodeBarang.TabIndex = 2;
            this.tbKodeBarang.TextChanged += new System.EventHandler(this.tbKodeBarang_TextChanged);
            this.tbKodeBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKodeBarang_KeyDown);
            // 
            // lblNamaBarang
            // 
            this.lblNamaBarang.AutoSize = true;
            this.lblNamaBarang.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaBarang.Location = new System.Drawing.Point(97, 51);
            this.lblNamaBarang.Name = "lblNamaBarang";
            this.lblNamaBarang.Size = new System.Drawing.Size(36, 18);
            this.lblNamaBarang.TabIndex = 34;
            this.lblNamaBarang.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Name :";
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.Location = new System.Drawing.Point(447, 14);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(55, 18);
            this.lblTanggal.TabIndex = 29;
            this.lblTanggal.Text = "Date :";
            // 
            // btnPindah
            // 
            this.btnPindah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(157)))));
            this.btnPindah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPindah.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(174)))), ((int)(((byte)(65)))));
            this.btnPindah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPindah.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPindah.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPindah.Location = new System.Drawing.Point(634, 14);
            this.btnPindah.Name = "btnPindah";
            this.btnPindah.Size = new System.Drawing.Size(83, 107);
            this.btnPindah.TabIndex = 4;
            this.btnPindah.Text = "Transfer";
            this.btnPindah.UseVisualStyleBackColor = false;
            this.btnPindah.Click += new System.EventHandler(this.btnPindah_Click);
            // 
            // dgvStokPengirim
            // 
            this.dgvStokPengirim.AllowUserToAddRows = false;
            this.dgvStokPengirim.AllowUserToDeleteRows = false;
            this.dgvStokPengirim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStokPengirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStokPengirim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3});
            this.dgvStokPengirim.Location = new System.Drawing.Point(11, 156);
            this.dgvStokPengirim.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStokPengirim.Name = "dgvStokPengirim";
            this.dgvStokPengirim.ReadOnly = true;
            this.dgvStokPengirim.RowTemplate.Height = 24;
            this.dgvStokPengirim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStokPengirim.Size = new System.Drawing.Size(545, 384);
            this.dgvStokPengirim.TabIndex = 37;
            this.dgvStokPengirim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStokPusat_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Barcode";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column5.HeaderText = "Amount";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Qty/Box";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // lblSJumlahPemindahan
            // 
            this.lblSJumlahPemindahan.AutoSize = true;
            this.lblSJumlahPemindahan.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSJumlahPemindahan.Location = new System.Drawing.Point(18, 44);
            this.lblSJumlahPemindahan.Name = "lblSJumlahPemindahan";
            this.lblSJumlahPemindahan.Size = new System.Drawing.Size(176, 18);
            this.lblSJumlahPemindahan.TabIndex = 13;
            this.lblSJumlahPemindahan.Text = "Transferred Amounts :";
            // 
            // lblJumlahPembelian
            // 
            this.lblJumlahPembelian.AutoSize = true;
            this.lblJumlahPembelian.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlahPembelian.Location = new System.Drawing.Point(192, 44);
            this.lblJumlahPembelian.Name = "lblJumlahPembelian";
            this.lblJumlahPembelian.Size = new System.Drawing.Size(18, 18);
            this.lblJumlahPembelian.TabIndex = 18;
            this.lblJumlahPembelian.Text = "0";
            // 
            // gbOverview
            // 
            this.gbOverview.Controls.Add(this.lblJumlahPembelian);
            this.gbOverview.Controls.Add(this.lblSJumlahPemindahan);
            this.gbOverview.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOverview.Location = new System.Drawing.Point(723, 14);
            this.gbOverview.Name = "gbOverview";
            this.gbOverview.Size = new System.Drawing.Size(321, 107);
            this.gbOverview.TabIndex = 38;
            this.gbOverview.TabStop = false;
            this.gbOverview.Text = "Overview";
            // 
            // btnKanan
            // 
            this.btnKanan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(157)))));
            this.btnKanan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKanan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(157)))));
            this.btnKanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKanan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKanan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKanan.Location = new System.Drawing.Point(561, 278);
            this.btnKanan.Name = "btnKanan";
            this.btnKanan.Size = new System.Drawing.Size(22, 44);
            this.btnKanan.TabIndex = 5;
            this.btnKanan.Text = ">";
            this.btnKanan.UseVisualStyleBackColor = false;
            this.btnKanan.Click += new System.EventHandler(this.btnKanan_Click);
            // 
            // btnKiri
            // 
            this.btnKiri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(157)))));
            this.btnKiri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKiri.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(157)))));
            this.btnKiri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiri.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiri.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKiri.Location = new System.Drawing.Point(561, 328);
            this.btnKiri.Name = "btnKiri";
            this.btnKiri.Size = new System.Drawing.Size(22, 44);
            this.btnKiri.TabIndex = 6;
            this.btnKiri.Text = "<";
            this.btnKiri.UseVisualStyleBackColor = false;
            this.btnKiri.Click += new System.EventHandler(this.btnKiri_Click);
            // 
            // lblSNama
            // 
            this.lblSNama.AutoSize = true;
            this.lblSNama.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNama.Location = new System.Drawing.Point(12, 133);
            this.lblSNama.Name = "lblSNama";
            this.lblSNama.Size = new System.Drawing.Size(149, 18);
            this.lblSNama.TabIndex = 36;
            this.lblSNama.Text = "Central Warehouse";
            // 
            // lblSNama2
            // 
            this.lblSNama2.AutoSize = true;
            this.lblSNama2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNama2.Location = new System.Drawing.Point(591, 133);
            this.lblSNama2.Name = "lblSNama2";
            this.lblSNama2.Size = new System.Drawing.Size(147, 18);
            this.lblSNama2.TabIndex = 42;
            this.lblSNama2.Text = "Branch Warehouse";
            // 
            // dgvStokPenerima
            // 
            this.dgvStokPenerima.AllowUserToAddRows = false;
            this.dgvStokPenerima.AllowUserToDeleteRows = false;
            this.dgvStokPenerima.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStokPenerima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStokPenerima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column6,
            this.Column4});
            this.dgvStokPenerima.Location = new System.Drawing.Point(594, 156);
            this.dgvStokPenerima.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStokPenerima.Name = "dgvStokPenerima";
            this.dgvStokPenerima.ReadOnly = true;
            this.dgvStokPenerima.RowTemplate.Height = 24;
            this.dgvStokPenerima.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStokPenerima.Size = new System.Drawing.Size(545, 384);
            this.dgvStokPenerima.TabIndex = 43;
            this.dgvStokPenerima.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStokCabang_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Barcode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column6.HeaderText = "Amount";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Qty/Box";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // nudJumlahPindah
            // 
            this.nudJumlahPindah.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudJumlahPindah.Location = new System.Drawing.Point(450, 84);
            this.nudJumlahPindah.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudJumlahPindah.Name = "nudJumlahPindah";
            this.nudJumlahPindah.Size = new System.Drawing.Size(120, 26);
            this.nudJumlahPindah.TabIndex = 3;
            this.nudJumlahPindah.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Amount :";
            // 
            // cbPemindahan
            // 
            this.cbPemindahan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPemindahan.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPemindahan.FormattingEnabled = true;
            this.cbPemindahan.Items.AddRange(new object[] {
            "Central Warehouse -> Branch Warehouse",
            "Branch Warehouse -> Branch Display"});
            this.cbPemindahan.Location = new System.Drawing.Point(108, 11);
            this.cbPemindahan.Name = "cbPemindahan";
            this.cbPemindahan.Size = new System.Drawing.Size(297, 26);
            this.cbPemindahan.TabIndex = 1;
            this.cbPemindahan.SelectedIndexChanged += new System.EventHandler(this.cbPemindahan_SelectedIndexChanged);
            // 
            // lblSPemindahan
            // 
            this.lblSPemindahan.AutoSize = true;
            this.lblSPemindahan.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPemindahan.Location = new System.Drawing.Point(22, 14);
            this.lblSPemindahan.Name = "lblSPemindahan";
            this.lblSPemindahan.Size = new System.Drawing.Size(80, 18);
            this.lblSPemindahan.TabIndex = 47;
            this.lblSPemindahan.Text = "Transfer :";
            // 
            // Manager_Pindah_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 560);
            this.Controls.Add(this.cbPemindahan);
            this.Controls.Add(this.lblSPemindahan);
            this.Controls.Add(this.nudJumlahPindah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvStokPenerima);
            this.Controls.Add(this.lblSNama2);
            this.Controls.Add(this.lblSNama);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.btnKirim);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.btnKiri);
            this.Controls.Add(this.btnKanan);
            this.Controls.Add(this.btnPindah);
            this.Controls.Add(this.dgvStokPengirim);
            this.Controls.Add(this.gbOverview);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manager_Pindah_Stock";
            this.Text = "Lihat Stock";
            this.Shown += new System.EventHandler(this.Manager_Pindah_Stock_Shown);
            this.VisibleChanged += new System.EventHandler(this.Manager_Pindah_Stock_VisibleChanged);
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokPengirim)).EndInit();
            this.gbOverview.ResumeLayout(false);
            this.gbOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokPenerima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahPindah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKodeBarang;
        private System.Windows.Forms.Label lblNamaBarang;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPindah;
        private System.Windows.Forms.DataGridView dgvStokPengirim;
        private System.Windows.Forms.Label lblSJumlahPemindahan;
        private System.Windows.Forms.Label lblJumlahPembelian;
        private System.Windows.Forms.GroupBox gbOverview;
        private System.Windows.Forms.Button btnKanan;
        private System.Windows.Forms.Button btnKiri;
        private System.Windows.Forms.Label lblSNama;
        private System.Windows.Forms.Label lblSNama2;
        private System.Windows.Forms.DataGridView dgvStokPenerima;
        private System.Windows.Forms.NumericUpDown nudJumlahPindah;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPemindahan;
        private System.Windows.Forms.Label lblSPemindahan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}