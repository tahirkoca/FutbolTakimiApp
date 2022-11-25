using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KD12_EtutOOP
{
    public class Asci : Calisan
    {
        public void YemekYap()
        {
            MessageBox.Show("Ben çok lezzetli yemek yaparım");
        }
        public override void ProfesyonelFutbolOyna()
        {
            MessageBox.Show("abi ben aşçıyam ne topu ne futbolu oynarım.");
        }

        public override void Calis()
        {
            MessageBox.Show("Benim çalışma görevim yemek yapmaktır.");
        }
    }
}
