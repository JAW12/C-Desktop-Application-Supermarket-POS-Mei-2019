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
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {

            InitializeComponent();

        }

        string connstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Proyek_POS.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        DataSet ds;

        public static Kasir frmkasir;
        public static Kasir_Browse ksr_browse;
        public static Kasir_Login_Manager ksr_mgr;
        public static Kasir_Pembayaran ksr_byr;
        public static Kasir_Register_Member ksr_mbr;

        public static Login login;

        public static Manager frmmanager;
        public static Manager_Lihat_Edit_Stock mgr_stock;
        public static Manager_Pindah_Stock mgr_pindah;

        public static Owner frmOwner;
  
        public static Owner_Beli_Stock own_beli;
        public static Owner_Browse own_browse;
        public static Owner_Lihat_Penjualan own_penjualan;
        public static Owner_Lihat_Stock own_stock;
        public static Owner_Ubah_Harga own_harga;

        public static Riwayat riwayat;
       

        int waktu = 3;
        private void Splashscreen_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            tmr.Start();
            tmrPindah.Start();
            frmkasir = new Kasir();
            ksr_browse = new Kasir_Browse();
            ksr_mgr = new Kasir_Login_Manager();
            ksr_byr = new Kasir_Pembayaran();
            ksr_mbr = new Kasir_Register_Member();
            login = new Login();
            frmmanager = new Manager();
            mgr_stock = new Manager_Lihat_Edit_Stock();
            mgr_pindah = new Manager_Pindah_Stock();
            frmOwner = new Owner();
            own_beli = new Owner_Beli_Stock();
            own_browse = new Owner_Browse();
            own_penjualan = new Owner_Lihat_Penjualan();
            own_stock = new Owner_Lihat_Stock();
            own_harga = new Owner_Ubah_Harga();
            riwayat = new Riwayat();
            mgr_stock.TopLevel = false;
            mgr_stock.AutoScroll = true;
            mgr_pindah.TopLevel = false;
            mgr_pindah.AutoScroll = true;
            own_beli.TopLevel = false;
            own_beli.AutoScroll = true;
            own_penjualan.TopLevel = false;
            own_penjualan.AutoScroll = true;
            own_stock.TopLevel = false;
            own_stock.AutoScroll = true;
            own_harga.TopLevel = false;
            own_harga.AutoScroll = true;
            riwayat.TopLevel = false;
            riwayat.AutoScroll = true;
        }
        
        private void tmr_Tick(object sender, EventArgs e)
        {
            panelSlide.Left += 5;
            if (panelSlide.Left > 225)
            {
                panelSlide.Left = 10;
            }
        }

        private void tmrPindah_Tick(object sender, EventArgs e)
        {
            if (waktu <= 0)
            {
                login.Show();
                tmr.Stop();
                tmrPindah.Stop();
                this.Hide();
            }
            else
            {
                waktu--;
            }
        }
    }
}
