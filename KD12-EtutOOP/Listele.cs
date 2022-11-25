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
    public partial class Listele : Form
    {
        public Listele()
        {
            InitializeComponent();
        }

        public Takim listeleTakim;
        private void Listele_Load(object sender, EventArgs e)
        {
            dgwListele.DataSource = listeleTakim._Futbolcular;
        }
    }
}
