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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu makan = new menu();
            makan.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            riwayat_pesanan riwayat = new riwayat_pesanan();
            riwayat.Show();
            this.Hide();
        }
    }
}
