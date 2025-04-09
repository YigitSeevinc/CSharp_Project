namespace resim_seçip_gösterme
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
            this.gorsel_ac = new System.Windows.Forms.Button();
            this.resim_alani = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.resim_alani)).BeginInit();
            this.SuspendLayout();
            // 
            // gorsel_ac
            // 
            this.gorsel_ac.Location = new System.Drawing.Point(12, 396);
            this.gorsel_ac.Name = "gorsel_ac";
            this.gorsel_ac.Size = new System.Drawing.Size(776, 42);
            this.gorsel_ac.TabIndex = 0;
            this.gorsel_ac.Text = "GÖRSELİ AÇ";
            this.gorsel_ac.UseVisualStyleBackColor = true;
            this.gorsel_ac.Click += new System.EventHandler(this.gorsel_ac_Click);
            // 
            // resim_alani
            // 
            this.resim_alani.Location = new System.Drawing.Point(12, 12);
            this.resim_alani.Name = "resim_alani";
            this.resim_alani.Size = new System.Drawing.Size(776, 378);
            this.resim_alani.TabIndex = 1;
            this.resim_alani.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resim_alani);
            this.Controls.Add(this.gorsel_ac);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.resim_alani)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gorsel_ac;
        private System.Windows.Forms.PictureBox resim_alani;
    }
}

