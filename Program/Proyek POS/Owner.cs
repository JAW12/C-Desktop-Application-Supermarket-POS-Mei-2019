using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Proyek_POS
{
    public partial class Owner : Form
    {
        public Owner()
        {
            InitializeComponent();
        }

        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Proyek_POS.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand cmd;


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void LogOut()
        {
            if (MessageBox.Show("Are you sure?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                Splashscreen.login.Show();
                this.Hide();
            }
        }


        private void lblMinimize_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.FromArgb(255, 174, 66, 65);
        }

        private void lblMinimize_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.FromArgb(255, 51, 51, 51);
        }

        private void Owner_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            lblNamaOwner.Text = Login.ds.Tables["Owner"].Rows[0][2].ToString();
            panel1.Controls.Clear();
            panel1.Controls.Add(Splashscreen.own_penjualan);
            Splashscreen.own_penjualan.Show();
            panel2.Top = pbPenjualan.Top;
            pbLogout.Left = lblNamaOwner.Location.X + lblNamaOwner.Size.Width + 20;
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonHoverEnter(object sender, EventArgs e)
        { 
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = Color.FromArgb(255, 113, 174, 65);
        }

        private void ButtonHoverLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = Color.FromArgb(255, 187, 216, 163);
        }

        private void ButtonClick(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            panel2.Top = pb.Top;
        }

        private void pbHistory_Click(object sender, EventArgs e)
        {
            Login.RiwayatLogin = "Owner";
            panel1.Controls.Clear();
            panel1.Controls.Add(Splashscreen.riwayat);
            Splashscreen.riwayat.Hide();
            Splashscreen.riwayat.Show();
        }

        private void pbPenjualan_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Splashscreen.own_penjualan))
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(Splashscreen.own_penjualan);
                Splashscreen.own_penjualan.Show();
            }
        }

        private void pbLihat_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Splashscreen.own_stock))
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(Splashscreen.own_stock);
                Splashscreen.own_stock.Show();
            }
        }

        private void pbUbahHarga_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Splashscreen.own_harga))
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(Splashscreen.own_harga);
                Splashscreen.own_harga.Show();
            }
        }

        private void pbBeli_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Splashscreen.own_beli))
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(Splashscreen.own_beli);
                Splashscreen.own_beli.Show();
            }
        }

        private void pbLogout_MouseEnter(object sender, EventArgs e)
        {
            pbLogout.Image = Properties.Resources.logouthover;
        }

        private void pbLogout_MouseLeave(object sender, EventArgs e)
        {
            pbLogout.Image = Properties.Resources.logout;
        }

        private void Owner_VisibleChanged(object sender, EventArgs e)
        {
            Owner_Load(this, e);
        }
    }
}
