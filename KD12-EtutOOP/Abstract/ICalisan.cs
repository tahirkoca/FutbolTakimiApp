using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD12_EtutOOP.Abstract
{
    public interface ICalisan
    {
        //İnterface içerisinde ben access modifiers (erişim belirteçleri kullanamıyorum.)
        string Ad { get; set; }
        string Soyad { get; set; }
        string TcNo { get; set; }
        bool Cinsiyet { get; set; } // Cinsiyet == true ise erkek false ise kadın olacak
        void Calis();
    }
}
