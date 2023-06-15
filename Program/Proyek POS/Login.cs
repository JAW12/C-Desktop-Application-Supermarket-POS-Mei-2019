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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Proyek_POS.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public static DataSet ds;
        public static string RiwayatLogin = "";

        private void Login_Load(object sender, EventArgs e)
        {
            
            conn = new SqlConnection(connString);
            if (ds == null)
            {
                ds = new DataSet();
            }
            tbUsername.Focus();
        }
        public static string id_useraktif = "";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUser(0); //kasir
            LoginUser(1); //manager
            LoginUser(2); //owner
            if (ds.Tables["Kasir"].Rows.Count > 0)
            {
                tbUsername.Clear();
                tbPassword.Clear();
                this.Hide();
                Splashscreen.frmkasir.Show();
            }
            else
            {
                if (ds.Tables["Manager"].Rows.Count > 0)
                {
                    tbUsername.Clear();
                    tbPassword.Clear();
                    this.Hide();
                    Form manager = new Manager();
                    manager.Show();
                    //Splashscreen.frmmanager.Show();
                }
                else
                {
                    if (ds.Tables["Owner"].Rows.Count > 0)
                    {
                        tbUsername.Clear();
                        tbPassword.Clear();
                        id_useraktif = ds.Tables["Owner"].Rows[0][0].ToString();
                        this.Hide();
                        Splashscreen.frmOwner.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username / password", "LOGIN FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void LoginUser(int status_user)
        {
            if (status_user == 0)
            {
                if (ds.Tables.Contains("Kasir"))
                {
                    ds.Tables["Kasir"].Rows.Clear();
                }
            }
            else if (status_user == 1)
            {
                if (ds.Tables.Contains("Manager"))
                {
                    ds.Tables["Manager"].Rows.Clear();
                }
            }
            else if (status_user == 2)
            {
                if (ds.Tables.Contains("Owner"))
                {
                    ds.Tables["Owner"].Rows.Clear();
                }
            }

            conn.Close();
            conn.Open();
            cmd = new SqlCommand("SELECT ID_User, Password_User, Nama_User FROM [User] WHERE ID_User = @ID AND Password_User = @Password AND Status_User = @Status", conn);
            cmd.Parameters.AddWithValue("@ID", tbUsername.Text);
            cmd.Parameters.AddWithValue("@Password", tbPassword.Text);
            cmd.Parameters.AddWithValue("@Status", status_user);
            adapter = new SqlDataAdapter(cmd);

            if (status_user == 0) //kasir
            {
                adapter.Fill(ds, "Kasir");
            }
            else if (status_user == 1) //manager
            {
                adapter.Fill(ds, "Manager");
            }
            else if (status_user == 2) //owner
            {
                adapter.Fill(ds, "Owner");
            }

            conn.Close();
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
            else if(!Eye)
            {
                pictureBox4.BackgroundImage = Properties.Resources.eye;
                tbPassword.PasswordChar = '\0';
                Eye = !Eye;
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
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

        private void Login_VisibleChanged(object sender, EventArgs e)
        {
            tbUsername.Focus();
        }
    }
}
