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
    public partial class editSuplier : MetroFramework.Forms.MetroForm
    {
        initialiazeDA da = new initialiazeDA();
        
        public editSuplier()
        {
            InitializeComponent();
        }
        public editSuplier(string kodesup, string nmpers, string nmcontact, string almt, string kdpos, string emails, string nomhp)
            : this() {
            kodeSuplier.Text = kodesup;
            nm_perusahaan.Text = nmpers;
            nm_contact.Text = nmcontact;
            alamat.Text = almt;
            kodepos.Text = kdpos;
            email.Text = emails;
            nohp.Text = nomhp;
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                da.db_connection();
                da.Suplier(kodeSuplier.Text, nm_perusahaan.Text, nm_contact.Text, alamat.Text,kodepos.Text, email.Text, nohp.Text, 1);
                da.insertSuplier.ExecuteNonQuery();
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

        private void metroLink1_Click(object sender, EventArgs e)
        {
            menuSuplier mns = new menuSuplier();
            mns.Show();
            this.Close();
        }
    }
}
