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
    public partial class menu : Form
    {
        int jumlah = 0;
        public menu()
        {
            InitializeComponent();

        }



        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {
            start mulai = new start();
            mulai.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah(object sender, EventArgs e)
        {
            jumlah++;
            label44.Text = jumlah.ToString();
        }

        private void btnKurang(object sender, EventArgs e)
        {

        }

        private void Label2(object sender, EventArgs e)
        {

        }

        private void lblJumlah(object sender, EventArgs e)
        {

        }

        private void btnkurang(object sender, EventArgs e)
        {
            if (jumlah > 0)
            {
                jumlah--;
                label44.Text = jumlah.ToString();
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            data_pelanggan data = new data_pelanggan();
            data.Show();
            this.Hide();
        }

        private void lblNomor(object sender, EventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
