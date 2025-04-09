namespace Stok_Programı_Y_
{
    partial class Form1
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
            this.urun_ekle = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.stok_ekle = new System.Windows.Forms.GroupBox();
            this.stok_listesi = new System.Windows.Forms.GroupBox();
            this.urun_adi = new System.Windows.Forms.Label();
            this.urun_textbox = new System.Windows.Forms.TextBox();
            this.urun_kaydet = new System.Windows.Forms.Button();
            this.stok_liste_goster = new System.Windows.Forms.Button();
            this.stok_liste_gizle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.urun_sec_combobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.miktar_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.beden2 = new System.Windows.Forms.RadioButton();
            this.beden1 = new System.Windows.Forms.RadioButton();
            this.beden3 = new System.Windows.Forms.RadioButton();
            this.kaydet = new System.Windows.Forms.Button();
            this.sifirla = new System.Windows.Forms.Button();
            this.liste1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.liste2 = new System.Windows.Forms.ListBox();
            this.liste3 = new System.Windows.Forms.ListBox();
            this.tum_sil = new System.Windows.Forms.Button();
            this.urun_ekle.SuspendLayout();
            this.stok_ekle.SuspendLayout();
            this.stok_listesi.SuspendLayout();
            this.SuspendLayout();
            // 
            // urun_ekle
            // 
            this.urun_ekle.Controls.Add(this.stok_liste_gizle);
            this.urun_ekle.Controls.Add(this.stok_liste_goster);
            this.urun_ekle.Controls.Add(this.urun_kaydet);
            this.urun_ekle.Controls.Add(this.urun_textbox);
            this.urun_ekle.Controls.Add(this.urun_adi);
            this.urun_ekle.Location = new System.Drawing.Point(12, 12);
            this.urun_ekle.Name = "urun_ekle";
            this.urun_ekle.Size = new System.Drawing.Size(363, 210);
            this.urun_ekle.TabIndex = 0;
            this.urun_ekle.TabStop = false;
            this.urun_ekle.Text = "Ürün Ekle";
            // 
            // stok_ekle
            // 
            this.stok_ekle.Controls.Add(this.sifirla);
            this.stok_ekle.Controls.Add(this.kaydet);
            this.stok_ekle.Controls.Add(this.beden3);
            this.stok_ekle.Controls.Add(this.beden1);
            this.stok_ekle.Controls.Add(this.beden2);
            this.stok_ekle.Controls.Add(this.label5);
            this.stok_ekle.Controls.Add(this.label4);
            this.stok_ekle.Controls.Add(this.miktar_textbox);
            this.stok_ekle.Controls.Add(this.label3);
            this.stok_ekle.Controls.Add(this.urun_sec_combobox);
            this.stok_ekle.Controls.Add(this.label2);
            this.stok_ekle.Location = new System.Drawing.Point(397, 12);
            this.stok_ekle.Name = "stok_ekle";
            this.stok_ekle.Size = new System.Drawing.Size(363, 210);
            this.stok_ekle.TabIndex = 1;
            this.stok_ekle.TabStop = false;
            this.stok_ekle.Text = "Stok Ekle";
            // 
            // stok_listesi
            // 
            this.stok_listesi.Controls.Add(this.tum_sil);
            this.stok_listesi.Controls.Add(this.liste3);
            this.stok_listesi.Controls.Add(this.liste2);
            this.stok_listesi.Controls.Add(this.label8);
            this.stok_listesi.Controls.Add(this.label7);
            this.stok_listesi.Controls.Add(this.label6);
            this.stok_listesi.Controls.Add(this.liste1);
            this.stok_listesi.Location = new System.Drawing.Point(12, 228);
            this.stok_listesi.Name = "stok_listesi";
            this.stok_listesi.Size = new System.Drawing.Size(747, 323);
            this.stok_listesi.TabIndex = 2;
            this.stok_listesi.TabStop = false;
            this.stok_listesi.Text = "Stok Listesi";
            // 
            // urun_adi
            // 
            this.urun_adi.AutoSize = true;
            this.urun_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urun_adi.Location = new System.Drawing.Point(20, 35);
            this.urun_adi.Name = "urun_adi";
            this.urun_adi.Size = new System.Drawing.Size(61, 16);
            this.urun_adi.TabIndex = 0;
            this.urun_adi.Text = "Ürün Adı:";
            // 
            // urun_textbox
            // 
            this.urun_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urun_textbox.Location = new System.Drawing.Point(97, 29);
            this.urun_textbox.Name = "urun_textbox";
            this.urun_textbox.Size = new System.Drawing.Size(129, 22);
            this.urun_textbox.TabIndex = 1;
            // 
            // urun_kaydet
            // 
            this.urun_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urun_kaydet.Location = new System.Drawing.Point(250, 28);
            this.urun_kaydet.Name = "urun_kaydet";
            this.urun_kaydet.Size = new System.Drawing.Size(93, 23);
            this.urun_kaydet.TabIndex = 2;
            this.urun_kaydet.Text = "Ürün Kaydet";
            this.urun_kaydet.UseVisualStyleBackColor = true;
            this.urun_kaydet.Click += new System.EventHandler(this.urun_kaydet_Click);
            // 
            // stok_liste_goster
            // 
            this.stok_liste_goster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stok_liste_goster.Location = new System.Drawing.Point(176, 118);
            this.stok_liste_goster.Name = "stok_liste_goster";
            this.stok_liste_goster.Size = new System.Drawing.Size(75, 58);
            this.stok_liste_goster.TabIndex = 3;
            this.stok_liste_goster.Text = "Stok Listesi Göster";
            this.stok_liste_goster.UseVisualStyleBackColor = true;
            this.stok_liste_goster.Visible = false;
            this.stok_liste_goster.Click += new System.EventHandler(this.stok_liste_goster_Click);
            // 
            // stok_liste_gizle
            // 
            this.stok_liste_gizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stok_liste_gizle.Location = new System.Drawing.Point(95, 119);
            this.stok_liste_gizle.Name = "stok_liste_gizle";
            this.stok_liste_gizle.Size = new System.Drawing.Size(75, 58);
            this.stok_liste_gizle.TabIndex = 4;
            this.stok_liste_gizle.Text = "Stok Listesi Gizle";
            this.stok_liste_gizle.UseVisualStyleBackColor = true;
            this.stok_liste_gizle.Click += new System.EventHandler(this.stok_liste_gizle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Seçiniz:";
            // 
            // urun_sec_combobox
            // 
            this.urun_sec_combobox.FormattingEnabled = true;
            this.urun_sec_combobox.Location = new System.Drawing.Point(137, 54);
            this.urun_sec_combobox.Name = "urun_sec_combobox";
            this.urun_sec_combobox.Size = new System.Drawing.Size(121, 21);
            this.urun_sec_combobox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(82, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Miktarı:";
            // 
            // miktar_textbox
            // 
            this.miktar_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.miktar_textbox.Location = new System.Drawing.Point(137, 86);
            this.miktar_textbox.Name = "miktar_textbox";
            this.miktar_textbox.Size = new System.Drawing.Size(121, 22);
            this.miktar_textbox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(264, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(81, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Beden:";
            // 
            // beden2
            // 
            this.beden2.AutoSize = true;
            this.beden2.Location = new System.Drawing.Point(178, 118);
            this.beden2.Name = "beden2";
            this.beden2.Size = new System.Drawing.Size(37, 17);
            this.beden2.TabIndex = 10;
            this.beden2.TabStop = true;
            this.beden2.Text = "39";
            this.beden2.UseVisualStyleBackColor = true;
            // 
            // beden1
            // 
            this.beden1.AutoSize = true;
            this.beden1.Location = new System.Drawing.Point(135, 118);
            this.beden1.Name = "beden1";
            this.beden1.Size = new System.Drawing.Size(37, 17);
            this.beden1.TabIndex = 11;
            this.beden1.TabStop = true;
            this.beden1.Text = "38";
            this.beden1.UseVisualStyleBackColor = true;
            // 
            // beden3
            // 
            this.beden3.AutoSize = true;
            this.beden3.Location = new System.Drawing.Point(221, 118);
            this.beden3.Name = "beden3";
            this.beden3.Size = new System.Drawing.Size(37, 17);
            this.beden3.TabIndex = 12;
            this.beden3.TabStop = true;
            this.beden3.Text = "40";
            this.beden3.UseVisualStyleBackColor = true;
            // 
            // kaydet
            // 
            this.kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydet.Location = new System.Drawing.Point(165, 181);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(93, 23);
            this.kaydet.TabIndex = 5;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // sifirla
            // 
            this.sifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifirla.Location = new System.Drawing.Point(264, 181);
            this.sifirla.Name = "sifirla";
            this.sifirla.Size = new System.Drawing.Size(93, 23);
            this.sifirla.TabIndex = 13;
            this.sifirla.Text = "Sıfırla";
            this.sifirla.UseVisualStyleBackColor = true;
            this.sifirla.Click += new System.EventHandler(this.sifirla_Click);
            // 
            // liste1
            // 
            this.liste1.FormattingEnabled = true;
            this.liste1.Location = new System.Drawing.Point(26, 51);
            this.liste1.Name = "liste1";
            this.liste1.Size = new System.Drawing.Size(359, 238);
            this.liste1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(23, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ürün Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(433, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Miktarı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(603, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Beden:";
            // 
            // liste2
            // 
            this.liste2.FormattingEnabled = true;
            this.liste2.Location = new System.Drawing.Point(435, 51);
            this.liste2.Name = "liste2";
            this.liste2.Size = new System.Drawing.Size(122, 238);
            this.liste2.TabIndex = 15;
            // 
            // liste3
            // 
            this.liste3.FormattingEnabled = true;
            this.liste3.Location = new System.Drawing.Point(606, 51);
            this.liste3.Name = "liste3";
            this.liste3.Size = new System.Drawing.Size(122, 238);
            this.liste3.TabIndex = 16;
            // 
            // tum_sil
            // 
            this.tum_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tum_sil.Location = new System.Drawing.Point(635, 294);
            this.tum_sil.Name = "tum_sil";
            this.tum_sil.Size = new System.Drawing.Size(93, 23);
            this.tum_sil.TabIndex = 14;
            this.tum_sil.Text = "Tümünü Sil";
            this.tum_sil.UseVisualStyleBackColor = true;
            this.tum_sil.Click += new System.EventHandler(this.tum_sil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 561);
            this.Controls.Add(this.stok_listesi);
            this.Controls.Add(this.stok_ekle);
            this.Controls.Add(this.urun_ekle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.urun_ekle.ResumeLayout(false);
            this.urun_ekle.PerformLayout();
            this.stok_ekle.ResumeLayout(false);
            this.stok_ekle.PerformLayout();
            this.stok_listesi.ResumeLayout(false);
            this.stok_listesi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox urun_ekle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox stok_ekle;
        private System.Windows.Forms.GroupBox stok_listesi;
        private System.Windows.Forms.TextBox urun_textbox;
        private System.Windows.Forms.Label urun_adi;
        private System.Windows.Forms.Button stok_liste_gizle;
        private System.Windows.Forms.Button stok_liste_goster;
        private System.Windows.Forms.Button urun_kaydet;
        private System.Windows.Forms.Button sifirla;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.RadioButton beden3;
        private System.Windows.Forms.RadioButton beden1;
        private System.Windows.Forms.RadioButton beden2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox miktar_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox urun_sec_combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tum_sil;
        private System.Windows.Forms.ListBox liste3;
        private System.Windows.Forms.ListBox liste2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox liste1;
    }
}

