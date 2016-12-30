using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LatihanPos
{
    public partial class penjualan : MetroFramework.Forms.MetroForm
    {
        DataTable dt;
        initialiazeDA da = new initialiazeDA();
        string idpenj,no, kode, nama, hrgjual, jlh, sub;
        int jlhAw,rjlh;
        public int faktur() {
            int faktursauto = 0;
            da.db_connection();
            MySqlCommand auto = da.connect.CreateCommand();
            auto.CommandText = "SELECT * FROM tbltransaksipenjualan order by idtransaksi asc";
            MySqlDataReader autord;
            autord = auto.ExecuteReader();
            while (autord.Read())
            {
                faktursauto = 1 + Convert.ToInt32(autord.GetString(1));
            }
            return faktursauto;
            autord.Close();
            
            
            
        }
        public int totals() {
            int SubTotal = 0;
            for (int x = 0; x < dataGridView1.Rows.Count; x++)
            {
                string SubT = dataGridView1.Rows[x].Cells[6].Value.ToString();
                SubT = SubT.Replace("Rp.", "");
                SubTotal += Convert.ToInt32(SubT);
            }
            return SubTotal;  
          }
        
        public penjualan()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            da.db_connection();
            
            DialogResult pesan;
            pesan = MessageBox.Show("Anda Yakin ingin membatalkannya?", "Warning", MessageBoxButtons.YesNo);
            if (pesan == DialogResult.No)
            {
                return;
            }
            else
            {
                try
                {
                    da.db_connection();
                    MySqlCommand delall = da.connect.CreateCommand();
                    delall.CommandText = "delete from tblpenjualan";
                    delall.ExecuteNonQuery();
                   
                    


                }
                catch (Exception)
                {
                    throw;


                }
                finally
                {
                    if (da.connect.State == ConnectionState.Open)
                    {
                        da.connect.Close();
                        menuUtama mnu = new menuUtama();
                        mnu.Show();
                        this.Close();
                    }
                }
            }
        }

        private void kodecust_TextChanged(object sender, EventArgs e)
        {
            da.db_connection();
            MySqlCommand namacust = da.connect.CreateCommand();
            if (kodecust.Text == "")
            {
                nm_cust.Text = "";
            }
            else if (kodecust.Text == "0")
            {
                nm_cust.Text = "Tamu";
            }
            else
            {
                namacust.CommandText = "SELECT * FROM tblcustomer where idcust ='" + kodecust.Text + "'";
                MySqlDataReader namard;
                namard = namacust.ExecuteReader();
                while (namard.Read())
                {
                    nm_cust.Text = namard.GetString(1);
                }
                namard.Close();
            }
            
           
        }
        string rkodebrg, rnmbrg, rhrgjual, rjumlah, rsubtotal;

        private void tblBarang_Click(object sender, EventArgs e)
        {
            menuBarang mnb = new menuBarang();
            mnb.Show();
            this.Close();
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = "kodeBarang like '%" + cari.Text + "%' or namaBarang like '%" + cari.Text + "%'";

            dataGridView2.DataSource = dv;
        }

        private void byrBayar_TextChanged(object sender, EventArgs e)
        {
            double kembali = 0;
            if (byrBayar.Text == "")
                byrKembali.Text = "0";
            else {
                kembali = Convert.ToDouble(byrBayar.Text) - totals();
                byrKembali.Text = kembali.ToString();
            }
            
        }

        private void byrCancel_Click(object sender, EventArgs e)
        {
            da.db_connection();
            MySqlCommand delstat = da.connect.CreateCommand();
            delstat.CommandText = "delete from tbltransaksipenjualan where status='Belum Bayar'";
            delstat.ExecuteNonQuery();
            metroPanel2.Visible = false;
        }

        private void byrBtnBayar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(byrKembali.Text) < 0)
            {
                MessageBox.Show("Uang Tidak Cukup");
            }
            else
            {
                
                da.db_connection();
                
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {

                    rkodebrg = dataGridView1.Rows[i].Cells["kodeBarang"].Value.ToString();
                    rnmbrg = dataGridView1.Rows[i].Cells["namaBarang"].Value.ToString();
                    rhrgjual = dataGridView1.Rows[i].Cells["hrgJual"].Value.ToString();
                    rjlh =Convert.ToInt32(dataGridView1.Rows[i].Cells["jumlah"].Value.ToString());
                    rsubtotal = dataGridView1.Rows[i].Cells["subtotal"].Value.ToString();
                   
                    
                    MySqlCommand upstok = da.connect.CreateCommand();
                    upstok.CommandText = "update tblbarang set jlhAwal=jlhAwal-@rjlh where kodeBarang=@rkodebrg";
                    upstok.Parameters.AddWithValue("@rjlh", rjlh);
                    upstok.Parameters.AddWithValue("@rkodebrg", rkodebrg);
                    upstok.ExecuteNonQuery();

                }

                da.db_connection();
                da.Transaksi("", "0", "", "", "", "0", "0", "0", 1);
                da.insertTransaksi.ExecuteNonQuery();
                da.connect.Close();

                da.db_connection();
                MySqlCommand delall = da.connect.CreateCommand();
                delall.CommandText = "delete from tblpenjualan";
                delall.ExecuteNonQuery();
                MessageBox.Show("Terima Kasih");
                metroPanel2.Visible = false;
                da.db_connection();
                dt = new DataTable();
                da.TampilPenjualan();
                da.penjualanDA.SelectCommand.ExecuteScalar();
                da.penjualanDA.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                lbltotal.Text = "Rp." + totals().ToString();
                lblsubtotal.Text = "Rp." + totals().ToString();
                fakturpenjualan.Text = faktur().ToString();
            }
            
        }

        private void bayar_Click(object sender, EventArgs e)
        {
            if (kodecust.Text == "")
            {
                MessageBox.Show("Masukan Kode Customer");
            }
            else
            {
                try
                {
                    da.db_connection();
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {

                        rkodebrg = dataGridView1.Rows[i].Cells["kodeBarang"].Value.ToString();
                        rnmbrg = dataGridView1.Rows[i].Cells["namaBarang"].Value.ToString();
                        rhrgjual = dataGridView1.Rows[i].Cells["hrgJual"].Value.ToString();
                        rjumlah = dataGridView1.Rows[i].Cells["jumlah"].Value.ToString();
                        rsubtotal = dataGridView1.Rows[i].Cells["subtotal"].Value.ToString();
                        da.Transaksi(fakturpenjualan.Text, kodecust.Text, nm_cust.Text, rkodebrg, rnmbrg, rhrgjual, rjumlah, rsubtotal, 0);
                        da.insertTransaksi.ExecuteNonQuery();

                    }
                    byrSubtotal.Text = lblsubtotal.Text;
                    metroPanel2.Visible = true;
                    //MessageBox.Show("data tersimpan");
                    kodeBarang.Text = "";
                    kodecust.Text = "";
                    nm_cust.Text = "";










                }
                catch (Exception)
                {
                    throw;


                }
                finally
                {
                    if (da.connect.State == ConnectionState.Open)
                    {
                        da.connect.Close();


                    }
                }
            }
        }

        

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = dataGridView2.Rows[e.RowIndex];
            kodeBarang.Text = rows.Cells[1].Value.ToString();
            nmBarang.Text = rows.Cells[3].Value.ToString();
            hrgBarang.Text = rows.Cells[6].Value.ToString();
            stock.Text = rows.Cells[4].Value.ToString();
            


            metroPanel1.Visible = false;

        }

        private void btncekBarang_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = true;

            da.db_connection();
            da.TampilBarang();
            da.barangDA.SelectCommand.ExecuteScalar();
            dt = new DataTable();
            da.barangDA.Fill(dt);
            dataGridView2.DataSource = dt;
            da.connect.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            int subtotals = 0;   
            da.db_connection();
            MySqlCommand auto = da.connect.CreateCommand();
            auto.CommandText = "SELECT COUNT(*) FROM tblpenjualan";
            int hitauto = Convert.ToInt32(auto.ExecuteScalar());
            int fakturs = hitauto + 1;
            da.connect.Close();
            if (jumlah.Text == "" || kodeBarang.Text=="" || nmBarang.Text=="" || stock.Text=="" || hrgBarang.Text=="" )
            {
                MessageBox.Show("Masukan Kode Barang atau Jumlah Tidak boleh Kosong");
            }
            else
            {
                subtotals = Convert.ToInt32(hrgBarang.Text) * Convert.ToInt32(jumlah.Text);
                da.db_connection();
                MySqlCommand count = da.connect.CreateCommand();
                count.CommandText = "SELECT jlhAwal FROM tblbarang where kodeBarang='" + kodeBarang.Text + "' ";
                int hit = Convert.ToInt32(count.ExecuteScalar());
                if (hit < Convert.ToInt32(jumlah.Text))
                {
                    MessageBox.Show("Stock Tidak Cukup");
                }
                else
                {
                    da.connect.Close();
                    try
                    {
                        da.db_connection();

                        da.Penjualan("", Convert.ToString(fakturs), kodeBarang.Text, nmBarang.Text, hrgBarang.Text, jumlah.Text, Convert.ToString(subtotals), 0);
                        da.insertPenjualan.ExecuteNonQuery();
                        MessageBox.Show("1 Record tersimpan");
                        kodeBarang.Text = "";
                        nmBarang.Text = "";
                        hrgBarang.Text = "";
                        stock.Text = "";
                        jumlah.Text = "";

                        dt = new DataTable();
                        da.TampilPenjualan();
                        da.penjualanDA.SelectCommand.ExecuteScalar();
                        da.penjualanDA.Fill(dt);
                        dataGridView1.DataSource = dt;
                        lbltotal.Text = "Rp." + totals().ToString();
                        lblsubtotal.Text = "Rp." + totals().ToString();




                    }
                    catch (Exception)
                    {
                        throw;


                    }
                    finally
                    {
                        if (da.connect.State == ConnectionState.Open)
                        {
                            da.connect.Close();
                        }
                    }
                }
            


            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            da.db_connection();
            DialogResult pesan;
            pesan = MessageBox.Show("Anda Yakin ingin menghapus data ini?", "Warning", MessageBoxButtons.YesNo);
            if (pesan == DialogResult.No)
            {
                return;
            }
            else
            {
                try
                {
                    da.db_connection();
                    da.Penjualan( idpenj,no, kode, nama, hrgjual, jlh,sub, 2);
                    da.insertPenjualan.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Dihapus");
                    dt = new DataTable();
                    da.TampilPenjualan();
                    da.penjualanDA.SelectCommand.ExecuteScalar();
                    da.penjualanDA.Fill(dt);
                    dataGridView1.DataSource = dt;
                    lbltotal.Text = "Rp." + totals().ToString();
                    lblsubtotal.Text = "Rp." + totals().ToString();


                }
                catch (Exception)
                {
                    throw;


                }
                finally
                {
                    if (da.connect.State == ConnectionState.Open)
                    {
                        da.connect.Close();
                    }
                }
            }
        }

        

        private void penjualan_Load(object sender, EventArgs e)
        {
           
            metroPanel1.Visible = false;
            metroPanel2.Visible = false;
            da.db_connection();
            dt = new DataTable();
            da.TampilPenjualan();
            da.penjualanDA.SelectCommand.ExecuteScalar();
            da.penjualanDA.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            lbltotal.Text = "Rp." +totals().ToString();
            lblsubtotal.Text = "Rp." + totals().ToString();
            fakturpenjualan.Text = faktur().ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = dataGridView1.Rows[e.RowIndex];
            idpenj = rows.Cells[0].Value.ToString();
            no = rows.Cells[1].Value.ToString();
            
            kode= rows.Cells[2].Value.ToString();
            nama = rows.Cells[3].Value.ToString();
            hrgjual = rows.Cells[4].Value.ToString();
            jlh= rows.Cells[5].Value.ToString();
            sub = rows.Cells[6].Value.ToString();
        }
    }
}
