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
    public partial class Kasir_Register_Member : Form
    {
        public Kasir_Register_Member()
        {
            InitializeComponent();
        }

        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Proyek_POS.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public void dtmCustomFormat(ref DateTimePicker dtm, string format)
        {
            dtm.Format = DateTimePickerFormat.Custom;
            dtm.CustomFormat = format;
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
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbNama.Text != "" && tbNoHP.Text != "" && (rbLaki.Checked || rbPerempuan.Checked))
            {
                conn.Open();
                string jeniskelamin = "";
                if (rbLaki.Checked == true)
                {
                    jeniskelamin = "L";
                }
                else if (rbPerempuan.Checked == true)
                {
                    jeniskelamin = "P";
                }
                SqlCommand sqins = new SqlCommand("insert into [Member](Id_Member, Nama_Member, Hp_Member, TL_Member, JK_Member, Id_Kasir) values(@a,@b,@c,@d,@e,@f)", conn);
                sqins.Parameters.AddWithValue("@a", lblNoMember.Text);
                sqins.Parameters.AddWithValue("@b", tbNama.Text);
                sqins.Parameters.AddWithValue("@c", tbNoHP.Text);
                sqins.Parameters.AddWithValue("@d", dateTL.Value);
                sqins.Parameters.AddWithValue("@e", jeniskelamin);
                sqins.Parameters.AddWithValue("@f", Login.ds.Tables["Kasir"].Rows[0][0]);
                sqins.ExecuteNonQuery();
                MessageBox.Show("New member has been registered!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please complete the data first", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Kasir_Register_Member_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            conn.Open();
            DateTime waktu = DateTime.Now;

            string tahun = waktu.ToString("yyyy");
            string bulan = waktu.ToString("MM");
            string tanggal = waktu.ToString("dd");
            string hdepan = Kasir.ID_Cabang_Kasir.Substring(2, 3);
            SqlCommand sqlcari1 = new SqlCommand("select count(Id_Member) from [Member] where upper(substring(Id_member,1,11))='" + hdepan + tahun + bulan + tanggal + "'", conn);
            lblNoMember.Text = hdepan + tahun + bulan + tanggal;
            int jmlh = (int)sqlcari1.ExecuteScalar() + 1;
            lblNoMember.Text += jmlh.ToString().PadLeft(3, '0');

            conn.Close();

            dtmCustomFormat(ref dateTL, "dd/MMM/yyyy");
        }


        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Kasir_Register_Member_VisibleChanged(object sender, EventArgs e)
        {
            Kasir_Register_Member_Load(this, e);
            tbNama.Clear();
            tbNoHP.Clear();
            dateTL.Value = DateTime.Now;
            rbLaki.Checked = true;
        }

        private void dateTL_ValueChanged(object sender, EventArgs e)
        {
            if (dateTL.Value.Date > DateTime.Now.Date)
            {
                lblBirthdateInvalid.Visible = true;
                btnConfirm.Enabled = false;
                dateTL.Focus();
            }
            else
            {
                lblBirthdateInvalid.Visible = false;
                btnConfirm.Enabled = true;
                tbNoHP.Focus();
            }
        }

        private void tbNoHP_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNoHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (Char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) && e.KeyChar != (Char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void dateTL_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
