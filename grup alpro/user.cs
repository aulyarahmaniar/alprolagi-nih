using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grup_alpro
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;


            if (username == "kasir1" && password == "loginkasir1")
            {

                MessageBox.Show("Login berhasil!");

                start abislogin = new start();
                abislogin.Show();
                Visible = false;
                this.Close();

            }
            else if (username == "kasir2" && password == "loginkasir2")
            {

                MessageBox.Show("Login berhasil!");

                start abislogin = new start();
                abislogin.Show();
                Visible = false;
                this.Close();

               
            }
            else if (username == "kasir3" && password == "loginkasir3")
            {

                MessageBox.Show("Login berhasil!");

                start abislogin = new start();
                abislogin.Show();
                Visible = false;
                this.Close();

            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


