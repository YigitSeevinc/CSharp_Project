namespace Tahmin_oyunu
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
            this.label1 = new System.Windows.Forms.Label();
            this.İS_textBox = new System.Windows.Forms.TextBox();
            this.GİRİS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(224, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim - Soyisim";
            // 
            // İS_textBox
            // 
            this.İS_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İS_textBox.Location = new System.Drawing.Point(319, 78);
            this.İS_textBox.Name = "İS_textBox";
            this.İS_textBox.Size = new System.Drawing.Size(131, 22);
            this.İS_textBox.TabIndex = 2;
            // 
            // GİRİS
            // 
            this.GİRİS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GİRİS.Location = new System.Drawing.Point(299, 162);
            this.GİRİS.Name = "GİRİS";
            this.GİRİS.Size = new System.Drawing.Size(78, 38);
            this.GİRİS.TabIndex = 3;
            this.GİRİS.Text = "Giriş";
            this.GİRİS.UseVisualStyleBackColor = true;
            this.GİRİS.Click += new System.EventHandler(this.GİRİS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 391);
            this.Controls.Add(this.GİRİS);
            this.Controls.Add(this.İS_textBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LOBBY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox İS_textBox;
        private System.Windows.Forms.Button GİRİS;
    }
}

