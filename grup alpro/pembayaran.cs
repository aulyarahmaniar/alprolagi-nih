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
    public partial class pembayaran : Form
    {
        public pembayaran()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            qrcode kode = new qrcode();
            kode.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nota selesai = new nota();
            selesai.Show();
            this.Hide();
        }
    }
}
