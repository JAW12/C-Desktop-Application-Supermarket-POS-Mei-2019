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
    public partial class Owner_Browse : Form
    {
        public Owner_Browse()
        {
            InitializeComponent();
        }

        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Proyek_POS.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;


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

        private void Browse_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            LoadAwal();
            LoadDataSet();
        }

        private void LoadAwal()
        {
            if (Login.ds.Tables.Contains("Browse_Barang_Owner"))
            {
                Login.ds.Tables.Remove("Browse_Barang_Owner");
            }
            conn.Open();
            cmd = new SqlCommand("Select b.Kode_Barang, b.Nama_Barang, b.QtyBox, g.Jumlah " +
                "FROM Barang b, Stok g " +
                "WHERE b.Kode_Barang = g.Kode_Barang AND " +
                "g.Id_Cabang = 'ALL' AND " +
                "g.Status_Stok = @status", conn);
            cmd.Parameters.AddWithValue("@status", 0);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(Login.ds, "Browse_Barang_Owner");
            conn.Close();
        }

        private void LoadDataSet()
        {
            dgvBrowse.Rows.Clear();
            for (int i = 0; i < Login.ds.Tables["Browse_Barang_Owner"].Rows.Count; i++)
            {
                string[] row =
                {
                    Login.ds.Tables["Browse_Barang_Owner"].Rows[i][0].ToString(),
                    Login.ds.Tables["Browse_Barang_Owner"].Rows[i][1].ToString(),
                    Login.ds.Tables["Browse_Barang_Owner"].Rows[i][2].ToString(),
                    Login.ds.Tables["Browse_Barang_Owner"].Rows[i][3].ToString(),
                    "Pilih"
                };
                dgvBrowse.Rows.Add(row);
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadAwal();
            LoadDataSet();
            do_search();
        }

        private void do_search()
        {
          
            LoadAwal();

            if (tbSearch.Text != "")
            {

                for (int i = dgvBrowse.Rows.Count - 1; i >= 0; i--)
                {
                    if (!dgvBrowse.Rows[i].Cells[1].Value.ToString().ToLower().Contains(tbSearch.Text.ToLower()))
                    {
                        dgvBrowse.Rows.RemoveAt(i);
                    }
                }
            }
        }

        public static string KodeBarang;
        private void pilih(int indexRow)
        {
            KodeBarang = dgvBrowse.Rows[indexRow].Cells[0].Value.ToString();
            this.Hide();
        }

        int indexrow = 0;

        private void dgvBrowse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                indexrow = dgvBrowse.CurrentCell.RowIndex;
                pilih(indexrow);
            }
        }
    }
}
