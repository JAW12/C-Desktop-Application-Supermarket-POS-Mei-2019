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
    public partial class Manager_Lihat_Edit_Stock : Form
    {
        public Manager_Lihat_Edit_Stock()
        {
            InitializeComponent();
        }

        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Proyek_POS.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand query;
        SqlDataAdapter adapter;
        public static string Id_Cabang_Manager;

        public void dtmCustomFormat(ref DateTimePicker dtm, string format)
        {
            dtm.Format = DateTimePickerFormat.Custom;
            dtm.CustomFormat = format;
        }
        
        public int SumDGVTotalByIdxCol(int idx)
        {
            int ttl = 0;
            foreach (DataGridViewRow row in dgvStok.Rows)
            {
                ttl += Convert.ToInt32(row.Cells[idx].Value);
            }
            return ttl;
        }

        public int SumDGVTotalKali(int idx1, int idx2)
        {
            int ttl = 0;
            foreach (DataGridViewRow row in dgvStok.Rows)
            {
                ttl += Convert.ToInt32(row.Cells[idx1].Value) * Convert.ToInt32(row.Cells[idx2].Value);
            }
            return ttl;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Login.ds.Tables["Data_Barang"].Rows.Clear();
            SelectDataBarang();
            LoadAwal(dtmLihatStok.Value);
            Filter();
            if (tbSearch.Text != "")
            {
                do_search();
            }
        }

        public void do_search()
        {
            ResetDGV();
            for (int i = dgvStok.Rows.Count - 1; i >= 0; i--)
            {
                if (!dgvStok.Rows[i].Cells[1].Value.ToString().ToLower().Contains(tbSearch.Text.ToLower()))
                {
                    dgvStok.Rows.RemoveAt(i);
                }
            }

            for (int i = dgvStokRealita.Rows.Count - 1; i >= 0; i--)
            {
                if (!dgvStokRealita.Rows[i].Cells[1].Value.ToString().ToLower().Contains(tbSearch.Text.ToLower()))
                {
                    dgvStokRealita.Rows.RemoveAt(i);
                }
            }
        }

        public void ResetDGV()
        {
            dgvStok.Rows.Clear();
            dgvStokRealita.Rows.Clear();
            Filter();
        }

        private void LoadCabang()
        {
            conn.Close();
            conn.Open();
            query = new SqlCommand("SELECT ID_Cabang FROM [User] WHERE Id_User = @Id", conn);
            query.Parameters.AddWithValue("@Id", Login.ds.Tables["Manager"].Rows[0][0].ToString());
            Id_Cabang_Manager = (string)query.ExecuteScalar();
            conn.Close();
        }

        public void SelectDataBarang()
        {
            conn.Close();
            conn.Open();
            if (Login.ds.Tables.Contains("Data_Barang"))
            {
                Login.ds.Tables["Data_Barang"].Rows.Clear();
            }
            query = new SqlCommand("SELECT B.Kode_Barang, B.Nama_Barang, B.QtyBox FROM BARANG B, STOK S WHERE B.Kode_Barang = S.Kode_Barang AND B.Kode_Sistem = S.Kode_Sistem AND S.Id_Cabang = @id_cabang", conn);
            query.Parameters.AddWithValue("@id_cabang", Id_Cabang_Manager);
            adapter = new SqlDataAdapter(query);
            adapter.Fill(Login.ds, "Data_Barang");
            conn.Close();
        }

        public int SelectStokHRK(string kode_barang, string id_cabang, int status, DateTime time)
        {
            int stok = 0;
            conn.Close();
            conn.Open();
            query = new SqlCommand("SELECT Jumlah FROM [Stok_HRK] " +
                "WHERE Kode_Barang = @kode AND " +
                "Id_Cabang = @id_cabang AND " +
                "CAST(Tanggal AS DATE) = CAST(@time AS DATE) AND " +
                "Status_Stok = @status", conn);
            query.Parameters.AddWithValue("@kode", kode_barang);
            query.Parameters.AddWithValue("@id_cabang", id_cabang);
            query.Parameters.AddWithValue("@time", time);
            query.Parameters.AddWithValue("@status", status);
            if (query.ExecuteScalar() != null)
            {
                stok = Convert.ToInt16(query.ExecuteScalar());
            }
            conn.Close();
            return stok;
        }

        public int SelectStokRealita(string kode_barang, string id_cabang, DateTime time)
        {
            int stok = 0;
            conn.Close();
            conn.Open();
            query = new SqlCommand("SELECT Jumlah FROM [Stok] WHERE Kode_Barang = @kode AND " +
                "Id_Cabang = @id_cabang AND Status_Stok = @status", conn);
            query.Parameters.AddWithValue("@kode", kode_barang);
            query.Parameters.AddWithValue("@id_cabang", id_cabang);
            query.Parameters.AddWithValue("@time", time);
            query.Parameters.AddWithValue("@status", 1);
            stok = Convert.ToInt16(query.ExecuteScalar());
            conn.Close();
            return stok;
        }

        public void CekStokSesuai()
        {
            int stokGudang = 0, stokRealita = 0, hilang = 0, rusak = 0, kadaluarsa = 0;
            for (int i = 0; i < dgvStok.Rows.Count; i++)
            {
                stokGudang = Convert.ToInt32(dgvStok.Rows[i].Cells[4].Value);
                hilang = Convert.ToInt32(dgvStok.Rows[i].Cells[6].Value);
                rusak = Convert.ToInt32(dgvStok.Rows[i].Cells[7].Value);
                kadaluarsa = Convert.ToInt32(dgvStok.Rows[i].Cells[8].Value);

                if (stokGudang < 0 || hilang < 0 || rusak < 0 || kadaluarsa < 0)
                {
                    for (int j = 0; j < dgvStok.Columns.Count; j++)
                    {
                        dgvStok.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(255, 192, 0, 0); //merah
                        dgvStok.Rows[i].Cells[j].Style.ForeColor = Color.White;
                    }
                }
                else
                {
                    for (int j = 0; j < dgvStok.Columns.Count; j++)
                    {
                        dgvStok.Rows[i].Cells[j].Style.BackColor = Color.White;
                        dgvStok.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                    }
                }
            }

            for (int i = 0; i < dgvStokRealita.Rows.Count; i++)
            {
                stokRealita = Convert.ToInt32(dgvStokRealita.Rows[i].Cells[3].Value);
                if (stokRealita < 0)
                {
                    for (int j = 0; j < dgvStokRealita.Columns.Count; j++)
                    {
                        dgvStokRealita.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(255, 192, 0, 0); //merah
                        dgvStokRealita.Rows[i].Cells[j].Style.ForeColor = Color.White;
                    }
                }
                else
                {
                    for (int j = 0; j < dgvStokRealita.Columns.Count; j++)
                    {
                        dgvStokRealita.Rows[i].Cells[j].Style.BackColor = Color.White;
                        dgvStokRealita.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                    }
                }
            }
        }

        public int SelectHargaBeli(string kode_barang, DateTime time)
        {
            int hrg = 0;
            conn.Close();
            conn.Open();
            query = new SqlCommand("SELECT dp.Harga_Pembelian FROM [D_Pembelian] dp, [Pembelian] p " +
                "WHERE dp.Kode_Barang = @kode AND dp.No_Nota_Beli = p.No_Nota_Beli AND p.Tanggal_Pembelian in " +
                "(SELECT MAX(p.TANGGAL_PEMBELIAN) FROM [D_Pembelian] dp, [Pembelian] p WHERE dp.Kode_Barang = @kode " +
                "AND dp.No_Nota_Beli = p.No_Nota_Beli AND Tanggal_Pembelian <= @tanggal)", conn);
            query.Parameters.AddWithValue("@kode", kode_barang);
            query.Parameters.AddWithValue("@tanggal", time);
            hrg = Convert.ToInt32(query.ExecuteScalar());
            conn.Close();
            return hrg;
        }

        public int SelectHargaJual(string kode_barang, DateTime time)
        {
            string hrg = "0";
            time = time.Date;
            conn.Close();
            conn.Open();
            query = new SqlCommand("SELECT ISNULL(Harga_Jual, '0') FROM [PH_Jual] WHERE Kode_Barang = @kode AND CAST(Tanggal_Jual AS DATE) IN (SELECT CAST(MAX(Tanggal_Jual) AS DATE) FROM [PH_Jual] WHERE Kode_Barang = @kode AND CAST(Tanggal_Jual AS DATE) = CAST(@tanggal AS DATE))", conn);
            query.Parameters.AddWithValue("@kode", kode_barang);
            query.Parameters.AddWithValue("@tanggal", time);
            if (query.ExecuteScalar() == null)
            {
                query = new SqlCommand("SELECT ISNULL(Harga_Jual, '0') FROM [PH_Jual] WHERE Kode_Barang = @kode AND CAST(Tanggal_Jual AS DATE) IN (SELECT CAST(MAX(Tanggal_Jual) AS DATE) FROM [PH_Jual] WHERE Kode_Barang = @kode AND CAST(Tanggal_Jual AS DATE) < @tanggal)", conn);
                query.Parameters.AddWithValue("@kode", kode_barang);
                query.Parameters.AddWithValue("@tanggal", time);
                hrg = Convert.ToInt32(query.ExecuteScalar()).ToString();
            }
            else
            {
                hrg = Convert.ToInt32(query.ExecuteScalar()).ToString();
            }
            conn.Close();
            return Convert.ToInt32(hrg);
        }

        public int SumJumlahBeli(string kode_barang, string id_cabang)
        {
            int jml = 0;
            conn.Close();
            conn.Open();
            string queryStr = "SELECT Jumlah FROM [Stok] WHERE Kode_barang = @kode AND Id_Cabang = @id_cabang AND Status_Stok = @gudang";
            query = new SqlCommand(queryStr, conn);
            query.Parameters.AddWithValue("@kode", kode_barang);
            query.Parameters.AddWithValue("@id_cabang", id_cabang);
            query.Parameters.AddWithValue("@gudang", 0);
            jml = Convert.ToInt32(query.ExecuteScalar());
            return jml;
        }

        public int SumJumlahTerjual(string kode_barang, string id_cabang, DateTime time)
        {
            int jml = 0;
            conn.Close();
            conn.Open();
            string queryStr = "SELECT ISNULL(SUM(D.Jumlah_Pembelian), '0') " +
                "FROM [D_Trans] D, [Transaksi] T WHERE D.Kode_Barang = @kode AND T.No_Nota_Transaksi = D.No_Nota_Transaksi AND CAST(T.Waktu_trans AS DATE) = CAST(@time AS DATE)";
            query = new SqlCommand(queryStr, conn);
            query.Parameters.AddWithValue("@kode", kode_barang);
            query.Parameters.AddWithValue("@id_cabang", id_cabang);
            query.Parameters.AddWithValue("@time", time);
            jml = Convert.ToInt32(query.ExecuteScalar());
            return jml;
        }

        public void LoadAwal(DateTime time)
        {
            dgvStok.Rows.Clear();
            dgvStokRealita.Rows.Clear();

            for (int i = 0; i < Login.ds.Tables["Data_Barang"].Rows.Count; i++)
            {
                string kode_barang = Login.ds.Tables["Data_Barang"].Rows[i][0].ToString();
                string nama_barang = Login.ds.Tables["Data_Barang"].Rows[i][1].ToString();
                string QtyBox = Login.ds.Tables["Data_Barang"].Rows[i][2].ToString();
                int hrgBeli = SelectHargaBeli(kode_barang, time);
                int hrgJual = SelectHargaJual(kode_barang, time);
                int jmlBeli = SumJumlahBeli(kode_barang, Id_Cabang_Manager);
                int jmlJual = SumJumlahTerjual(kode_barang, Id_Cabang_Manager, time);
                int stokHilang = SelectStokHRK(kode_barang, Id_Cabang_Manager, 0, time);
                int stokRusak = SelectStokHRK(kode_barang, Id_Cabang_Manager, 1, time);
                int stokKadaluarsa = SelectStokHRK(kode_barang, Id_Cabang_Manager, 2, time);
                int stokRealita = SelectStokRealita(kode_barang, Id_Cabang_Manager, time);
                
                Login.ds.Tables["Data_Barang"].Rows[i][3] = hrgBeli.ToString();
                Login.ds.Tables["Data_Barang"].Rows[i][4] = hrgJual.ToString();
                Login.ds.Tables["Data_Barang"].Rows[i][5] = jmlBeli.ToString();
                Login.ds.Tables["Data_Barang"].Rows[i][6] = jmlJual.ToString();
                Login.ds.Tables["Data_Barang"].Rows[i][7] = stokHilang.ToString();
                Login.ds.Tables["Data_Barang"].Rows[i][8] = stokRusak.ToString();
                Login.ds.Tables["Data_Barang"].Rows[i][9] = stokKadaluarsa.ToString();
                Login.ds.Tables["Data_Barang"].Rows[i][10] = stokRealita.ToString();

                CekStokSesuai();
                lblHilang.Text = SumDGVTotalByIdxCol(6).ToString();
                lblRusak.Text = SumDGVTotalByIdxCol(7).ToString();
                lblKadaluarsa.Text = SumDGVTotalByIdxCol(8).ToString();
                lblPenjualan.Text = "Rp. " + SumDGVTotalKali(3, 5).ToString("#,##0");
            }
        }

        private string[] GetRowDGVFromDsDataBarang(int i)
        {
            string kode = Login.ds.Tables["Data_Barang"].Rows[i][0].ToString();
            string nama_barang = Login.ds.Tables["Data_Barang"].Rows[i][1].ToString();
            string hrgBeli = Login.ds.Tables["Data_Barang"].Rows[i][3].ToString();
            string hrgJual = Login.ds.Tables["Data_Barang"].Rows[i][4].ToString();
            string stokGudang = Login.ds.Tables["Data_Barang"].Rows[i][5].ToString();
            string terjual = Login.ds.Tables["Data_Barang"].Rows[i][6].ToString();
            string hilang = Login.ds.Tables["Data_Barang"].Rows[i][7].ToString();
            string rusak = Login.ds.Tables["Data_Barang"].Rows[i][8].ToString();
            string kadaluarsa = Login.ds.Tables["Data_Barang"].Rows[i][9].ToString();

            string[] row = new string[] { kode, nama_barang, hrgBeli, hrgJual, stokGudang, terjual, hilang, rusak, kadaluarsa};
            return row;
        }

        private string[] GetRowDGVFromDsDataBarangRealita(int i)
        {
            string kode = Login.ds.Tables["Data_Barang"].Rows[i][0].ToString();
            string nama_barang = Login.ds.Tables["Data_Barang"].Rows[i][1].ToString();
            string stokRealita = Login.ds.Tables["Data_Barang"].Rows[i][10].ToString();
            string QtyBox = Login.ds.Tables["Data_Barang"].Rows[i][2].ToString();

            string[] row = new string[] { kode, nama_barang, QtyBox, stokRealita };
            return row;
        }

        private bool CekRowSesuai(int i)
        {
            int stokGudang = Convert.ToInt32(Login.ds.Tables["Data_Barang"].Rows[i][5]);
            int terjual = Convert.ToInt32(Login.ds.Tables["Data_Barang"].Rows[i][6]);
            int hilang = Convert.ToInt32(Login.ds.Tables["Data_Barang"].Rows[i][7]);
            int rusak = Convert.ToInt32(Login.ds.Tables["Data_Barang"].Rows[i][8]);
            int kadaluarsa = Convert.ToInt32(Login.ds.Tables["Data_Barang"].Rows[i][9]);
            int stokRealita = Convert.ToInt32(Login.ds.Tables["Data_Barang"].Rows[i][10]);

            return stokRealita >= 0 && terjual >= 0 && hilang >= 0 && rusak >= 0 && kadaluarsa >= 0 && stokGudang >= 0;
        }
        
        private void RecursiveLoadDataset(string filter, int i)
        {
            if (i < Login.ds.Tables["Data_Barang"].Rows.Count)
            {
                if (filter == "semua")
                {
                    dgvStok.Rows.Add(GetRowDGVFromDsDataBarang(i));
                    dgvStokRealita.Rows.Add(GetRowDGVFromDsDataBarangRealita(i));
                }
                else if (filter == "eceran")
                {
                    if (Login.ds.Tables["Data_Barang"].Rows[i][2].ToString() == "1")
                    {
                        dgvStok.Rows.Add(GetRowDGVFromDsDataBarang(i));
                        dgvStokRealita.Rows.Add(GetRowDGVFromDsDataBarangRealita(i));
                    }
                }
                else if (filter == "dus")
                {
                    if (Login.ds.Tables["Data_Barang"].Rows[i][2].ToString() != "1")
                    {
                        dgvStok.Rows.Add(GetRowDGVFromDsDataBarang(i));
                        dgvStokRealita.Rows.Add(GetRowDGVFromDsDataBarangRealita(i));
                    }
                }
                else if (filter == "sesuai")
                {
                    if (CekRowSesuai(i))
                    {
                        dgvStok.Rows.Add(GetRowDGVFromDsDataBarang(i));
                        dgvStokRealita.Rows.Add(GetRowDGVFromDsDataBarangRealita(i));
                    }
                }
                else if (filter == "tidak sesuai")
                {
                    if (!CekRowSesuai(i))
                    {
                        dgvStok.Rows.Add(GetRowDGVFromDsDataBarang(i));
                        dgvStokRealita.Rows.Add(GetRowDGVFromDsDataBarangRealita(i));
                    }
                }

                RecursiveLoadDataset(filter, i + 1);
            }
        }

        private void LoadDataSetToDGV(string filter)
        {
            dgvStok.Rows.Clear();
            dgvStokRealita.Rows.Clear();
            RecursiveLoadDataset(filter, 0);
            CekStokSesuai();
        }

        private void cbLihatStok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            int idx = cbFilter.SelectedIndex;
            if (idx == 0) //semua
            {
                LoadDataSetToDGV("semua");
            }
            else if (idx == 1) //eceran
            {
                LoadDataSetToDGV("eceran");
            }
            else if (idx == 2) //dus
            {
                LoadDataSetToDGV("dus");
            }
            else if (idx == 3) //sesuai
            {
                LoadDataSetToDGV("sesuai");
            }
            else if (idx == 4) //tidak sesuai
            {
                LoadDataSetToDGV("tidak sesuai");
            }
        }

        private void dgvStok_MouseEnter(object sender, EventArgs e)
        {
            if (Manager.LihatAtauInput == "Lihat")
            {
                for (int i = 0; i < dgvStok.ColumnCount; i++)
                {
                    dgvStok.Columns[i].ReadOnly = true;
                }
                for(int i =0; i < dgvStokRealita.ColumnCount; i++)
                {
                    dgvStokRealita.Columns[i].ReadOnly = true;
                }
            }
            else if (Manager.LihatAtauInput == "Input")
            {
                for (int i = 0; i < 5; i++)
                {
                    dgvStok.Columns[i].ReadOnly = true;
                }
                for (int i = 6; i <= 8; i++)
                {
                    dgvStok.Columns[i].ReadOnly = false;
                }
                for (int i = 0; i < dgvStokRealita.Columns.Count; i++)
                {
                    dgvStokRealita.Columns[i].ReadOnly = true;
                }
                dgvStokRealita.Columns[dgvStokRealita.Columns.Count-1].ReadOnly = false;
            }
        }

        private void dgvStok_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
            }
            catch
            {
                throw;
            }
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (Char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void dgvStok_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgvStok.Rows.Count && e.ColumnIndex > -1 && e.ColumnIndex < 13)
            {
                string kodeBarangEdit = dgvStok.Rows[e.RowIndex].Cells[0].Value.ToString();
                int idxAda = -1;
                for (int i = 0; i < Login.ds.Tables["Data_Barang"].Rows.Count; i++)
                {
                    if (Login.ds.Tables["Data_Barang"].Rows[i][0].ToString() == kodeBarangEdit)
                    {
                        idxAda = i;
                        break;
                    }
                }
                //dr kehong
                if (idxAda != -1)
                {
                    Login.ds.Tables["Data_Barang"].Rows[idxAda][7] = dgvStok.Rows[e.RowIndex].Cells[6].Value.ToString();
                    Login.ds.Tables["Data_Barang"].Rows[idxAda][8] = dgvStok.Rows[e.RowIndex].Cells[7].Value.ToString();
                    Login.ds.Tables["Data_Barang"].Rows[idxAda][9] = dgvStok.Rows[e.RowIndex].Cells[8].Value.ToString();
                }
                CekStokSesuai();
                lblHilang.Text = SumDGVTotalByIdxCol(6).ToString();
                lblRusak.Text = SumDGVTotalByIdxCol(7).ToString();
                lblKadaluarsa.Text = SumDGVTotalByIdxCol(8).ToString();
                lblPenjualan.Text = "Rp. " + SumDGVTotalKali(3, 5).ToString("#,##0");
            }
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

        private void btnKirimLaporan_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            query = new SqlCommand("Select count(Kode_Barang) from [Stok_HRK] where CAST(Tanggal AS DATE) = CAST(GETDATE() AS DATE)", conn);
            int row_kode_barang = (int)query.ExecuteScalar();
            conn.Close();
            conn.Open();
            if (row_kode_barang == 0)
            {
                for (int i = 0; i < Login.ds.Tables["Data_Barang"].Rows.Count; i++)
                {
                    
                    for (int j = 7; j <= 9; j++)
                    {
                        string kodesistem = LoadKodeSistem(Login.ds.Tables["Data_Barang"].Rows[i][0].ToString());
                        query = new SqlCommand("Insert into [Stok_HRK](Kode_Sistem, Kode_Barang, Jumlah, Tanggal, Id_Cabang, Status_Stok, Id_User) values(@Kode_Sistem,@Kode_Barang,@Jumlah,@Tanggal,@ID_Cabang,@Status_Stok, @User)", conn);
                        query.Parameters.AddWithValue("@Kode_Barang", Login.ds.Tables["Data_Barang"].Rows[i][0].ToString());
                        query.Parameters.AddWithValue("@Kode_Sistem", kodesistem);
                        query.Parameters.AddWithValue("@Jumlah", Login.ds.Tables["Data_Barang"].Rows[i][j].ToString());
                        query.Parameters.AddWithValue("@Tanggal", DateTime.Now);
                        query.Parameters.AddWithValue("@ID_Cabang", Id_Cabang_Manager);
                        query.Parameters.AddWithValue("@User", Login.ds.Tables["Manager"].Rows[0][0].ToString());
                        query.Parameters.AddWithValue("@Status_Stok", j - 7);
                        query.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                for (int i = 0; i < Login.ds.Tables["Data_Barang"].Rows.Count; i++)
                {
                    for (int j = 7; j <= 9; j++)
                    {
                        query = new SqlCommand("Update [Stok_HRK] set Jumlah=@Jumlah where CAST(Tanggal AS DATE) = CAST(@Tanggal AS DATE) and ID_Cabang=@ID_Cabang and Status_Stok=@Status_Stok and Kode_Barang=@Kode_Barang and ID_Cabang=@ID_Cabang", conn);
                        query.Parameters.AddWithValue("@Kode_Barang", Login.ds.Tables["Data_Barang"].Rows[i][0].ToString());
                        query.Parameters.AddWithValue("@Jumlah", Login.ds.Tables["Data_Barang"].Rows[i][j].ToString());
                        query.Parameters.AddWithValue("@Tanggal", DateTime.Now);
                        query.Parameters.AddWithValue("@ID_Cabang", Id_Cabang_Manager);
                        query.Parameters.AddWithValue("@Status_Stok", j - 7);
                        query.ExecuteNonQuery();
                    }
                }
                query.ExecuteNonQuery();
            }
            conn.Close();
            conn.Open();
            for (int i = 0; i < Login.ds.Tables["Data_Barang"].Rows.Count; i++)
            {
                query = new SqlCommand("Update [Stok] set Jumlah = @Jumlah where status_stok = @realita and Kode_Barang=@Kode and id_cabang=@Id", conn);
                query.Parameters.AddWithValue("@Kode", Login.ds.Tables["Data_Barang"].Rows[i][0].ToString());
                query.Parameters.AddWithValue("@Jumlah", Login.ds.Tables["Data_Barang"].Rows[i][10].ToString());
                query.Parameters.AddWithValue("@Id", Id_Cabang_Manager);
                query.Parameters.AddWithValue("@realita", 1);
                query.ExecuteNonQuery();
            }
            conn.Close();
            KirimRiwayat();
            SelectDataBarang();
            LoadAwal(dtmLihatStok.Value);
            Filter();
            if (tbSearch.Text != "")
            {
                do_search();
            }
            MessageBox.Show("Succeed In Sending Report", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int JmlStokBaik()
        {
            int stok = 0;
            for (int i = 0; i < Login.ds.Tables["Data_Barang"].Rows.Count; i++)
            {
                stok += Convert.ToInt32(Login.ds.Tables["Data_Barang"].Rows[i][10]);
            }
            return stok;
        }

        private int JmlStokHilang()
        {
            int stok = 0;
            for (int i = 0; i < Login.ds.Tables["Data_Barang"].Rows.Count; i++)
            {
                stok += Convert.ToInt32(Login.ds.Tables["Data_Barang"].Rows[i][7]);
            }
            return stok;
        }

        private int JmlStokRusak()
        {
            int stok = 0;
            for (int i = 0; i < Login.ds.Tables["Data_Barang"].Rows.Count; i++)
            {
                stok += Convert.ToInt32(Login.ds.Tables["Data_Barang"].Rows[i][8]);
            }
            return stok;
        }

        private int JmlStokKadaluarsa()
        {
            int stok = 0;
            for (int i = 0; i < Login.ds.Tables["Data_Barang"].Rows.Count; i++)
            {
                stok += Convert.ToInt32(Login.ds.Tables["Data_Barang"].Rows[i][9]);
            }
            return stok;
        }

        private void KirimRiwayat()
        {
            string keterangan = "Mengirim Laporan Stok dengan Total Stok Baik " + JmlStokBaik() + ", Stok Hilang " + JmlStokHilang() + ", Stok Rusak " + JmlStokRusak() + " dan Stok Kadaluarsa " + JmlStokKadaluarsa() + ".";
            conn.Open();
            query = new SqlCommand("INSERT INTO [Riwayat](Id_User, Id_Cabang, Keterangan, Waktu) VALUES(@Id, @Cabang, @Keterangan, @Waktu)", conn);
            query.Parameters.AddWithValue("@Id", Login.ds.Tables["Manager"].Rows[0][0].ToString());
            query.Parameters.AddWithValue("@Cabang", Id_Cabang_Manager);
            query.Parameters.AddWithValue("@Keterangan", keterangan);
            query.Parameters.AddWithValue("@Waktu", DateTime.Now);
            query.ExecuteNonQuery();
            conn.Close();
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnShow_Click(sender, e);
            }
        }

        bool SetDtmAwalDone = false;

        private void dtmLihatStok_ValueChanged(object sender, EventArgs e)
        {
            if (dtmLihatStok.Value.Date <= DateTime.Now.Date)
            {
                lblDateShow.Text = "Warehouse Stock from " + dtmLihatStok.Value.ToLongDateString();

                if (SetDtmAwalDone)
                {
                    btnShow_Click(sender, e);
                }
            }
            else
            {
                dtmLihatStok.Value = DateTime.Now;
                MessageBox.Show("ERROR : chosen viewing date can't surpass today", "VIEW STOCKS FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void dtmLihatStok_Enter(object sender, EventArgs e)
        {

        }

        private void dgvStokRealita_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgvStokRealita.Rows.Count && e.ColumnIndex > -1 && e.ColumnIndex < dgvStokRealita.ColumnCount)
            {
                string kodeBarangEdit = dgvStokRealita.Rows[e.RowIndex].Cells[0].Value.ToString();
                int idxAda = -1;
                for (int i = 0; i < Login.ds.Tables["Data_Barang"].Rows.Count; i++)
                {
                    if (Login.ds.Tables["Data_Barang"].Rows[i][0].ToString() == kodeBarangEdit)
                    {
                        idxAda = i;
                        break;
                    }
                }
                //dr kehong
                if (idxAda != -1)
                {
                    Login.ds.Tables["Data_Barang"].Rows[idxAda][10] = dgvStokRealita.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
                CekStokSesuai();
                lblHilang.Text = SumDGVTotalByIdxCol(6).ToString();
                lblRusak.Text = SumDGVTotalByIdxCol(7).ToString();
                lblKadaluarsa.Text = SumDGVTotalByIdxCol(8).ToString();
                lblPenjualan.Text = "Rp. " + SumDGVTotalKali(3, 5).ToString("#,##0");
            }
        }

        private void Manager_Lihat_Edit_Stock_Activated(object sender, EventArgs e)
        {
        }

        private void Manager_Lihat_Edit_Stock_Load(object sender, EventArgs e)
        {

            

        }

        bool DGVLoaded = false;
        
        private void Manager_Lihat_Edit_Stock_VisibleChanged(object sender, EventArgs e)
        {
            if (Manager.LihatAtauInput == "Lihat")
            {
                lblPenjualan.Visible = true;
                lblSPenjualan.Visible = true;
                btnKirimLaporan.Visible = false;
                lblSTgl.Visible = true;
                dtmLihatStok.Visible = true;
                dtmLihatStok.Enabled = true;
                dgvStok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvStokRealita.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else if (Manager.LihatAtauInput == "Input")
            {
                if (dtmLihatStok.Value.ToShortDateString() != DateTime.Now.ToShortDateString())
                {
                    dtmLihatStok.Value = DateTime.Now;
                    Login.ds.Tables["Data_Barang"].Rows.Clear();
                    SelectDataBarang();
                    LoadAwal(dtmLihatStok.Value);
                    Filter();
                }
                lblPenjualan.Visible = false;
                lblSPenjualan.Visible = false;
                btnKirimLaporan.Visible = true;
                dgvStok.Enabled = true;
                lblSTgl.Visible = false;
                dtmLihatStok.Enabled = false;
                dtmLihatStok.Visible = false;
                dtmLihatStok.Enabled = false;
                dgvStok.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dgvStokRealita.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }

            dtmCustomFormat(ref dtmLihatStok, "dd/MMM/yyyy");
            conn = new SqlConnection(connString);
            dtmLihatStok.Value = DateTime.Now;
            SetDtmAwalDone = true;
            lblDateNow.Text = "Available Stock from " + DateTime.Now.ToLongDateString();
            LoadCabang();
            SelectDataBarang();
            if (Login.ds.Tables["Data_Barang"].Columns.Count < 4)
            {
                Login.ds.Tables["Data_Barang"].Columns.Add("hrgBeli");
                Login.ds.Tables["Data_Barang"].Columns.Add("hrgJual");
                Login.ds.Tables["Data_Barang"].Columns.Add("jmlBeli");
                Login.ds.Tables["Data_Barang"].Columns.Add("jmlJual");
                Login.ds.Tables["Data_Barang"].Columns.Add("stokHilang");
                Login.ds.Tables["Data_Barang"].Columns.Add("stokRusak");
                Login.ds.Tables["Data_Barang"].Columns.Add("stokKadaluarsa");
                Login.ds.Tables["Data_Barang"].Columns.Add("stokRealita");
            }
            LoadAwal(dtmLihatStok.Value);
            cbFilter.SelectedIndex = -1;
            cbFilter.SelectedIndex = 0;
            CekStokSesuai();
            lblHilang.Text = SumDGVTotalByIdxCol(6).ToString();
            lblRusak.Text = SumDGVTotalByIdxCol(7).ToString();
            lblKadaluarsa.Text = SumDGVTotalByIdxCol(8).ToString();
            lblPenjualan.Text = "Rp. " + SumDGVTotalKali(3, 5).ToString("#,##0");
        }

        
    }
}
