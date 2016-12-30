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
    public partial class menuUtama : MetroFramework.Forms.MetroForm
    {
        public menuUtama()
        {
            InitializeComponent();
        }

        private void menuUtama_Load(object sender, EventArgs e)
        {

        }


        private void barang_Click(object sender, EventArgs e)
        {
            menuBarang mnb = new menuBarang();
            mnb.Show();
            this.Hide();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            menuCustomer mnc = new menuCustomer();
            mnc.Show();
            this.Close();
        }

        private void supplier_Click(object sender, EventArgs e)
        {
            menuSuplier mns = new menuSuplier();
            mns.Show();
            this.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            penjualan jual = new penjualan();
            jual.Show();
            this.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            pembelian beli = new pembelian();
            beli.Show();
            this.Close();
        }
    }
}
