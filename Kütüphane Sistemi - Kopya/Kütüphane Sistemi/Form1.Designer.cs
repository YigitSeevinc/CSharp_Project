namespace Kütüphane_Sistemi
{
    partial class formAnaSayfa
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
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnTur = new System.Windows.Forms.Button();
            this.btnOdunc = new System.Windows.Forms.Button();
            this.btnOgrenciİ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Location = new System.Drawing.Point(37, 27);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(170, 75);
            this.btnOgrenci.TabIndex = 1;
            this.btnOgrenci.Text = "KİTAP İŞLEMLERİ";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnTur
            // 
            this.btnTur.Location = new System.Drawing.Point(37, 131);
            this.btnTur.Name = "btnTur";
            this.btnTur.Size = new System.Drawing.Size(170, 75);
            this.btnTur.TabIndex = 2;
            this.btnTur.Text = "TÜR İŞLEMLERİ";
            this.btnTur.UseVisualStyleBackColor = true;
            this.btnTur.Click += new System.EventHandler(this.btnTur_Click);
            // 
            // btnOdunc
            // 
            this.btnOdunc.Location = new System.Drawing.Point(221, 131);
            this.btnOdunc.Name = "btnOdunc";
            this.btnOdunc.Size = new System.Drawing.Size(170, 75);
            this.btnOdunc.TabIndex = 3;
            this.btnOdunc.Text = "ÖDÜNÇ KİTAP İŞLEMLERİ";
            this.btnOdunc.UseVisualStyleBackColor = true;
            this.btnOdunc.Click += new System.EventHandler(this.btnOdunc_Click);
            // 
            // btnOgrenciİ
            // 
            this.btnOgrenciİ.Location = new System.Drawing.Point(221, 27);
            this.btnOgrenciİ.Name = "btnOgrenciİ";
            this.btnOgrenciİ.Size = new System.Drawing.Size(170, 75);
            this.btnOgrenciİ.TabIndex = 4;
            this.btnOgrenciİ.Text = "ÖĞRENCİ İŞLEMLERİ";
            this.btnOgrenciİ.UseVisualStyleBackColor = true;
            this.btnOgrenciİ.Click += new System.EventHandler(this.btnOgrenciİ_Click);
            // 
            // formAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.btnOgrenciİ);
            this.Controls.Add(this.btnOdunc);
            this.Controls.Add(this.btnTur);
            this.Controls.Add(this.btnOgrenci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANA EKRAN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnTur;
        private System.Windows.Forms.Button btnOdunc;
        private System.Windows.Forms.Button btnOgrenciİ;
    }
}

