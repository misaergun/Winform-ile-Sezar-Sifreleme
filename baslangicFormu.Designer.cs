namespace Sezar_Şifreleme_Algoritması
{
    partial class baslangicFormu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.sifreCozme_bttn = new System.Windows.Forms.Button();
            this.sifreleme_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sifreCozme_bttn
            // 
            this.sifreCozme_bttn.Location = new System.Drawing.Point(85, 168);
            this.sifreCozme_bttn.Name = "sifreCozme_bttn";
            this.sifreCozme_bttn.Size = new System.Drawing.Size(286, 68);
            this.sifreCozme_bttn.TabIndex = 1;
            this.sifreCozme_bttn.Text = "ŞİFRE ÇÖZME SAYFASI";
            this.sifreCozme_bttn.UseVisualStyleBackColor = true;
            this.sifreCozme_bttn.Click += new System.EventHandler(this.sifreCozme_bttn_Click);
            // 
            // sifreleme_bttn
            // 
            this.sifreleme_bttn.Location = new System.Drawing.Point(85, 67);
            this.sifreleme_bttn.Name = "sifreleme_bttn";
            this.sifreleme_bttn.Size = new System.Drawing.Size(284, 68);
            this.sifreleme_bttn.TabIndex = 2;
            this.sifreleme_bttn.Text = "ŞİFRELEME SAYFASI";
            this.sifreleme_bttn.UseVisualStyleBackColor = true;
            this.sifreleme_bttn.Click += new System.EventHandler(this.sifreleme_bttn_Click);
            // 
            // baslangicFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 332);
            this.Controls.Add(this.sifreleme_bttn);
            this.Controls.Add(this.sifreCozme_bttn);
            this.Name = "baslangicFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Başlangıç Formu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button sifreCozme_bttn;
        private System.Windows.Forms.Button sifreleme_bttn;
    }
}

