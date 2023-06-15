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
    public partial class Riwayat : Form
    {
        public Riwayat()
        {
            InitializeComponent();
        }

        string LoginAs = "";
        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Proyek_POS.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd;

        private void LoadCabang()
        {
            conn.Open();
            cmd = new SqlCommand("SELECT Id_Cabang, Nama_Cabang From Cabang WHERE Id_Cabang <> 'ALL'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbFilter.Items.Add(reader.GetString(0) + " - " + reader.GetString(1));
            }
            conn.Close();
        }

        private void Riwayat_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
        }

        private void LoadDatabase(string LoginAs, string Filter)
        {
            if (Filter == "All")
            {
                if(LoginAs == "Manager")
                {
                    dt.Clear();
                    LoadKasir(Manager_Lihat_Edit_Stock.Id_Cabang_Manager);
                    LoadManager(Manager_Lihat_Edit_Stock.Id_Cabang_Manager);
                }
                else if(LoginAs == "Owner")
                {
                    dt.Clear();
                    LoadManager("ALL");
                    LoadOwner();
                }
            }
            else if(Filter == "Cashier")
            {
                dt.Clear();
                LoadKasir(Manager_Lihat_Edit_Stock.Id_Cabang_Manager);
            }
            else if(Filter == "Manager")
            {
                if(LoginAs == "Manager")
                {
                    dt.Clear();
                    LoadManager(Manager_Lihat_Edit_Stock.Id_Cabang_Manager);
                }
                else if(LoginAs == "Owner")
                {
                    dt.Clear();
                    LoadManager("ALL");
                }
            }
            else if(Filter == "Owner")
            {
                dt.Clear();
                LoadOwner();
            }
            else
            {
                dt.Clear();
                LoadManager(GetIdCabang(cbFilter.SelectedItem.ToString()));
            }
        }

        private string GetIdCabang(string text)
        {
            string id = "";
            if (text == "Gudang Pusat")
            {
                id = "ALL";
            }
            else
            {
                id = text.Substring(0, 5);
            }
            return id;
        }

        private void LoadDataTableToDGV(string LoginAs, string Filter)
        {
            dataGridView1.Rows.Clear();
            if (LoginAs == "Manager")
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string[] row = { dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString()};
                    dataGridView1.Rows.Add(row);
                }
            }
            else if(LoginAs == "Owner")
            {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string[] row = { dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString() };
                        dataGridView1.Rows.Add(row);
                    }
            }
            
        }

        DataTable dt = new DataTable();

        private void LoadKasir(string idcabang)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT U.Nama_User, C.Nama_Cabang, R.Waktu, R.Keterangan FROM [Cabang] C, [User] U, [Riwayat] R WHERE U.Id_User = R.Id_User AND U.Status_User = 0 AND R.Id_Cabang = @Cabang AND U.Id_Cabang = C.Id_Cabang", conn);
            cmd.Parameters.AddWithValue("@Cabang", idcabang);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();
        }
        
        private void LoadManager(string idcabang)
        {
            conn.Open();
            if (idcabang != "ALL")
            {
                string query = "SELECT U.Nama_User, R.Keterangan, R.Waktu FROM [User] U, [Riwayat] R WHERE U.Id_User = R.Id_User AND U.Status_User = 1";
                query += " AND R.Id_Cabang = @Cabang";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Cabang", idcabang);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }
            else
            {
                string query = "SELECT U.Nama_User, C.Nama_Cabang, R.Waktu, R.Keterangan FROM [Cabang] C, [User] U, [Riwayat] R WHERE U.Id_User = R.Id_User AND U.Status_User = 1 AND  U.Id_Cabang = C.Id_Cabang";
                cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }
        }


        private void LoadOwner()
        {
            conn.Open();
            cmd = new SqlCommand("SELECT U.Nama_User, R.Keterangan, R.Waktu FROM [User] U, [Riwayat] R WHERE U.Id_User = R.Id_User AND U.Status_User = 2", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            
            LoadDatabase(LoginAs, cbFilter.SelectedItem.ToString());
            LoadDataTableToDGV(LoginAs, cbFilter.SelectedItem.ToString());
            if (LoginAs == "Owner")
            {
                if (cbFilter.SelectedIndex == 0 || cbFilter.SelectedIndex == 1)
                {
                    do_search(cbBerdasarkan.SelectedIndex);
                }
                else if (cbFilter.SelectedIndex>1 && cbBerdasarkan.SelectedIndex==0)
                {
                    do_search(cbBerdasarkan.SelectedIndex);
                }
                
                else if (cbFilter.SelectedIndex > 1 && cbBerdasarkan.SelectedIndex == 0)
                {
                    do_search(cbBerdasarkan.SelectedIndex + 1);
                }
                else if (cbFilter.SelectedIndex > 1 && cbBerdasarkan.SelectedIndex > 0)
                {
                    do_search(cbBerdasarkan.SelectedIndex + 1);
                }
            }
            else if (LoginAs == "Manager" && cbBerdasarkan.SelectedIndex == 0)
            {
                do_search(cbBerdasarkan.SelectedIndex);
            }
            else if (LoginAs == "Manager" && cbBerdasarkan.SelectedIndex > 0)
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
            LoadDataTableToDGV(LoginAs, cbFilter.SelectedItem.ToString());
            if (tbSearch.Text != "")
            {
               
                for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
                {
                    if (!dataGridView1.Rows[i].Cells[idx].Value.ToString().ToLower().Contains(tbSearch.Text.ToLower()))
                    {
                        dataGridView1.Rows.RemoveAt(i);
                    }
                }
            }
        }
       
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boolean ada = true;
            Boolean aman = false;
            if(LoginAs == "Owner")
            {
                if (cbFilter.SelectedItem.ToString() == "Owner" || cbFilter.SelectedItem.ToString().Contains("CA"))
                {
                    dataGridView1.Columns[1].Visible = false;
                    ada = false;
                }
                else
                {
                    dataGridView1.Columns[1].Visible = true;
                    ada = true;
                }
            }
            else if(LoginAs == "Manager")
            {
                dataGridView1.Columns[1].Visible = false;
            }

            LoadDatabase(LoginAs, cbFilter.SelectedItem.ToString());
            LoadDataTableToDGV(LoginAs, cbFilter.SelectedItem.ToString());
            
            tbSearch.Text = "";
            masukincombox(ada);
            cbBerdasarkan.SelectedIndex = 0;

        }

        private void masukincombox(Boolean ada)
        {
            cbBerdasarkan.Items.Clear();
            if (LoginAs=="Owner"&& cbFilter.SelectedIndex<=1 && cbFilter.SelectedIndex>=0)
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    cbBerdasarkan.Items.Add(dataGridView1.Columns[i].HeaderText);
                }
            }
            else
            {
                cbBerdasarkan.Items.Add("Name");
                cbBerdasarkan.Items.Add("Date");
                cbBerdasarkan.Items.Add("Description");
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Riwayat_Shown(object sender, EventArgs e)
        {
           
        }

        private void Riwayat_VisibleChanged(object sender, EventArgs e)
        {
            if (Login.RiwayatLogin == "Manager")
            {
                LoginAs = Login.RiwayatLogin;
                cbFilter.Items.Clear();
                cbFilter.Items.Add("All");
                cbFilter.Items.Add("Cashier");
                cbFilter.Items.Add("Manager");
                dataGridView1.Columns[1].Visible = false;
            }
            else if (Login.RiwayatLogin == "Owner")
            {
                LoginAs = Login.RiwayatLogin;
                cbFilter.Items.Clear();
                cbFilter.Items.Add("All");
                cbFilter.Items.Add("Manager");
                cbFilter.Items.Add("Owner");
                LoadCabang();
                dataGridView1.Columns[1].Visible = true;
            }
            cbFilter.SelectedIndex = 0;
            LoadDatabase(LoginAs, cbFilter.SelectedItem.ToString());
            LoadDataTableToDGV(LoginAs, cbFilter.SelectedItem.ToString());
            cbBerdasarkan.SelectedIndex = 0;
        }

        private void cbBerdasarkan_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnShow_Click(sender, e);
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnShow_Click(sender, e);
            }
        }
    }
}
