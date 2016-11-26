using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            TxtHasil.Text = check(Convert.ToInt64(Txt1.Text), Convert.ToInt64(Txt2.Text)).ToString();
        }
        public static long kombinasi(long n, long r)
        {
            long hasil = 1;
            for (long i = 0; i < (n - r); i++)
            {
                hasil = hasil * (n - i) / (i + 1);
            }
            return hasil % 1000000007;
        }
        public static long pow(long b, long n)
        {
            if (n == 0)
                return 1;
            if (n == 1)
                return b;
            long halfn = pow(b, n / 2);
            if (n % 2 == 0)
                return (halfn * halfn) % 1000000007;
            else
                return ((halfn * halfn) % 1000000007) * b;
        }
        public static long check(long scoreA, long scoreB)
        {
            if (scoreA < scoreB)
                return check(scoreB, scoreA);
            if (scoreA >= (scoreB + 2) && scoreA == 25)
                return kombinasi((scoreA + scoreB) - 1, scoreB);
            else if (scoreA == (scoreB + 2) && scoreA >= 26)
                return kombinasi(48, 24) * pow(2, (scoreB - 24)) % 1000000007;
            else
                return 0;
        }
    }
}
