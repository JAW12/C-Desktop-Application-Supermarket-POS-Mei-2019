namespace Proyek_POS
{
    partial class Owner_Lihat_Penjualan
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
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cbBerdasarkan = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSBerdasarkan = new System.Windows.Forms.Label();
            this.lblSSearch = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.cbIdCabang = new System.Windows.Forms.ComboBox();
            this.dtmTanggalAkhir = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSCabang = new System.Windows.Forms.Label();
            this.lblPemasukkan = new System.Windows.Forms.Label();
            this.lblPotongan = new System.Windows.Forms.Label();
            this.lblPengeluaran = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.dtmTanggalAwal = new System.Windows.Forms.DateTimePicker();
            this.gbPenjualan = new System.Windows.Forms.GroupBox();
            this.dgvStok = new System.Windows.Forms.DataGridView();
            this.cellKode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellQtyBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokAwal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellStokKadaluarsa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokRealita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbPenjualan = new System.Windows.Forms.ComboBox();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.gbSearch.SuspendLayout();
            this.gbTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.cbBerdasarkan);
            this.gbSearch.Controls.Add(this.tbSearch);
            this.gbSearch.Controls.Add(this.lblSBerdasarkan);
            this.gbSearch.Controls.Add(this.lblSSearch);
            this.gbSearch.Controls.Add(this.btnShow);
            this.gbSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.Location = new System.Drawing.Point(465, 461);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(378, 89);
            this.gbSearch.TabIndex = 37;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // cbBerdasarkan
            // 
            this.cbBerdasarkan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBerdasarkan.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBerdasarkan.FormattingEnabled = true;
            this.cbBerdasarkan.Items.AddRange(new object[] {
            "Barcode",
            "Name",
            "Retail Price",
            "Amount",
            "Subtotal"});
            this.cbBerdasarkan.Location = new System.Drawing.Point(120, 53);
            this.cbBerdasarkan.Name = "cbBerdasarkan";
            this.cbBerdasarkan.Size = new System.Drawing.Size(169, 24);
            this.cbBerdasarkan.TabIndex = 5;
            this.cbBerdasarkan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbBerdasarkan_KeyDown);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(120, 21);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(169, 23);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // lblSBerdasarkan
            // 
            this.lblSBerdasarkan.AutoSize = true;
            this.lblSBerdasarkan.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSBerdasarkan.Location = new System.Drawing.Point(28, 56);
            this.lblSBerdasarkan.Name = "lblSBerdasarkan";
            this.lblSBerdasarkan.Size = new System.Drawing.Size(86, 16);
            this.lblSBerdasarkan.TabIndex = 23;
            this.lblSBerdasarkan.Text = "Based On : ";
            // 
            // lblSSearch
            // 
            this.lblSSearch.AutoSize = true;
            this.lblSSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSearch.Location = new System.Drawing.Point(49, 24);
            this.lblSSearch.Name = "lblSSearch";
            this.lblSSearch.Size = new System.Drawing.Size(65, 16);
            this.lblSSearch.TabIndex = 23;
            this.lblSSearch.Text = "Search :";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(157)))));
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(174)))), ((int)(((byte)(65)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShow.Location = new System.Drawing.Point(308, 20);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(64, 57);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cbIdCabang
            // 
            this.cbIdCabang.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdCabang.FormattingEnabled = true;
            this.cbIdCabang.Location = new System.Drawing.Point(103, 10);
            this.cbIdCabang.Name = "cbIdCabang";
            this.cbIdCabang.Size = new System.Drawing.Size(254, 26);
            this.cbIdCabang.TabIndex = 1;
            this.cbIdCabang.SelectedIndexChanged += new System.EventHandler(this.cbIdCabang_SelectedIndexChanged);
            // 
            // dtmTanggalAkhir
            // 
            this.dtmTanggalAkhir.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmTanggalAkhir.Location = new System.Drawing.Point(649, 10);
            this.dtmTanggalAkhir.Name = "dtmTanggalAkhir";
            this.dtmTanggalAkhir.Size = new System.Drawing.Size(194, 26);
            this.dtmTanggalAkhir.TabIndex = 3;
            this.dtmTanggalAkhir.ValueChanged += new System.EventHandler(this.dtmTanggalAkhir_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(628, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "-";
            // 
            // lblSCabang
            // 
            this.lblSCabang.AutoSize = true;
            this.lblSCabang.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSCabang.Location = new System.Drawing.Point(21, 13);
            this.lblSCabang.Name = "lblSCabang";
            this.lblSCabang.Size = new System.Drawing.Size(71, 18);
            this.lblSCabang.TabIndex = 34;
            this.lblSCabang.Text = "Branch :";
            // 
            // lblPemasukkan
            // 
            this.lblPemasukkan.AutoSize = true;
            this.lblPemasukkan.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPemasukkan.Location = new System.Drawing.Point(127, 56);
            this.lblPemasukkan.Name = "lblPemasukkan";
            this.lblPemasukkan.Size = new System.Drawing.Size(36, 16);
            this.lblPemasukkan.TabIndex = 21;
            this.lblPemasukkan.Text = "Rp -";
            // 
            // lblPotongan
            // 
            this.lblPotongan.AutoSize = true;
            this.lblPotongan.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotongan.Location = new System.Drawing.Point(248, 56);
            this.lblPotongan.Name = "lblPotongan";
            this.lblPotongan.Size = new System.Drawing.Size(36, 16);
            this.lblPotongan.TabIndex = 21;
            this.lblPotongan.Text = "Rp -";
            // 
            // lblPengeluaran
            // 
            this.lblPengeluaran.AutoSize = true;
            this.lblPengeluaran.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPengeluaran.Location = new System.Drawing.Point(127, 28);
            this.lblPengeluaran.Name = "lblPengeluaran";
            this.lblPengeluaran.Size = new System.Drawing.Size(36, 16);
            this.lblPengeluaran.TabIndex = 21;
            this.lblPengeluaran.Text = "Rp -";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Outflow :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(248, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sales Discounts : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Inflow :";
            // 
            // gbTotal
            // 
            this.gbTotal.Controls.Add(this.lblPemasukkan);
            this.gbTotal.Controls.Add(this.lblPotongan);
            this.gbTotal.Controls.Add(this.lblPengeluaran);
            this.gbTotal.Controls.Add(this.label9);
            this.gbTotal.Controls.Add(this.label8);
            this.gbTotal.Controls.Add(this.label7);
            this.gbTotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotal.Location = new System.Drawing.Point(13, 461);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(446, 89);
            this.gbTotal.TabIndex = 38;
            this.gbTotal.TabStop = false;
            this.gbTotal.Text = "Cashflow";
            // 
            // dtmTanggalAwal
            // 
            this.dtmTanggalAwal.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmTanggalAwal.Location = new System.Drawing.Point(451, 10);
            this.dtmTanggalAwal.Name = "dtmTanggalAwal";
            this.dtmTanggalAwal.Size = new System.Drawing.Size(171, 26);
            this.dtmTanggalAwal.TabIndex = 2;
            this.dtmTanggalAwal.ValueChanged += new System.EventHandler(this.dtmTanggalAwal_ValueChanged);
            // 
            // gbPenjualan
            // 
            this.gbPenjualan.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPenjualan.Location = new System.Drawing.Point(851, 42);
            this.gbPenjualan.Name = "gbPenjualan";
            this.gbPenjualan.Size = new System.Drawing.Size(279, 297);
            this.gbPenjualan.TabIndex = 41;
            this.gbPenjualan.TabStop = false;
            this.gbPenjualan.Text = "Most Selling";
            this.gbPenjualan.Paint += new System.Windows.Forms.PaintEventHandler(this.gbPenjualan_Paint);
            // 
            // dgvStok
            // 
            this.dgvStok.AllowUserToAddRows = false;
            this.dgvStok.AllowUserToDeleteRows = false;
            this.dgvStok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cellKode,
            this.cellNama,
            this.cellQtyBox,
            this.StokAwal,
            this.cellStokKadaluarsa,
            this.StokRealita});
            this.dgvStok.Location = new System.Drawing.Point(12, 41);
            this.dgvStok.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStok.Name = "dgvStok";
            this.dgvStok.RowTemplate.Height = 24;
            this.dgvStok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStok.Size = new System.Drawing.Size(831, 415);
            this.dgvStok.TabIndex = 32;
            // 
            // cellKode
            // 
            this.cellKode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cellKode.FillWeight = 135.5502F;
            this.cellKode.HeaderText = "Date";
            this.cellKode.Name = "cellKode";
            this.cellKode.ReadOnly = true;
            // 
            // cellNama
            // 
            this.cellNama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cellNama.FillWeight = 197.9957F;
            this.cellNama.HeaderText = "Barcode";
            this.cellNama.Name = "cellNama";
            this.cellNama.ReadOnly = true;
            // 
            // cellQtyBox
            // 
            this.cellQtyBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cellQtyBox.HeaderText = "Name";
            this.cellQtyBox.Name = "cellQtyBox";
            this.cellQtyBox.ReadOnly = true;
            // 
            // StokAwal
            // 
            this.StokAwal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.StokAwal.DefaultCellStyle = dataGridViewCellStyle1;
            this.StokAwal.FillWeight = 55.34606F;
            this.StokAwal.HeaderText = "Retail Price";
            this.StokAwal.Name = "StokAwal";
            this.StokAwal.ReadOnly = true;
            // 
            // cellStokKadaluarsa
            // 
            this.cellStokKadaluarsa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cellStokKadaluarsa.DefaultCellStyle = dataGridViewCellStyle2;
            this.cellStokKadaluarsa.HeaderText = "Amount";
            this.cellStokKadaluarsa.Name = "cellStokKadaluarsa";
            this.cellStokKadaluarsa.ReadOnly = true;
            // 
            // StokRealita
            // 
            this.StokRealita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.StokRealita.DefaultCellStyle = dataGridViewCellStyle3;
            this.StokRealita.FillWeight = 50.76142F;
            this.StokRealita.HeaderText = "Subtotal";
            this.StokRealita.Name = "StokRealita";
            this.StokRealita.ReadOnly = true;
            // 
            // cbPenjualan
            // 
            this.cbPenjualan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPenjualan.FormattingEnabled = true;
            this.cbPenjualan.Items.AddRange(new object[] {
            "Most Selling",
            "Least Selling"});
            this.cbPenjualan.Location = new System.Drawing.Point(851, 10);
            this.cbPenjualan.Name = "cbPenjualan";
            this.cbPenjualan.Size = new System.Drawing.Size(279, 26);
            this.cbPenjualan.TabIndex = 7;
            this.cbPenjualan.SelectedIndexChanged += new System.EventHandler(this.cbPenjualan_SelectedIndexChanged);
            // 
            // gbDetail
            // 
            this.gbDetail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetail.Location = new System.Drawing.Point(851, 345);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(279, 205);
            this.gbDetail.TabIndex = 42;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Detail";
            this.gbDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.gbDetail_Paint);
            // 
            // Owner_Lihat_Penjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 560);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.cbPenjualan);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.cbIdCabang);
            this.Controls.Add(this.dtmTanggalAkhir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSCabang);
            this.Controls.Add(this.gbTotal);
            this.Controls.Add(this.dtmTanggalAwal);
            this.Controls.Add(this.gbPenjualan);
            this.Controls.Add(this.dgvStok);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Owner_Lihat_Penjualan";
            this.Text = "Lihat Stock";
            this.Shown += new System.EventHandler(this.Owner_Lihat_Penjualan_Shown);
            this.VisibleChanged += new System.EventHandler(this.Owner_Lihat_Penjualan_VisibleChanged);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbTotal.ResumeLayout(false);
            this.gbTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSBerdasarkan;
        private System.Windows.Forms.Label lblSSearch;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cbIdCabang;
        private System.Windows.Forms.DateTimePicker dtmTanggalAkhir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSCabang;
        private System.Windows.Forms.Label lblPemasukkan;
        private System.Windows.Forms.Label lblPotongan;
        private System.Windows.Forms.Label lblPengeluaran;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbTotal;
        private System.Windows.Forms.DateTimePicker dtmTanggalAwal;
        private System.Windows.Forms.GroupBox gbPenjualan;
        private System.Windows.Forms.DataGridView dgvStok;
        private System.Windows.Forms.ComboBox cbBerdasarkan;
        private System.Windows.Forms.ComboBox cbPenjualan;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellQtyBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokAwal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellStokKadaluarsa;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokRealita;
    }
}