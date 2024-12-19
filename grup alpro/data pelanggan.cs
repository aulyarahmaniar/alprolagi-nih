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
    public partial class data_pelanggan : Form
    {
        private List<pelanggan> daftarPelanggan = new List<pelanggan>();
        public data_pelanggan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = textBox1.Text;
            string noTelp = textBox2.Text;
            string alamat = textBox3.Text;

            pelanggan data = new pelanggan(nama, noTelp, alamat);
            daftarPelanggan.Add(data);

            keranjang formKeranjang = new keranjang();
            formKeranjang.NamaPelanggan = data.Nama;
            formKeranjang.NoTelpPelanggan = data.NoTelp;
            formKeranjang.AlamatPelanggan = data.Alamat;
            formKeranjang.Show();
            this.Hide();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           textBox1.Clear();
           textBox2.Clear();
           textBox3.Clear();
        }
    }
}
