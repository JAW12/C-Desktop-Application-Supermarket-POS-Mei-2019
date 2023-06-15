using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Proyek_POS
{
    public partial class Owner_Ubah_Harga : Form
    {
        public Owner_Ubah_Harga()
        {
            InitializeComponent();
        }

        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Proyek_POS.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand query;
        SqlDataAdapter adapter;

        private void Owner_Ubah_Harga_Shown(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            LoadDGV();
            cbBerdasarkan.SelectedIndex = 1;
        }

        public void SelectDataBarang()
        {
            conn.Close();
            conn.Open();
            if (Login.ds.Tables.Contains("Harga_Jual_Barang"))
            {
                Login.ds.Tables["Harga_Jual_Barang"].Rows.Clear();
            }
            query = new SqlCommand("SELECT Kode_Barang, Nama_Barang FROM BARANG", conn);
            adapter = new SqlDataAdapter(query);
            adapter.Fill(Login.ds, "Harga_Jual_Barang");
            DataColumn[] col = new DataColumn[] { Login.ds.Tables["Harga_Jual_Barang"].Columns["Kode_Barang"] };
            Login.ds.Tables["Harga_Jual_Barang"].PrimaryKey = col;
            conn.Close();
        }

        public int SelectHargaJual(string kode_barang)
        {
            int hrg = 0;
            conn.Close();
            conn.Open();
            query = new SqlCommand("SELECT Harga_Jual FROM [PH_Jual] WHERE Kode_Barang = @kode AND Tanggal_Jual in (SELECT MAX(Tanggal_Jual) FROM PH_JUAL WHERE Kode_Barang = @kode)", conn);
            query.Parameters.AddWithValue("@kode", kode_barang);
            hrg = Convert.ToInt32(query.ExecuteScalar());
            conn.Close();
            return hrg;
        }

        bool LoadDone;
        public void RecursiveLoadDGV(int i)
        {
            if (i < Login.ds.Tables["Harga_Jual_Barang"].Rows.Count)
            {
                string kode = Login.ds.Tables["Harga_Jual_Barang"].Rows[i][0].ToString();
                string nama = Login.ds.Tables["Harga_Jual_Barang"].Rows[i][1].ToString();
                string harga = SelectHargaJual(kode).ToString();
                Login.ds.Tables["Harga_Jual_Barang"].Rows[i][2] = harga;
                string[] row = new string[] { kode, nama, harga };
                dgvBarang.Rows.Add(row);
                RecursiveLoadDGV(i + 1);
            }
        }
        public void LoadDGV()
        {
            SelectDataBarang();

            if (Login.ds.Tables["Harga_Jual_Barang"].Columns.Count < 3)
            {
                Login.ds.Tables["Harga_Jual_Barang"].Columns.Add("Harga_Jual");
            }
            dgvBarang.Rows.Clear();
            RecursiveLoadDGV(0);
            LoadDone = true;
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnShow_Click(sender, e);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cbBerdasarkan.SelectedIndex != -1)
            {
                do_search(cbBerdasarkan.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please choose which item you base on your seach first", "SEARCH FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UpdateDataset(int RowIndex)
        {
            if (LoadDone)
            {
                string kode = dgvBarang.Rows[RowIndex].Cells[0].Value.ToString();
                DataRow row = Login.ds.Tables["Harga_Jual_Barang"].Rows.Find(kode);
                int idx = Login.ds.Tables["Harga_Jual_Barang"].Rows.IndexOf(row);
                Login.ds.Tables["Harga_Jual_Barang"].Rows[idx][2] = dgvBarang.Rows[idx].Cells[2].Value;
            }
        }

        string HargaJual = "";

        private void UpdateDatabase()
        {
            conn.Close();
            conn.Open();
            for (int i = 0; i < Login.ds.Tables["Harga_Jual_Barang"].Rows.Count; i++)
            {
                string kodesistem = LoadKodeSistem(Login.ds.Tables["Harga_Jual_Barang"].Rows[i][0].ToString());
                HargaJual = Convert.ToString(Login.ds.Tables["Harga_Jual_Barang"].Rows[i][2]);
                query = new SqlCommand("INSERT INTO [PH_Jual](Kode_Sistem, Kode_Barang, Harga_Jual, Tanggal_Jual, Id_Owner) VALUES(@Kode_Sistem, @Kode, @Harga, GETDATE(), @Owner)", conn);
                query.Parameters.AddWithValue("@Kode_Sistem", kodesistem);
                query.Parameters.AddWithValue("@Harga", Convert.ToInt32(HargaJual));
                query.Parameters.AddWithValue("@Owner", Login.ds.Tables["Owner"].Rows[0][0].ToString());
                query.Parameters.AddWithValue("@Kode", Login.ds.Tables["Harga_Jual_Barang"].Rows[i][0].ToString());
                query.ExecuteNonQuery();
            }
            conn.Close();
        }


        private string LoadKodeSistem(string kodebrg)
        {
            string hasil;
            conn.Close();
            conn.Open();
            query = new SqlCommand("SELECT ISNULL(Kode_Sistem, '') FROM Barang WHERE Kode_Barang = @Kode", conn);
            query.Parameters.AddWithValue("@Kode", kodebrg);
            try
            {
                hasil = query.ExecuteScalar().ToString();
            }
            catch
            {
                hasil = "";
            }
            conn.Close();
            conn.Open();
            return hasil;
        }

        private void KirimRiwayat()
        {
            for (int i = 0; i < Login.ds.Tables["Harga_Jual_Barang"].Rows.Count; i++)
            {
                if(SelectHargaJual(Login.ds.Tables["Harga_Jual_Barang"].Rows[i][0].ToString()).ToString() != Login.ds.Tables["Harga_Jual_Barang"].Rows[i][2].ToString())
                {
                    string keterangan = "Mengubah Harga Barang " + Login.ds.Tables["Harga_Jual_Barang"].Rows[i][1].ToString() + " Dari Rp. " + SelectHargaJual(Login.ds.Tables["Harga_Jual_Barang"].Rows[i][0].ToString()).ToString("#,##0") + " Menjadi Rp. " + Convert.ToInt32(Login.ds.Tables["Harga_Jual_Barang"].Rows[i][2]).ToString("#,##0");
                    conn.Open();
                    query = new SqlCommand("INSERT INTO [Riwayat](Id_User, Id_Cabang, Keterangan, Waktu) VALUES(@Id, @Cabang, @Keterangan, @Waktu)", conn);
                    query.Parameters.AddWithValue("@Id", Login.ds.Tables["Owner"].Rows[0][0].ToString());
                    query.Parameters.AddWithValue("@Cabang", "ALL");
                    query.Parameters.AddWithValue("@Keterangan", keterangan);
                    query.Parameters.AddWithValue("@Waktu", DateTime.Now);
                    query.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        private void do_search(int idx)
        {
            ResetDGV();
            for (int i = dgvBarang.Rows.Count - 1; i >= 0; i--)
            {
                if (!dgvBarang.Rows[i].Cells[idx].Value.ToString().ToLower().Contains(tbSearch.Text.ToLower()))
                {
                    dgvBarang.Rows.RemoveAt(i);
                }
            }
        }

        private void dgvBarang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDataset(e.RowIndex);

        }

        
        private void MasukList()
        {
            
        }

        private void ResetDGV()
        {
            dgvBarang.Rows.Clear();
            LoadDGV();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetDGV();
            btnShow_Click(sender, e);
        }

        private void cbBerdasarkan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnShow_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KirimRiwayat();
            UpdateDatabase();
            MessageBox.Show("Succeed In Changing Price", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbBerdasarkan_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnShow_Click(sender, e);
        }

        private void Owner_Ubah_Harga_VisibleChanged(object sender, EventArgs e)
        {
            //Owner_Ubah_Harga_Shown(this, e);
        }
    }
}
