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
    public partial class Kasir_Browse : Form
    {
        public Kasir_Browse()
        {
            InitializeComponent();
        }

        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Proyek_POS.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;


        private void Browse_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
        }

        private void LoadAwal()
        {
            if (Login.ds.Tables.Contains("Browse_Barang"))
            {
                Login.ds.Tables["Browse_Barang"].Rows.Clear();
            }
            conn.Open();
            cmd = new SqlCommand("SELECT s.Kode_Barang, b.Nama_Barang, b.QtyBox, pj.Harga_Jual, s.Jumlah " +
                "FROM Barang b, PH_Jual pj, Stok s " +
                "WHERE b.Kode_Barang = pj.Kode_Barang AND " +
                "b.Kode_Barang = s.Kode_Barang AND " +
                "pj.Kode_Barang = s.Kode_Barang AND " +
                "s.Status_Stok = @status AND " +
                "s.Id_Cabang = @Id AND " +
                "pj.tanggal_jual in " +
                "(SELECT MAX(Tanggal_Jual) FROM PH_Jual pj GROUP BY Kode_Barang)", conn);
            cmd.Parameters.AddWithValue("@Id", Kasir.ID_Cabang_Kasir);
            cmd.Parameters.AddWithValue("@status", 1);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(Login.ds, "Browse_Barang");
            conn.Close();
            conn.Open();
            cmd = new SqlCommand("Select b.Kode_Barang, b.Nama_Barang, b.QtyBox, pj.Harga_Jual, s.Jumlah " +
               "FROM Barang b, PH_Jual pj, Stok s " +
               "WHERE b.Kode_Barang = pj.Kode_Barang AND " +
               "b.Kode_Barang = s.Kode_Barang AND " +
               "s.Status_Stok = @status AND " +
               "s.Id_Cabang = @Id AND " +
               "pj.tanggal_jual in " +
               "(SELECT MAX(Tanggal_Jual) FROM PH_Jual GROUP BY Kode_Barang) AND b.Qtybox > 1", conn);
            cmd.Parameters.AddWithValue("@Id", Kasir.ID_Cabang_Kasir);
            cmd.Parameters.AddWithValue("@status", 0);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(Login.ds, "Browse_Barang");
            conn.Close();
        }

        private void LoadDataSet(int i)
        {
            if (i < Login.ds.Tables["Browse_Barang"].Rows.Count)
            {
                string[] row =
                {
                    Login.ds.Tables["Browse_Barang"].Rows[i][0].ToString(),
                    Login.ds.Tables["Browse_Barang"].Rows[i][1].ToString(),
                    Login.ds.Tables["Browse_Barang"].Rows[i][2].ToString(),
                    Login.ds.Tables["Browse_Barang"].Rows[i][3].ToString(),
                    Login.ds.Tables["Browse_Barang"].Rows[i][4].ToString(),
                    "Pilih"
                };
                dgvBrowse.Rows.Add(row);
                LoadDataSet(i + 1);
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
            do_search();
        }
        private void do_search()
        {
            LoadAwal();
            dgvBrowse.Rows.Clear();
            LoadDataSet(0);
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

        int indexcolumn = 0, indexrow = 0;

        private void Kasir_Browse_Shown(object sender, EventArgs e)
        {
            LoadAwal();
            dgvBrowse.Rows.Clear();
            LoadDataSet(0);
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void Kasir_Browse_VisibleChanged(object sender, EventArgs e)
        {
            Kasir_Browse_Shown(this, e);
        }

        private void dgvBrowse_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                indexrow = dgvBrowse.CurrentCell.RowIndex;
                pilih(indexrow);
            }
        }


    }
}
