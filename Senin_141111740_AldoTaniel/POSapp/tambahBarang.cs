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
    public partial class tambahBarang : MetroFramework.Forms.MetroForm
    {
        initialiazeDA da = new initialiazeDA();
        DataTable dt = new DataTable();
        public tambahBarang()
        {
            InitializeComponent();
        }
        
        private void metroLink1_Click(object sender, EventArgs e)
        {
            menuUtama mn = new menuUtama();
            mn.Show();
            this.Close();
            
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            da.db_connection();
            MySqlCommand count = da.connect.CreateCommand();
            count.CommandText = "SELECT COUNT(*) FROM tblbarang where kodeBarang='"+kodeBarang.Text+"' ";
            int hit = Convert.ToInt32(count.ExecuteScalar());
            if (hit >= 1)
            {
                MessageBox.Show("Kode Barang sudah terdaftar");
            }
            else
            {
                try
                {
                    da.Barang(kodeBarang.Text,kodeSuplier.Text, namaBarang.Text,  jlhAwal.Text, hargaHPP.Text,hrgJual.Text, 0);
                    da.insertBarang.ExecuteNonQuery();
                    MessageBox.Show("1 Record tersimpan");
                    kodeBarang.Text = "";
                    namaBarang.Text = "";
                    kodeSuplier.Text = "";
                    jlhAwal.Text = "";
                    hargaHPP.Text = "";
                    kodeSuplier.Text = "";
                    hrgJual.Text = "";
                    


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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            kodeBarang.Text = "";
            namaBarang.Text = "";
            kodeSuplier.Text = "";
            jlhAwal.Text = "";
            hargaHPP.Text = "";
            kodeSuplier.Text="";
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            metroPanel1.Visible = true;
            
            da.db_connection();
            da.TampilSuplier();
            da.suplierDA.SelectCommand.ExecuteScalar();
            dt = new DataTable();
            da.suplierDA.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void tambahBarang_Load(object sender, EventArgs e)
        {
            metroPanel1.Hide();
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = "kodeSuplier like '%" + cari.Text + "%' or nm_Perusahaan like '%" + cari.Text + "%' or nama_contact like '%" + cari.Text + "%'";

            dataGridView1.DataSource = dv;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = dataGridView1.Rows[e.RowIndex];
             kodeSuplier.Text = rows.Cells[1].Value.ToString();
            
            metroPanel1.Visible = false;
            

           
        }
    }
}
