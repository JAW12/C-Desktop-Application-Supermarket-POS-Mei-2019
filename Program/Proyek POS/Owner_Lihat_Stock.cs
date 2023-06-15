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
    public partial class Owner_Lihat_Stock : Form
    {
        public Owner_Lihat_Stock()
        {
            InitializeComponent();
        }

        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Proyek_POS.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand query;
        SqlDataAdapter adapter;

        bool RealitaLoaded = false;
        List<DateTime> dtime = new List<DateTime>();

        public void GetListBetweenDates(ref List<DateTime> dtList, DateTime dtAwal, DateTime dtAkhir)
        {
            dtList.Clear();
            int selisih = (int)(dtAkhir.Date - dtAwal.Date).TotalDays;
            for (int i = 0; i <= selisih; i++)
            {
                dtList.Add(dtAwal.AddDays(i));
            }
        }

        private void RecursiveLoadCabangToCombobox(int i, DataTable dt)
        {
            if (i < dt.Rows.Count)
            {
                String cek = dt.Rows[i][0].ToString();
                if (dt.Rows[i][0].ToString() == "ALL")
                {
                    cbIdCabang.Items.Add("Central Warehouse");
                }
                else
                {
                    cbIdCabang.Items.Add(dt.Rows[i][0] + " - " + dt.Rows[i][1]);
                }

                RecursiveLoadCabangToCombobox(i + 1, dt);
            }
        }

        private void LoadCabangToComboBox(ref ComboBox sender)
        {
            ComboBox cb = (ComboBox)sender;
            cb.Items.Clear();
            conn.Close();
            conn.Open();
            DataTable dt = new DataTable();
            if (dt.Rows.Count > 0)
            {
                dt.Rows.Clear();
            }
            query = new SqlCommand("SELECT ID_Cabang, Nama_Cabang FROM Cabang", conn);
            adapter = new SqlDataAdapter(query);
            adapter.Fill(dt);
            conn.Close();
            RecursiveLoadCabangToCombobox(0, dt);
        }

        private void RecursiveAutoSizeColumnMode(int i, bool statsVisible, DataGridViewAutoSizeColumnsMode auto)
        {
            if (i <= 9)
            {
                dgvStok.Columns[i].Visible = statsVisible;
                dgvStok.AutoSizeColumnsMode = auto;
                RecursiveAutoSizeColumnMode(i + 1, statsVisible, auto);
            }
        }

        int LastFilterIdx = 0;
        private void ChangeFilterDGVAndDTMDisplay()
        {
            if (cbIdCabang.SelectedIndex > -1)
            {
                if (cbIdCabang.SelectedItem.ToString() == "Central Warehouse")
                {
                    dgvStok.Columns[0].Visible = false;
                    RecursiveAutoSizeColumnMode(6, false, DataGridViewAutoSizeColumnsMode.DisplayedCells);
                    dtmTanggalAwal.Visible = false;
                    dtmTanggalAkhir.Visible = false;
                    lblSampai.Visible = false;
                    lblDateShow.Text = DateTime.Now.ToLongDateString();
                  
                    cbFilter.Visible = false;
                    lblSFilter.Visible = false;
                    
                    cbFilter.SelectedIndex = 2;
                }
                else
                {
                    dgvStok.Columns[0].Visible = true;
                    RecursiveAutoSizeColumnMode(6, true, DataGridViewAutoSizeColumnsMode.Fill);
                    dtmTanggalAwal.Visible = true;
                    dtmTanggalAkhir.Visible = true;
                    lblSampai.Visible = true;
                    lblDateShow.Text = lblDateAwalToAkhir(dtmTanggalAwal, dtmTanggalAkhir);
                    cbFilter.Visible = true;
                    lblSFilter.Visible = true;
                    cbFilter.SelectedIndex = LastFilterIdx;
                }
            }
        }

        private void Owner_Lihat_Stock_Shown(object sender, EventArgs e)
        {
            dtmCustomFormat(ref dtmTanggalAkhir, "dd/MMM/yyyy");
            dtmCustomFormat(ref dtmTanggalAwal, "dd/MMM/yyyy");
            conn = new SqlConnection(connString);

            LoadCabangToComboBox(ref cbIdCabang);
            ChangeFilterDGVAndDTMDisplay();

            lblDateShow.Text = lblDateAwalToAkhir(dtmTanggalAwal, dtmTanggalAkhir);
            lblDateNow.Text = DateTime.Now.ToLongDateString();

            
            SelectDataBarang();

            int idx = cbIdCabang.FindStringExact("Central Warehouse");
            //cbIdCabang.SelectedIndexChanged -= cbIdCabang_SelectedIndexChanged;
            cbBerdasarkan.SelectedIndexChanged -= cbBerdasarkan_SelectedIndexChanged;
            cbIdCabang.SelectedIndex = idx;

            ////cbFilter.SelectedIndex = 0;
            cbStok.SelectedIndex = 0;
            //cbBerdasarkan.SelectedIndex = 0;
            //cbIdCabang.SelectedIndexChanged += new EventHandler(cbIdCabang_SelectedIndexChanged);
            cbBerdasarkan.SelectedIndexChanged += new EventHandler(cbBerdasarkan_SelectedIndexChanged);

        }

        public void SelectDataBarang()
        {
            string id_cabang = "";
            if (cbIdCabang.SelectedIndex == -1)
            {
                id_cabang = "ALL";
            }
            else
            {
                id_cabang = GetIdCabang(cbIdCabang.SelectedItem.ToString());
            }

            if (Login.ds.Tables.Contains("Data_Barang"))
            {
                Login.ds.Tables["Data_Barang"].Columns.Clear();
            }
            conn.Close();
            conn.Open();
            if (Login.ds.Tables.Contains("Data_Barang"))
            {
                Login.ds.Tables.Remove("Data_Barang");
            }
            query = new SqlCommand("SELECT B.Kode_Barang, B.Nama_Barang, B.QtyBox FROM BARANG B, STOK S WHERE B.Kode_Barang = S.Kode_Barang AND B.Kode_Sistem = S.Kode_Sistem AND S.Id_Cabang = @id_cabang", conn);
            query.Parameters.AddWithValue("@id_cabang", id_cabang);
            adapter = new SqlDataAdapter(query);
            adapter.Fill(Login.ds, "Data_Barang");
            conn.Close();
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
                Login.ds.Tables["Data_Barang"].Columns.Add("tanggal");
            }
        }
        
        public void dtmCustomFormat(ref DateTimePicker dtm, string format)
        {
            dtm.Format = DateTimePickerFormat.Custom;
            dtm.CustomFormat = format;
        }

        private string GetIdCabang(string text)
        {
            string id = "";
            if (text == "Central Warehouse")
            {
                id = "ALL";
            }
            else
            {
                id = text.Substring(0, 5);
            }
            return id;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvStok.Rows.Clear();
            dgvStokRealita.Rows.Clear();
            LoopLoadSesuaiTanggal(dtmTanggalAwal.Value.Date, dtmTanggalAkhir.Value.Date);
            dgvStok.Sort(dgvStok.Columns[0], ListSortDirection.Descending);
            dgvStokRealita.Sort(dgvStokRealita.Columns[1], ListSortDirection.Ascending);
        }

        public int SelectStokHRK(string kode_barang, string id_cabang, int status, DateTime time)
        {
            int stok = 0;
            conn.Close();
            conn.Open();
            query = new SqlCommand("SELECT ISNULL(SUM(Jumlah), '0') FROM [Stok_HRK] " +
                "WHERE Kode_Barang = @kode AND " +
                "Id_Cabang = @id_cabang AND Status_Stok = @status AND " +
                "CAST(Tanggal AS DATE) = @time", conn);
            query.Parameters.AddWithValue("@kode", kode_barang);
            query.Parameters.AddWithValue("@id_cabang", id_cabang);
            query.Parameters.AddWithValue("@status", status);
            query.Parameters.AddWithValue("@time", time.Date);
            if (query.ExecuteScalar() != null)
            {
                stok = Convert.ToInt16(query.ExecuteScalar());
            }
            conn.Close();
            return stok;
        }

        public int SelectStokRealita(string kode_barang, string id_cabang)
        {
            int stok = 0;
            conn.Close();
            conn.Open();
            query = new SqlCommand("SELECT ISNULL(Jumlah, '0') FROM [Stok] WHERE Kode_Barang = @kode AND " +
                "Id_Cabang = @id_cabang AND Status_Stok = @realita", conn);
            query.Parameters.AddWithValue("@kode", kode_barang);
            query.Parameters.AddWithValue("@id_cabang", id_cabang);
            query.Parameters.AddWithValue("@realita", 1);
            stok = Convert.ToInt16(query.ExecuteScalar());
            conn.Close();
            return stok;
        }

        public void RecursiveChangeRowColor(int i, int j, ref DataGridView dgv, Color font, Color background)
        {
            if (j < dgv.Columns.Count)
            {
                dgv.Rows[i].Cells[j].Style.BackColor = background;
                dgv.Rows[i].Cells[j].Style.ForeColor = font;
                RecursiveChangeRowColor(i, j + 1, ref dgv, font, background);
            }
        }
        public void ChangeRowColor(ref DataGridView dgv, int i, Color font, Color background)
        {
            RecursiveChangeRowColor(i, 0, ref dgv, font, background);
        }

        public void RecursiveCekStokSesuai(int i)
        {
            int stokGudang = 0, hilang = 0, rusak = 0, kadaluarsa = 0;
            if (i < dgvStok.Rows.Count)
            {
                if (cbIdCabang.SelectedIndex > -1)
                {
                    if (cbIdCabang.SelectedIndex == 0)
                    {
                        stokGudang = Convert.ToInt32(dgvStok.Rows[i].Cells[5].Value);

                        if (stokGudang < 0)
                        {
                            ChangeRowColor(ref dgvStok, i, Color.White, Color.FromArgb(255, 192, 0, 0));
                        }
                        else
                        {
                            ChangeRowColor(ref dgvStok, i, Color.Black, Color.White);
                        }
                    }
                    else
                    {
                        stokGudang = Convert.ToInt32(dgvStok.Rows[i].Cells[5].Value);
                        hilang = Convert.ToInt32(dgvStok.Rows[i].Cells[7].Value);
                        rusak = Convert.ToInt32(dgvStok.Rows[i].Cells[8].Value);
                        kadaluarsa = Convert.ToInt32(dgvStok.Rows[i].Cells[9].Value);

                        if (stokGudang < 0 || hilang < 0 || rusak < 0 || kadaluarsa < 0)
                        {
                            ChangeRowColor(ref dgvStok, i, Color.White, Color.FromArgb(255, 192, 0, 0));
                        }
                        else
                        {
                            ChangeRowColor(ref dgvStok, i, Color.Black, Color.White);
                        }
                    }
                }

                RecursiveCekStokSesuai(i + 1);
            }
        }

        public void RecursiveCekStokRealitaSesuai(int i)
        {
            int stokRealita = 0;
            if (i < dgvStokRealita.Rows.Count)
            {
                stokRealita = Convert.ToInt32(dgvStokRealita.Rows[i].Cells[3].Value);
                if (stokRealita < 0)
                {
                    ChangeRowColor(ref dgvStokRealita, i, Color.White, Color.FromArgb(255, 192, 0, 0));
                }
                else
                {
                    ChangeRowColor(ref dgvStokRealita, i, Color.Black, Color.White);
                }

                RecursiveCekStokRealitaSesuai(i + 1);
            }
        }

        public void CekStokSesuai()
        {
            RecursiveCekStokSesuai(0);
            RecursiveCekStokRealitaSesuai(0);
        }

        public int SelectHargaBeli(string kode_barang, string id_cabang)
        {
            int hrg = 0;
            conn.Close();
            conn.Open();
            query = new SqlCommand("SELECT dp.Harga_Pembelian FROM [D_Pembelian] dp, [Pembelian] p " +
                "WHERE dp.Kode_Barang = @kode AND dp.No_Nota_Beli = p.No_Nota_Beli AND p.Tanggal_Pembelian in " +
                "(SELECT MAX(p.TANGGAL_PEMBELIAN) FROM [D_Pembelian] dp, [Pembelian] p WHERE dp.Kode_Barang = @kode " +
                "AND dp.No_Nota_Beli = p.No_Nota_Beli)", conn);
            query.Parameters.AddWithValue("@kode", kode_barang);
            query.Parameters.AddWithValue("@id_cabang", id_cabang);
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
            query = new SqlCommand("SELECT ISNULL(Harga_Jual, '-') FROM [PH_Jual] WHERE Kode_Barang = @kode AND CAST(Tanggal_Jual AS DATE) = @tanggal", conn);
            query.Parameters.AddWithValue("@kode", kode_barang);
            query.Parameters.AddWithValue("@tanggal", time);
            if (query.ExecuteScalar() == null)
            {
                query = new SqlCommand("SELECT Harga_Jual FROM [PH_Jual] WHERE Kode_Barang = @kode AND CAST(Tanggal_Jual AS DATE) IN (SELECT CAST(MAX(Tanggal_Jual) AS DATE) FROM [PH_Jual] WHERE Kode_Barang = @kode HAVING CAST(MAX(Tanggal_Jual) AS DATE) <= @tanggal)", conn);
                query.Parameters.AddWithValue("@kode", kode_barang);
                query.Parameters.AddWithValue("@tanggal", time.Date);
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

        public int SumJumlahBeli(string kode_barang, string id_cabang)
        {
            int jml = 0;
            conn.Close();
            conn.Open();
            string queryStr = "SELECT Jumlah FROM [Stok] WHERE Kode_barang = @kode AND Id_Cabang = @id_cabang AND " +
                "Status_Stok = @gudang";
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

        public int SumDGVHRKByIdxCol(int idx)
        {
            int ttl = 0;
            foreach (DataGridViewRow row in dgvStok.Rows)
            {
                ttl += Convert.ToInt32(row.Cells[idx].Value);
            }
            return ttl;
        }

        public int SumDGVRealitaByIdxCol(int idx)
        {
            int ttl = 0;
            foreach (DataGridViewRow row in dgvStokRealita.Rows)
            {
                ttl += Convert.ToInt32(row.Cells[idx].Value);
            }
            return ttl;
        }

        public void RecursiveLoadStockPerHari(int i, string id_cabang, DateTime time)
        {
            if (i < Login.ds.Tables["Data_Barang"].Rows.Count)
            {
                string kode_barang = Login.ds.Tables["Data_Barang"].Rows[i][0].ToString();
                string nama_barang = Login.ds.Tables["Data_Barang"].Rows[i][1].ToString();
                string QtyBox = Login.ds.Tables["Data_Barang"].Rows[i][2].ToString();
                int hrgBeli = SelectHargaBeli(kode_barang, id_cabang);
                int hrgJual = SelectHargaJual(kode_barang, time);
                int jmlBeli = SumJumlahBeli(kode_barang, id_cabang);
                int jmlJual = SumJumlahTerjual(kode_barang, id_cabang, time);
                int stokHilang = SelectStokHRK(kode_barang, id_cabang, 0, time);
                int stokRusak = SelectStokHRK(kode_barang, id_cabang, 1, time);
                int stokKadaluarsa = SelectStokHRK(kode_barang, id_cabang, 2, time);
                int stokRealita = SelectStokRealita(kode_barang, id_cabang);

                Login.ds.Tables["Data_Barang"].Rows[i][3] = hrgBeli.ToString();
                Login.ds.Tables["Data_Barang"].Rows[i][4] = hrgJual.ToString();
                Login.ds.Tables["Data_Barang"].Rows[i][5] = jmlBeli.ToString();
                Login.ds.Tables["Data_Barang"].Rows[i][6] = jmlJual.ToString();
                Login.ds.Tables["Data_Barang"].Rows[i][7] = stokHilang.ToString();
                Login.ds.Tables["Data_Barang"].Rows[i][8] = stokRusak.ToString();
                Login.ds.Tables["Data_Barang"].Rows[i][9] = stokKadaluarsa.ToString();
                Login.ds.Tables["Data_Barang"].Rows[i][10] = stokRealita.ToString();
                Login.ds.Tables["Data_Barang"].Rows[i][11] = time;

                RecursiveLoadStockPerHari(i + 1, id_cabang, time);
            }
        }
        public void LoadStockPerHari(DateTime time)
        {
            string id_cabang = GetIdCabang(cbIdCabang.SelectedItem.ToString());
            RecursiveLoadStockPerHari(0, id_cabang, time);
            Filter();
        }

        public void RecursiveDtime(int i)
        {
            if (i < dtime.Count)
            {
                LoadStockPerHari(dtime[i]);
                RecursiveDtime(i + 1);
            }
        }

        private void LoopLoadSesuaiTanggal(DateTime tglAwal, DateTime tglAkhir)
        {
            SelectDataBarang();
            dgvStok.Rows.Clear();
            int selisih = (int)(tglAkhir.Date - tglAwal.Date).TotalDays;
            GetListBetweenDates(ref dtime, tglAwal, tglAkhir);
            RecursiveDtime(0);
            CekStokSesuai();
            if (cbIdCabang.SelectedIndex != 0)
            {
                lblHilang.Text = SumDGVHRKByIdxCol(7).ToString();
                lblRusak.Text = SumDGVHRKByIdxCol(8).ToString();
                lblKadaluarsa.Text = SumDGVHRKByIdxCol(9).ToString();
                lblStokBaik.Text = SumDGVRealitaByIdxCol(3).ToString();
            }
            else
            {
                lblHilang.Text = SumDGVHRKByIdxCol(7).ToString();
                lblRusak.Text = SumDGVHRKByIdxCol(8).ToString();
                lblKadaluarsa.Text = SumDGVHRKByIdxCol(9).ToString();
                lblStokBaik.Text = SumDGVHRKByIdxCol(5).ToString();
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
            string tgl = Convert.ToDateTime(Login.ds.Tables["Data_Barang"].Rows[i][11]).ToString("dd/MMM/yyyy");

            string[] row = new string[] { tgl, kode, nama_barang, hrgBeli, hrgJual, stokGudang, terjual, hilang, rusak, kadaluarsa };
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
            int terjual = Convert.ToInt32(Login.ds.Tables["Data_Barang"].Rows[i][6]);
            int hilang = Convert.ToInt32(Login.ds.Tables["Data_Barang"].Rows[i][7]);
            int rusak = Convert.ToInt32(Login.ds.Tables["Data_Barang"].Rows[i][8]);
            int kadaluarsa = Convert.ToInt32(Login.ds.Tables["Data_Barang"].Rows[i][9]);
            int stokRealita = Convert.ToInt32(Login.ds.Tables["Data_Barang"].Rows[i][10]);

            return stokRealita >= 0 && terjual >= 0 && hilang >= 0 && rusak >= 0 && kadaluarsa >= 0;
        }

        private void RecursiveLoadDatasetToDGV(int i, string filter)
        {
            if (i < Login.ds.Tables["Data_Barang"].Rows.Count)
            {
                if (filter == "semua")
                {
                    dgvStok.Rows.Add(GetRowDGVFromDsDataBarang(i));
                    if (!RealitaLoaded && cbIdCabang.SelectedIndex > 0)
                    {
                        dgvStokRealita.Rows.Add(GetRowDGVFromDsDataBarangRealita(i));
                    }
                }
                else if (filter == "eceran")
                {
                    if (Login.ds.Tables["Data_Barang"].Rows[i][2].ToString() == "1")
                    {
                        dgvStok.Rows.Add(GetRowDGVFromDsDataBarang(i));
                        if (!RealitaLoaded && cbIdCabang.SelectedIndex > 0)
                        {
                            dgvStokRealita.Rows.Add(GetRowDGVFromDsDataBarangRealita(i));
                        }
                    }
                }
                else if (filter == "dus")
                {
                    if (Login.ds.Tables["Data_Barang"].Rows[i][2].ToString() != "1")
                    {
                        dgvStok.Rows.Add(GetRowDGVFromDsDataBarang(i));
                        if (!RealitaLoaded && cbIdCabang.SelectedIndex > 0)
                        {
                            dgvStokRealita.Rows.Add(GetRowDGVFromDsDataBarangRealita(i));
                        }
                    }
                }
                else if (filter == "sesuai")
                {
                    if (CekRowSesuai(i))
                    {
                        dgvStok.Rows.Add(GetRowDGVFromDsDataBarang(i));
                        if (!RealitaLoaded && cbIdCabang.SelectedIndex > 0)
                        {
                            dgvStokRealita.Rows.Add(GetRowDGVFromDsDataBarangRealita(i));
                        }
                    }
                }
                else if (filter == "tidak sesuai")
                {
                    if (!CekRowSesuai(i))
                    {
                        dgvStok.Rows.Add(GetRowDGVFromDsDataBarang(i));
                        if (!RealitaLoaded && cbIdCabang.SelectedIndex > 0)
                        {
                            dgvStokRealita.Rows.Add(GetRowDGVFromDsDataBarangRealita(i));
                        }

                    }
                }
                CekStokSesuai();
                RecursiveLoadDatasetToDGV(i + 1, filter);
            }
        }

        private void LoadDataSetToDGV(string filter)
        {
            if (!RealitaLoaded)
            {
                dgvStokRealita.Rows.Clear();
            }
            RecursiveLoadDatasetToDGV(0, filter);
            if (cbIdCabang.SelectedIndex > 0)
            {
                RealitaLoaded = true;
            }
        }

        private void Filter()
        {
            RealitaLoaded = false;
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

        private void cbIdCabang_SelectedIndexChanged(object sender, EventArgs e)
        {
            RealitaLoaded = false;
            if (cbIdCabang.SelectedIndex == 0)
            {
                dgvStok.Rows.Clear();
                dtmTanggalAwal.Value = DateTime.Now.Date;
                dtmTanggalAkhir.Value = DateTime.Now.Date;
                //LoopLoadSesuaiTanggal(dtmTanggalAwal.Value, dtmTanggalAkhir.Value);
                //dgvStok.Sort(dgvStok.Columns[0], ListSortDirection.Descending);
                //dgvStokRealita.Sort(dgvStokRealita.Columns[1], ListSortDirection.Ascending);
            }
            else
            {
                LastFilterIdx = cbFilter.SelectedIndex;
                //LoopLoadSesuaiTanggal(dtmTanggalAwal.Value, dtmTanggalAkhir.Value);
                //dgvStok.Sort(dgvStok.Columns[0], ListSortDirection.Descending);
                //dgvStokRealita.Sort(dgvStokRealita.Columns[1], ListSortDirection.Ascending);
            }
            
            ChangeFilterDGVAndDTMDisplay();
            gbStok.Refresh();
            gbDetail.Refresh();
            if (cbIdCabang.SelectedIndex == 0)
            {
                dgvStok.Size = new Size(821, 367);
                dgvStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvStokRealita.Visible = false;
                lblDateNow.Visible = false;
            }
            else
            {
                dgvStok.Size = new Size(547, 367);
                dgvStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvStokRealita.Visible = true;
                lblDateNow.Visible = true;
            }
            masukcombox();
            cbBerdasarkan.SelectedIndex = 0;
            tbSearchKeyword.Text = "";
        }

        private void masukcombox()
        {
            cbBerdasarkan.Items.Clear();
            if (cbIdCabang.SelectedIndex == 0)
            {
                cbBerdasarkan.Items.Add("Barcode");
                cbBerdasarkan.Items.Add("Name");
                cbBerdasarkan.Items.Add("Purchase Price");
                cbBerdasarkan.Items.Add("Retail Price");
                cbBerdasarkan.Items.Add("Warehouse Stock");
            }
            else
            {
                cbBerdasarkan.Items.Add("Barcode");
                cbBerdasarkan.Items.Add("Name");
                cbBerdasarkan.Items.Add("Purchase Price");
                cbBerdasarkan.Items.Add("Retail Price");
                cbBerdasarkan.Items.Add("Warehouse Stock");
                cbBerdasarkan.Items.Add("Sold");
                cbBerdasarkan.Items.Add("Lost");
                cbBerdasarkan.Items.Add("Damage");
                cbBerdasarkan.Items.Add("Expired");
                cbBerdasarkan.Items.Add("Quantity/Box");
                cbBerdasarkan.Items.Add("Available Stock");
            }


        }

        private string lblDateAwalToAkhir(DateTimePicker awal, DateTimePicker akhir)
        {
            if (awal.Value.Date == akhir.Value.Date)
            {
                return awal.Value.ToLongDateString();
            }
            else
            {
                return awal.Value.ToLongDateString() + " - " + akhir.Value.ToLongDateString();
            }
            
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
                    MessageBox.Show("ERROR : earliest viewing date can't surpass latest viewing date", "VIEW STOCKS BETWEEN DATES FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                errorShown = false;
                lblDateShow.Text = lblDateAwalToAkhir(dtmTanggalAwal, dtmTanggalAkhir);
                LoopLoadSesuaiTanggal(dtmTanggalAwal.Value, dtmTanggalAkhir.Value);
                dgvStok.Sort(dgvStok.Columns[0], ListSortDirection.Descending);
                dgvStokRealita.Sort(dgvStokRealita.Columns[1], ListSortDirection.Ascending);
                gbStok.Refresh();
                gbDetail.Refresh();
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cbBerdasarkan.SelectedIndex != -1)
            {
                do_search(cbBerdasarkan.SelectedIndex);
            }
        }

        private void RemoveRowsFromDGV(ref DataGridView dgv, string keyword, int idxCell)
        {
            for (int i = dgv.Rows.Count - 1; i >= 0; i--)
            {
                if (!dgv.Rows[i].Cells[idxCell].Value.ToString().ToLower().Contains(tbSearchKeyword.Text.ToLower()))
                {
                    dgv.Rows.RemoveAt(i);
                }
            }
        }

        private void do_search(int idx)
        {
            dgvStok.Rows.Clear();
            dgvStokRealita.Rows.Clear();
            LoopLoadSesuaiTanggal(dtmTanggalAwal.Value.Date, dtmTanggalAkhir.Value.Date);
            dgvStok.Sort(dgvStok.Columns[0], ListSortDirection.Descending);
            dgvStokRealita.Sort(dgvStokRealita.Columns[1], ListSortDirection.Ascending);
            if (idx==0||idx==1)
            {
                RemoveRowsFromDGV(ref dgvStok, tbSearchKeyword.Text, idx+1);
                RemoveRowsFromDGV(ref dgvStokRealita, tbSearchKeyword.Text, idx);
            }
            else if (idx>=2 && idx<=8)
            {
                RemoveRowsFromDGV(ref dgvStok, tbSearchKeyword.Text, idx + 1);
            }
            else if (idx==9)
            {
                RemoveRowsFromDGV(ref dgvStokRealita, tbSearchKeyword.Text, 2);
            }
            else if (idx==10)
            {
                RemoveRowsFromDGV(ref dgvStokRealita, tbSearchKeyword.Text, 3);
            }
           
        }

        private void tbSearchKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnShow_Click(sender, e);
            }
        }

        private void cbBerdasarkan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnShow_Click(sender, e);
            }
        }

        string[] Stok;
        int[] yStok;

        private void LoadGrafik(string Filter)
        {
            SqlDataReader reader;
            string id_cabang = GetIdCabang(cbIdCabang.SelectedItem.ToString());
            yStok = new int[3];
            Stok = new string[3];

            if (Filter == "Highest Available Stock")
            {
                if (id_cabang != "ALL")
                {
                    conn.Close();
                    conn.Open();
                    query = new SqlCommand("SELECT TOP 3 B.Nama_Barang, S.Jumlah FROM Stok S, Barang B WHERE S.Kode_Barang = B.Kode_Barang AND S.Id_Cabang = @Id AND S.Status_Stok = @status ORDER BY 2 DESC", conn);
                    query.Parameters.AddWithValue("@akhir", dtmTanggalAkhir.Value);
                    query.Parameters.AddWithValue("@Id", id_cabang);
                    query.Parameters.AddWithValue("@status", 1);
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    query = new SqlCommand("SELECT TOP 3 B.Nama_Barang, S.Jumlah FROM Stok S, Barang B WHERE S.Kode_Barang = B.Kode_Barang AND S.Id_Cabang = @Id AND S.Status_Stok = @status ORDER BY 2 DESC", conn);
                    query.Parameters.AddWithValue("@akhir", dtmTanggalAkhir.Value);
                    query.Parameters.AddWithValue("@Id", id_cabang);
                    query.Parameters.AddWithValue("@status", 0);
                }
            }
            else if (Filter == "Lowest Available Stock")
            {
                if (id_cabang != "ALL")
                {
                    conn.Close();
                    conn.Open();
                    query = new SqlCommand("SELECT TOP 3 B.Nama_Barang, S.Jumlah FROM Stok S, Barang B WHERE S.Kode_Barang = B.Kode_Barang AND S.Id_Cabang = @Id AND S.Status_Stok = @status ORDER BY 2 ASC", conn);
                    query.Parameters.AddWithValue("@akhir", dtmTanggalAkhir.Value);
                    query.Parameters.AddWithValue("@Id", id_cabang);
                    query.Parameters.AddWithValue("@status", 1);
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    query = new SqlCommand("SELECT TOP 3 B.Nama_Barang, S.Jumlah FROM Stok S, Barang B WHERE S.Kode_Barang = B.Kode_Barang AND S.Id_Cabang = @Id AND S.Status_Stok = @status ORDER BY 2 ASC", conn);
                    query.Parameters.AddWithValue("@akhir", dtmTanggalAkhir.Value);
                    query.Parameters.AddWithValue("@Id", id_cabang);
                    query.Parameters.AddWithValue("@status", 0);
                }
            }

            reader = query.ExecuteReader();
            int ctr = 0;
            while (reader.Read())
            {
                Stok[ctr] = reader.GetString(0);
                yStok[ctr] = reader.GetInt32(1);
                ctr++;
            }

            if (Filter == "Highest Available Stock")
            {
                SwapI(ref yStok[0], ref yStok[1]);
                SwapS(ref Stok[0], ref Stok[1]);
            }
            else if (Filter == "Lowest Available Stock" && ctr == 3)
            {
                SwapI(ref yStok[1], ref yStok[2]);
                SwapS(ref Stok[1], ref Stok[2]);
                SwapI(ref yStok[0], ref yStok[2]);
                SwapS(ref Stok[0], ref Stok[2]);
            }
            else if (Filter == "Lowest Available Stock" && ctr == 1)
            {
                SwapI(ref yStok[0], ref yStok[1]);
                SwapS(ref Stok[0], ref Stok[1]);
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

        Brush[] brush = new Brush[3] { Brushes.Orange, Brushes.Green, Brushes.Blue };

        private void dgvStok_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CekStokSesuai();
        }

        private void cbStok_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbStok.Text = cbStok.SelectedItem.ToString();
            gbStok.Refresh();
            gbDetail.Refresh();
        }

        private void gbStok_Paint(object sender, PaintEventArgs e)
        {
            if (cbStok.SelectedIndex != -1)
            {
                LoadGrafik(cbStok.SelectedItem.ToString());
            }
            Graphics g = e.Graphics;
            Font f = new Font("Verdana", 11);
            Font f2 = new Font("Verdana", 8);

            for (int i = 0; i < 3; i++)
            {
                if (yStok != null)
                {
                    g.FillRectangle(brush[i], i * 80 + 35, 270 - (int)(150 * ((double)yStok[i] / (double)yStok[1])), 50, (int)(150 * ((double)yStok[i] / (double)yStok[1])));
                }
                if (yStok != null)
                {
                    g.DrawString(yStok[i].ToString(), f, Brushes.Black, i * 80 + 45, 273);
                }
            }
        }

        private void gbDetail_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font f = new Font("Verdana", 8);
            for (int i = 0; i < 3; i++)
            {
                if (Stok != null)
                {
                    g.FillRectangle(brush[i], 25, i * 50 + 50, 20, 20);
                    g.DrawString(Stok[i], f, Brushes.Black, 50, i * 50 + 55);
                }
            }
        }

        private void Owner_Lihat_Stock_VisibleChanged(object sender, EventArgs e)
        {
            //Owner_Lihat_Stock_Shown(this, e);
        }

        private void cbBerdasarkan_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnShow_Click(sender, e);
        }
    }
}