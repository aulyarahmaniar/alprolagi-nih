using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grup_alpro
{
    public class pelanggan
    {
        public string Nama { get; set; }
        public string NoTelp { get; set; }
        public string Alamat { get; set; }

        public pelanggan(string nama, string noTelp, string alamat)
        {
            Nama = nama;
            NoTelp = noTelp;
            Alamat = alamat;
        }
    }
}
