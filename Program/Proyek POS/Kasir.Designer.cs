namespace Proyek_POS
{
    partial class Kasir
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kasir));
            this.lblSTanggal = new System.Windows.Forms.Label();
            this.cbKodeBarang = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.nudEditJumlah = new System.Windows.Forms.NumericUpDown();
            this.lblJumlahBarang = new System.Windows.Forms.Label();
            this.lblKodeBarang = new System.Windows.Forms.Label();
            this.gbInputPenjualan = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblNamaBarang = new System.Windows.Forms.Label();
            this.lblsJumlahBarangInput = new System.Windows.Forms.Label();
            this.lblSNamaBarang = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.nudInputJumlah = new System.Windows.Forms.NumericUpDown();
            this.lblSKodeBarang = new System.Windows.Forms.Label();
            this.tbKodeBarang = new System.Windows.Forms.TextBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.gbEditPenjualan = new System.Windows.Forms.GroupBox();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.btnBayar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSTotal = new System.Windows.Forms.Label();
            this.lblNoNota = new System.Windows.Forms.Label();
            this.lblNamaKasir = new System.Windows.Forms.Label();
            this.lblSNoNota = new System.Windows.Forms.Label();
            this.dgvInput = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSNamaKasir = new System.Windows.Forms.Label();
            this.gbMember = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbNoKartu = new System.Windows.Forms.TextBox();
            this.lblSNoKartu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbKasir = new System.Windows.Forms.GroupBox();
            this.tmrJam = new System.Windows.Forms.Timer(this.components);
            this.tmrPenjualan = new System.Windows.Forms.Timer(this.components);
            this.lblNamaCabang = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.pbLogOut = new System.Windows.Forms.PictureBox();
            this.tmrBayar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudEditJumlah)).BeginInit();
            this.gbInputPenjualan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputJumlah)).BeginInit();
            this.gbEditPenjualan.SuspendLayout();
            this.gbTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).BeginInit();
            this.gbMember.SuspendLayout();
            this.gbKasir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogOut)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSTanggal
            // 
            this.lblSTanggal.AutoSize = true;
            this.lblSTanggal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTanggal.Location = new System.Drawing.Point(38, 69);
            this.lblSTanggal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSTanggal.Name = "lblSTanggal";
            this.lblSTanggal.Size = new System.Drawing.Size(62, 18);
            this.lblSTanggal.TabIndex = 28;
            this.lblSTanggal.Text = "Time :";
            // 
            // cbKodeBarang
            // 
            this.cbKodeBarang.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKodeBarang.FormattingEnabled = true;
            this.cbKodeBarang.Location = new System.Drawing.Point(122, 26);
            this.cbKodeBarang.Margin = new System.Windows.Forms.Padding(2);
            this.cbKodeBarang.Name = "cbKodeBarang";
            this.cbKodeBarang.Size = new System.Drawing.Size(233, 26);
            this.cbKodeBarang.TabIndex = 5;
            this.cbKodeBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbKodeBarang_KeyDown);
            this.cbKodeBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputAngkaSaja);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(66)))), ((int)(((byte)(65)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(157)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(161, 117);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 40);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(174)))), ((int)(((byte)(65)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(157)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(260, 117);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 40);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // nudEditJumlah
            // 
            this.nudEditJumlah.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEditJumlah.Location = new System.Drawing.Point(122, 66);
            this.nudEditJumlah.Margin = new System.Windows.Forms.Padding(2);
            this.nudEditJumlah.Name = "nudEditJumlah";
            this.nudEditJumlah.Size = new System.Drawing.Size(233, 27);
            this.nudEditJumlah.TabIndex = 6;
            // 
            // lblJumlahBarang
            // 
            this.lblJumlahBarang.AutoSize = true;
            this.lblJumlahBarang.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlahBarang.Location = new System.Drawing.Point(31, 68);
            this.lblJumlahBarang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJumlahBarang.Name = "lblJumlahBarang";
            this.lblJumlahBarang.Size = new System.Drawing.Size(84, 18);
            this.lblJumlahBarang.TabIndex = 2;
            this.lblJumlahBarang.Text = "Amount :";
            // 
            // lblKodeBarang
            // 
            this.lblKodeBarang.AutoSize = true;
            this.lblKodeBarang.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKodeBarang.Location = new System.Drawing.Point(29, 29);
            this.lblKodeBarang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKodeBarang.Name = "lblKodeBarang";
            this.lblKodeBarang.Size = new System.Drawing.Size(86, 18);
            this.lblKodeBarang.TabIndex = 0;
            this.lblKodeBarang.Text = "Barcode :";
            // 
            // gbInputPenjualan
            // 
            this.gbInputPenjualan.Controls.Add(this.btnBrowse);
            this.gbInputPenjualan.Controls.Add(this.lblNamaBarang);
            this.gbInputPenjualan.Controls.Add(this.lblsJumlahBarangInput);
            this.gbInputPenjualan.Controls.Add(this.lblSNamaBarang);
            this.gbInputPenjualan.Controls.Add(this.btnInput);
            this.gbInputPenjualan.Controls.Add(this.nudInputJumlah);
            this.gbInputPenjualan.Controls.Add(this.lblSKodeBarang);
            this.gbInputPenjualan.Controls.Add(this.tbKodeBarang);
            this.gbInputPenjualan.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInputPenjualan.Location = new System.Drawing.Point(903, 113);
            this.gbInputPenjualan.Margin = new System.Windows.Forms.Padding(2);
            this.gbInputPenjualan.Name = "gbInputPenjualan";
            this.gbInputPenjualan.Padding = new System.Windows.Forms.Padding(2);
            this.gbInputPenjualan.Size = new System.Drawing.Size(370, 179);
            this.gbInputPenjualan.TabIndex = 30;
            this.gbInputPenjualan.TabStop = false;
            this.gbInputPenjualan.Text = "Input";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(157)))));
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(174)))), ((int)(((byte)(65)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrowse.Location = new System.Drawing.Point(161, 125);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(95, 40);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblNamaBarang
            // 
            this.lblNamaBarang.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaBarang.Location = new System.Drawing.Point(119, 58);
            this.lblNamaBarang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamaBarang.Name = "lblNamaBarang";
            this.lblNamaBarang.Size = new System.Drawing.Size(236, 24);
            this.lblNamaBarang.TabIndex = 26;
            this.lblNamaBarang.Text = "-";
            this.lblNamaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblsJumlahBarangInput
            // 
            this.lblsJumlahBarangInput.AutoSize = true;
            this.lblsJumlahBarangInput.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsJumlahBarangInput.Location = new System.Drawing.Point(31, 88);
            this.lblsJumlahBarangInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsJumlahBarangInput.Name = "lblsJumlahBarangInput";
            this.lblsJumlahBarangInput.Size = new System.Drawing.Size(84, 18);
            this.lblsJumlahBarangInput.TabIndex = 3;
            this.lblsJumlahBarangInput.Text = "Amount :";
            // 
            // lblSNamaBarang
            // 
            this.lblSNamaBarang.AutoSize = true;
            this.lblSNamaBarang.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNamaBarang.Location = new System.Drawing.Point(47, 60);
            this.lblSNamaBarang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSNamaBarang.Name = "lblSNamaBarang";
            this.lblSNamaBarang.Size = new System.Drawing.Size(68, 18);
            this.lblSNamaBarang.TabIndex = 25;
            this.lblSNamaBarang.Text = "Name :";
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(174)))), ((int)(((byte)(65)))));
            this.btnInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInput.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(157)))));
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInput.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.Location = new System.Drawing.Point(260, 125);
            this.btnInput.Margin = new System.Windows.Forms.Padding(2);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(95, 40);
            this.btnInput.TabIndex = 3;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // nudInputJumlah
            // 
            this.nudInputJumlah.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInputJumlah.Location = new System.Drawing.Point(122, 86);
            this.nudInputJumlah.Margin = new System.Windows.Forms.Padding(2);
            this.nudInputJumlah.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInputJumlah.Name = "nudInputJumlah";
            this.nudInputJumlah.Size = new System.Drawing.Size(233, 27);
            this.nudInputJumlah.TabIndex = 2;
            this.nudInputJumlah.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInputJumlah.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudInputJumlah_KeyDown);
            // 
            // lblSKodeBarang
            // 
            this.lblSKodeBarang.AutoSize = true;
            this.lblSKodeBarang.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSKodeBarang.Location = new System.Drawing.Point(29, 32);
            this.lblSKodeBarang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSKodeBarang.Name = "lblSKodeBarang";
            this.lblSKodeBarang.Size = new System.Drawing.Size(86, 18);
            this.lblSKodeBarang.TabIndex = 0;
            this.lblSKodeBarang.Text = "Barcode :";
            // 
            // tbKodeBarang
            // 
            this.tbKodeBarang.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKodeBarang.Location = new System.Drawing.Point(122, 29);
            this.tbKodeBarang.Margin = new System.Windows.Forms.Padding(2);
            this.tbKodeBarang.Name = "tbKodeBarang";
            this.tbKodeBarang.Size = new System.Drawing.Size(233, 27);
            this.tbKodeBarang.TabIndex = 1;
            this.tbKodeBarang.TextChanged += new System.EventHandler(this.tbKodeBarang_TextChanged);
            this.tbKodeBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKodeBarang_KeyDown);
            this.tbKodeBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputAngkaSaja);
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.Location = new System.Drawing.Point(118, 69);
            this.lblTanggal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(127, 18);
            this.lblTanggal.TabIndex = 32;
            this.lblTanggal.Text = "DD-MON-YYYY";
            // 
            // gbEditPenjualan
            // 
            this.gbEditPenjualan.Controls.Add(this.cbKodeBarang);
            this.gbEditPenjualan.Controls.Add(this.btnEdit);
            this.gbEditPenjualan.Controls.Add(this.nudEditJumlah);
            this.gbEditPenjualan.Controls.Add(this.lblJumlahBarang);
            this.gbEditPenjualan.Controls.Add(this.lblKodeBarang);
            this.gbEditPenjualan.Controls.Add(this.btnDelete);
            this.gbEditPenjualan.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditPenjualan.Location = new System.Drawing.Point(903, 296);
            this.gbEditPenjualan.Margin = new System.Windows.Forms.Padding(2);
            this.gbEditPenjualan.Name = "gbEditPenjualan";
            this.gbEditPenjualan.Padding = new System.Windows.Forms.Padding(2);
            this.gbEditPenjualan.Size = new System.Drawing.Size(370, 180);
            this.gbEditPenjualan.TabIndex = 29;
            this.gbEditPenjualan.TabStop = false;
            this.gbEditPenjualan.Text = "Edit";
            // 
            // gbTotal
            // 
            this.gbTotal.Controls.Add(this.btnBayar);
            this.gbTotal.Controls.Add(this.button2);
            this.gbTotal.Controls.Add(this.lblTotal);
            this.gbTotal.Controls.Add(this.lblSTotal);
            this.gbTotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotal.Location = new System.Drawing.Point(707, 11);
            this.gbTotal.Margin = new System.Windows.Forms.Padding(2);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Padding = new System.Windows.Forms.Padding(2);
            this.gbTotal.Size = new System.Drawing.Size(475, 98);
            this.gbTotal.TabIndex = 25;
            this.gbTotal.TabStop = false;
            this.gbTotal.Text = "Total";
            // 
            // btnBayar
            // 
            this.btnBayar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(174)))), ((int)(((byte)(65)))));
            this.btnBayar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBayar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(157)))));
            this.btnBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBayar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBayar.Location = new System.Drawing.Point(369, 48);
            this.btnBayar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(95, 40);
            this.btnBayar.TabIndex = 12;
            this.btnBayar.Text = "Pay";
            this.btnBayar.UseVisualStyleBackColor = false;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 158);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 19);
            this.button2.TabIndex = 5;
            this.button2.Text = "Bayar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(131, 20);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 45);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "0";
            // 
            // lblSTotal
            // 
            this.lblSTotal.AutoSize = true;
            this.lblSTotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTotal.Location = new System.Drawing.Point(13, 22);
            this.lblSTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSTotal.Name = "lblSTotal";
            this.lblSTotal.Size = new System.Drawing.Size(114, 23);
            this.lblSTotal.TabIndex = 2;
            this.lblSTotal.Text = "TOTAL Rp";
            // 
            // lblNoNota
            // 
            this.lblNoNota.AutoSize = true;
            this.lblNoNota.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoNota.Location = new System.Drawing.Point(118, 43);
            this.lblNoNota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoNota.Name = "lblNoNota";
            this.lblNoNota.Size = new System.Drawing.Size(125, 18);
            this.lblNoNota.TabIndex = 6;
            this.lblNoNota.Text = "xxxxxxxxxxxxx";
            // 
            // lblNamaKasir
            // 
            this.lblNamaKasir.AutoSize = true;
            this.lblNamaKasir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaKasir.Location = new System.Drawing.Point(118, 16);
            this.lblNamaKasir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamaKasir.Name = "lblNamaKasir";
            this.lblNamaKasir.Size = new System.Drawing.Size(102, 18);
            this.lblNamaKasir.TabIndex = 1;
            this.lblNamaKasir.Text = "Nama Kasir";
            // 
            // lblSNoNota
            // 
            this.lblSNoNota.AutoSize = true;
            this.lblSNoNota.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNoNota.Location = new System.Drawing.Point(17, 43);
            this.lblSNoNota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSNoNota.Name = "lblSNoNota";
            this.lblSNoNota.Size = new System.Drawing.Size(83, 18);
            this.lblSNoNota.TabIndex = 5;
            this.lblSNoNota.Text = "Invoice :";
            // 
            // dgvInput
            // 
            this.dgvInput.AllowUserToAddRows = false;
            this.dgvInput.AllowUserToDeleteRows = false;
            this.dgvInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInput.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column4,
            this.Column3,
            this.Column5});
            this.dgvInput.Location = new System.Drawing.Point(10, 113);
            this.dgvInput.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInput.Name = "dgvInput";
            this.dgvInput.ReadOnly = true;
            this.dgvInput.RowTemplate.Height = 24;
            this.dgvInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInput.Size = new System.Drawing.Size(884, 502);
            this.dgvInput.TabIndex = 15;
            this.dgvInput.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInput_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30.45685F;
            this.Column1.HeaderText = "No.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 113.9086F;
            this.Column2.HeaderText = "Barcode";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 113.9086F;
            this.Column6.HeaderText = "Name";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.FillWeight = 113.9086F;
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.FillWeight = 113.9086F;
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.FillWeight = 113.9086F;
            this.Column5.HeaderText = "Subtotal";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // lblSNamaKasir
            // 
            this.lblSNamaKasir.AutoSize = true;
            this.lblSNamaKasir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNamaKasir.Location = new System.Drawing.Point(15, 16);
            this.lblSNamaKasir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSNamaKasir.Name = "lblSNamaKasir";
            this.lblSNamaKasir.Size = new System.Drawing.Size(85, 18);
            this.lblSNamaKasir.TabIndex = 0;
            this.lblSNamaKasir.Text = "Cashier :";
            // 
            // gbMember
            // 
            this.gbMember.Controls.Add(this.btnConfirm);
            this.gbMember.Controls.Add(this.tbNoKartu);
            this.gbMember.Controls.Add(this.lblSNoKartu);
            this.gbMember.Controls.Add(this.label1);
            this.gbMember.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMember.Location = new System.Drawing.Point(356, 11);
            this.gbMember.Margin = new System.Windows.Forms.Padding(2);
            this.gbMember.Name = "gbMember";
            this.gbMember.Padding = new System.Windows.Forms.Padding(2);
            this.gbMember.Size = new System.Drawing.Size(335, 98);
            this.gbMember.TabIndex = 26;
            this.gbMember.TabStop = false;
            this.gbMember.Text = "Member";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(174)))), ((int)(((byte)(65)))));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(157)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(224, 58);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(90, 30);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbNoKartu
            // 
            this.tbNoKartu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoKartu.Location = new System.Drawing.Point(116, 27);
            this.tbNoKartu.Margin = new System.Windows.Forms.Padding(2);
            this.tbNoKartu.Name = "tbNoKartu";
            this.tbNoKartu.Size = new System.Drawing.Size(198, 27);
            this.tbNoKartu.TabIndex = 9;
            this.tbNoKartu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNoKartu_KeyDown);
            this.tbNoKartu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputAngkaSaja);
            // 
            // lblSNoKartu
            // 
            this.lblSNoKartu.AutoSize = true;
            this.lblSNoKartu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNoKartu.Location = new System.Drawing.Point(21, 30);
            this.lblSNoKartu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSNoKartu.Name = "lblSNoKartu";
            this.lblSNoKartu.Size = new System.Drawing.Size(91, 18);
            this.lblSNoKartu.TabIndex = 0;
            this.lblSNoKartu.Text = "Member :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(21, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Register";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // gbKasir
            // 
            this.gbKasir.Controls.Add(this.lblSTanggal);
            this.gbKasir.Controls.Add(this.lblNoNota);
            this.gbKasir.Controls.Add(this.lblTanggal);
            this.gbKasir.Controls.Add(this.lblNamaKasir);
            this.gbKasir.Controls.Add(this.lblSNoNota);
            this.gbKasir.Controls.Add(this.lblSNamaKasir);
            this.gbKasir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKasir.Location = new System.Drawing.Point(11, 11);
            this.gbKasir.Margin = new System.Windows.Forms.Padding(2);
            this.gbKasir.Name = "gbKasir";
            this.gbKasir.Padding = new System.Windows.Forms.Padding(2);
            this.gbKasir.Size = new System.Drawing.Size(327, 98);
            this.gbKasir.TabIndex = 24;
            this.gbKasir.TabStop = false;
            this.gbKasir.Text = "Cashier";
            // 
            // tmrJam
            // 
            this.tmrJam.Interval = 1000;
            this.tmrJam.Tick += new System.EventHandler(this.tmrJam_Tick);
            // 
            // tmrPenjualan
            // 
            this.tmrPenjualan.Tick += new System.EventHandler(this.tmrPenjualan_Tick);
            // 
            // lblNamaCabang
            // 
            this.lblNamaCabang.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaCabang.Location = new System.Drawing.Point(1039, 597);
            this.lblNamaCabang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamaCabang.Name = "lblNamaCabang";
            this.lblNamaCabang.Size = new System.Drawing.Size(234, 18);
            this.lblNamaCabang.TabIndex = 39;
            this.lblNamaCabang.Text = "Nama Cabang";
            this.lblNamaCabang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblMinimize.Location = new System.Drawing.Point(1230, 9);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(18, 18);
            this.lblMinimize.TabIndex = 13;
            this.lblMinimize.Text = "_";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseEnter += new System.EventHandler(this.lblMinimize_MouseEnter);
            this.lblMinimize.MouseLeave += new System.EventHandler(this.lblMinimize_MouseLeave);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblClose.Location = new System.Drawing.Point(1254, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(19, 18);
            this.lblClose.TabIndex = 14;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblMinimize_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblMinimize_MouseLeave);
            // 
            // pbLogOut
            // 
            this.pbLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogOut.Image = global::Proyek_POS.Properties.Resources.logout;
            this.pbLogOut.Location = new System.Drawing.Point(1206, 59);
            this.pbLogOut.Name = "pbLogOut";
            this.pbLogOut.Size = new System.Drawing.Size(42, 39);
            this.pbLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogOut.TabIndex = 31;
            this.pbLogOut.TabStop = false;
            this.pbLogOut.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pbLogOut.MouseEnter += new System.EventHandler(this.pbLogOut_MouseEnter);
            this.pbLogOut.MouseLeave += new System.EventHandler(this.pbLogOut_MouseLeave);
            // 
            // tmrBayar
            // 
            this.tmrBayar.Tick += new System.EventHandler(this.tmrBayar_Tick);
            // 
            // Kasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 626);
            this.Controls.Add(this.lblMinimize);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblNamaCabang);
            this.Controls.Add(this.pbLogOut);
            this.Controls.Add(this.gbInputPenjualan);
            this.Controls.Add(this.gbEditPenjualan);
            this.Controls.Add(this.gbTotal);
            this.Controls.Add(this.dgvInput);
            this.Controls.Add(this.gbMember);
            this.Controls.Add(this.gbKasir);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Kasir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasir";
            this.Activated += new System.EventHandler(this.Kasir_Activated);
            this.Load += new System.EventHandler(this.Kasir_Load);
            this.VisibleChanged += new System.EventHandler(this.Kasir_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.nudEditJumlah)).EndInit();
            this.gbInputPenjualan.ResumeLayout(false);
            this.gbInputPenjualan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputJumlah)).EndInit();
            this.gbEditPenjualan.ResumeLayout(false);
            this.gbEditPenjualan.PerformLayout();
            this.gbTotal.ResumeLayout(false);
            this.gbTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).EndInit();
            this.gbMember.ResumeLayout(false);
            this.gbMember.PerformLayout();
            this.gbKasir.ResumeLayout(false);
            this.gbKasir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSTanggal;
        private System.Windows.Forms.ComboBox cbKodeBarang;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.NumericUpDown nudEditJumlah;
        private System.Windows.Forms.Label lblJumlahBarang;
        private System.Windows.Forms.Label lblKodeBarang;
        private System.Windows.Forms.GroupBox gbInputPenjualan;
        private System.Windows.Forms.Label lblNamaBarang;
        private System.Windows.Forms.Label lblsJumlahBarangInput;
        private System.Windows.Forms.Label lblSNamaBarang;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.NumericUpDown nudInputJumlah;
        private System.Windows.Forms.Label lblSKodeBarang;
        private System.Windows.Forms.TextBox tbKodeBarang;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.GroupBox gbEditPenjualan;
        private System.Windows.Forms.GroupBox gbTotal;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSTotal;
        private System.Windows.Forms.Label lblNoNota;
        private System.Windows.Forms.Label lblNamaKasir;
        private System.Windows.Forms.Label lblSNoNota;
        private System.Windows.Forms.DataGridView dgvInput;
        private System.Windows.Forms.Label lblSNamaKasir;
        private System.Windows.Forms.GroupBox gbMember;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbNoKartu;
        private System.Windows.Forms.Label lblSNoKartu;
        private System.Windows.Forms.GroupBox gbKasir;
        private System.Windows.Forms.PictureBox pbLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrJam;
        private System.Windows.Forms.Timer tmrPenjualan;
        private System.Windows.Forms.Label lblNamaCabang;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Timer tmrBayar;
    }
}