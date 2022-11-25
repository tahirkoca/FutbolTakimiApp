using KD12_EtutOOP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KD12_EtutOOP
{
    public abstract class Calisan : ICalisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public bool Cinsiyet { get; set; }

        // Eğer ben kalıtım verirsem , bu sınıfı kalıtım alan classlarda(sınıflarda) Calis metodunu istersem ezebilirim. Metodu ezmek şunu ifade eder metot gövdesinin değiştirilmesini. Eğer alt sınıfta bu metot ezildiyse buda polimorphism özelliğini sağlar.
        //Polymorphism -> alt sınıflar üst sınıfın birebir aynısı olmak zorunda değildir!!
        public virtual void Calis()
        {
            MessageBox.Show("Çalışanın görevi çalışmaktır.");
        }

        //Maaş kapsülleme
        private double _Maas;
        public double Maas
        {
            get { return _Maas; }
            set
            {
                if(value < 5500)
                {
                    _Maas = 5500;
                }
                else
                {
                    _Maas = value;
                }
            }
        }

        //Kapsülleme Yapıcam
        private int _Yas;
        public int Yas
        {
            get { return _Yas; }
            set
            {
                if (value < 0 && value < 18)
                {
                    _Yas = 18;
                }
                else
                {
                    _Yas = value;
                }
            }
        }  

        public void NefesAl()
        {
            MessageBox.Show("Çalışırken nefes almak zorundayım yoksa ölürüm.");
        }

        public abstract void ProfesyonelFutbolOyna();
    }
}
