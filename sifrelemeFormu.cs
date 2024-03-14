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
    public partial class sifrelemeFormu : Form
    {
        string metin = "";
        string sifreliMetin = "";
        string alfabe = "abcçdefgğhıijklmnoöprsştuüvyz";
        int anahtar = 3;

        void sifrele()
        {
            sifreliMetin = "";
            metin = metin_textbox.Text.ToLower();


            for (int i = 0; i < metin.Length; i++)
            {
                bool sonuc = false;
                for (int j = 0; j < 29; j++)
                {
                    if (metin[i] == alfabe[j])
                    {
                        sonuc = true;
                        char ch = alfabe[(j + anahtar) % 29];
                        sifreliMetin += ch;

                    }
                }
                if (!sonuc)
                    sifreliMetin += metin[i];
            }
           
            sifreliMetin_textbox.Text = sifreliMetin;


        }
        private void sifrele_bttn_Click(object sender, EventArgs e)
        {
            sifrele();
        }


        public sifrelemeFormu()
        {
            InitializeComponent();
        }

        private void sifreyiCoz_bttn_Click(object sender, EventArgs e)
        {

        }

        private void metin_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                sifrele_bttn.PerformClick();


            }
        }
    }
}
