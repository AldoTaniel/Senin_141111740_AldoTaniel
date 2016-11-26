using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = vScrollBar1.Value.ToString();
            int tahun = DateTime.Now.Year - vScrollBar1.Value;
            label6.Text = tahun.ToString() ;
            dateTimePicker1.MinDate = DateTime.Today.AddYears(-vScrollBar1.Value);
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = vScrollBar2.Value.ToString();
            int tahun = DateTime.Now.Year + vScrollBar2.Value;
            label8.Text = tahun.ToString();
            dateTimePicker1.MaxDate = DateTime.Today.AddYears(vScrollBar2.Value);
        }
    }
}
