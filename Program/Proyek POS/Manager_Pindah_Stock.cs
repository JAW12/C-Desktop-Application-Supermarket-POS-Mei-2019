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
    public partial class Manager_Pindah_Stock : Form
    {
        public Manager_Pindah_Stock()
        {
            InitializeComponent();
        }

        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Proyek_POS.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        string Id_Cabang_Manager;

        public void dtmCustomFormat(ref DateTimePicker dtm, string format)
        {
            dtm.Format = DateTimePickerFormat.Custom;
            dtm.CustomFormat = format;
        }

        private void LoadCabang()
        {
            conn.Open();
            cmd = new SqlCommand("SELECT Id_Cabang FROM [User] WHERE Id_User = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", Login.ds.Tables["Manager"].Rows[0][0].ToString());
            Id_Cabang_Manager = (string)cmd.ExecuteScalar();
            conn.Close();
        }

        private void NamaBarang()
        {
            conn.Close();
            conn.Open();
            cmd = new SqlCommand("SELECT ISNULL(Nama_Barang, 'N/A') FROM Barang WHERE Kode_Barang = @Kode", conn);
            cmd.Parameters.AddWithValue("@Kode", tbKodeBarang.Text);
            if (cmd.ExecuteScalar() == null)
            {
                lblNamaBarang.Text = "N/A";
                nudJumlahPindah.Value = 1;
                btnPindah.Enabled = false;
            }
            else
            {
                string hsl = cmd.ExecuteScalar().ToString();
                lblNamaBarang.Text = hsl;

                lblNamaBarang.Font = new Font(lblNamaBarang.Font.FontFamily, 12, lblNamaBarang.Font.Style);
                if (lblNamaBarang.Location.X + lblNamaBarang.Size.Width > gbDetail.Size.Width)
                {
                    while (lblNamaBarang.Location.X + lblNamaBarang.Size.Width > gbDetail.Size.Width)
                    {
                        lblNamaBarang.Font = new Font(lblNamaBarang.Font.FontFamily, lblNamaBarang.Font.Size - 1, lblNamaBarang.Font.Style);
                    }
                }
                btnPindah.Enabled = true;
            }
            conn.Close();
        }

        private void tbKodeBarang_TextChanged(object sender, EventArgs e)
        {
            NamaBarang();
        }

        private void RefreshStokPusatDanCabang()
        {
            if (cbPemindahan.SelectedIndex == 0)
            {
                SelectStok("ALL", 0);
                LoadDatasetStokGudangToDGV("ALL", ref dgvStokPengirim, 0);
                SelectStok(Id_Cabang_Manager, 0);
                LoadDatasetStokGudangToDGV(Id_Cabang_Manager, ref dgvStokPenerima, 0);
            }
            else if(cbPemindahan.SelectedIndex == 1)
            {
                SelectStok(Id_Cabang_Manager, 0);
                LoadDatasetStokGudangToDGV(Id_Cabang_Manager, ref dgvStokPengirim, 0);
                SelectStok(Id_Cabang_Manager, 1);
                LoadDatasetStokGudangToDGV(Id_Cabang_Manager, ref dgvStokPenerima, 1);
            }          
        }

        private void Manager_Pindah_Stock_Shown(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            lblTanggal.Text = DateTime.Now.Date.ToLongDateString();
            LoadCabang();
            RefreshStokPusatDanCabang();
            cbPemindahan.SelectedIndex = 0;
        }

        private void SelectStok(string id_cabang, int statusStok)
        {
            String queryStr = "SELECT SG.Kode_Barang, SG.Jumlah, B.QtyBox, B.Nama_Barang FROM [Stok] SG, [Barang] B WHERE SG.Kode_Barang = B.Kode_Barang AND SG.Id_Cabang = @id_cabang AND Status_Stok = @status AND B.Qtybox > 1";
            conn.Close();
            conn.Open();
            cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@id_cabang", id_cabang);
            cmd.Parameters.AddWithValue("@status", statusStok);
            da = new SqlDataAdapter(cmd);
            if (id_cabang == "ALL")
            {
                if (Login.ds.Tables.Contains("Stok_Gudang_Pusat"))
                {
                    Login.ds.Tables["Stok_Gudang_Pusat"].Rows.Clear();
                }
                da.Fill(Login.ds, "Stok_Gudang_Pusat");
            }
            else
            {
                if (statusStok == 0)
                {
                    if (Login.ds.Tables.Contains("Stok_Gudang_Cabang"))
                    {
                        Login.ds.Tables["Stok_Gudang_Cabang"].Rows.Clear();
                    }
                    da.Fill(Login.ds, "Stok_Gudang_Cabang");
                }
                else if (statusStok == 1)
                {
                    if (Login.ds.Tables.Contains("Stok_Display_Cabang"))
                    {
                        Login.ds.Tables["Stok_Display_Cabang"].Rows.Clear();
                    }
                    conn.Close();
                    queryStr = "SELECT Kode_Barang, 0, Qtybox, Nama_Barang FROM Barang WHERE Qtybox > 1";
                    conn.Open();
                    cmd = new SqlCommand(queryStr, conn);
                    da = new SqlDataAdapter(cmd);
                    da.Fill(Login.ds, "Stok_Display_Cabang");
                    conn.Close();
                }
            }
            conn.Close();
        }

        private void RecursiveLoadDataset(string table, int i, ref DataGridView dgv)
        {
            if (i < Login.ds.Tables[table].Rows.Count)
            {
                string kode = Login.ds.Tables[table].Rows[i][0].ToString();
                string nama = Login.ds.Tables[table].Rows[i][3].ToString();
                string qtybox = Login.ds.Tables[table].Rows[i][2].ToString();
                string jumlah = Login.ds.Tables[table].Rows[i][1].ToString();
                string[] row = new string[] { kode, nama, jumlah, qtybox };
                dgv.Rows.Add(row);
                RecursiveLoadDataset(table, i + 1, ref dgv);
            }
        }

        private void LoadDatasetStokGudangToDGV(string id_cabang, ref DataGridView sender, int statusStok)
        {
            DataGridView dgv = (DataGridView)sender;
            dgv.Rows.Clear();
            string table = "";
            if (id_cabang == "ALL")
            {
                table = "Stok_Gudang_Pusat";
            }
            else
            {
                if (statusStok == 0)
                {
                    table = "Stok_Gudang_Cabang";
                }
                else
                {
                    table = "Stok_Display_Cabang";
                }
            }

            if (table != "" && Login.ds.Tables[table] != null)
            {
                RecursiveLoadDataset(table, 0, ref dgv);
                DataColumn[] col = new DataColumn[] { Login.ds.Tables[table].Columns["Kode_Barang"] };
                Login.ds.Tables[table].PrimaryKey = col;
            }
            LoadDone = true;
        }

        bool LoadDone;

        private void PindahStokKiri(string dataset)
        {
            if (LoadDone)
            {
                string kode = tbKodeBarang.Text;
                DataRow row = Login.ds.Tables[dataset].Rows.Find(kode);
                int idx = Login.ds.Tables[dataset].Rows.IndexOf(row);
                if (idx != -1)
                {
                    Login.ds.Tables[dataset].Rows[idx][1] = Convert.ToInt32(dgvStokPengirim.Rows[idx].Cells[2].Value.ToString()) - Convert.ToInt32(nudJumlahPindah.Value);
                }
            }
        }

        private void PindahStokKanan(string dataset)
        {
            if (LoadDone)
            {
                string kode = tbKodeBarang.Text;
                DataRow row = Login.ds.Tables[dataset].Rows.Find(kode);
                int idx = Login.ds.Tables[dataset].Rows.IndexOf(row);
                if (idx != -1)
                {
                    Login.ds.Tables[dataset].Rows[idx][1] = Convert.ToInt32(dgvStokPenerima.Rows[idx].Cells[2].Value) + Convert.ToInt32(nudJumlahPindah.Value);
                }
            }
        }

        int JumlahPembelian = 0;

        private void btnPindah_Click(object sender, EventArgs e)
        {
            if (cbPemindahan.SelectedIndex == 0)
            {
                PindahStokKiri("Stok_Gudang_Pusat");
                PindahStokKanan("Stok_Gudang_Cabang");
            }
            else if (cbPemindahan.SelectedIndex == 1)
            {
                PindahStokKiri("Stok_Gudang_Cabang");
                PindahStokKanan("Stok_Display_Cabang");
            }
            JumlahPembelian += Convert.ToInt32(nudJumlahPindah.Value);
            lblJumlahPembelian.Text = JumlahPembelian.ToString();
            //setelah pindah refresh stok
            RefreshDGV();
            ResetPindah();
        }

        private void btnKanan_Click(object sender, EventArgs e)
        {
            PindahStokKeKananAll();
            //setelah pindah refresh stok
            RefreshDGV();
            ResetPindah();
        }

        private void RecursiveRefreshDGV(string table, int i, ref DataGridView dgv)
        {
            if (i < Login.ds.Tables[table].Rows.Count)
            {
                string[] row = new string[] { Login.ds.Tables[table].Rows[i][0].ToString(), Login.ds.Tables[table].Rows[i][3].ToString(), Login.ds.Tables[table].Rows[i][1].ToString(), Login.ds.Tables[table].Rows[i][2].ToString() };

                if (Login.ds.Tables[table].Rows[i][2].ToString() != "0")
                {
                    dgv.Rows.Add(row);
                }
                
                RecursiveRefreshDGV(table, i + 1, ref dgv);
            }
        }

        private void RefreshDGV()
        {
            dgvStokPengirim.Rows.Clear();
            dgvStokPenerima.Rows.Clear();
            if (cbPemindahan.SelectedIndex == 0)
            {
                RecursiveRefreshDGV("Stok_Gudang_Pusat", 0, ref dgvStokPengirim);
                RecursiveRefreshDGV("Stok_Gudang_Cabang", 0, ref dgvStokPenerima);
            }
            else if (cbPemindahan.SelectedIndex == 1)
            {
                RecursiveRefreshDGV("Stok_Gudang_Cabang", 0, ref dgvStokPengirim);
                RecursiveRefreshDGV("Stok_Display_Cabang", 0, ref dgvStokPenerima);
            }
        }

        private void btnKiri_Click(object sender, EventArgs e)
        {
            PindahStokKeKiriAll();
            //setelah pindah refresh stok
            RefreshDGV();
            ResetPindah();
        }

        private void PindahStokKeKananAll()
        {
            if (LoadDone)
            {
                if (cbPemindahan.SelectedIndex == 0)
                {
                    string kode = tbKodeBarang.Text;
                    DataRow row = Login.ds.Tables["Stok_Gudang_Pusat"].Rows.Find(kode);
                    int idx = Login.ds.Tables["Stok_Gudang_Pusat"].Rows.IndexOf(row);
                    if (idx != -1)
                    {
                        Login.ds.Tables["Stok_Gudang_Cabang"].Rows[idx][1] = Convert.ToInt32(Login.ds.Tables["Stok_Gudang_Cabang"].Rows[idx][1]) + Convert.ToInt32(Login.ds.Tables["Stok_Gudang_Pusat"].Rows[idx][1]);
                        JumlahPembelian += Convert.ToInt32(Login.ds.Tables["Stok_Gudang_Pusat"].Rows[idx][1]);
                        Login.ds.Tables["Stok_Gudang_Pusat"].Rows[idx][1] = 0;
                        lblJumlahPembelian.Text = JumlahPembelian.ToString();
                    }
                }
                else if (cbPemindahan.SelectedIndex == 1)
                {
                    string kode = tbKodeBarang.Text;
                    DataRow row = Login.ds.Tables["Stok_Gudang_Cabang"].Rows.Find(kode);
                    int idx = Login.ds.Tables["Stok_Gudang_Cabang"].Rows.IndexOf(row);
                    if (idx != -1)
                    {
                        Login.ds.Tables["Stok_Display_Cabang"].Rows[idx][1] = Convert.ToInt32(Login.ds.Tables["Stok_Display_Cabang"].Rows[idx][1]) + Convert.ToInt32(Login.ds.Tables["Stok_Gudang_Cabang"].Rows[idx][1]);
                        JumlahPembelian += Convert.ToInt32(Login.ds.Tables["Stok_Gudang_Cabang"].Rows[idx][1]);
                        Login.ds.Tables["Stok_Gudang_Cabang"].Rows[idx][1] = 0;
                        lblJumlahPembelian.Text = JumlahPembelian.ToString();
                    }
                }
            }
        }

        private void PindahStokKeKiriAll()
        {
            if (LoadDone)
            {
                if (cbPemindahan.SelectedIndex == 0)
                {
                    string kode = tbKodeBarang.Text;
                    DataRow row = Login.ds.Tables["Stok_Gudang_Cabang"].Rows.Find(kode);
                    int idx = Login.ds.Tables["Stok_Gudang_Cabang"].Rows.IndexOf(row);
                    if (idx != -1)
                    {
                        Login.ds.Tables["Stok_Gudang_Pusat"].Rows[idx][1] = Convert.ToInt32(Login.ds.Tables["Stok_Gudang_Pusat"].Rows[idx][1]) + Convert.ToInt32(Login.ds.Tables["Stok_Gudang_Cabang"].Rows[idx][1]);
                        JumlahPembelian -= Convert.ToInt32(Login.ds.Tables["Stok_Gudang_Cabang"].Rows[idx][1]);
                        Login.ds.Tables["Stok_Gudang_Cabang"].Rows[idx][1] = 0;
                        lblJumlahPembelian.Text = JumlahPembelian.ToString();
                    }
                }
                else if (cbPemindahan.SelectedIndex == 1)
                {
                    string kode = tbKodeBarang.Text;
                    DataRow row = Login.ds.Tables["Stok_Display_Cabang"].Rows.Find(kode);
                    int idx = Login.ds.Tables["Stok_Display_Cabang"].Rows.IndexOf(row);
                    if (idx != -1)
                    {
                        Login.ds.Tables["Stok_Gudang_Cabang"].Rows[idx][1] = Convert.ToInt32(Login.ds.Tables["Stok_Gudang_Cabang"].Rows[idx][1]) + Convert.ToInt32(Login.ds.Tables["Stok_Display_Cabang"].Rows[idx][1]);
                        JumlahPembelian -= Convert.ToInt32(Login.ds.Tables["Stok_Display_Cabang"].Rows[idx][1]);
                        Login.ds.Tables["Stok_Display_Cabang"].Rows[idx][1] = 0;
                        lblJumlahPembelian.Text = JumlahPembelian.ToString();
                    }
                }
            }
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            UpdateDatabase();
            lblJumlahPembelian.Text = "0";
            KirimRiwayat();
            RefreshStokPusatDanCabang();
            MessageBox.Show("Succeed in Transferring Stocks", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void KirimRiwayat()
        {
            if (cbPemindahan.SelectedIndex == 0)
            {
                for (int i = 0; i < Login.ds.Tables["Stok_Gudang_Cabang"].Rows.Count; i++)
                {
                    string keterangan = "Melakukan Pemindahan Barang " + Login.ds.Tables["Stok_Gudang_Pusat"].Rows[i][3].ToString() + " dari Stok Gudang Pusat ke Stok Gudang Cabang, Sehingga Stok Gudang Cabang Menjadi " + Login.ds.Tables["Stok_Gudang_Cabang"].Rows[i][1];
                    conn.Open();
                    cmd = new SqlCommand("INSERT INTO [Riwayat](Id_User, Id_Cabang, Keterangan, Waktu) VALUES(@Id, @Cabang, @Keterangan, @Waktu)", conn);
                    cmd.Parameters.AddWithValue("@Id", Login.ds.Tables["Manager"].Rows[0][0].ToString());
                    cmd.Parameters.AddWithValue("@Cabang", Id_Cabang_Manager);
                    cmd.Parameters.AddWithValue("@Keterangan", keterangan);
                    cmd.Parameters.AddWithValue("@Waktu", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            else if(cbPemindahan.SelectedIndex == 1)
            {
                for (int i = 0; i < Login.ds.Tables["Stok_Display_Cabang"].Rows.Count; i++)
                {
                    string keterangan = "Melakukan Pembukaan Dus " + Login.ds.Tables["Stok_Display_Cabang"].Rows[i][3].ToString() + " dari Stok Gudang Cabang ke Display sebanyak " + Login.ds.Tables["Stok_Display_Cabang"].Rows[i][1] + " dus, sehingga Display bertambah sebanyak " + Convert.ToInt32(Login.ds.Tables["Stok_Display_Cabang"].Rows[i][1]) * Convert.ToInt32(Login.ds.Tables["Stok_Display_Cabang"].Rows[i][2]) + " biji.";
                    conn.Open();
                    cmd = new SqlCommand("INSERT INTO [Riwayat](Id_User, Id_Cabang, Keterangan, Waktu) VALUES(@Id, @Cabang, @Keterangan, @Waktu)", conn);
                    cmd.Parameters.AddWithValue("@Id", Login.ds.Tables["Manager"].Rows[0][0].ToString());
                    cmd.Parameters.AddWithValue("@Cabang", Id_Cabang_Manager);
                    cmd.Parameters.AddWithValue("@Keterangan", keterangan);
                    cmd.Parameters.AddWithValue("@Waktu", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        private void UpdateDatabase()
        {
            conn.Close();
            if (cbPemindahan.SelectedIndex == 0)
            {
                conn.Open();
                for (int i = 0; i < Login.ds.Tables["Stok_Gudang_Pusat"].Rows.Count; i++)
                {
                    cmd = new SqlCommand("Update [Stok] set Jumlah=@SumGudang WHERE Id_Cabang='ALL' and Kode_Barang=@Kode and Status_Stok = @gudang", conn);
                    cmd.Parameters.AddWithValue("@SumGudang", Login.ds.Tables["Stok_Gudang_Pusat"].Rows[i][1]);
                    cmd.Parameters.AddWithValue("@Kode", Login.ds.Tables["Stok_Gudang_Pusat"].Rows[i][0]);
                    cmd.Parameters.AddWithValue("@gudang", 0);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                conn.Open();
                for (int i = 0; i < Login.ds.Tables["Stok_Gudang_Cabang"].Rows.Count; i++)
                {
                    cmd = new SqlCommand("Update [Stok] set Jumlah=@SumGudang WHERE Id_Cabang=@Id and Kode_Barang=@Kode and Status_Stok = @gudang", conn);
                    cmd.Parameters.AddWithValue("@SumGudang", Login.ds.Tables["Stok_Gudang_Cabang"].Rows[i][1]);
                    cmd.Parameters.AddWithValue("@Id", Manager_Lihat_Edit_Stock.Id_Cabang_Manager);
                    cmd.Parameters.AddWithValue("@Kode", Login.ds.Tables["Stok_Gudang_Cabang"].Rows[i][0]);
                    cmd.Parameters.AddWithValue("@gudang", 0);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            else if (cbPemindahan.SelectedIndex == 1)
            {
                conn.Open();
                for (int i = 0; i < Login.ds.Tables["Stok_Gudang_Cabang"].Rows.Count; i++)
                {
                    cmd = new SqlCommand("Update [Stok] set Jumlah=@SumGudang WHERE Id_Cabang=@Id and Kode_Barang=@Kode and Status_Stok = @gudang", conn);
                    cmd.Parameters.AddWithValue("@SumGudang", Login.ds.Tables["Stok_Gudang_Cabang"].Rows[i][1]);
                    cmd.Parameters.AddWithValue("@Id", Manager_Lihat_Edit_Stock.Id_Cabang_Manager);
                    cmd.Parameters.AddWithValue("@Kode", Login.ds.Tables["Stok_Gudang_Cabang"].Rows[i][0]);
                    cmd.Parameters.AddWithValue("@gudang", 0);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                for (int i = 0; i < Login.ds.Tables["Stok_Gudang_Cabang"].Rows.Count; i++)
                {
                    string kodesistem = LoadKodeSistem(Login.ds.Tables["Stok_Display_Cabang"].Rows[i][0].ToString());
                    cmd = new SqlCommand("Update [Stok] set Jumlah = Jumlah + @SumGudang WHERE Id_Cabang=@Id and Kode_Sistem=@Kode and Status_Stok = @gudang", conn);
                    cmd.Parameters.AddWithValue("@SumGudang", Convert.ToInt32(Login.ds.Tables["Stok_Display_Cabang"].Rows[i][1]) * Convert.ToInt32(Login.ds.Tables["Stok_Display_Cabang"].Rows[i][2]));
                    cmd.Parameters.AddWithValue("@Id", Manager_Lihat_Edit_Stock.Id_Cabang_Manager);
                    cmd.Parameters.AddWithValue("@Kode", kodesistem);
                    cmd.Parameters.AddWithValue("@gudang", 1);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        private string LoadKodeSistem(string kodebrg)
        {
            string hasil;
            conn.Close();
            conn.Open();
            cmd = new SqlCommand("SELECT ISNULL(Kode_Sistem, '') FROM Barang WHERE Kode_Barang = @Kode", conn);
            cmd.Parameters.AddWithValue("@Kode", kodebrg);
            try
            {
                hasil = cmd.ExecuteScalar().ToString();
            }
            catch
            {
                hasil = "";
            }
            conn.Close();
            conn.Open();
            return hasil;
        }

        private void tbKodeBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPindah_Click(sender, e);
            }
        }

        private void dgvStokPusat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            if (row > -1 && row <= dgvStokPengirim.RowCount && col > -1 && col <= dgvStokPengirim.ColumnCount)
            {
                tbKodeBarang.Text = dgvStokPengirim.Rows[row].Cells[0].Value.ToString();
                if(int.Parse(dgvStokPengirim.Rows[row].Cells[2].Value.ToString()) >= 0)
                {
                    nudJumlahPindah.Value = int.Parse(dgvStokPengirim.Rows[row].Cells[2].Value.ToString());
                }
            }
        }

        private void dgvStokCabang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            if (row > -1 && row <= dgvStokPenerima.RowCount && col > -1 && col <= dgvStokPengirim.ColumnCount)
            {
                tbKodeBarang.Text = dgvStokPenerima.Rows[row].Cells[0].Value.ToString();
                if(int.Parse(dgvStokPenerima.Rows[row].Cells[2].Value.ToString()) >= 0)
                {
                    nudJumlahPindah.Value = int.Parse(dgvStokPenerima.Rows[row].Cells[2].Value.ToString());
                }
            }
        }

        private void ResetPindah()
        {
            tbKodeBarang.Clear();
            nudJumlahPindah.Value = 1;
        }

        private void cbPemindahan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPemindahan.SelectedIndex == 0)
            {
                lblSNama.Text = "Central Warehouse";
                lblSNama2.Text = "Branch Warehouse";
                RefreshStokPusatDanCabang();
            }
            else if (cbPemindahan.SelectedIndex == 1)
            {
                lblSNama.Text = "Branch Warehouse";
                lblSNama2.Text = "Branch Display";
                RefreshStokPusatDanCabang();
            }
        }

        private void Manager_Pindah_Stock_VisibleChanged(object sender, EventArgs e)
        {
            Manager_Pindah_Stock_Shown(this, e);
        }
    }
}
