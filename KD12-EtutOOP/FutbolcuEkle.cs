using KD12_EtutOOP.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KD12_EtutOOP
{
    public partial class FutbolcuEkle : Form
    {
        public FutbolcuEkle()
        {
            InitializeComponent();
        }

        public Takim futbolcuTakim2;
        private void FutbolcuEkle_Load(object sender, EventArgs e)
        {
            cmbMevkiler.Items.AddRange(Enum.GetNames(typeof(Mevki)));
        }

        private void btnFutbolcuEkle_Click(object sender, EventArgs e)
        {
            Futbolcu eklenecekFutbolcu = new Futbolcu()
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                FormaNumari = Convert.ToInt32(txtFormaNo.Text),
                Maas = Convert.ToDouble(txtMaas.Text),
                Yas = Convert.ToInt32(txtYas.Text),
                TcNo = txtTcNo.Text
            };
            if (rdbErkek.Checked)
            {
                eklenecekFutbolcu.Cinsiyet = true;
            }
            else
                eklenecekFutbolcu.Cinsiyet = false;

            if(cmbMevkiler.SelectedItem.ToString() == "Defans")
            {
                eklenecekFutbolcu.Mevki = Mevki.Defans;
            }
            if (cmbMevkiler.SelectedItem.ToString() == "Forvet")
            {
                eklenecekFutbolcu.Mevki = Mevki.Forvet;
            }
            if (cmbMevkiler.SelectedItem.ToString() == "Kaleci")
            {
                eklenecekFutbolcu.Mevki = Mevki.Kaleci;
            }
            if (cmbMevkiler.SelectedItem.ToString() == "OrtaSaha")
            {
                eklenecekFutbolcu.Mevki = Mevki.OrtaSaha;
            }

            futbolcuTakim2._Futbolcular.Add(eklenecekFutbolcu);
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            Listele listele = new Listele();
            listele.listeleTakim = futbolcuTakim2;
            listele.Show();
        }
    }
}
