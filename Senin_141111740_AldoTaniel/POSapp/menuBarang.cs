using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace LatihanPos
{
    public partial class menuBarang :  MetroFramework.Forms.MetroForm 
    {
        
        string kodebarang,idsuplier, namabarang, hargajual, hargahpp, jlhawal;
        DataTable dt;
        initialiazeDA da = new initialiazeDA();
        
        public menuBarang()
        {
            InitializeComponent();
        }
        private void mlback_Click(object sender, EventArgs e)
        {
            menuUtama mn = new menuUtama();
            mn.Show();
            this.Close();
        }

        private void mttambah_Click(object sender, EventArgs e)
        {
            using (tambahBarang tmbh = new tambahBarang()) {
                tmbh.ShowDialog();
            }
        }

        private void menuBarang_Load(object sender, EventArgs e)
        {
            dt = new DataTable();

            da.db_connection();
            da.TampilBarang();
            da.barangDA.SelectCommand.ExecuteScalar();
            da.barangDA.Fill(dt);
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
            da.TampilBarang();
            da.barangDA.SelectCommand.ExecuteScalar();
            dt = new DataTable();
            da.barangDA.Fill(dt);
            dataGridView1.DataSource = dt;
            da.connect.Close();
            
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = "kodeBarang like '%" + cari.Text + "%' or namaBarang like '%" + cari.Text + "%'";
            
            dataGridView1.DataSource = dv;
            
            
        }

        private void menuBarang_FormClosed(object sender, FormClosedEventArgs e)
        {
            da.connect.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = dataGridView1.Rows[e.RowIndex];
            kodebarang = rows.Cells[1].Value.ToString();
            idsuplier = rows.Cells[2].Value.ToString();
            namabarang = rows.Cells[3].Value.ToString();
            jlhawal = rows.Cells[4].Value.ToString();
            hargahpp = rows.Cells[5].Value.ToString();
            hargajual = rows.Cells[6].Value.ToString();   
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
                    da.Barang(kodebarang,idsuplier, namabarang,jlhawal, hargahpp, hargajual, 2);
                    da.insertBarang.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Dihapus");
                    dt = new DataTable();
                    da.TampilBarang();
                    da.barangDA.SelectCommand.ExecuteScalar();
                    da.barangDA.Fill(dt);
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
            editBarang edt = new editBarang(kodebarang,idsuplier, namabarang, jlhawal, hargahpp, hargajual);
            edt.Show();
        }
    }
}
