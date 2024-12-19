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
    public partial class qrcode : Form
    {
        public qrcode()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            nota selesai = new nota();
            selesai.Show();
            this.Hide();
        }
    }
}
