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
    public partial class Kasir : Form
    {
        public Kasir()
        {
            InitializeComponent();
        }

        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Proyek_POS.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        public static DataSet ds;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void LogOut()
        {
            if (MessageBox.Show("Are you sure?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                Splashscreen.login.Show();
                tmrJam.Stop();
                tmrPenjualan.Stop();
                Kasir_Browse.KodeBarang = "";
                this.Hide();
            }
        }

        private void Kasir_Load(object sender, EventArgs e)
        {
            LoadAwal();
            gbInputPenjualan.Focus();
            tbKodeBarang.Focus();
            NoNota();
            tmrBayar.Start();
        }

        private void LoadAwal()
        {
            if (ds != null)
            {
                ds = null;
                ds = new DataSet();
            }
            else
            {
                ds = new DataSet();
            }
            HariIni();
            tmrJam.Start();
            tmrPenjualan.Start();
            conn = new SqlConnection(connString);
            NoNota();
            lblNamaKasir.Text = NamaKasir();
            lblTanggal.Text = HariIni().ToString("dd MMMM yyyy HH:mm:ss");
            LoadCabang();
            LoadNamaCabang();
            ds.Tables.Add("Penjualan");
            ds.Tables["Penjualan"].Columns.Add("Kode_Barang");
            ds.Tables["Penjualan"].Columns.Add("Nama_Barang");
            ds.Tables["Penjualan"].Columns.Add("Harga");
            ds.Tables["Penjualan"].Columns.Add("Jumlah");
            ds.Tables["Penjualan"].Columns.Add("Subtotal");
            DataColumn[] col = new DataColumn[] { ds.Tables["Penjualan"].Columns["Kode_Barang"] };
            ds.Tables["Penjualan"].PrimaryKey = col;
        }

        public static string ID_Cabang_Kasir = "";
        private void LoadCabang()
        {
            conn.Open();
            cmd = new SqlCommand("SELECT Id_Cabang FROM [User] WHERE Id_User = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", Login.ds.Tables["Kasir"].Rows[0][0].ToString());
            ID_Cabang_Kasir = cmd.ExecuteScalar().ToString();
            conn.Close();
        }

        private void LoadNamaCabang()
        {
            conn.Open();
            cmd = new SqlCommand("SELECT C.Nama_Cabang FROM [Cabang] C, [User] U WHERE U.Id_User = @Id AND U.Id_Cabang = C.Id_Cabang", conn);
            cmd.Parameters.AddWithValue("@Id", Login.ds.Tables["Kasir"].Rows[0][0].ToString());
            lblNamaCabang.Text = (string)cmd.ExecuteScalar();
            conn.Close();
        }

        public static string NamaKasir()
        {
            return Login.ds.Tables["Kasir"].Rows[0][2].ToString();
        }

        public static string SNota = "";
        private void NoNota()
        {
            DateTime now = DateTime.Now;
            lblNoNota.Text = now.ToString("yyyyMMdd");
            conn.Close();
            conn.Open();
            cmd = new SqlCommand("SELECT COUNT(No_Nota_Transaksi) FROM Transaksi WHERE CAST(Waktu_Trans AS DATE) = CAST(GetDate() AS DATE)", conn);
            int count = (int)cmd.ExecuteScalar() + 1;
            lblNoNota.Text = lblNoNota.Text + count.ToString().PadLeft(5, '0');
            SNota = lblNoNota.Text;
            conn.Close();
        }

        public static DateTime HariIni()
        {
            DateTime now = DateTime.Now;
            return now;
        }


        private void tmrJam_Tick(object sender, EventArgs e)
        {
            lblTanggal.Text = HariIni().ToString("dd MMMM yyyy HH:mm:ss");
        }

        private void tbKodeBarang_TextChanged(object sender, EventArgs e)
        {
            NamaBarang();
        }

        private void AutoresizeLabelFont(ref Label sender)
        {
            Label lb = (Label)sender;
            lb.Font = new Font(lb.Font.FontFamily, 12, lb.Font.Style);
            if (TextRenderer.MeasureText(lb.Text, new Font(lb.Font.FontFamily, lb.Font.Size, lb.Font.Style)).Width > lb.Width)
            {
                while (TextRenderer.MeasureText(lb.Text, new Font(lb.Font.FontFamily, lb.Font.Size, lb.Font.Style)).Width > lb.Width)
                {
                    lb.Font = new Font(lb.Font.FontFamily, lb.Font.Size - 1, lb.Font.Style);
                }
            }
        }

        private void NamaBarang()
        {
            conn.Open();
            cmd = new SqlCommand("SELECT ISNULL(Nama_Barang, 'N/A') FROM Barang WHERE Kode_Barang = @Kode", conn);
            cmd.Parameters.AddWithValue("@Kode", tbKodeBarang.Text);
            if (cmd.ExecuteScalar() == null)
            {
                lblNamaBarang.Text = "N/A";
                nudInputJumlah.Value = 1;
                btnInput.Enabled = false;
            }
            else
            {
                string hsl = cmd.ExecuteScalar().ToString();
                lblNamaBarang.Text = hsl;

                AutoresizeLabelFont(ref lblNamaBarang);
                btnInput.Enabled = true;
            }
            conn.Close();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            InputPembelian();
            gbInputPenjualan.Focus();
            tbKodeBarang.Focus();
        }

        private void InputPembelian()
        {
            if (nudInputJumlah.Value > 0)
            {
                int qty = LoadQtyBox(tbKodeBarang.Text);
                if(qty == 1)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT B.Kode_Barang, B.Nama_Barang, PH.Harga_Jual, " +
                        "@Jumlah, @Jumlah * PH.Harga_Jual AS 'Subtotal' " +
                        "FROM Barang B, PH_Jual PH, Stok SR " +
                        "WHERE B.Kode_Barang = @Kode AND " +
                        "B.Kode_Barang = PH.Kode_Barang AND " +
                        "B.Kode_Barang = SR.Kode_Barang AND " +
                        "SR.Status_Stok = @status AND " +
                        "PH.Tanggal_Jual IN " +
                        "(SELECT MAX(PH.Tanggal_Jual) FROM PH_Jual PH WHERE PH.Kode_Barang = @Kode) AND " +
                        "SR.Id_Cabang = @Id", conn);
                    cmd.Parameters.AddWithValue("@Kode", tbKodeBarang.Text);
                    cmd.Parameters.AddWithValue("@Jumlah", (int)nudInputJumlah.Value);
                    cmd.Parameters.AddWithValue("@Id", ID_Cabang_Kasir);
                    cmd.Parameters.AddWithValue("@status", 1);
                    reader = cmd.ExecuteReader();
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT B.Kode_Barang, B.Nama_Barang, PH.Harga_Jual, " +
                        "@Jumlah, @Jumlah * PH.Harga_Jual AS 'Subtotal' " +
                        "FROM Barang B, PH_Jual PH, Stok SR " +
                        "WHERE B.Kode_Barang = @Kode AND " +
                        "B.Kode_Barang = PH.Kode_Barang AND " +
                        "B.Kode_Barang = SR.Kode_Barang AND " +
                        "SR.Status_Stok = @status AND " +
                        "PH.Tanggal_Jual IN " +
                        "(SELECT MAX(PH.Tanggal_Jual) FROM PH_Jual PH WHERE PH.Kode_Barang = @Kode) AND " +
                        "SR.Id_Cabang = @Id", conn);
                    cmd.Parameters.AddWithValue("@Kode", tbKodeBarang.Text);
                    cmd.Parameters.AddWithValue("@Jumlah", (int)nudInputJumlah.Value);
                    cmd.Parameters.AddWithValue("@Id", ID_Cabang_Kasir);
                    cmd.Parameters.AddWithValue("@status", 0);
                    reader = cmd.ExecuteReader();
                }
                List<object> row = new List<object>();
                // 0 -> Kode
                // 1 -> Nama
                // 2 -> Harga
                // 3 -> Jumlah
                // 4 -> Subtotal
                while (reader.Read())
                {
                    row.Add(reader.GetString(0));
                    row.Add(reader.GetString(1));
                    row.Add(reader.GetInt32(2));
                    row.Add(reader.GetInt32(3));
                    row.Add(reader.GetInt32(4));
                }
                conn.Close();
                if (row.Count > 0)
                {
                    int idxAda = -1;
                    for (int i = 0; i < ds.Tables["Penjualan"].Rows.Count; i++)
                    {
                        string kode = ds.Tables["Penjualan"].Rows[i][0].ToString();
                        if (kode == row[0].ToString())
                        {
                            idxAda = i;
                            break;
                        }
                    }
                    if (idxAda != -1)
                    {
                        int jmlRealita = JumlahRealitaHariIni(row[0].ToString());
                        ds.Tables["Penjualan"].Rows[idxAda][3] = Convert.ToInt32(Convert.ToInt32(ds.Tables["Penjualan"].Rows[idxAda][3]) + Convert.ToInt32(row[3]));
                        ds.Tables["Penjualan"].Rows[idxAda][4] = Convert.ToInt32(Convert.ToInt32(ds.Tables["Penjualan"].Rows[idxAda][2]) * Convert.ToInt32(ds.Tables["Penjualan"].Rows[idxAda][3]));
                    }
                    else
                    {
                        ds.Tables["Penjualan"].Rows.Add(row.ToArray());
                    }
                    LoadDataSet();
                    lblTotal.Text = SumTotal().ToString("#,##0");
                }
            }
            ResetInput();
        }

        private int LoadQtyBox(string kode)
        {
            int qty = 1;
            conn.Open();
            cmd = new SqlCommand("SELECT Qtybox FROM Barang WHERE Kode_Barang = @Kode", conn);
            cmd.Parameters.AddWithValue("@Kode", kode);
            qty = (int)cmd.ExecuteScalar();
            conn.Close();
            return qty;
        }

        private void ResetInput()
        {
            tbKodeBarang.Clear();
            lblNamaBarang.Text = "-";
            nudInputJumlah.Value = 1;
        }

        private void LoadDataSet()
        {
            dgvInput.Rows.Clear();
            cbKodeBarang.Items.Clear();
            for (int i = 0; i < ds.Tables["Penjualan"].Rows.Count; i++)
            {
                Object[] row = new Object[5];
                row[0] = ds.Tables["Penjualan"].Rows[i][0];
                row[1] = ds.Tables["Penjualan"].Rows[i][1];
                row[2] = ds.Tables["Penjualan"].Rows[i][2];
                row[3] = ds.Tables["Penjualan"].Rows[i][3];
                row[4] = ds.Tables["Penjualan"].Rows[i][4];
                dgvInput.Rows.Add(dgvInput.Rows.Count + 1, row[0], row[1], row[2], row[3], row[4]);
                cbKodeBarang.Items.Add(row[0]);
            }
        }

        private bool Cek_Member()
        {
            conn.Close();
            conn.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select * from [Member] where Id_Member='" + NoMember + "'", conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            conn.Close();
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private int Potongan_Member(int total)
        {
            int temp = 0;
            temp = (int)(total * 0.05);
            return temp;
        }

        public int SumTotal()
        {
            int ttl = 0;
            foreach (DataGridViewRow row in dgvInput.Rows)
            {
                ttl += Convert.ToInt32(row.Cells[5].Value);
            }
            return ttl;
        }

        private int JumlahRealitaHariIni(string kode)
        {
            int jml = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT jumlah FROM Stok WHERE kode_barang = @kode AND Id_Cabang = @Id AND Status_Stok = @status", conn);
                cmd.Parameters.AddWithValue("@kode", kode);
                cmd.Parameters.AddWithValue("@id", ID_Cabang_Kasir);
                cmd.Parameters.AddWithValue("@status", 1);
                if (cmd.ExecuteScalar() != null)
                {
                    jml = Convert.ToInt32(cmd.ExecuteScalar());
                }
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return jml;
        }

        string kode = "";
        int qtyEdit = -1;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cbKodeBarang.Items.Count >= 1 && cbKodeBarang.SelectedIndex > -1)
            {
                kode = cbKodeBarang.SelectedItem.ToString();
                qtyEdit = Convert.ToInt16(nudEditJumlah.Value);
                Splashscreen.ksr_mgr.ShowDialog();
                cbKodeBarang.SelectedIndex = -1;
                nudEditJumlah.Value = 0;
            }
            else
            {
                MessageBox.Show("ERROR : Product not found", "EDIT FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void EditBarang(ref DataSet dsPenjualan, int idxRow, int qtyBaru, string kode)
        {
            //ubah jml dan subtotal pembelian
            int harga = Convert.ToInt32(dsPenjualan.Tables["Penjualan"].Rows[idxRow][2]);
            int qtyLama = Convert.ToInt32(dsPenjualan.Tables["Penjualan"].Rows[idxRow][3]);
            dsPenjualan.Tables["Penjualan"].Rows[idxRow][3] = qtyBaru;
            ds.Tables["Penjualan"].Rows[idxRow][4] = qtyBaru * harga;

            int jmlRealita = JumlahRealitaHariIni(kode) + qtyLama - qtyBaru;
            LoadDataSet();
        }

        private void DeleteBarang(ref DataSet dsPenjualan, int idxRow, int qtyBaru, string kode)
        {
            //ubah jml dan subtotal pembelian
            int qtyLama = Convert.ToInt32(dsPenjualan.Tables["Penjualan"].Rows[idxRow][3]);
            dsPenjualan.Tables["Penjualan"].Rows.RemoveAt(idxRow);
            int jmlRealita = JumlahRealitaHariIni(kode) + qtyLama;
            LoadDataSet();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbKodeBarang.Items.Count >= 1 && cbKodeBarang.SelectedIndex > -1)
            {
                nudEditJumlah.Value = 0;
                kode = cbKodeBarang.SelectedItem.ToString();
                qtyEdit = Convert.ToInt16(nudEditJumlah.Value);
                Splashscreen.ksr_mgr.ShowDialog();
                cbKodeBarang.SelectedIndex = -1;
                nudEditJumlah.Value = 0;
            }
            else
            {
                MessageBox.Show("ERROR : Product not found", "DELETE FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static int Potongan = 0;
        private void tmrPenjualan_Tick(object sender, EventArgs e)
        {
            if (Kasir_Login_Manager.LoginBenar)
            {
                int idxFound = -1;
                for (int i = 0; i < ds.Tables["Penjualan"].Rows.Count; i++)
                {
                    if (ds.Tables["Penjualan"].Rows[i][0].ToString() == kode)
                    {
                        idxFound = i;
                        break;
                    }
                }

                int jmlRealita = JumlahRealitaHariIni(kode);
                if (qtyEdit == 0) //delete barang
                {
                    DeleteBarang(ref ds, idxFound, qtyEdit, kode);
                }
                else //edit barang
                {
                    if (qtyEdit != 0)
                    {
                        EditBarang(ref ds, idxFound, qtyEdit, kode);
                    }
                }
                Kasir_Login_Manager.LoginBenar = false;
                LoadDataSet();
                kode = "";
                qtyEdit = 0;
            }
            if (KlikConfirm)
            {
                if (Cek_Member())
                {
                    NoKartu = tbNoKartu.Text;
                    Potongan = Potongan_Member(SumTotal());
                    lblTotal.Text = (SumTotal() - Potongan_Member(SumTotal())).ToString("#,##0");
                }
                else
                {
                    NoKartu = "";
                    Potongan = 0;
                    KlikConfirm = false;
                    lblTotal.Text = SumTotal().ToString("#,##0");
                    if(tbNoKartu.Text != "")
                    {
                        MessageBox.Show("ERROR : Member not found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tbNoKartu.Clear();
                    }
                }
            }
            else
            {
                lblTotal.Text = SumTotal().ToString("#,##0");
            }
            if (Kasir_Pembayaran.SelesaiBayar)
            {
                LoadAwal();
                LoadDataSet();
                tbKodeBarang.Clear();
                ResetInput();
                tbNoKartu.Clear();
                lblTotal.Text = "0";
                TotalBayar = 0;
                NoKartu = "";
                Kasir_Pembayaran.SelesaiBayar = false;
            }
        }

        bool KlikConfirm = false;
        string NoMember = "";
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            NoMember = tbNoKartu.Text;
            KlikConfirm = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Splashscreen.ksr_mbr.ShowDialog();
        }

        public static int TotalBayar = 0;
        public static string NoKartu = "";
        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (dgvInput.Rows.Count > 0)
            {
                TotalBayar = 0;
                string bayar = "";
                for (int i = 0; i < lblTotal.Text.Length; i++)
                {
                    if (lblTotal.Text[i] != '.' && lblTotal.Text[i] != ',')
                    {
                        bayar += lblTotal.Text[i];
                    }
                }
                TotalBayar = int.Parse(bayar);
                Splashscreen.ksr_byr.ShowDialog();

            }
            else
            {
                MessageBox.Show("ERROR : There is no transaction being processed", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvInput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgvInput.Rows.Count && e.ColumnIndex > -1 && e.ColumnIndex < dgvInput.ColumnCount)
            {
                cbKodeBarang.Text = dgvInput.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void InputAngkaSaja(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (Char)Keys.Back)
            {
                e.Handled = true;
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Splashscreen.ksr_browse.ShowDialog();
        }

        private void Kasir_Activated(object sender, EventArgs e)
        {
            NoKartu = "";
            KlikConfirm = false;
            tbKodeBarang.Text = Kasir_Browse.KodeBarang;
            NoNota();
            tbKodeBarang.Focus();
        }

        private void Kasir_Shown(object sender, EventArgs e)
        {
            tbKodeBarang.Focus();
        }

        private void tbNoKartu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConfirm_Click(sender, e);
            }
        }

        private void tbKodeBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnInput_Click(sender, e);
            }
        }

        private void nudInputJumlah_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnInput_Click(sender, e);
            }
        }

        private void cbKodeBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (nudEditJumlah.Value == 0)
                {
                    btnDelete_Click(sender, e);
                }
                else
                {
                    btnEdit_Click(sender, e);
                }
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

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.FromArgb(255, 0, 63, 116);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = Color.FromName("Highlight");
        }

        private void pbLogOut_MouseEnter(object sender, EventArgs e)
        {
            pbLogOut.Image = Properties.Resources.logouthover;
        }

        private void pbLogOut_MouseLeave(object sender, EventArgs e)
        {
            pbLogOut.Image = Properties.Resources.logout;
        }

        private void tmrBayar_Tick(object sender, EventArgs e)
        {
            if (dgvInput.Rows.Count > 0)
            {
                btnBayar.Enabled = true;
            }
            else
            {
                btnBayar.Enabled = false;
            }
        }

        private void Kasir_VisibleChanged(object sender, EventArgs e)
        {
            Kasir_Load(this, e);
            Kasir_Shown(this, e);
            dgvInput.Rows.Clear();
            tbKodeBarang.Clear();
            tbNoKartu.Clear();
            nudEditJumlah.Value = 1;
            nudInputJumlah.Value = 1;
            cbKodeBarang.SelectedIndex = -1;
        }
    }
}
