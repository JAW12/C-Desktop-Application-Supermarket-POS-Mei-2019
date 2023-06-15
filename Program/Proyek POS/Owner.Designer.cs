namespace Proyek_POS
{
    partial class Owner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owner));
            this.lblNamaOwner = new System.Windows.Forms.Label();
            this.lblSNamaManager = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbHistory = new System.Windows.Forms.PictureBox();
            this.pbUbahHarga = new System.Windows.Forms.PictureBox();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.pbPenjualan = new System.Windows.Forms.PictureBox();
            this.pbLihat = new System.Windows.Forms.PictureBox();
            this.pbBeli = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUbahHarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPenjualan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLihat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBeli)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNamaOwner
            // 
            this.lblNamaOwner.AutoSize = true;
            this.lblNamaOwner.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaOwner.Location = new System.Drawing.Point(110, 18);
            this.lblNamaOwner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamaOwner.Name = "lblNamaOwner";
            this.lblNamaOwner.Size = new System.Drawing.Size(113, 18);
            this.lblNamaOwner.TabIndex = 35;
            this.lblNamaOwner.Text = "Nama Owner";
            // 
            // lblSNamaManager
            // 
            this.lblSNamaManager.AutoSize = true;
            this.lblSNamaManager.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNamaManager.Location = new System.Drawing.Point(9, 18);
            this.lblSNamaManager.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSNamaManager.Name = "lblSNamaManager";
            this.lblSNamaManager.Size = new System.Drawing.Size(79, 18);
            this.lblSNamaManager.TabIndex = 34;
            this.lblSNamaManager.Text = "Owner :";
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblMinimize.Location = new System.Drawing.Point(1229, 9);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(18, 18);
            this.lblMinimize.TabIndex = 37;
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
            this.lblClose.Location = new System.Drawing.Point(1253, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(19, 18);
            this.lblClose.TabIndex = 38;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblMinimize_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblMinimize_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(130, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 565);
            this.panel1.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(157)))));
            this.panel2.Location = new System.Drawing.Point(14, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 113);
            this.panel2.TabIndex = 45;
            // 
            // pbHistory
            // 
            this.pbHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(216)))), ((int)(((byte)(163)))));
            this.pbHistory.BackgroundImage = global::Proyek_POS.Properties.Resources.history;
            this.pbHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHistory.Location = new System.Drawing.Point(14, 503);
            this.pbHistory.Name = "pbHistory";
            this.pbHistory.Size = new System.Drawing.Size(110, 113);
            this.pbHistory.TabIndex = 41;
            this.pbHistory.TabStop = false;
            this.pbHistory.Click += new System.EventHandler(this.pbHistory_Click);
            this.pbHistory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonClick);
            this.pbHistory.MouseEnter += new System.EventHandler(this.ButtonHoverEnter);
            this.pbHistory.MouseLeave += new System.EventHandler(this.ButtonHoverLeave);
            // 
            // pbUbahHarga
            // 
            this.pbUbahHarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(216)))), ((int)(((byte)(163)))));
            this.pbUbahHarga.BackgroundImage = global::Proyek_POS.Properties.Resources.ubahharga;
            this.pbUbahHarga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbUbahHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUbahHarga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUbahHarga.Location = new System.Drawing.Point(14, 390);
            this.pbUbahHarga.Name = "pbUbahHarga";
            this.pbUbahHarga.Size = new System.Drawing.Size(110, 113);
            this.pbUbahHarga.TabIndex = 42;
            this.pbUbahHarga.TabStop = false;
            this.pbUbahHarga.Click += new System.EventHandler(this.pbUbahHarga_Click);
            this.pbUbahHarga.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonClick);
            this.pbUbahHarga.MouseEnter += new System.EventHandler(this.ButtonHoverEnter);
            this.pbUbahHarga.MouseLeave += new System.EventHandler(this.ButtonHoverLeave);
            // 
            // pbLogout
            // 
            this.pbLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogout.Image = global::Proyek_POS.Properties.Resources.logout;
            this.pbLogout.Location = new System.Drawing.Point(245, 12);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(25, 25);
            this.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogout.TabIndex = 32;
            this.pbLogout.TabStop = false;
            this.pbLogout.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pbLogout.MouseEnter += new System.EventHandler(this.pbLogout_MouseEnter);
            this.pbLogout.MouseLeave += new System.EventHandler(this.pbLogout_MouseLeave);
            // 
            // pbPenjualan
            // 
            this.pbPenjualan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(216)))), ((int)(((byte)(163)))));
            this.pbPenjualan.BackgroundImage = global::Proyek_POS.Properties.Resources.incomer;
            this.pbPenjualan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPenjualan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPenjualan.Location = new System.Drawing.Point(14, 51);
            this.pbPenjualan.Name = "pbPenjualan";
            this.pbPenjualan.Size = new System.Drawing.Size(110, 113);
            this.pbPenjualan.TabIndex = 46;
            this.pbPenjualan.TabStop = false;
            this.pbPenjualan.Click += new System.EventHandler(this.pbPenjualan_Click);
            this.pbPenjualan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonClick);
            this.pbPenjualan.MouseEnter += new System.EventHandler(this.ButtonHoverEnter);
            this.pbPenjualan.MouseLeave += new System.EventHandler(this.ButtonHoverLeave);
            // 
            // pbLihat
            // 
            this.pbLihat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(216)))), ((int)(((byte)(163)))));
            this.pbLihat.BackgroundImage = global::Proyek_POS.Properties.Resources.lihat;
            this.pbLihat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLihat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLihat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLihat.Location = new System.Drawing.Point(14, 164);
            this.pbLihat.Name = "pbLihat";
            this.pbLihat.Size = new System.Drawing.Size(110, 113);
            this.pbLihat.TabIndex = 46;
            this.pbLihat.TabStop = false;
            this.pbLihat.Click += new System.EventHandler(this.pbLihat_Click);
            this.pbLihat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonClick);
            this.pbLihat.MouseEnter += new System.EventHandler(this.ButtonHoverEnter);
            this.pbLihat.MouseLeave += new System.EventHandler(this.ButtonHoverLeave);
            // 
            // pbBeli
            // 
            this.pbBeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(216)))), ((int)(((byte)(163)))));
            this.pbBeli.BackgroundImage = global::Proyek_POS.Properties.Resources.beli;
            this.pbBeli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBeli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBeli.Location = new System.Drawing.Point(14, 277);
            this.pbBeli.Name = "pbBeli";
            this.pbBeli.Size = new System.Drawing.Size(110, 113);
            this.pbBeli.TabIndex = 47;
            this.pbBeli.TabStop = false;
            this.pbBeli.Click += new System.EventHandler(this.pbBeli_Click);
            this.pbBeli.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonClick);
            this.pbBeli.MouseEnter += new System.EventHandler(this.ButtonHoverEnter);
            this.pbBeli.MouseLeave += new System.EventHandler(this.ButtonHoverLeave);
            // 
            // Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 626);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbHistory);
            this.Controls.Add(this.pbUbahHarga);
            this.Controls.Add(this.lblMinimize);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblNamaOwner);
            this.Controls.Add(this.lblSNamaManager);
            this.Controls.Add(this.pbLogout);
            this.Controls.Add(this.pbPenjualan);
            this.Controls.Add(this.pbLihat);
            this.Controls.Add(this.pbBeli);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Owner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owner";
            this.Load += new System.EventHandler(this.Owner_Load);
            this.VisibleChanged += new System.EventHandler(this.Owner_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUbahHarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPenjualan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLihat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBeli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.Label lblNamaOwner;
        private System.Windows.Forms.Label lblSNamaManager;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.PictureBox pbHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbUbahHarga;
        private System.Windows.Forms.PictureBox pbLihat;
        private System.Windows.Forms.PictureBox pbPenjualan;
        private System.Windows.Forms.PictureBox pbBeli;
    }
}