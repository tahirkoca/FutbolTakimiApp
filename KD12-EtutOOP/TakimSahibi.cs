using KD12_EtutOOP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KD12_EtutOOP
{
    public class TakimSahibi : ICalisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public bool Cinsiyet { get; set; }

        public void Calis()
        {
            MessageBox.Show("Ben klubün yönetilmesinden sorumlu kişiyim.");
        }
    }
}
