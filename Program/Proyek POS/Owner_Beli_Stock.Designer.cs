namespace Proyek_POS
{
    partial class Owner_Beli_Stock
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
            this.components = new System.ComponentModel.Container();
            this.btnKirim = new System.Windows.Forms.Button();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.lblKodeSistem = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNonota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKodeBarang = new System.Windows.Forms.TextBox();
            this.lblNamaBarang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHargaBarang = new System.Windows.Forms.TextBox();
            this.nudJumlahBeli = new System.Windows.Forms.NumericUpDown();
            this.lblSKodeSistem = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBeli = new System.Windows.Forms.Button();
            this.dgvBeliStok = new System.Windows.Forms.DataGridView();
            this.lblSTotalPembelian = new System.Windows.Forms.Label();
            this.lblSJumlahPembelian = new System.Windows.Forms.Label();
            this.lblJumlahPembelian = new System.Windows.Forms.Label();
            this.lblTotalPembelian = new System.Windows.Forms.Label();
            this.lblRP = new System.Windows.Forms.Label();
            this.gbOverview = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahBeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeliStok)).BeginInit();
            this.gbOverview.SuspendLayout();
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
            this.btnKirim.Size = new System.Drawing.Size(83, 106);
            this.btnKirim.TabIndex = 6;
            this.btnKirim.Text = "Update Data";
            this.btnKirim.UseVisualStyleBackColor = false;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.lblKodeSistem);
            this.gbDetail.Controls.Add(this.label5);
            this.gbDetail.Controls.Add(this.tbNonota);
            this.gbDetail.Controls.Add(this.label1);
            this.gbDetail.Controls.Add(this.tbKodeBarang);
            this.gbDetail.Controls.Add(this.lblNamaBarang);
            this.gbDetail.Controls.Add(this.label2);
            this.gbDetail.Controls.Add(this.label4);
            this.gbDetail.Controls.Add(this.tbHargaBarang);
            this.gbDetail.Controls.Add(this.nudJumlahBeli);
            this.gbDetail.Controls.Add(this.lblSKodeSistem);
            this.gbDetail.Controls.Add(this.label3);
            this.gbDetail.Location = new System.Drawing.Point(11, 7);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(631, 114);
            this.gbDetail.TabIndex = 41;
            this.gbDetail.TabStop = false;
            this.gbDetail.Enter += new System.EventHandler(this.gbDetail_Enter);
            // 
            // lblKodeSistem
            // 
            this.lblKodeSistem.AutoSize = true;
            this.lblKodeSistem.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKodeSistem.Location = new System.Drawing.Point(378, 77);
            this.lblKodeSistem.Name = "lblKodeSistem";
            this.lblKodeSistem.Size = new System.Drawing.Size(36, 18);
            this.lblKodeSistem.TabIndex = 37;
            this.lblKodeSistem.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Invoice :";
            // 
            // tbNonota
            // 
            this.tbNonota.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNonota.Location = new System.Drawing.Point(102, 14);
            this.tbNonota.Name = "tbNonota";
            this.tbNonota.Size = new System.Drawing.Size(190, 26);
            this.tbNonota.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Barcode :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbKodeBarang
            // 
            this.tbKodeBarang.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKodeBarang.Location = new System.Drawing.Point(102, 44);
            this.tbKodeBarang.Name = "tbKodeBarang";
            this.tbKodeBarang.Size = new System.Drawing.Size(190, 26);
            this.tbKodeBarang.TabIndex = 2;
            this.tbKodeBarang.TextChanged += new System.EventHandler(this.tbKodeBarang_TextChanged);
            this.tbKodeBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKodeBarang_KeyPress);
            // 
            // lblNamaBarang
            // 
            this.lblNamaBarang.AutoSize = true;
            this.lblNamaBarang.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaBarang.Location = new System.Drawing.Point(378, 17);
            this.lblNamaBarang.Name = "lblNamaBarang";
            this.lblNamaBarang.Size = new System.Drawing.Size(36, 18);
            this.lblNamaBarang.TabIndex = 34;
            this.lblNamaBarang.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Name :";
            // 
            // tbHargaBarang
            // 
            this.tbHargaBarang.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHargaBarang.Location = new System.Drawing.Point(102, 74);
            this.tbHargaBarang.Name = "tbHargaBarang";
            this.tbHargaBarang.Size = new System.Drawing.Size(190, 26);
            this.tbHargaBarang.TabIndex = 3;
            this.tbHargaBarang.Text = "0";
            this.tbHargaBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHargaBarang_KeyPress);
            // 
            // nudJumlahBeli
            // 
            this.nudJumlahBeli.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudJumlahBeli.Location = new System.Drawing.Point(380, 44);
            this.nudJumlahBeli.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudJumlahBeli.Name = "nudJumlahBeli";
            this.nudJumlahBeli.Size = new System.Drawing.Size(120, 26);
            this.nudJumlahBeli.TabIndex = 4;
            this.nudJumlahBeli.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSKodeSistem
            // 
            this.lblSKodeSistem.AutoSize = true;
            this.lblSKodeSistem.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSKodeSistem.Location = new System.Drawing.Point(298, 77);
            this.lblSKodeSistem.Name = "lblSKodeSistem";
            this.lblSKodeSistem.Size = new System.Drawing.Size(83, 18);
            this.lblSKodeSistem.TabIndex = 31;
            this.lblSKodeSistem.Text = "Syscode :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Amount :";
            // 
            // btnBeli
            // 
            this.btnBeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(157)))));
            this.btnBeli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBeli.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(174)))), ((int)(((byte)(65)))));
            this.btnBeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeli.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBeli.Location = new System.Drawing.Point(648, 14);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(69, 106);
            this.btnBeli.TabIndex = 5;
            this.btnBeli.Text = "Buy";
            this.btnBeli.UseVisualStyleBackColor = false;
            this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);
            // 
            // dgvBeliStok
            // 
            this.dgvBeliStok.AllowUserToAddRows = false;
            this.dgvBeliStok.AllowUserToDeleteRows = false;
            this.dgvBeliStok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBeliStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeliStok.Location = new System.Drawing.Point(11, 125);
            this.dgvBeliStok.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBeliStok.Name = "dgvBeliStok";
            this.dgvBeliStok.RowTemplate.Height = 24;
            this.dgvBeliStok.Size = new System.Drawing.Size(1122, 415);
            this.dgvBeliStok.TabIndex = 37;
            this.dgvBeliStok.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBeliStok_CellValueChanged);
            // 
            // lblSTotalPembelian
            // 
            this.lblSTotalPembelian.AutoSize = true;
            this.lblSTotalPembelian.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTotalPembelian.Location = new System.Drawing.Point(18, 31);
            this.lblSTotalPembelian.Name = "lblSTotalPembelian";
            this.lblSTotalPembelian.Size = new System.Drawing.Size(127, 18);
            this.lblSTotalPembelian.TabIndex = 13;
            this.lblSTotalPembelian.Text = "Total Purchase :";
            // 
            // lblSJumlahPembelian
            // 
            this.lblSJumlahPembelian.AutoSize = true;
            this.lblSJumlahPembelian.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSJumlahPembelian.Location = new System.Drawing.Point(18, 65);
            this.lblSJumlahPembelian.Name = "lblSJumlahPembelian";
            this.lblSJumlahPembelian.Size = new System.Drawing.Size(151, 18);
            this.lblSJumlahPembelian.TabIndex = 13;
            this.lblSJumlahPembelian.Text = "Purchase Amount :";
            // 
            // lblJumlahPembelian
            // 
            this.lblJumlahPembelian.AutoSize = true;
            this.lblJumlahPembelian.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlahPembelian.Location = new System.Drawing.Point(176, 64);
            this.lblJumlahPembelian.Name = "lblJumlahPembelian";
            this.lblJumlahPembelian.Size = new System.Drawing.Size(18, 18);
            this.lblJumlahPembelian.TabIndex = 18;
            this.lblJumlahPembelian.Text = "0";
            // 
            // lblTotalPembelian
            // 
            this.lblTotalPembelian.AutoSize = true;
            this.lblTotalPembelian.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPembelian.Location = new System.Drawing.Point(219, 31);
            this.lblTotalPembelian.Name = "lblTotalPembelian";
            this.lblTotalPembelian.Size = new System.Drawing.Size(18, 18);
            this.lblTotalPembelian.TabIndex = 19;
            this.lblTotalPembelian.Text = "0";
            // 
            // lblRP
            // 
            this.lblRP.AutoSize = true;
            this.lblRP.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRP.Location = new System.Drawing.Point(176, 31);
            this.lblRP.Name = "lblRP";
            this.lblRP.Size = new System.Drawing.Size(37, 18);
            this.lblRP.TabIndex = 18;
            this.lblRP.Text = "Rp. ";
            // 
            // gbOverview
            // 
            this.gbOverview.Controls.Add(this.lblTotalPembelian);
            this.gbOverview.Controls.Add(this.lblJumlahPembelian);
            this.gbOverview.Controls.Add(this.lblSJumlahPembelian);
            this.gbOverview.Controls.Add(this.lblRP);
            this.gbOverview.Controls.Add(this.lblSTotalPembelian);
            this.gbOverview.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOverview.Location = new System.Drawing.Point(723, 14);
            this.gbOverview.Name = "gbOverview";
            this.gbOverview.Size = new System.Drawing.Size(321, 107);
            this.gbOverview.TabIndex = 38;
            this.gbOverview.TabStop = false;
            this.gbOverview.Text = "Overview";
            // 
            // Owner_Beli_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 560);
            this.Controls.Add(this.btnKirim);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.btnBeli);
            this.Controls.Add(this.dgvBeliStok);
            this.Controls.Add(this.gbOverview);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Owner_Beli_Stock";
            this.Text = "Lihat Stock";
            this.Load += new System.EventHandler(this.Owner_Beli_Stock_Load);
            this.Shown += new System.EventHandler(this.Owner_Beli_Stock_Shown);
            this.VisibleChanged += new System.EventHandler(this.Owner_Beli_Stock_VisibleChanged);
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahBeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeliStok)).EndInit();
            this.gbOverview.ResumeLayout(false);
            this.gbOverview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKodeBarang;
        private System.Windows.Forms.Label lblNamaBarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHargaBarang;
        private System.Windows.Forms.NumericUpDown nudJumlahBeli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.DataGridView dgvBeliStok;
        private System.Windows.Forms.Label lblSTotalPembelian;
        private System.Windows.Forms.Label lblSJumlahPembelian;
        private System.Windows.Forms.Label lblJumlahPembelian;
        private System.Windows.Forms.Label lblTotalPembelian;
        private System.Windows.Forms.Label lblRP;
        private System.Windows.Forms.GroupBox gbOverview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNonota;
        private System.Windows.Forms.Label lblKodeSistem;
        private System.Windows.Forms.Label lblSKodeSistem;
        private System.Windows.Forms.Timer timer1;
    }
}