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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Proyek_POS.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand cmd;
        public static string LihatAtauInput;


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LogOut();
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

        private void LogOut()
        {
            if (MessageBox.Show("Are you sure?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                Splashscreen.login.Show();
                this.Hide();
            }
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            lblNamaManager.Text = Login.ds.Tables["Manager"].Rows[0][2].ToString();
            LihatAtauInput = "Lihat";
            pbLogout.Left = lblNamaManager.Location.X + lblNamaManager.Size.Width + 20;
            panel1.Controls.Add(Splashscreen.mgr_stock);
            Splashscreen.mgr_stock.Show();
            LoadCabang();
        }

        private void LoadCabang()
        {
            conn.Open();
            cmd = new SqlCommand("SELECT C.Nama_Cabang FROM [User] U, [Cabang] C WHERE Id_User = @Id AND C.Id_Cabang = U.Id_Cabang", conn);
            cmd.Parameters.AddWithValue("@Id", Login.ds.Tables["Manager"].Rows[0][0].ToString());
            lblNamaCabang.Text = (string)cmd.ExecuteScalar();
            conn.Close();
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

        private void pbLihat_Click(object sender, EventArgs e)
        {
            LihatAtauInput = "Lihat";
            panel1.Controls.Clear();
            panel1.Controls.Add(Splashscreen.mgr_stock);
            Splashscreen.mgr_stock.Hide();
            Splashscreen.mgr_stock.Show();
        }

        private void pbInput_Click(object sender, EventArgs e)
        {
            LihatAtauInput = "Input";
            panel1.Controls.Clear();
            panel1.Controls.Add(Splashscreen.mgr_stock);
            Splashscreen.mgr_stock.Hide();
            Splashscreen.mgr_stock.Show();
        }

        private void pbPindah_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Splashscreen.mgr_pindah))
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(Splashscreen.mgr_pindah);
                Splashscreen.mgr_pindah.Show();
            }
        }

        private void pbHistory_Click(object sender, EventArgs e)
        {
            Login.RiwayatLogin = "Manager";
            panel1.Controls.Clear();
            panel1.Controls.Add(Splashscreen.riwayat);
            Splashscreen.riwayat.Hide();
            Splashscreen.riwayat.Show();
        }


        private void pbLogout_MouseEnter(object sender, EventArgs e)
        {
            pbLogout.Image = Properties.Resources.logouthover;
        }

        private void pbLogout_MouseLeave(object sender, EventArgs e)
        {
            pbLogout.Image = Properties.Resources.logout;
        }

        private void Manager_VisibleChanged(object sender, EventArgs e)
        {
            Manager_Load(this, e);
        }
    }
}
