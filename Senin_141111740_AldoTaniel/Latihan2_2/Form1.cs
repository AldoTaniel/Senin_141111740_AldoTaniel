using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime my = new DateTime(2016, 8, 22);
            monthCalendar1.AddAnnuallyBoldedDate(my);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bulan = 0;
            if (comboBox1.Text == "Januari")
                bulan = 1;
            else if (comboBox1.Text == "Febuari")
                bulan = 2;
            else if (comboBox1.Text == "Maret")
                bulan = 3;
            else if (comboBox1.Text == "April")
                bulan = 4;
            else if (comboBox1.Text == "Mei")
                bulan = 5;
            else if (comboBox1.Text == "Juni")
                bulan = 6;
            else if (comboBox1.Text == "Juli")
                bulan = 7;
            else if (comboBox1.Text == "Agustus")
                bulan = 8;
            else if (comboBox1.Text == "September")
                bulan = 9;
            else if (comboBox1.Text == "Oktober")
                bulan = 10;
            else if (comboBox1.Text == "November")
                bulan = 11;
            else if (comboBox1.Text == "Desember")
                bulan = 12;
            else
                bulan = 0;

            DateTime jadwal = new DateTime(2016, bulan, (int)numericUpDown1.Value);
            monthCalendar1.AddAnnuallyBoldedDate(jadwal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bulan = 0;
            if (comboBox1.Text == "Januari")
                bulan = 1;
            else if (comboBox1.Text == "Febuari")
                bulan = 2;
            else if (comboBox1.Text == "Maret")
                bulan = 3;
            else if (comboBox1.Text == "April")
                bulan = 4;
            else if (comboBox1.Text == "Mei")
                bulan = 5;
            else if (comboBox1.Text == "Juni")
                bulan = 6;
            else if (comboBox1.Text == "Juli")
                bulan = 7;
            else if (comboBox1.Text == "Agustus")
                bulan = 8;
            else if (comboBox1.Text == "September")
                bulan = 9;
            else if (comboBox1.Text == "Oktober")
                bulan = 10;
            else if (comboBox1.Text == "November")
                bulan = 11;
            else if (comboBox1.Text == "Desember")
                bulan = 12;
            else
                bulan = 0;

            DateTime jadwal = new DateTime(2016, bulan, (int)numericUpDown1.Value);
            monthCalendar1.RemoveAnnuallyBoldedDate(jadwal);
        }
    }
}
