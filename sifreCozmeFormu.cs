using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sezar_Şifreleme_Algoritması
{
    public partial class sifreCozmeFormu : Form
    {
        string metin = "";
        string sifreliMetin = "";
        string alfabe = "abcçdefgğhıijklmnoöprsştuüvyz";
        int anahtar = 3;
        public sifreCozmeFormu()
        {
            InitializeComponent();
        }

        void desifrele()
        {
            metin = "";
            sifreliMetin = sifreliMetin_textbox.Text.ToLower();


            for (int i = 0; i < sifreliMetin.Length; i++)
            {
                bool sonuc = false;
                for (int j = 0; j < 29; j++)
                {
                    if (sifreliMetin[i] == alfabe[j])
                    {
                        sonuc = true;

                        int kontrol = j - anahtar;
                        if (kontrol < 0)
                            kontrol += 29;

                        char ch = alfabe[kontrol];
                        
                        metin += ch;

                    }
                }
                if (!sonuc)
                    metin += sifreliMetin[i];
            }

            metin_textbox.Text = metin;


        }

        private void sifreyiCoz_bttn_Click(object sender, EventArgs e)
        {
            desifrele();
        }

        private void sifreliMetin_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                sifreyiCoz_bttn.PerformClick();


            }
        }
    }
}
