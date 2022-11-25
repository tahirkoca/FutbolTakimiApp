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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void futbolcuEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FutbolcuEkle futbolcuEkle = new FutbolcuEkle();
            futbolcuEkle.MdiParent = this;
            futbolcuEkle.futbolcuTakim2 = kd12Takimi;
            futbolcuEkle.Show();
        }
        public Takim kd12Takimi;
        private void Form1_Load(object sender, EventArgs e)
        {
            kd12Takimi = new Takim()
            {
                KurulusTarihi = new DateTime(1960, 02, 05),
                TakimAdi = "BA Boost KD-12 Takımı",
                SampiyonlulSayisi = 15,
                ToplamCalisanSayisi = 5867
            };
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string takimAdi = kd12Takimi.TakimAdi;
        }

        private void futbolcuListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
