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
    public partial class editBarang : MetroFramework.Forms.MetroForm
    {
        initialiazeDA da = new initialiazeDA();
        DataTable dt = new DataTable();
        public editBarang()
        {
            InitializeComponent();
        }

        public editBarang(string kode,string idsup,string nama,string jlh,string hpp,string jual)

        : this(){

            kodeBarang.Text = kode;
            namaBarang.Text = nama;
            kodeSuplier.Text = idsup;
            jlhAwal.Text = jlh;
            hargaHPP.Text = hpp;
            hrgJual.Text = jual;

        }
        private void editBarang_Load(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                da.db_connection();
                da.Barang(kodeBarang.Text,kodeSuplier.Text, namaBarang.Text,  jlhAwal.Text, hargaHPP.Text, hrgJual.Text, 1);
                da.insertBarang.ExecuteNonQuery();
                MessageBox.Show("1 Record telah di Edit");
                this.Close();


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

        private void metroLink1_Click(object sender, EventArgs e)
        {
            menuBarang mnb = new menuBarang();
            mnb.Show();
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = true;

            da.db_connection();
            da.TampilSuplier();
            da.suplierDA.SelectCommand.ExecuteScalar();
            dt = new DataTable();
            da.suplierDA.Fill(dt);
            dataGridView1.DataSource = dt;
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
