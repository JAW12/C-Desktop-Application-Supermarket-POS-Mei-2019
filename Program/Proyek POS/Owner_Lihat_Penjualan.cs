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
    public partial class Owner_Lihat_Penjualan : Form
    {
        public Owner_Lihat_Penjualan()
        {
            InitializeComponent();
        }

        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Proyek_POS.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand query;
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();
        
        public void dtmCustomFormat(ref DateTimePicker dtm, string format)
        {
            dtm.Format = DateTimePickerFormat.Custom;
            dtm.CustomFormat = format;
        }

        public void SelectPenjualan(string id_cabang, DateTime tglAwal, DateTime tglAkhir)
        {
            if (ds.Tables.Contains("Penjualan"))
            {
                ds.Tables.Remove(ds.Tables["Penjualan"]);
            }
            conn.Close();
            conn.Open();
            query = new SqlCommand("SELECT CAST(T.Waktu_Trans AS DATE), B.Kode_Barang, B.Nama_Barang, " +
                "SUM(D.Jumlah_Pembelian), SUM(D.Subtotal) " +
                "FROM [Barang] B, [D_Trans] D, [Transaksi] T " +
                "WHERE B.Kode_Barang = D.Kode_Barang AND  " +
                "T.Id_cabang = @id_cabang AND " +
                "D.No_Nota_Transaksi = T.No_Nota_Transaksi AND " +
                "CAST(T.Waktu_Trans AS DATE) >= @awal AND CAST(T.Waktu_Trans AS DATE) <= @akhir " +
                "GROUP BY CAST(T.Waktu_Trans AS DATE), B.Kode_Barang, B.Nama_Barang", conn);
            query.Parameters.AddWithValue("@id_cabang", id_cabang);
            query.Parameters.AddWithValue("@awal", tglAwal.Date);
            query.Parameters.AddWithValue("@akhir", tglAkhir.Date);
            adapter = new SqlDataAdapter(query);
            adapter.Fill(ds, "Penjualan");
            conn.Close();
            InsertHargaJualIntoDataset();
            /*INDEX DATASET TABLE PENJUALAN
             * 0 = waktu transaksi
             * 1 = kode barang
             * 2 = nama barang
             * 3 = sum jumlah terjual
             * 4 = sum subtotal transaksi
             * 5 = harga jual -> ada setelah InsertHargaJualIntoDataset(); dipanggil
             */
        }

        private int SelectHargaJual(string kode_barang, DateTime time)
        {
            string hrg = "0";
            time = time.Date;
            conn.Close();
            conn.Open();
            query = new SqlCommand("SELECT ISNULL(Harga_Jual, '0') FROM [PH_Jual] WHERE Kode_Barang = @kode AND CAST(Tanggal_Jual AS DATE) IN (SELECT CAST(MAX(Tanggal_Jual) AS DATE) FROM [PH_Jual] WHERE Kode_Barang = @kode AND CAST(Tanggal_Jual AS DATE) = @tanggal)", conn);
            query.Parameters.AddWithValue("@kode", kode_barang);
            query.Parameters.AddWithValue("@tanggal", time);
            if (query.ExecuteScalar() == null)
            {
                query = new SqlCommand("SELECT ISNULL(Harga_Jual, '0') FROM [PH_Jual] WHERE Kode_Barang = @kode AND CAST(Tanggal_Jual AS DATE) IN (SELECT CAST(MAX(Tanggal_Jual) AS DATE) FROM [PH_Jual] WHERE Kode_Barang = @kode AND CAST(Tanggal_Jual AS DATE) < @tanggal)", conn);
                query.Parameters.AddWithValue("@kode", kode_barang);
                query.Parameters.AddWithValue("@tanggal", time);
                if (query.ExecuteScalar() == null)
                {
                    hrg = "0";
                }
                else
                {
                    hrg = query.ExecuteScalar().ToString();
                }
            }
            else
            {
                hrg = query.ExecuteScalar().ToString();
            }
            conn.Close();
            return Convert.ToInt32(hrg);
        }

        private void InsertHargaJualIntoDataset()
        {
            if (ds.Tables["Penjualan"].Columns.Count < 6)
            {
                ds.Tables["Penjualan"].Columns.Add("hargaJual");
                for (int i = 0; i < ds.Tables["Penjualan"].Rows.Count; i++)
                {
                    DateTime waktuTrans = Convert.ToDateTime(ds.Tables["Penjualan"].Rows[i][0]);
                    string kodeBarang = ds.Tables["Penjualan"].Rows[i][1].ToString();
                    ds.Tables["Penjualan"].Rows[i][5] = SelectHargaJual(kodeBarang, waktuTrans);
                }
            }
        }

        private void RecursiveLoadCabangToComboBox(int i, DataTable dt)
        {
            if (i < dt.Rows.Count)
            {
                if (dt.Rows[i][0].ToString() != "ALL")
                {
                    cbIdCabang.Items.Add(dt.Rows[i][0] + " - " + dt.Rows[i][1]);
                }
                RecursiveLoadCabangToComboBox(i + 1, dt);
            }
        }

        private void LoadCabangToComboBox(ref ComboBox sender)
        {
            ComboBox cb = (ComboBox)sender;
            cb.Items.Clear();
            conn.Close();
            conn.Open();
            DataTable dt = new DataTable();
            query = new SqlCommand("SELECT ID_Cabang, Nama_Cabang FROM Cabang", conn);
            adapter = new SqlDataAdapter(query);
            adapter.Fill(dt);
            RecursiveLoadCabangToComboBox(0, dt);
            conn.Close();
        }

        private string GetIdCabang(string text)
        {
            return text.Substring(0, 5);
        }

        private void Sum()
        {
            int sum_potongan = 0, sum_pengeluaran = 0, sum_pemasukan = 0;
            if (cbIdCabang.SelectedIndex > -1)
            {
                SelectPenjualan(GetIdCabang(cbIdCabang.SelectedItem.ToString()), dtmTanggalAwal.Value.Date, dtmTanggalAkhir.Value.Date);
                for (int i = 0; i < ds.Tables["Penjualan"].Rows.Count; i++)
                {
                    sum_pemasukan += Convert.ToInt32(ds.Tables["Penjualan"].Rows[i][4]);
                }
                conn.Close();
                conn.Open();
                query = new SqlCommand("SELECT IsNull(sum(Potongan_Member),'0') FROM [Transaksi] WHERE CAST(Waktu_Trans As Date) >= CAST(@date1 As Date) AND CAST(Waktu_Trans As Date) <= CAST( @date2 As Date) and Id_Cabang=@Cabang", conn);
                query.Parameters.AddWithValue("@date1", dtmTanggalAwal.Value.Date);
                query.Parameters.AddWithValue("@date2", dtmTanggalAkhir.Value.Date);
                query.Parameters.AddWithValue("@Cabang", GetIdCabang(cbIdCabang.SelectedItem.ToString()));
                sum_potongan += Convert.ToInt32(query.ExecuteScalar());
                conn.Close();
                conn.Open();
                query = new SqlCommand("SELECT IsNull(sum(DP.Harga_Pembelian * DP.Jumlah_Pembelian),'0') FROM [D_Pembelian] DP, [Pembelian] P WHERE P.No_Nota_Beli = DP.No_Nota_Beli and CAST(P.Tanggal_Pembelian As Date) >= CAST(@date1 As Date) AND CAST(P.Tanggal_Pembelian As Date) <= CAST( @date2 As Date)", conn);
                query.Parameters.AddWithValue("@date1", dtmTanggalAwal.Value.Date);
                query.Parameters.AddWithValue("@date2", dtmTanggalAkhir.Value.Date);
                sum_pengeluaran += Convert.ToInt32(query.ExecuteScalar());
                conn.Close();
                lblPotongan.Text = "Rp." + sum_potongan.ToString("#,##0");
                lblPemasukkan.Text = "Rp." + sum_pemasukan.ToString("#,##0");
                lblPengeluaran.Text = "Rp." + sum_pengeluaran.ToString("#,##0");
            }
        }

        private void RecursiveLoadDGV(int i)
        {
            if (i < ds.Tables["Penjualan"].Rows.Count)
            {
                string tanggal = Convert.ToDateTime(ds.Tables["Penjualan"].Rows[i][0]).ToString("dd/MMM/yyyy");
                string KodeBarang = ds.Tables["Penjualan"].Rows[i][1].ToString();
                string NamaBarang = ds.Tables["Penjualan"].Rows[i][2].ToString();
                string jumlahTerjual = ds.Tables["Penjualan"].Rows[i][3].ToString();
                string subtotal = ds.Tables["Penjualan"].Rows[i][4].ToString();
                string harga = Convert.ToInt32(ds.Tables["Penjualan"].Rows[i][5]).ToString("#,##0");
                string[] row = new string[] { tanggal, KodeBarang, NamaBarang, harga, jumlahTerjual, subtotal };
                dgvStok.Rows.Add(row);
                RecursiveLoadDGV(i + 1);
            }
        }
        private void LoadDGV(DateTime awal, DateTime akhir)
        {
            dgvStok.Rows.Clear();
            SelectPenjualan(GetIdCabang(cbIdCabang.SelectedItem.ToString()), awal, akhir);
            RecursiveLoadDGV(0);
            dgvStok.Sort(dgvStok.Columns[0], ListSortDirection.Descending);
        }

        private void cbIdCabang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateChanged();
            gbPenjualan.Refresh();
            gbDetail.Refresh();
            Sum();
        }

        bool error = false;
        bool errorShown = false;
        private void DateChanged()
        {
            if (dtmTanggalAkhir.Value.Date <= DateTime.Now.Date)
            {
                if (dtmTanggalAwal.Value.Date <= dtmTanggalAkhir.Value.Date)
                {
                    error = false;
                }
                else
                {
                    error = true;
                }
            }
            else
            {
                error = true;
            }

            if (error)
            {
                if (errorShown == false)
                {
                    errorShown = true;
                    dtmTanggalAkhir.Value = DateTime.Now;
                    dtmTanggalAwal.Value = DateTime.Now;
                    MessageBox.Show("ERROR : earliest viewing date can't surpass latest viewing date", "VIEW SALES BETWEEN DATES FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                errorShown = false;
                LoadDGV(dtmTanggalAwal.Value.Date, dtmTanggalAkhir.Value.Date);
                gbPenjualan.Refresh();
                gbDetail.Refresh();
                Sum();
            }
        }

        private void dtmTanggalAwal_ValueChanged(object sender, EventArgs e)
        {
            DateChanged();
            btnShow_Click(sender, e);
        }

        private void dtmTanggalAkhir_ValueChanged(object sender, EventArgs e)
        {
            DateChanged();
            btnShow_Click(sender, e);
        }

        private void Owner_Lihat_Penjualan_Shown(object sender, EventArgs e)
        {
            cbBerdasarkan.SelectedIndex = 1;

            dtmCustomFormat(ref dtmTanggalAwal, "dd/MMM/yyyy");
            dtmCustomFormat(ref dtmTanggalAkhir, "dd/MMM/yyyy");
            conn = new SqlConnection(connString);

            LoadCabangToComboBox(ref cbIdCabang);
            cbIdCabang.SelectedIndex = 0;
            Sum();
            cbPenjualan.SelectedIndex = 0;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cbBerdasarkan.SelectedIndex != -1)
            {
                do_search(cbBerdasarkan.SelectedIndex + 1);
            }
            else
            {
                MessageBox.Show("Please choose which item you base on your seach first", "SEARCH FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void do_search(int idx)
        {
            ResetDGV();
            if (tbSearch.Text != "")
            {
                for (int i = dgvStok.Rows.Count - 1; i >= 0; i--)
                {
                    if (!dgvStok.Rows[i].Cells[idx].Value.ToString().ToLower().Contains(tbSearch.Text.ToLower()))
                    {
                        dgvStok.Rows.RemoveAt(i);
                    }
                }
            }
        }

        private void ResetDGV()
        {
            dgvStok.Rows.Clear();
            DateChanged();
        }

        private void cbBerdasarkan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnShow_Click(sender, e);
            }
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnShow_Click(sender, e);
            }
        }
        
        string[] Penjualan;
        int[] yPenjualan;

        private void LoadGrafik(string Filter)
        {
            SqlDataReader reader;
            string id_cabang = GetIdCabang(cbIdCabang.SelectedItem.ToString());
            yPenjualan = new int[3];
            Penjualan = new string[3];

            if(Filter == "Most Selling")
            {
                conn.Close();
                conn.Open();
                query = new SqlCommand("SELECT TOP 3 B.Nama_Barang, SUM(DT.Jumlah_Pembelian) FROM Barang B, D_Trans DT, Transaksi T WHERE DT.No_Nota_Transaksi = T.No_Nota_Transaksi AND T.Id_Cabang = @Id AND CAST(T.Waktu_Trans AS DATE) >= CAST(@awal AS DATE) AND CAST(T.Waktu_Trans AS DATE) <= CAST(@akhir AS DATE) AND B.Kode_Barang = DT.Kode_Barang GROUP BY B.Nama_Barang ORDER BY 2 DESC", conn);
                query.Parameters.AddWithValue("@awal", dtmTanggalAwal.Value);
                query.Parameters.AddWithValue("@akhir", dtmTanggalAkhir.Value);
                query.Parameters.AddWithValue("@Id", id_cabang);
            }
            else if(Filter == "Least Selling")
            {
                conn.Close();
                conn.Open();
                query = new SqlCommand("SELECT TOP 3 B.Nama_Barang, SUM(DT.Jumlah_Pembelian) FROM Barang B, D_Trans DT, Transaksi T WHERE DT.No_Nota_Transaksi = T.No_Nota_Transaksi AND T.Id_Cabang = @Id AND CAST(T.Waktu_Trans AS DATE) >= CAST(@awal AS DATE) AND CAST(T.Waktu_Trans AS DATE) <= CAST(@akhir AS DATE) AND B.Kode_Barang = DT.Kode_Barang GROUP BY B.Nama_Barang ORDER BY 2 ASC", conn);
                query.Parameters.AddWithValue("@awal", dtmTanggalAwal.Value);
                query.Parameters.AddWithValue("@akhir", dtmTanggalAkhir.Value);
                query.Parameters.AddWithValue("@Id", id_cabang);
            }
            
            reader = query.ExecuteReader();
            int ctr = 0;
            while (reader.Read())
            {
                Penjualan[ctr] = reader.GetString(0);
                yPenjualan[ctr] = reader.GetInt32(1);
                ctr++;
            }

            if(Filter == "Most Selling")
            {
                SwapI(ref yPenjualan[0], ref yPenjualan[1]);
                SwapS(ref Penjualan[0], ref Penjualan[1]);
            }
            else if(Filter == "Least Selling" && ctr == 3)
            {
                SwapI(ref yPenjualan[1], ref yPenjualan[2]);
                SwapS(ref Penjualan[1], ref Penjualan[2]);
                SwapI(ref yPenjualan[0], ref yPenjualan[2]);
                SwapS(ref Penjualan[0], ref Penjualan[2]);
            }
            else if (Filter == "Least Selling" && ctr == 1)
            {
                SwapI(ref yPenjualan[0], ref yPenjualan[1]);
                SwapS(ref Penjualan[0], ref Penjualan[1]);
            }
            conn.Close();
        }

        private void SwapS(ref string satu, ref string dua)
        {
            string temp = satu;
            satu = dua;
            dua = temp;
        }

        private void SwapI(ref int satu, ref int dua)
        {
            int temp = satu;
            satu = dua;
            dua = temp;
        }

        private void cbPenjualan_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbPenjualan.Text = cbPenjualan.SelectedItem.ToString();
            gbPenjualan.Refresh();
            gbDetail.Refresh();
        }

        Brush[] brush = new Brush[3] { Brushes.Orange, Brushes.Green, Brushes.Blue };
        private void gbPenjualan_Paint(object sender, PaintEventArgs e)
        {
            if(cbPenjualan.SelectedIndex != -1)
            {
                LoadGrafik(cbPenjualan.SelectedItem.ToString());
            }
            Graphics g = e.Graphics;
            Font f = new Font("Verdana", 11);
            Font f2 = new Font("Verdana", 8);

            for (int i = 0; i < 3; i++)
            {
                if (yPenjualan != null)
                {
                        g.FillRectangle(brush[i], i * 80 + 35, 270 - (int)(150 * ((double)yPenjualan[i] / (double)yPenjualan[1])), 50, (int)(150 * ((double)yPenjualan[i] / (double)yPenjualan[1])));
                }
                if (yPenjualan != null)
                {
                    g.DrawString(yPenjualan[i].ToString(), f, Brushes.Black, i * 80 + 50, 273);
                }
            }
        }

        private void gbDetail_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font f = new Font("Verdana", 8);
            for(int i =0; i < 3; i++)
            {
                if(Penjualan != null)
                {
                    g.FillRectangle(brush[i], 25, i * 50 + 50, 20, 20);
                    g.DrawString(Penjualan[i], f, Brushes.Black, 50, i * 50 + 55);
                }
            }
        }

        private void Owner_Lihat_Penjualan_VisibleChanged(object sender, EventArgs e)
        {
            //Owner_Lihat_Penjualan_Shown(this, e);
        }
    }
}
