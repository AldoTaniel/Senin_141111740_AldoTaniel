using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanPos
{
    public partial class menuSuplier : MetroFramework.Forms.MetroForm
    {
        initialiazeDA da = new initialiazeDA();
        DataTable dt = new DataTable();
        string kodesuplier, namapers, namacontact, alamat, kodepos, email, nohp;
        public menuSuplier()
        {
            InitializeComponent();
        }

        private void mthapus_Click(object sender, EventArgs e)
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
                    da.Suplier(kodesuplier, namapers, namacontact, alamat, kodepos, email, nohp, 2);
                    da.insertSuplier.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Dihapus");
                    dt = new DataTable();
                    da.TampilSuplier();
                    da.suplierDA.SelectCommand.ExecuteScalar();
                    da.suplierDA.Fill(dt);
                    dataGridView1.DataSource = dt;


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
private void mtubah_Click(object sender, EventArgs e)
        {
            editSuplier eds = new editSuplier(kodesuplier,namapers,namacontact,alamat,kodepos,email,nohp);
            eds.Show();
        }

        private void mttambah_Click(object sender, EventArgs e)
        {
            tambahSuplier tbs = new tambahSuplier();
            tbs.Show();
            
        }

        private void mlback_Click(object sender, EventArgs e)
        {
            menuUtama mnu = new menuUtama();
            mnu.Show();
            this.Close();
        }

        private void menuSuplier_Load(object sender, EventArgs e)
        {
            dt = new DataTable();

            da.db_connection();
            da.TampilSuplier ();
            da.suplierDA.SelectCommand.ExecuteScalar();
            da.suplierDA.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void mlrefresh_Click(object sender, EventArgs e)
        {
            da.db_connection();
            da.TampilSuplier();
            da.suplierDA.SelectCommand.ExecuteScalar();
            dt = new DataTable();
            da.suplierDA.Fill(dt);
            dataGridView1.DataSource = dt;
            da.connect.Close();
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = "kodeSuplier like '%" + cari.Text + "%' or nm_perusahaan like '%" + cari.Text + "%' or nama_contact like '%" + cari.Text + "%'";

            dataGridView1.DataSource = dv;
        }

        private void menuSuplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            da.connect.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = dataGridView1.Rows[e.RowIndex];
            kodesuplier = rows.Cells[1].Value.ToString();
            namapers = rows.Cells[2].Value.ToString();
            namacontact = rows.Cells[3].Value.ToString();
            alamat = rows.Cells[4].Value.ToString();
            kodepos = rows.Cells[5].Value.ToString();
            email = rows.Cells[6].Value.ToString();
            nohp = rows.Cells[7].Value.ToString(); ;
        }
    }
}
