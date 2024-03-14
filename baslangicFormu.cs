using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sezar_Şifreleme_Algoritması
{
    public partial class baslangicFormu : Form
    {
        public baslangicFormu()
        {
            InitializeComponent();
        }

        private void sifreCozme_bttn_Click(object sender, EventArgs e)
        {
            sifreCozmeFormu sifreCozme_Formu = new sifreCozmeFormu();
            sifreCozme_Formu.ShowDialog();


        }

        private void sifreleme_bttn_Click(object sender, EventArgs e)
        {
            sifrelemeFormu sifreleme_Formu = new sifrelemeFormu();
            sifreleme_Formu.ShowDialog();


        }
    }
}
