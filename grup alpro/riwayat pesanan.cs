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
    public partial class riwayat_pesanan : Form
    {
        public riwayat_pesanan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            start mulai = new start();
            mulai.Show();

            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
