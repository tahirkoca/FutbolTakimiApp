using KD12_EtutOOP.Abstract;
using KD12_EtutOOP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KD12_EtutOOP
{
    public class Futbolcu : Calisan , IFutbolcu
    {
        public int FormaNumari { get; set; }
        public Mevki Mevki { get; set; }

        //override dediğin zaman ezebilirsin.
        public override void Calis()
        {
            MessageBox.Show("Senin işin takımın için top koşturmaktır.");
        }

        public override void ProfesyonelFutbolOyna()
        {
            MessageBox.Show("Ben profesyonel olarak futbol oynarım.");
        }
    }
}
