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
    public partial class Kasir_Login_Manager : Form
    {
        public Kasir_Login_Manager()
        {
            InitializeComponent();
        }

        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Proyek_POS.mdf;Integrated Security=True;Connect Timeout=30";
        DataSet ds;
        SqlConnection conn;
        SqlDataAdapter adapter;
        public static bool LoginBenar;
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID_User, Password_User, Nama_User FROM [User] WHERE ID_User = @id AND Password_User = @pw AND Status_User = @Status AND Id_Cabang = @id_cabang", conn);
            cmd.Parameters.AddWithValue("@id", tbUsername.Text);
            cmd.Parameters.AddWithValue("@pw", tbPassword.Text);
            cmd.Parameters.AddWithValue("@Status", 1);
            cmd.Parameters.AddWithValue("@id_cabang", Kasir.ID_Cabang_Kasir);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "Manager");

            if (ds.Tables["Manager"].Rows.Count > 0)
            {
                LoginBenar = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERROR : Manager not found", "LOGIN FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbUsername.Focus();
            }
            conn.Close();
        }

        private void Kasir_Login_Manager_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            ds = new DataSet();
            LoginBenar = false;
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        bool Eye = false;
        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (Eye)
            {
                pictureBox4.BackgroundImage = Properties.Resources.eyehide;
                tbPassword.PasswordChar = '*';
                Eye = !Eye;
            }
            else if (!Eye)
            {
                pictureBox4.BackgroundImage = Properties.Resources.eye;
                tbPassword.PasswordChar = '\0';
                Eye = !Eye;
            }
        }


        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            if (Eye)
            {
                pictureBox4.BackgroundImage = Properties.Resources.eyehover;
            }
            else if (!Eye)
            {
                pictureBox4.BackgroundImage = Properties.Resources.eyehidehover;
            }
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            if (Eye)
            {
                pictureBox4.BackgroundImage = Properties.Resources.eye;
            }
            else if (!Eye)
            {
                pictureBox4.BackgroundImage = Properties.Resources.eyehide;
            }
        }

        private void TbEnterHandleButtonClick(object sender,KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            TbEnterHandleButtonClick(sender, e);
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            TbEnterHandleButtonClick(sender, e);
        }

        private void Kasir_Login_Manager_VisibleChanged(object sender, EventArgs e)
        {
            tbUsername.Clear();
            tbPassword.Clear();
            tbUsername.Focus();
        }
    }
}
