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
    public partial class Owner_Beli_Stock : Form
    {
        public Owner_Beli_Stock()
        {
            InitializeComponent();
            tbKodeBarang.GotFocus += new EventHandler(tbKodeBarang_GotFocus);
        }


        private void Owner_Beli_Stock_Shown(object sender, EventArgs e)
        {
            Owner_Beli_Stock_Load(sender, e);
        }

        private void tbKodeBarang_GotFocus(object sender, EventArgs e)
        {
            if(Owner_Browse.KodeBarang != "")
            {
                tbKodeBarang.Text = Owner_Browse.KodeBarang;
                Owner_Browse.KodeBarang = "";
            }
        }

        string id_owner;

        DataTable dtstok;
        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Proyek_POS.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd;

        string tgl = DateTime.Now.ToString("dd/MM/yyyy");

        private void Manager_Beli_Stock_Shown(object sender, EventArgs e)
        {

            Owner_Beli_Stock_Load(sender, e);
        }

        private void tbKodeBarang_TextChanged(object sender, EventArgs e)
        {
            
            if (tbKodeBarang.Text.Length > 0)
            {
                SqlDataAdapter adap = new SqlDataAdapter("Select barang.Nama_barang ,barang.Kode_Sistem from barang where barang.kode_barang='" + tbKodeBarang.Text + "'", conn);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    lblNamaBarang.Text = dt.Rows[0].ItemArray[0].ToString();
                    lblNamaBarang.Font = new Font(lblNamaBarang.Font.FontFamily, 12, lblNamaBarang.Font.Style);
                    lblKodeSistem.Text = dt.Rows[0].ItemArray[1].ToString();
                    if (lblNamaBarang.Location.X + lblNamaBarang.Size.Width > gbDetail.Size.Width)
                    {
                        while (lblNamaBarang.Location.X + lblNamaBarang.Size.Width > gbDetail.Size.Width)
                        {
                            lblNamaBarang.Font = new Font(lblNamaBarang.Font.FontFamily, lblNamaBarang.Font.Size - 1, lblNamaBarang.Font.Style);
                        }
                    }
               
                    btnBeli.Enabled = true;
                }
                else
                {
                    lblNamaBarang.Text = "N/A";
                    tbHargaBarang.Text = "0";
                    btnKirim.Enabled = false;
                    btnBeli.Enabled = false;
                }
            }
        }

        private int ambilIsiPerBox(String kd)
        {
            conn.Close();
            conn.Open();
            SqlCommand sqlcom = new SqlCommand("select qtybox from barang where kode_Barang='" + kd + "'", conn);
            int qty = 0;
            try
            {
                qty = int.Parse(sqlcom.ExecuteScalar().ToString());
            }
            catch
            {
                qty = 0;
            }
            conn.Close();
            return qty;
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            int ketemu = -1;
            
            
                for (int i = 0; i < dtstok.Rows.Count; i++)
                {
                    if (dtstok.Rows[i].ItemArray[0].ToString() == tbKodeBarang.Text &&
                        dtstok.Rows[i].ItemArray[3].ToString() == tbHargaBarang.Text)
                    {
                        ketemu = i;
                    }
                }
                if (ketemu == -1)
                {
                    if(ambilIsiPerBox(tbKodeBarang.Text) > 1)
                    {
                        DataRow dr = dtstok.NewRow();
                        dr[0] = int.Parse(lblKodeSistem.Text.ToString());
                        dr[1] = tbKodeBarang.Text;
                        dr[2] = lblNamaBarang.Text;
                        dr[3] = ambilIsiPerBox(tbKodeBarang.Text);
                        dr[4] = tbHargaBarang.Text;
                        dr[5] = nudJumlahBeli.Value;
                        dr[6] = int.Parse(tbHargaBarang.Text) * nudJumlahBeli.Value;
                        dtstok.Rows.Add(dr);
                    btnKirim.Enabled = true;
                        
                    }
                    else
                    {
                        MessageBox.Show("ERROR : Unable to buy retail product", "BUYING PROODUCT FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    int asal = int.Parse(dtstok.Rows[ketemu].ItemArray[4].ToString());
                    dtstok.Rows[ketemu][4] = (asal + int.Parse(nudJumlahBeli.Value.ToString())).ToString();
                    dtstok.Rows[ketemu][5] = int.Parse(dtstok.Rows[ketemu][4].ToString()) * int.Parse(dtstok.Rows[ketemu][3].ToString());
                }
                isi_total();
                isi_lbl_jumlah();
                tbKodeBarang.Text = "";
                lblNamaBarang.Text = "N/A";
                nudJumlahBeli.Value = 1;
                tbHargaBarang.Text = "0";
            
           
        }

        private void isi_lbl_jumlah()
        {
            int jumlah = 0;
            foreach (DataGridViewRow row in dgvBeliStok.Rows)
            {
                jumlah = jumlah + int.Parse(row.Cells[5].Value.ToString());
            }
            lblJumlahPembelian.Text = jumlah.ToString();
        }
        private void isi_total()
        {
            int total_belanja = 0;
            foreach (DataGridViewRow row in dgvBeliStok.Rows)
            {
                total_belanja = total_belanja + int.Parse(row.Cells[6].Value.ToString());
            }
            lblTotalPembelian.Text = total_belanja.ToString();
            lblTotalPembelian.Font = new Font(lblTotalPembelian.Font.FontFamily, 12, lblTotalPembelian.Font.Style);
            if (lblTotalPembelian.Location.X + lblTotalPembelian.Size.Width > gbOverview.Size.Width)
            {
                while (lblTotalPembelian.Location.X + lblTotalPembelian.Size.Width > gbOverview.Size.Width)
                {
                    lblTotalPembelian.Font = new Font(lblTotalPembelian.Font.FontFamily, lblTotalPembelian.Font.Size - 1, lblNamaBarang.Font.Style);
                }
            }
        }

        private void Owner_Beli_Stock_Load(object sender, EventArgs e)
        {
            id_owner = Login.id_useraktif;
           
            btnBeli.Enabled = false;
            btnKirim.Enabled = false;
            conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Barang.Kode_Sistem,Barang.kode_barang , Barang.Nama_barang, barang.qtybox, " +
                "d_pembelian.Harga_Pembelian, stok.Jumlah, " +
                "stok.Jumlah * d_pembelian.Harga_Pembelian as subtotal " +
                "from Barang , Stok, d_pembelian, Pembelian where 1=2 and " +
                 "Barang.Kode_Barang = Stok.Kode_Barang and d_pembelian.Kode_Barang= Barang.Kode_barang AND " +
                 "stok.Status_Stok = @gudang", conn);
            cmd.Parameters.AddWithValue("@gudang", 0);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);

            dtstok = new DataTable();
            adap.Fill(dtstok);

            dgvBeliStok.DataSource = dtstok;
            dgvBeliStok.Columns[0].HeaderText = "Syscode";
            dgvBeliStok.Columns[1].HeaderText = "Barcode";
            dgvBeliStok.Columns[2].HeaderText = "Name";
            dgvBeliStok.Columns[3].HeaderText = "Qty/Box";
            dgvBeliStok.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBeliStok.Columns[4].HeaderText = "Purchase Price";
            dgvBeliStok.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBeliStok.Columns[5].HeaderText = "Purchase Amount";
            dgvBeliStok.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBeliStok.Columns[6].HeaderText = "Subtotal";
            dgvBeliStok.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            for (int i = 0; i < dgvBeliStok.Columns.Count; i++)
            {
               if(i == 4 || i == 5)
                {
                    dgvBeliStok.Columns[i].ReadOnly = false;
                }
                else
                {
                    dgvBeliStok.Columns[i].ReadOnly = true;
                }
            }
            isi_total();
            isi_lbl_jumlah();
        }
        private void btnKirim_Click(object sender, EventArgs e)
        {
            if (tbNonota.Text=="")
            {
                MessageBox.Show("Please input the invoice number", "SENDING REPORT FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (cek_nonota(tbNonota.Text) == 'A')
                {
                    MessageBox.Show("Please input the invoice number", "SENDING REPORT FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    DateTime tanggal_pemebelian = DateTime.Now;
                    SqlCommand isi = new SqlCommand("Insert into [Pembelian] (No_nota_Beli,Tanggal_Pembelian, Id_Owner) values (@a,@b, @id_owner)", conn);
                    isi.Parameters.AddWithValue("@a", tbNonota.Text);
                    isi.Parameters.AddWithValue("@b", tanggal_pemebelian);
                    isi.Parameters.AddWithValue("@id_owner", id_owner);
                    isi.ExecuteNonQuery();

                    for (int i = 0; i < dgvBeliStok.Rows.Count; i++)
                    {
                        conn.Close();
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("Insert into [D_Pembelian] (No_nota_Beli,Kode_Sistem,Kode_Barang,Harga_Pembelian,Jumlah_Pembelian)values(@a,@ki,@b,@c,@d)", conn);
                        cmd.Parameters.AddWithValue("@a", tbNonota.Text);
                        cmd.Parameters.AddWithValue("@ki", int.Parse(dgvBeliStok.Rows[i].Cells[0].Value.ToString()));
                        cmd.Parameters.AddWithValue("@b", dgvBeliStok.Rows[i].Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@c", dgvBeliStok.Rows[i].Cells[4].Value.ToString());
                        cmd.Parameters.AddWithValue("@d", dgvBeliStok.Rows[i].Cells[5].Value.ToString());
                        cmd.ExecuteNonQuery();
                        string kd = dtstok.Rows[i].ItemArray[1].ToString();
                        if (cek_database(kd) == 'I')
                        {
                            conn.Close();
                            conn.Open();
                            SqlCommand sqlins = new SqlCommand("insert into stok (Kode_Sistem,kode_barang,Jumlah,Id_Cabang, Status_Stok) values(@ks,@a,@b,@c, @gudang)", conn);
                            sqlins.Parameters.AddWithValue("@ks", int.Parse(dtstok.Rows[i].ItemArray[0].ToString()));
                            sqlins.Parameters.AddWithValue("@a", dtstok.Rows[i].ItemArray[1].ToString());
                            sqlins.Parameters.AddWithValue("@b", dtstok.Rows[i].ItemArray[5].ToString());
                            sqlins.Parameters.AddWithValue("@c", "ALL");
                            sqlins.Parameters.AddWithValue("@gudang", 0);
                            sqlins.ExecuteNonQuery();
                            conn.Close();
                        }
                        else if (cek_database(kd) == 'U')
                        {
                            conn.Close();
                            conn.Open();
                            SqlCommand sqlupd = new SqlCommand("update stok set Jumlah = Jumlah + @j where kode_barang=@a AND status_stok = @gudang", conn);
                            sqlupd.Parameters.AddWithValue("@j", int.Parse(dtstok.Rows[i].ItemArray[5].ToString()));
                            sqlupd.Parameters.AddWithValue("@a", dtstok.Rows[i].ItemArray[1].ToString());
                            sqlupd.Parameters.AddWithValue("@gudang", 0);
                            sqlupd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                    btnKirim.Enabled = false;
                    btnBeli.Enabled = false;
                    KirimRiwayat();
                    Owner_Beli_Stock_Load(sender, e);
                }
            }
            tbNonota.Clear();
        }

        private void KirimRiwayat()
        {
            string keterangan = "Melakukan Pembelian Stok dengan No Nota " + tbNonota.Text + " dengan Total sebesar Rp. " + Convert.ToInt32(lblTotalPembelian.Text).ToString("#,##0");
            conn.Open();
            cmd = new SqlCommand("INSERT INTO [Riwayat](Id_User, Id_Cabang, Keterangan, Waktu) VALUES(@Id, @Cabang, @Keterangan, @Waktu)", conn);
            cmd.Parameters.AddWithValue("@Id", Login.ds.Tables["Owner"].Rows[0][0].ToString());
            cmd.Parameters.AddWithValue("@Cabang", "ALL");
            cmd.Parameters.AddWithValue("@Keterangan", keterangan);
            cmd.Parameters.AddWithValue("@Waktu", DateTime.Now);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private char cek_nonota(string text)
        {
            conn.Close();
            conn.Open();
            
            SqlCommand ceknota = new SqlCommand("select count (*) from pembelian where No_Nota_Beli=@a", conn);
            ceknota.Parameters.AddWithValue("@a", text);
            long ada = Convert.ToInt64(ceknota.ExecuteScalar().ToString());
            if (ada>0)
            {
              
                return 'A';
            }
            else
            {
                return 'B';
            }
        }

        private char cek_database(string kd)
        {
            conn.Close();
            conn.Open();
            SqlCommand sqlcom = new SqlCommand("select count(*) from stok where kode_barang =@a and id_cabang=@b AND status_stok = @gudang", conn);
            sqlcom.Parameters.AddWithValue("@a", kd);
            sqlcom.Parameters.AddWithValue("@b", "ALL");
            sqlcom.Parameters.AddWithValue("@gudang", 0);
            int ada = int.Parse(sqlcom.ExecuteScalar().ToString());
            conn.Close();

            if (ada == 0) return 'I';
            else return 'U';
        }

        private void tbHargaBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (Char)Keys.Back)
            {
                e.Handled = true;
            }
            
        }

        private void dgvBeliStok_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                dtstok.Rows[e.RowIndex][6] = int.Parse(dtstok.Rows[e.RowIndex][5].ToString()) * int.Parse(dtstok.Rows[e.RowIndex][4].ToString());
                isi_lbl_jumlah();
                isi_total();
            } 
        }

        private void tbKodeBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().ToLower() == "b")
            {
                e.Handled = true;
                tbKodeBarang.Clear();
                Owner_Browse browse = new Owner_Browse();
                browse.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gbDetail_Enter(object sender, EventArgs e)
        {

        }

        private void Owner_Beli_Stock_VisibleChanged(object sender, EventArgs e)
        {
            //Owner_Beli_Stock_Load(this, e);
            //Owner_Beli_Stock_Shown(this, e);
        }
    }
}
