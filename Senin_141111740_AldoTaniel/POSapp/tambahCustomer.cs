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
    public partial class tambahCustomer : MetroFramework.Forms.MetroForm
    {
       
        public tambahCustomer()
        {
            InitializeComponent();
        }
        initialiazeDA da = new initialiazeDA();
        private void metroButton1_Click(object sender, EventArgs e)
        {
            da.db_connection();
            MySqlCommand count = da.connect.CreateCommand();
            count.CommandText = "SELECT COUNT(*) FROM tblcustomer where email='" + email.Text + "' ";
            int hit = Convert.ToInt32(count.ExecuteScalar());
            if (hit >= 1)
            {
                MessageBox.Show("Email Sudah terdaftar");
            }
            else
            {
                try
                {
                    da.Customer("", nama.Text, alamat.Text, kodepos.Text, email.Text, nohp.Text, 0);
                    da.insertCustomer.ExecuteNonQuery();
                    MessageBox.Show("1 Record tersimpan");
                    nama.Text = "";
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

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            nama.Text = "";
            alamat.Text = "";
            kodepos.Text = "";
            email.Text = "";
            nohp.Text = "";
        }
    }
}
