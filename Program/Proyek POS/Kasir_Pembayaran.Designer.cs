namespace Proyek_POS
{
    partial class Kasir_Pembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kasir_Pembayaran));
            this.lblSPembayaran = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbPembayaran = new System.Windows.Forms.TextBox();
            this.lblSJudul = new System.Windows.Forms.Label();
            this.lblSTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSKembalian = new System.Windows.Forms.Label();
            this.lblKembalian = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btn1k = new System.Windows.Forms.Button();
            this.btn2k = new System.Windows.Forms.Button();
            this.btn5k = new System.Windows.Forms.Button();
            this.btn10k = new System.Windows.Forms.Button();
            this.btn20k = new System.Windows.Forms.Button();
            this.btn50k = new System.Windows.Forms.Button();
            this.btn100k = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSPembayaran
            // 
            this.lblSPembayaran.AutoSize = true;
            this.lblSPembayaran.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPembayaran.Location = new System.Drawing.Point(142, 195);
            this.lblSPembayaran.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSPembayaran.Name = "lblSPembayaran";
            this.lblSPembayaran.Size = new System.Drawing.Size(97, 18);
            this.lblSPembayaran.TabIndex = 2;
            this.lblSPembayaran.Text = "Payment :";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(157)))));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Enabled = false;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(174)))), ((int)(((byte)(65)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirm.Location = new System.Drawing.Point(236, 267);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(117, 40);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbPembayaran
            // 
            this.tbPembayaran.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPembayaran.Location = new System.Drawing.Point(253, 192);
            this.tbPembayaran.Margin = new System.Windows.Forms.Padding(2);
            this.tbPembayaran.Name = "tbPembayaran";
            this.tbPembayaran.Size = new System.Drawing.Size(195, 27);
            this.tbPembayaran.TabIndex = 1;
            this.tbPembayaran.Text = "0";
            this.tbPembayaran.TextChanged += new System.EventHandler(this.tbPembayaran_TextChanged);
            this.tbPembayaran.Leave += new System.EventHandler(this.tbPembayaran_Leave);
            // 
            // lblSJudul
            // 
            this.lblSJudul.AutoSize = true;
            this.lblSJudul.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSJudul.Location = new System.Drawing.Point(226, 97);
            this.lblSJudul.Name = "lblSJudul";
            this.lblSJudul.Size = new System.Drawing.Size(97, 35);
            this.lblSJudul.TabIndex = 12;
            this.lblSJudul.Text = "Total";
            // 
            // lblSTotal
            // 
            this.lblSTotal.AutoSize = true;
            this.lblSTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTotal.Location = new System.Drawing.Point(175, 162);
            this.lblSTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSTotal.Name = "lblSTotal";
            this.lblSTotal.Size = new System.Drawing.Size(64, 18);
            this.lblSTotal.TabIndex = 2;
            this.lblSTotal.Text = "Total :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(250, 162);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 18);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Rp 0";
            // 
            // lblSKembalian
            // 
            this.lblSKembalian.AutoSize = true;
            this.lblSKembalian.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSKembalian.Location = new System.Drawing.Point(153, 231);
            this.lblSKembalian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSKembalian.Name = "lblSKembalian";
            this.lblSKembalian.Size = new System.Drawing.Size(86, 18);
            this.lblSKembalian.TabIndex = 2;
            this.lblSKembalian.Text = "Change :";
            // 
            // lblKembalian
            // 
            this.lblKembalian.AutoSize = true;
            this.lblKembalian.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKembalian.Location = new System.Drawing.Point(250, 231);
            this.lblKembalian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKembalian.Name = "lblKembalian";
            this.lblKembalian.Size = new System.Drawing.Size(48, 18);
            this.lblKembalian.TabIndex = 2;
            this.lblKembalian.Text = "Rp 0";
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblMinimize.Location = new System.Drawing.Point(943, 11);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(18, 18);
            this.lblMinimize.TabIndex = 14;
            this.lblMinimize.Text = "_";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblClose.Location = new System.Drawing.Point(967, 11);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(19, 18);
            this.lblClose.TabIndex = 15;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btn100
            // 
            this.btn100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn100.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn100.FlatAppearance.BorderSize = 5;
            this.btn100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn100.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn100.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn100.Location = new System.Drawing.Point(849, 318);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(137, 60);
            this.btn100.TabIndex = 11;
            this.btn100.Text = "100";
            this.btn100.UseVisualStyleBackColor = false;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btn200
            // 
            this.btn200.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn200.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn200.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn200.FlatAppearance.BorderSize = 5;
            this.btn200.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn200.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn200.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn200.Location = new System.Drawing.Point(706, 318);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(137, 60);
            this.btn200.TabIndex = 10;
            this.btn200.Text = "200";
            this.btn200.UseVisualStyleBackColor = false;
            this.btn200.Click += new System.EventHandler(this.btn200_Click);
            // 
            // btn500
            // 
            this.btn500.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn500.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn500.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn500.FlatAppearance.BorderSize = 5;
            this.btn500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn500.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn500.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn500.Location = new System.Drawing.Point(561, 318);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(137, 60);
            this.btn500.TabIndex = 9;
            this.btn500.Text = "500";
            this.btn500.UseVisualStyleBackColor = false;
            this.btn500.Click += new System.EventHandler(this.btn500_Click);
            // 
            // btn1k
            // 
            this.btn1k.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn1k.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1k.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn1k.FlatAppearance.BorderSize = 5;
            this.btn1k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1k.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1k.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn1k.Location = new System.Drawing.Point(849, 252);
            this.btn1k.Name = "btn1k";
            this.btn1k.Size = new System.Drawing.Size(138, 60);
            this.btn1k.TabIndex = 8;
            this.btn1k.Text = "1.000";
            this.btn1k.UseVisualStyleBackColor = false;
            this.btn1k.Click += new System.EventHandler(this.btn1k_Click);
            // 
            // btn2k
            // 
            this.btn2k.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn2k.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2k.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(169)))), ((int)(((byte)(186)))));
            this.btn2k.FlatAppearance.BorderSize = 5;
            this.btn2k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2k.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2k.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn2k.Location = new System.Drawing.Point(704, 252);
            this.btn2k.Name = "btn2k";
            this.btn2k.Size = new System.Drawing.Size(137, 60);
            this.btn2k.TabIndex = 7;
            this.btn2k.Text = "2.000";
            this.btn2k.UseVisualStyleBackColor = false;
            this.btn2k.Click += new System.EventHandler(this.btn2k_Click);
            // 
            // btn5k
            // 
            this.btn5k.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn5k.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5k.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(173)))), ((int)(((byte)(105)))));
            this.btn5k.FlatAppearance.BorderSize = 5;
            this.btn5k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5k.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5k.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn5k.Location = new System.Drawing.Point(560, 252);
            this.btn5k.Name = "btn5k";
            this.btn5k.Size = new System.Drawing.Size(137, 60);
            this.btn5k.TabIndex = 6;
            this.btn5k.Text = "5.000";
            this.btn5k.UseVisualStyleBackColor = false;
            this.btn5k.Click += new System.EventHandler(this.btn5k_Click);
            // 
            // btn10k
            // 
            this.btn10k.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn10k.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn10k.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(92)))), ((int)(((byte)(163)))));
            this.btn10k.FlatAppearance.BorderSize = 5;
            this.btn10k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10k.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10k.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn10k.Location = new System.Drawing.Point(849, 186);
            this.btn10k.Name = "btn10k";
            this.btn10k.Size = new System.Drawing.Size(137, 60);
            this.btn10k.TabIndex = 5;
            this.btn10k.Text = "10.000";
            this.btn10k.UseVisualStyleBackColor = false;
            this.btn10k.Click += new System.EventHandler(this.btn10k_Click);
            // 
            // btn20k
            // 
            this.btn20k.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn20k.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn20k.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(116)))), ((int)(((byte)(68)))));
            this.btn20k.FlatAppearance.BorderSize = 5;
            this.btn20k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn20k.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20k.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn20k.Location = new System.Drawing.Point(704, 186);
            this.btn20k.Name = "btn20k";
            this.btn20k.Size = new System.Drawing.Size(137, 60);
            this.btn20k.TabIndex = 4;
            this.btn20k.Text = "20.000";
            this.btn20k.UseVisualStyleBackColor = false;
            this.btn20k.Click += new System.EventHandler(this.btn20k_Click);
            // 
            // btn50k
            // 
            this.btn50k.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn50k.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn50k.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(146)))), ((int)(((byte)(247)))));
            this.btn50k.FlatAppearance.BorderSize = 5;
            this.btn50k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn50k.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn50k.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn50k.Location = new System.Drawing.Point(560, 186);
            this.btn50k.Name = "btn50k";
            this.btn50k.Size = new System.Drawing.Size(137, 60);
            this.btn50k.TabIndex = 3;
            this.btn50k.Text = "50.000";
            this.btn50k.UseVisualStyleBackColor = false;
            this.btn50k.Click += new System.EventHandler(this.btn50k_Click);
            // 
            // btn100k
            // 
            this.btn100k.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn100k.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn100k.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(115)))), ((int)(((byte)(113)))));
            this.btn100k.FlatAppearance.BorderSize = 5;
            this.btn100k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn100k.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn100k.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn100k.Location = new System.Drawing.Point(561, 120);
            this.btn100k.Name = "btn100k";
            this.btn100k.Size = new System.Drawing.Size(425, 60);
            this.btn100k.TabIndex = 2;
            this.btn100k.Text = "100.000";
            this.btn100k.UseVisualStyleBackColor = false;
            this.btn100k.Click += new System.EventHandler(this.btn100k_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(66)))), ((int)(((byte)(65)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(174)))), ((int)(((byte)(65)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Location = new System.Drawing.Point(781, 56);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(207, 40);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPas
            // 
            this.btnPas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(157)))));
            this.btnPas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(174)))), ((int)(((byte)(65)))));
            this.btnPas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPas.Location = new System.Drawing.Point(562, 56);
            this.btnPas.Name = "btnPas";
            this.btnPas.Size = new System.Drawing.Size(207, 40);
            this.btnPas.TabIndex = 1;
            this.btnPas.Text = "Exact Amount";
            this.btnPas.UseVisualStyleBackColor = false;
            this.btnPas.Click += new System.EventHandler(this.btnPas_Click);
            // 
            // Kasir_Pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(216)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(1000, 411);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btn200);
            this.Controls.Add(this.btn500);
            this.Controls.Add(this.btn1k);
            this.Controls.Add(this.btn2k);
            this.Controls.Add(this.btn5k);
            this.Controls.Add(this.btn10k);
            this.Controls.Add(this.btn20k);
            this.Controls.Add(this.btn50k);
            this.Controls.Add(this.btn100k);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPas);
            this.Controls.Add(this.lblMinimize);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblSJudul);
            this.Controls.Add(this.tbPembayaran);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblKembalian);
            this.Controls.Add(this.lblSKembalian);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSTotal);
            this.Controls.Add(this.lblSPembayaran);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Kasir_Pembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "x";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSPembayaran;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbPembayaran;
        private System.Windows.Forms.Label lblSJudul;
        private System.Windows.Forms.Label lblSTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSKembalian;
        private System.Windows.Forms.Label lblKembalian;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn1k;
        private System.Windows.Forms.Button btn2k;
        private System.Windows.Forms.Button btn5k;
        private System.Windows.Forms.Button btn10k;
        private System.Windows.Forms.Button btn20k;
        private System.Windows.Forms.Button btn50k;
        private System.Windows.Forms.Button btn100k;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPas;
    }
}