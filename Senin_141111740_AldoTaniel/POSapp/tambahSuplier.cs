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
    public partial class tambahSuplier : MetroFramework.Forms.MetroForm
    {
        initialiazeDA da = new initialiazeDA();
        public tambahSuplier()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            da.db_connection();
            MySqlCommand count = da.connect.CreateCommand();
            count.CommandText = "SELECT COUNT(*) FROM tblsuplier where email='" + email.Text + "' ";
            int hit = Convert.ToInt32(count.ExecuteScalar());
            if (hit >= 1)
            {
                MessageBox.Show("Email Sudah terdaftar");
            }
            else
            {
                try
                {
                    da.Suplier(kodeSuplier.Text, nm_perusahaan.Text, nm_contact.Text, alamat.Text, kodepos.Text, email.Text, nohp.Text, 0);
                    da.insertSuplier.ExecuteNonQuery();
                    MessageBox.Show("1 Record tersimpan");
                    kodeSuplier.Text = "";
                    nm_perusahaan.Text = "";
                    nm_contact.Text = "";
                    alamat.Text = "";
                    kodepos.Text = "";
                    email.Text = "";
                    nohp.Text = "";


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
            kodeSuplier.Text = "";
            nm_perusahaan.Text = "";
            nm_contact.Text = "";
            alamat.Text = "";
            kodepos.Text = "";
            email.Text = "";
            nohp.Text = "";
        }
    }
}
