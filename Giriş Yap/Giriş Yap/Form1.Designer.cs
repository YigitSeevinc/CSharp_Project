namespace Giriş_Yap
{
    partial class AnaFrm
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
            this.grpGirisYap = new System.Windows.Forms.GroupBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.lblKullaniciAdiGiris = new System.Windows.Forms.Label();
            this.txtKullanıcıAdiGiris = new System.Windows.Forms.TextBox();
            this.lblSifreGiris = new System.Windows.Forms.Label();
            this.txtSifreGiris = new System.Windows.Forms.TextBox();
            this.btnHesapOlusturGiris = new System.Windows.Forms.Button();
            this.lblTanimGiris = new System.Windows.Forms.Label();
            this.grpGirisYap.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGirisYap
            // 
            this.grpGirisYap.BackColor = System.Drawing.Color.DarkGray;
            this.grpGirisYap.Controls.Add(this.lblTanimGiris);
            this.grpGirisYap.Controls.Add(this.btnHesapOlusturGiris);
            this.grpGirisYap.Controls.Add(this.txtSifreGiris);
            this.grpGirisYap.Controls.Add(this.lblSifreGiris);
            this.grpGirisYap.Controls.Add(this.lblKullaniciAdiGiris);
            this.grpGirisYap.Controls.Add(this.txtKullanıcıAdiGiris);
            this.grpGirisYap.Controls.Add(this.btnGirisYap);
            this.grpGirisYap.Location = new System.Drawing.Point(12, 12);
            this.grpGirisYap.Name = "grpGirisYap";
            this.grpGirisYap.Size = new System.Drawing.Size(423, 510);
            this.grpGirisYap.TabIndex = 0;
            this.grpGirisYap.TabStop = false;
            this.grpGirisYap.Text = "Giriş Yap";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.DarkGray;
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirisYap.Location = new System.Drawing.Point(221, 392);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(130, 78);
            this.btnGirisYap.TabIndex = 2;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            // 
            // lblKullaniciAdiGiris
            // 
            this.lblKullaniciAdiGiris.AutoSize = true;
            this.lblKullaniciAdiGiris.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullaniciAdiGiris.Location = new System.Drawing.Point(33, 154);
            this.lblKullaniciAdiGiris.Name = "lblKullaniciAdiGiris";
            this.lblKullaniciAdiGiris.Size = new System.Drawing.Size(144, 26);
            this.lblKullaniciAdiGiris.TabIndex = 3;
            this.lblKullaniciAdiGiris.Text = "Kullanıcı Adı:";
            // 
            // txtKullanıcıAdiGiris
            // 
            this.txtKullanıcıAdiGiris.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullanıcıAdiGiris.Location = new System.Drawing.Point(183, 151);
            this.txtKullanıcıAdiGiris.Name = "txtKullanıcıAdiGiris";
            this.txtKullanıcıAdiGiris.Size = new System.Drawing.Size(180, 35);
            this.txtKullanıcıAdiGiris.TabIndex = 4;
            // 
            // lblSifreGiris
            // 
            this.lblSifreGiris.AutoSize = true;
            this.lblSifreGiris.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifreGiris.Location = new System.Drawing.Point(111, 195);
            this.lblSifreGiris.Name = "lblSifreGiris";
            this.lblSifreGiris.Size = new System.Drawing.Size(66, 26);
            this.lblSifreGiris.TabIndex = 6;
            this.lblSifreGiris.Text = "Şifre:";
            // 
            // txtSifreGiris
            // 
            this.txtSifreGiris.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifreGiris.Location = new System.Drawing.Point(183, 192);
            this.txtSifreGiris.Name = "txtSifreGiris";
            this.txtSifreGiris.Size = new System.Drawing.Size(180, 35);
            this.txtSifreGiris.TabIndex = 7;
            // 
            // btnHesapOlusturGiris
            // 
            this.btnHesapOlusturGiris.BackColor = System.Drawing.Color.DarkGray;
            this.btnHesapOlusturGiris.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapOlusturGiris.Location = new System.Drawing.Point(76, 392);
            this.btnHesapOlusturGiris.Name = "btnHesapOlusturGiris";
            this.btnHesapOlusturGiris.Size = new System.Drawing.Size(130, 78);
            this.btnHesapOlusturGiris.TabIndex = 8;
            this.btnHesapOlusturGiris.Text = "Hesap Oluştur";
            this.btnHesapOlusturGiris.UseVisualStyleBackColor = false;
            this.btnHesapOlusturGiris.Click += new System.EventHandler(this.btnHesapOlusturGiris_Click);
            // 
            // lblTanimGiris
            // 
            this.lblTanimGiris.AutoSize = true;
            this.lblTanimGiris.Location = new System.Drawing.Point(50, 484);
            this.lblTanimGiris.Name = "lblTanimGiris";
            this.lblTanimGiris.Size = new System.Drawing.Size(324, 13);
            this.lblTanimGiris.TabIndex = 9;
            this.lblTanimGiris.Text = "Eğer Hesabınız Yoksa Yukarıdaki Butondan Hesap Oluşturabilirsiniz";
            // 
            // AnaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(447, 534);
            this.Controls.Add(this.grpGirisYap);
            this.Name = "AnaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Ekran";
            this.grpGirisYap.ResumeLayout(false);
            this.grpGirisYap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGirisYap;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label lblKullaniciAdiGiris;
        private System.Windows.Forms.TextBox txtKullanıcıAdiGiris;
        private System.Windows.Forms.Button btnHesapOlusturGiris;
        private System.Windows.Forms.TextBox txtSifreGiris;
        private System.Windows.Forms.Label lblSifreGiris;
        private System.Windows.Forms.Label lblTanimGiris;
    }
}

