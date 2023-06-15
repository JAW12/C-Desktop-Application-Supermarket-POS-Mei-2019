namespace Proyek_POS
{
    partial class Kasir_Register_Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kasir_Register_Member));
            this.lblSNama = new System.Windows.Forms.Label();
            this.lblSNoHP = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbNoHP = new System.Windows.Forms.TextBox();
            this.lblSJudul = new System.Windows.Forms.Label();
            this.lblSNoMember = new System.Windows.Forms.Label();
            this.lblNoMember = new System.Windows.Forms.Label();
            this.lblSTL = new System.Windows.Forms.Label();
            this.dateTL = new System.Windows.Forms.DateTimePicker();
            this.lblSJK = new System.Windows.Forms.Label();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblBirthdateInvalid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSNama
            // 
            this.lblSNama.AutoSize = true;
            this.lblSNama.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNama.Location = new System.Drawing.Point(199, 146);
            this.lblSNama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSNama.Name = "lblSNama";
            this.lblSNama.Size = new System.Drawing.Size(91, 25);
            this.lblSNama.TabIndex = 2;
            this.lblSNama.Text = "Name :";
            // 
            // lblSNoHP
            // 
            this.lblSNoHP.AutoSize = true;
            this.lblSNoHP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNoHP.Location = new System.Drawing.Point(119, 230);
            this.lblSNoHP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSNoHP.Name = "lblSNoHP";
            this.lblSNoHP.Size = new System.Drawing.Size(193, 25);
            this.lblSNoHP.TabIndex = 2;
            this.lblSNoHP.Text = "Phone Number :";
            // 
            // tbNama
            // 
            this.tbNama.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.Location = new System.Drawing.Point(283, 143);
            this.tbNama.Margin = new System.Windows.Forms.Padding(2);
            this.tbNama.MaxLength = 128;
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(195, 32);
            this.tbNama.TabIndex = 1;
            this.tbNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNama_KeyPress);
            // 
            // tbNoHP
            // 
            this.tbNoHP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoHP.Location = new System.Drawing.Point(283, 227);
            this.tbNoHP.Margin = new System.Windows.Forms.Padding(2);
            this.tbNoHP.MaxLength = 14;
            this.tbNoHP.Name = "tbNoHP";
            this.tbNoHP.Size = new System.Drawing.Size(195, 32);
            this.tbNoHP.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tbNoHP, "08xxxxxxxxxx");
            this.tbNoHP.TextChanged += new System.EventHandler(this.tbNoHP_TextChanged);
            this.tbNoHP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNoHP_KeyPress);
            // 
            // lblSJudul
            // 
            this.lblSJudul.AutoSize = true;
            this.lblSJudul.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSJudul.Location = new System.Drawing.Point(166, 36);
            this.lblSJudul.Name = "lblSJudul";
            this.lblSJudul.Size = new System.Drawing.Size(376, 45);
            this.lblSJudul.TabIndex = 12;
            this.lblSJudul.Text = "Register Member";
            // 
            // lblSNoMember
            // 
            this.lblSNoMember.AutoSize = true;
            this.lblSNoMember.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNoMember.Location = new System.Drawing.Point(133, 113);
            this.lblSNoMember.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSNoMember.Name = "lblSNoMember";
            this.lblSNoMember.Size = new System.Drawing.Size(174, 25);
            this.lblSNoMember.TabIndex = 2;
            this.lblSNoMember.Text = "Card Number :";
            // 
            // lblNoMember
            // 
            this.lblNoMember.AutoSize = true;
            this.lblNoMember.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoMember.Location = new System.Drawing.Point(280, 113);
            this.lblNoMember.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoMember.Name = "lblNoMember";
            this.lblNoMember.Size = new System.Drawing.Size(194, 25);
            this.lblNoMember.TabIndex = 2;
            this.lblNoMember.Text = "xxxxxxxxxxxxxx";
            // 
            // lblSTL
            // 
            this.lblSTL.AutoSize = true;
            this.lblSTL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTL.Location = new System.Drawing.Point(168, 191);
            this.lblSTL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSTL.Name = "lblSTL";
            this.lblSTL.Size = new System.Drawing.Size(131, 25);
            this.lblSTL.TabIndex = 2;
            this.lblSTL.Text = "Birthdate :";
            // 
            // dateTL
            // 
            this.dateTL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTL.Location = new System.Drawing.Point(283, 185);
            this.dateTL.Name = "dateTL";
            this.dateTL.Size = new System.Drawing.Size(195, 32);
            this.dateTL.TabIndex = 2;
            this.dateTL.ValueChanged += new System.EventHandler(this.dateTL_ValueChanged);
            this.dateTL.Leave += new System.EventHandler(this.dateTL_Leave);
            // 
            // lblSJK
            // 
            this.lblSJK.AutoSize = true;
            this.lblSJK.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSJK.Location = new System.Drawing.Point(185, 271);
            this.lblSJK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSJK.Name = "lblSJK";
            this.lblSJK.Size = new System.Drawing.Size(107, 25);
            this.lblSJK.TabIndex = 2;
            this.lblSJK.Text = "Gender :";
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.Checked = true;
            this.rbLaki.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLaki.Location = new System.Drawing.Point(283, 269);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(80, 29);
            this.rbLaki.TabIndex = 4;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Male";
            this.rbLaki.UseVisualStyleBackColor = true;
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPerempuan.Location = new System.Drawing.Point(357, 269);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(106, 29);
            this.rbPerempuan.TabIndex = 5;
            this.rbPerempuan.Text = "Female";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblMinimize.Location = new System.Drawing.Point(579, 9);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(25, 25);
            this.lblMinimize.TabIndex = 18;
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
            this.lblClose.Location = new System.Drawing.Point(603, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(26, 25);
            this.lblClose.TabIndex = 19;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblMinimize_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblMinimize_MouseLeave);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(61)))), ((int)(((byte)(157)))));
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(174)))), ((int)(((byte)(65)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirm.Location = new System.Drawing.Point(255, 318);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(117, 40);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblBirthdateInvalid
            // 
            this.lblBirthdateInvalid.AutoSize = true;
            this.lblBirthdateInvalid.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdateInvalid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBirthdateInvalid.Location = new System.Drawing.Point(483, 191);
            this.lblBirthdateInvalid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBirthdateInvalid.Name = "lblBirthdateInvalid";
            this.lblBirthdateInvalid.Size = new System.Drawing.Size(145, 18);
            this.lblBirthdateInvalid.TabIndex = 20;
            this.lblBirthdateInvalid.Text = "Invalid Birthdate";
            // 
            // Kasir_Register_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(216)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.lblBirthdateInvalid);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblMinimize);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.rbPerempuan);
            this.Controls.Add(this.rbLaki);
            this.Controls.Add(this.dateTL);
            this.Controls.Add(this.lblSJudul);
            this.Controls.Add(this.tbNoHP);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lblSJK);
            this.Controls.Add(this.lblSNoHP);
            this.Controls.Add(this.lblNoMember);
            this.Controls.Add(this.lblSNoMember);
            this.Controls.Add(this.lblSTL);
            this.Controls.Add(this.lblSNama);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Kasir_Register_Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Member";
            this.Load += new System.EventHandler(this.Kasir_Register_Member_Load);
            this.VisibleChanged += new System.EventHandler(this.Kasir_Register_Member_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSNama;
        private System.Windows.Forms.Label lblSNoHP;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbNoHP;
        private System.Windows.Forms.Label lblSJudul;
        private System.Windows.Forms.Label lblSNoMember;
        private System.Windows.Forms.Label lblNoMember;
        private System.Windows.Forms.Label lblSTL;
        private System.Windows.Forms.DateTimePicker dateTL;
        private System.Windows.Forms.Label lblSJK;
        private System.Windows.Forms.RadioButton rbLaki;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblBirthdateInvalid;
    }
}