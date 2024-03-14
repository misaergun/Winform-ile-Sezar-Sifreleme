namespace Sezar_Şifreleme_Algoritması
{
    partial class sifrelemeFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sifrele_bttn = new System.Windows.Forms.Button();
            this.sifreliMetin_textbox = new System.Windows.Forms.TextBox();
            this.metin_textbox = new System.Windows.Forms.TextBox();
            this.sifreliMetin_label = new System.Windows.Forms.Label();
            this.metin_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sifrele_bttn
            // 
            this.sifrele_bttn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifrele_bttn.Location = new System.Drawing.Point(311, 131);
            this.sifrele_bttn.Name = "sifrele_bttn";
            this.sifrele_bttn.Size = new System.Drawing.Size(136, 36);
            this.sifrele_bttn.TabIndex = 14;
            this.sifrele_bttn.Text = "ŞİFRELE";
            this.sifrele_bttn.UseVisualStyleBackColor = true;
            this.sifrele_bttn.Click += new System.EventHandler(this.sifrele_bttn_Click);
            // 
            // sifreliMetin_textbox
            // 
            this.sifreliMetin_textbox.Location = new System.Drawing.Point(182, 213);
            this.sifreliMetin_textbox.Name = "sifreliMetin_textbox";
            this.sifreliMetin_textbox.Size = new System.Drawing.Size(178, 22);
            this.sifreliMetin_textbox.TabIndex = 13;
            // 
            // metin_textbox
            // 
            this.metin_textbox.Location = new System.Drawing.Point(182, 60);
            this.metin_textbox.Name = "metin_textbox";
            this.metin_textbox.Size = new System.Drawing.Size(178, 22);
            this.metin_textbox.TabIndex = 12;
            this.metin_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metin_textbox_KeyPress);
            // 
            // sifreliMetin_label
            // 
            this.sifreliMetin_label.AutoSize = true;
            this.sifreliMetin_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreliMetin_label.Location = new System.Drawing.Point(26, 213);
            this.sifreliMetin_label.Name = "sifreliMetin_label";
            this.sifreliMetin_label.Size = new System.Drawing.Size(141, 22);
            this.sifreliMetin_label.TabIndex = 11;
            this.sifreliMetin_label.Text = "ŞİFRELİ METİN:";
            // 
            // metin_label
            // 
            this.metin_label.AutoSize = true;
            this.metin_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metin_label.Location = new System.Drawing.Point(97, 60);
            this.metin_label.Name = "metin_label";
            this.metin_label.Size = new System.Drawing.Size(70, 22);
            this.metin_label.TabIndex = 10;
            this.metin_label.Text = "METİN:";
            // 
            // sifrelemeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 291);
            this.Controls.Add(this.sifrele_bttn);
            this.Controls.Add(this.sifreliMetin_textbox);
            this.Controls.Add(this.metin_textbox);
            this.Controls.Add(this.sifreliMetin_label);
            this.Controls.Add(this.metin_label);
            this.Name = "sifrelemeFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sifrelemeFormu";
            this.Load += new System.EventHandler(this.sifrele_bttn_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sifrele_bttn;
        private System.Windows.Forms.TextBox sifreliMetin_textbox;
        private System.Windows.Forms.TextBox metin_textbox;
        private System.Windows.Forms.Label sifreliMetin_label;
        private System.Windows.Forms.Label metin_label;
    }
}