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
    public partial class pembelian : MetroFramework.Forms.MetroForm
    {
        initialiazeDA da = new initialiazeDA();
        DataTable dt;
        string no,idpemb,kodesup,nmpers,kodebrg,nmbrg,hrghpp,jlh,sub;
        public pembelian()
        {
            InitializeComponent();
        }
        public int faktur()
        {
            int faktursauto = 0;
            da.db_connection();
            MySqlCommand auto = da.connect.CreateCommand();
            auto.CommandText = "SELECT * FROM tbltransaksipembelian order by idtransaksipembelian asc";
            MySqlDataReader autord;
            autord = auto.ExecuteReader();
            while (autord.Read())
            {
                faktursauto = 1 + Convert.ToInt32(autord.GetString(1));
            }
            return faktursauto;
            autord.Close();



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = dataGridView1.Rows[e.RowIndex];
            no = rows.Cells[0].Value.ToString();
            idpemb = rows.Cells[1].Value.ToString();

            kodesup = rows.Cells[2].Value.ToString();
            nmpers = rows.Cells[3].Value.ToString();
            kodebrg = rows.Cells[4].Value.ToString();
            nmbrg = rows.Cells[5].Value.ToString();
            hrghpp = rows.Cells[6].Value.ToString();
            jlh = rows.Cells[7].Value.ToString();
            sub = rows.Cells[8].Value.ToString();
        }

        private void tblBarang_Click(object sender, EventArgs e)
        {
            menuBarang mnb = new menuBarang();
            mnb.Show();
            this.Close();
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
                    delall.CommandText = "delete from tblpembelian";
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
        string rsuplier,rnmpers, rkodebrg, rnmbrg, rhrgjual, rjumlah, rsubtotal;
        private void beli_Click(object sender, EventArgs e)
        {

            try
            {
                da.db_connection();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    rsuplier = dataGridView1.Rows[i].Cells["kodesuplier"].Value.ToString();
                    rnmpers = dataGridView1.Rows[i].Cells["nm_perusahaan"].Value.ToString();
                    rkodebrg = dataGridView1.Rows[i].Cells["kodeBarang"].Value.ToString();
                    rnmbrg = dataGridView1.Rows[i].Cells["namaBarang"].Value.ToString();
                    rhrgjual = dataGridView1.Rows[i].Cells["hargaHPP"].Value.ToString();
                    rjumlah = dataGridView1.Rows[i].Cells["jumlah"].Value.ToString();
                    rsubtotal = dataGridView1.Rows[i].Cells["subtotal"].Value.ToString();
                    da.TransaksiPembelian(fakturpembelian.Text, rsuplier, rnmpers, rkodebrg, rnmbrg, rhrgjual, rjumlah, rsubtotal, 0);
                    da.insertTransaksiPembelian.ExecuteNonQuery();


                        MySqlCommand upstok = da.connect.CreateCommand();
                        upstok.CommandText = "update tblbarang set jlhAwal=jlhAwal+@rjlh where kodeBarang=@rkodebrg";
                        upstok.Parameters.AddWithValue("@rjlh", rjumlah);
                        upstok.Parameters.AddWithValue("@rkodebrg", rkodebrg);
                        upstok.ExecuteNonQuery();

                    
            
                }


                //MessageBox.Show("data tersimpan");
                kodeBarang.Text = "";
                kodesupplier.Text = "";
                nm_perusahaan.Text = "";
                da.db_connection();
                MySqlCommand delall = da.connect.CreateCommand();
                delall.CommandText = "delete from tblpembelian";
                delall.ExecuteNonQuery();
                MessageBox.Show("Pembelian Berhasil");

                da.db_connection();
                dt = new DataTable();
                da.TampilPembelian();
                da.pembelianDA.SelectCommand.ExecuteScalar();
                da.pembelianDA.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                lbltotal.Text = "Rp." + totals().ToString();
                lblsubtotal.Text = "Rp." + totals().ToString();

                fakturpembelian.Text = faktur().ToString();



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

        public int totals()
        {
            int SubTotal = 0;
            for (int x = 0; x < dataGridView1.Rows.Count; x++)
            {
                string SubT = dataGridView1.Rows[x].Cells[8].Value.ToString();
                SubT = SubT.Replace("Rp.", "");
                SubTotal += Convert.ToInt32(SubT);
            }
            return SubTotal;
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

        private void cari_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = "kodeBarang like '%" + cari.Text + "%' or namaBarang like '%" + cari.Text + "%'";

            dataGridView2.DataSource = dv;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = dataGridView2.Rows[e.RowIndex];
            kodeBarang.Text = rows.Cells[1].Value.ToString();
            nmBarang.Text = rows.Cells[3].Value.ToString();
            hrgBarang.Text = rows.Cells[5].Value.ToString();
            stock.Text = rows.Cells[4].Value.ToString();
            kodesupplier.Text= rows.Cells[2].Value.ToString();



            metroPanel1.Visible = false;
        }

        private void kodesupplier_TextChanged(object sender, EventArgs e)
        {
            da.db_connection();
            MySqlCommand namacust = da.connect.CreateCommand();
            if (kodesupplier.Text == "")
            {
                nm_perusahaan.Text = "";
            }
            else
            {
                namacust.CommandText = "SELECT * FROM tblsuplier where kodesuplier ='" + kodesupplier.Text + "'";
                MySqlDataReader namard;
                namard = namacust.ExecuteReader();
                while (namard.Read())
                {
                    nm_perusahaan.Text = namard.GetString(2);
                }
                namard.Close();
            }
        }

        private void pembelian_Load(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            
            da.db_connection();
            dt = new DataTable();
            da.TampilPembelian();
            da.pembelianDA.SelectCommand.ExecuteScalar();
            da.pembelianDA.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            lbltotal.Text = "Rp." + totals().ToString();
            lblsubtotal.Text = "Rp." + totals().ToString();
            
            fakturpembelian.Text = faktur().ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {
            int subtotals = 0;
            da.db_connection();
            MySqlCommand auto = da.connect.CreateCommand();
            auto.CommandText = "SELECT COUNT(*) FROM tblpembelian";
            int hitauto = Convert.ToInt32(auto.ExecuteScalar());
            int fakturs = hitauto + 1;
            da.connect.Close();
            if (kodesupplier.Text=="" || nm_perusahaan.Text=="" || jumlah.Text == "" || kodeBarang.Text == "" || nmBarang.Text == "" || stock.Text == "" || hrgBarang.Text == "")
            {
                MessageBox.Show("Masukan Kode Barang atau Jumlah Tidak boleh Kosong");
            }
            else
            {
                subtotals = Convert.ToInt32(hrgBarang.Text) * Convert.ToInt32(jumlah.Text);
                da.db_connection();
              
                
                    da.connect.Close();
                    try
                    {
                        da.db_connection();

                        da.Pembelian(Convert.ToString(fakturs),"",kodesupplier.Text,nm_perusahaan.Text, kodeBarang.Text, nmBarang.Text, hrgBarang.Text, jumlah.Text, Convert.ToString(subtotals), 0);
                        da.insertPembelian.ExecuteNonQuery();
                        MessageBox.Show("1 Record tersimpan");
                        kodeBarang.Text = "";
                        nmBarang.Text = "";
                        hrgBarang.Text = "";
                        stock.Text = "";
                        jumlah.Text = "";

                        dt = new DataTable();
                        da.TampilPembelian();
                        da.pembelianDA.SelectCommand.ExecuteScalar();
                        da.pembelianDA.Fill(dt);
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
                    da.Pembelian("0", idpemb, "", "", "", "","0","0","0", 2);
                    da.insertPembelian.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Dihapus");
                    dt = new DataTable();
                    da.TampilPembelian();
                    da.pembelianDA.SelectCommand.ExecuteScalar();
                    da.pembelianDA.Fill(dt);
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
}
