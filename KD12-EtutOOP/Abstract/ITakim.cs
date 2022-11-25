using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD12_EtutOOP.Abstract
{
    public interface ITakim
    {
        string TakimAdi { get; set; }
        int SampiyonlulSayisi { get; set; }
        int OyuncuSayisi { get; set; }
        DateTime KurulusTarihi { get; set; }
        TakimSahibi TakiminSahibi { get; set; }
        List<Futbolcu> _Futbolcular { get; set; }
        List<Asci> _Ascilar { get; set; }
        List<IdariPersonel> _IdariPersoneller { get; set; }
        int ToplamCalisanSayisi { get; set; }

    }
}
