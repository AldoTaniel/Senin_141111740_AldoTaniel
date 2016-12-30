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
    public partial class login : MetroFramework.Forms.MetroForm
    {
        private string conn;
        private MySqlConnection connect;
        public login()
        {

            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            textBox3.Select();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void db_connection()
        {
            try
            {
                conn = "Server=localhost;Database=posapp;Uid=root;Pwd=;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }
        private bool validate_login(string user, string pass)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from account where username=@username and password=@password";
            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@password", pass);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            
            string user = username.Text;
            string pass = password.Text;
            if (user == "" || pass == "")
            {
                MessageBox.Show("Username atau Password Tidak Boleh Kosong");
                return;
            }
            bool r = validate_login(user, pass);
            if (r) { 
                    MessageBox.Show("Login Success");
                    menuUtama mn = new menuUtama();
                    
                    mn.Show();
                    this.Hide();                
            }
            else
                MessageBox.Show("Username Atau Password Salah");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;
            if (user == "" || pass == "")
            {
                MessageBox.Show("Username atau Password Tidak Boleh Kosong");
                return;
            }
            bool r = validate_login(user, pass);
            if (r)
            {
                MessageBox.Show("Login Berhasil");
                menuUtama mn = new menuUtama();
                mn.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Username Atau Password Salah");
        }
    }
}
