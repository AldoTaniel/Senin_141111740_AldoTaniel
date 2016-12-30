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
    public partial class EditCustomer : MetroFramework.Forms.MetroForm
    {
        initialiazeDA da = new initialiazeDA();
        public EditCustomer()
        {
            InitializeComponent();
        }
        public EditCustomer(string cust, string namacs, string alamatcs, string kodeposcs, string emailcs,string nohpcs)

        : this(){
            idcust.Text = cust;
            nama.Text = namacs;
            alamat.Text = alamatcs;
            kodepos.Text = kodeposcs;
            email.Text = emailcs;
            nohp.Text = nohpcs;
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            menuBarang mnb = new menuBarang();
            mnb.Show();
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                da.db_connection();
                da.Customer(idcust.Text, nama.Text, alamat.Text, kodepos.Text, email.Text,nohp.Text, 1);
                da.insertCustomer.ExecuteNonQuery();
                MessageBox.Show("1 Record telah di Edit");
                


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
                    this.Close();
                }
            }
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
