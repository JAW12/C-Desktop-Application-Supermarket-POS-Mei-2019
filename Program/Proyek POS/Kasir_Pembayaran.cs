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
    public partial class Kasir_Pembayaran : Form
    {
        public Kasir_Pembayaran()
        {
            InitializeComponent();
        }

        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Proyek_POS.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public static bool SelesaiBayar = false;
        private void Login_Load(object sender, EventArgs e)
        {
            SelesaiBayar = false;
            conn = new SqlConnection(connString);
            lblTotal.Text = "Rp " + Kasir.TotalBayar.ToString("#,##0");
            btnPas.Text = "Rp " + Kasir.TotalBayar.ToString("#,##0");
            Kembalian();
        }

        private void tbPembayaran_TextChanged(object sender, EventArgs e)
        {
            Kembalian();
        }

        private void Kembalian()
        {
            // Awal Disable
            // Pembayaran - Total If >= 0 Then Warna Font Hitam & Button Enable
            // If < 0 Then Warna Font Merah & Button Disable
            if (tbPembayaran.Text.Length > 0)
            {
                int kembalian = int.Parse(tbPembayaran.Text) - Kasir.TotalBayar;
                lblKembalian.Text = "Rp " + kembalian.ToString("#,##0");
                if (kembalian < 0)
                {
                    lblKembalian.ForeColor = Color.Red;
                    btnConfirm.Enabled = false;
                }
                else if (kembalian >= 0)
                {
                    lblKembalian.ForeColor = Color.Green;
                    btnConfirm.Enabled = true;
                }
            }
            else
            {
                lblKembalian.Text = "Rp 0";
            }
        }
        int temp = 0;
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Nginsert di DTrans dari public Dataset Kasir di Looping
            // Nginsert di Transaksi_Member dari public static string
            // Nginsert di Trans dari public int Harga Akhir

            if (Kasir.NoKartu != "")
            {
                conn.Open();
                cmd = new SqlCommand("Insert into [Transaksi](No_Nota_Transaksi, Waktu_Trans, Total_Trans, Id_Kasir, Id_Cabang, Id_Member, Potongan_Member) values (@No_Nota,@Waktu_Trans,@Total_Trans,@Id_Kasir,@Id_Cabang, @Id_Member, @Potongan_Member)", conn);
                cmd.Parameters.AddWithValue("@No_Nota", Kasir.SNota);
                cmd.Parameters.AddWithValue("@Waktu_Trans", Kasir.HariIni());
                cmd.Parameters.AddWithValue("@Total_Trans", Kasir.TotalBayar);
                cmd.Parameters.AddWithValue("@Id_Kasir", Login.ds.Tables["Kasir"].Rows[0][0].ToString());
                cmd.Parameters.AddWithValue("@Id_Cabang", Kasir.ID_Cabang_Kasir);
                cmd.Parameters.AddWithValue("@Id_Member", Kasir.NoKartu);
                cmd.Parameters.AddWithValue("@Potongan_Member", Kasir.Potongan);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                conn.Open();
                cmd = new SqlCommand("Insert into [Transaksi](No_Nota_Transaksi, Waktu_Trans, Total_Trans, Id_Kasir, Id_Cabang) values (@No_Nota,@Waktu_Trans,@Total_Trans,@Id_Kasir,@Id_Cabang)", conn);
                cmd.Parameters.AddWithValue("@No_Nota", Kasir.SNota);
                cmd.Parameters.AddWithValue("@Waktu_Trans", Kasir.HariIni());
                cmd.Parameters.AddWithValue("@Total_Trans", Kasir.TotalBayar);
                cmd.Parameters.AddWithValue("@Id_Kasir", Login.ds.Tables["Kasir"].Rows[0][0].ToString());
                cmd.Parameters.AddWithValue("@Id_Cabang", Kasir.ID_Cabang_Kasir);
                cmd.ExecuteNonQuery();
                conn.Close();
            }


            for (int i = 0; i < Kasir.ds.Tables["Penjualan"].Rows.Count; i++)
            {
                string kodeSistem = LoadKodeSistem(Kasir.ds.Tables["Penjualan"].Rows[i][0].ToString());
                conn.Open();
                cmd = new SqlCommand("Insert into [D_Trans](No_Nota_Transaksi, Kode_Sistem, Kode_Barang, Jumlah_Pembelian, Subtotal) values (@No_Nota,@Kode_Sistem, @Kode_Barang,@Jumlah_Pembelian,@Subtotal)", conn);
                cmd.Parameters.AddWithValue("@No_Nota", Kasir.SNota);
                cmd.Parameters.AddWithValue("@Kode_Sistem", kodeSistem);
                cmd.Parameters.AddWithValue("@Kode_Barang", Kasir.ds.Tables["Penjualan"].Rows[i][0]);
                cmd.Parameters.AddWithValue("@Jumlah_Pembelian", Kasir.ds.Tables["Penjualan"].Rows[i][3]);
                cmd.Parameters.AddWithValue("@Subtotal", Kasir.ds.Tables["Penjualan"].Rows[i][4]);
                cmd.ExecuteNonQuery();
                conn.Close();

                string Kode = Kasir.ds.Tables["Penjualan"].Rows[i][0].ToString();
                int qtyBeli = Convert.ToInt32(Kasir.ds.Tables["Penjualan"].Rows[i][3]);
                UpdateStokRealita(qtyBeli, Kode);
            }
            KirimRiwayat();
            SelesaiBayar = true;
            this.Hide();
        }

        private void KirimRiwayat()
        {
            string keterangan = "Menangani Transaksi " + Kasir.SNota + " dengan Total Rp. " + Kasir.TotalBayar.ToString("#,##0");
            if(Kasir.NoKartu != "")
            {
                keterangan += " untuk Member " + Kasir.NoKartu + " dengan Potongan Member sebesar Rp. " + Kasir.Potongan.ToString("#,##0") + ".";
            }
            else
            {
                keterangan += ".";
            }
            conn.Open();
            cmd = new SqlCommand("INSERT INTO [Riwayat](Id_User, Id_Cabang, Keterangan, Waktu) VALUES(@Id, @Cabang, @Keterangan, @Waktu)", conn);
            cmd.Parameters.AddWithValue("@Id", Login.ds.Tables["Kasir"].Rows[0][0].ToString());
            cmd.Parameters.AddWithValue("@Cabang", Kasir.ID_Cabang_Kasir);
            cmd.Parameters.AddWithValue("@Keterangan", keterangan);
            cmd.Parameters.AddWithValue("@Waktu", DateTime.Now);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private string LoadKodeSistem(string kodebrg)
        {
            string hasil;
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
            return hasil;
        }

        private void UpdateStokRealita(int jumlah, string kode)
        {
            int qtybox = LoadQtyBox(kode);
            if(qtybox == 1)
            {
                conn.Open();
                cmd = new SqlCommand("UPDATE Stok SET Jumlah = Jumlah - @JumlahJual WHERE Kode_Barang = @Kode AND Id_Cabang = @Id AND Status_Stok = @status", conn);
                cmd.Parameters.AddWithValue("@Id", Kasir.ID_Cabang_Kasir);
                cmd.Parameters.AddWithValue("@JumlahJual", jumlah);
                cmd.Parameters.AddWithValue("@Kode", kode);
                cmd.Parameters.AddWithValue("@status", 1);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                conn.Open();
                cmd = new SqlCommand("UPDATE Stok SET Jumlah = Jumlah - @JumlahJual WHERE Kode_Barang = @Kode AND Id_Cabang = @Id AND Status_Stok = @status", conn);
                cmd.Parameters.AddWithValue("@Id", Kasir.ID_Cabang_Kasir);
                cmd.Parameters.AddWithValue("@JumlahJual", jumlah);
                cmd.Parameters.AddWithValue("@Kode", kode);
                cmd.Parameters.AddWithValue("@status", 0);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            
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

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPas_Click(object sender, EventArgs e)
        {
            tbPembayaran.Text = Kasir.TotalBayar.ToString();
            temp = int.Parse(Kasir.TotalBayar.ToString());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbPembayaran.Text = "0";
            temp = 0;
        }

        private void btn100k_Click(object sender, EventArgs e)
        {
            temp = temp + 100000;
            tbPembayaran.Text = temp.ToString();
        }

        private void btn50k_Click(object sender, EventArgs e)
        {
            temp = temp + 50000;
            tbPembayaran.Text = temp.ToString();
        }

        private void btn20k_Click(object sender, EventArgs e)
        {
            temp = temp + 20000;
            tbPembayaran.Text = temp.ToString();
        }

        private void btn10k_Click(object sender, EventArgs e)
        {
            temp = temp + 10000;
            tbPembayaran.Text = temp.ToString();
        }

        private void btn5k_Click(object sender, EventArgs e)
        {
            temp = temp + 5000;
            tbPembayaran.Text = temp.ToString();
        }

        private void btn2k_Click(object sender, EventArgs e)
        {
            temp = temp + 2000;
            tbPembayaran.Text = temp.ToString();
        }

        private void btn1k_Click(object sender, EventArgs e)
        {
            temp = temp + 1000;
            tbPembayaran.Text = temp.ToString();
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            temp = temp + 500;
            tbPembayaran.Text = temp.ToString();
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            temp = temp + 200;
            tbPembayaran.Text = temp.ToString();
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            temp = temp + 100;
            tbPembayaran.Text = temp.ToString();
        }

        private void tbPembayaran_Leave(object sender, EventArgs e)
        {
            if (tbPembayaran.Text != "")
            {
                temp = int.Parse(tbPembayaran.Text);
            }
        }
    }
}
