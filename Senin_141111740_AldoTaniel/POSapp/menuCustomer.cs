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
    public partial class menuCustomer : MetroFramework.Forms.MetroForm
    {
        initialiazeDA da = new initialiazeDA();
        string idcust, nama, alamat, kodepos, email,nohp;
        public menuCustomer()
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

                    da.Customer(idcust, nama, alamat, kodepos, email,nohp, 2);
                    da.insertCustomer.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Dihapus");



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

       

        

        private void mttambah_Click(object sender, EventArgs e)
        {
            using (tambahCustomer tmbh = new tambahCustomer())
            {
                tmbh.ShowDialog();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = dataGridView1.Rows[e.RowIndex];
            idcust = rows.Cells[0].Value.ToString();
            nama = rows.Cells[1].Value.ToString();
            alamat = rows.Cells[2].Value.ToString();
            kodepos = rows.Cells[3].Value.ToString();
            email = rows.Cells[4].Value.ToString();
            nohp = rows.Cells[5].Value.ToString();
        }

        private void mlback_Click(object sender, EventArgs e)
        {
            menuUtama mn = new menuUtama();
            mn.Show();
            this.Close();
        }

        private void menuCustomer_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            da.db_connection();
            da.TampilCustomer();
            da.customerDA.SelectCommand.ExecuteScalar();
            da.customerDA.Fill(ds, "customer");
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "customer";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void mlrefresh_Click(object sender, EventArgs e)
        {
            da.db_connection();
            da.TampilCustomer();
            da.customerDA.SelectCommand.ExecuteScalar();
            DataTable dt = new DataTable();
            da.customerDA.Fill(dt);
            dataGridView1.DataSource = dt;
            da.connect.Close();
        }

        private void menuCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            da.connect.Close();
        }
        private void mtubah_Click(object sender, EventArgs e)
        {
            EditCustomer edt = new EditCustomer(idcust, nama, alamat, kodepos, email, nohp);
            edt.Show();
        }
    }
}
