using KD12_EtutOOP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD12_EtutOOP
{
    public class Takim : ITakim
    {
        public Takim()
        {
            _Futbolcular = new List<Futbolcu>();
            _Ascilar = new List<Asci>();
            _IdariPersoneller = new List<IdariPersonel>();
        }
        public string TakimAdi { get; set; }
        public int SampiyonlulSayisi { get; set; }
        public int OyuncuSayisi { get; set; }
        public DateTime KurulusTarihi { get; set; }
        public TakimSahibi TakiminSahibi { get; set; }
        public List<Futbolcu> _Futbolcular { get; set; }
        public List<Asci> _Ascilar { get; set; }
        public List<IdariPersonel> _IdariPersoneller { get; set; }
        public int ToplamCalisanSayisi { get; set; }
    }
}
