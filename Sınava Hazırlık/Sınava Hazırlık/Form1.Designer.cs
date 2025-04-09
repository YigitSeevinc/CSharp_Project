namespace sınava_hazırlık
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SonucKare1 = new System.Windows.Forms.Label();
            this.btnKareCH = new System.Windows.Forms.Button();
            this.btnKareAH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKareK = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SonucDaire = new System.Windows.Forms.Label();
            this.btnDaireCH = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDaireAH = new System.Windows.Forms.Button();
            this.txtDaireYÇ = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SonucDikdörtgen = new System.Windows.Forms.Label();
            this.btnDikdörtgenCH = new System.Windows.Forms.Button();
            this.txtDikdörtgenKK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDikdörtgenAH = new System.Windows.Forms.Button();
            this.Labelll = new System.Windows.Forms.Label();
            this.txtDikdörgenUK = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtYukseklik = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SonucUcgen = new System.Windows.Forms.Label();
            this.btnUcgenCH = new System.Windows.Forms.Button();
            this.btnUcgenAH = new System.Windows.Forms.Button();
            this.txtUcgenK3 = new System.Windows.Forms.TextBox();
            this.txtUcgenK2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUcgenK1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox1.Controls.Add(this.SonucKare1);
            this.groupBox1.Controls.Add(this.btnKareCH);
            this.groupBox1.Controls.Add(this.btnKareAH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKareK);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KARE";
            // 
            // SonucKare1
            // 
            this.SonucKare1.AutoSize = true;
            this.SonucKare1.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SonucKare1.ForeColor = System.Drawing.Color.Red;
            this.SonucKare1.Location = new System.Drawing.Point(59, 218);
            this.SonucKare1.Name = "SonucKare1";
            this.SonucKare1.Size = new System.Drawing.Size(0, 27);
            this.SonucKare1.TabIndex = 3;
            // 
            // btnKareCH
            // 
            this.btnKareCH.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKareCH.Location = new System.Drawing.Point(161, 66);
            this.btnKareCH.Name = "btnKareCH";
            this.btnKareCH.Size = new System.Drawing.Size(118, 94);
            this.btnKareCH.TabIndex = 2;
            this.btnKareCH.Text = "Çevre Hesapla";
            this.btnKareCH.UseVisualStyleBackColor = true;
            this.btnKareCH.Click += new System.EventHandler(this.btnKareCH_Click);
            // 
            // btnKareAH
            // 
            this.btnKareAH.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKareAH.Location = new System.Drawing.Point(27, 66);
            this.btnKareAH.Name = "btnKareAH";
            this.btnKareAH.Size = new System.Drawing.Size(118, 94);
            this.btnKareAH.TabIndex = 1;
            this.btnKareAH.Text = "Alan Hesapla";
            this.btnKareAH.UseVisualStyleBackColor = true;
            this.btnKareAH.Click += new System.EventHandler(this.btnKareAH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kare\'nin bir kenarını giriniz:";
            // 
            // txtKareK
            // 
            this.txtKareK.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKareK.Location = new System.Drawing.Point(202, 19);
            this.txtKareK.Name = "txtKareK";
            this.txtKareK.Size = new System.Drawing.Size(100, 27);
            this.txtKareK.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox2.Controls.Add(this.SonucDaire);
            this.groupBox2.Controls.Add(this.btnDaireCH);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnDaireAH);
            this.groupBox2.Controls.Add(this.txtDaireYÇ);
            this.groupBox2.Location = new System.Drawing.Point(12, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DAİRE";
            // 
            // SonucDaire
            // 
            this.SonucDaire.AutoSize = true;
            this.SonucDaire.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SonucDaire.ForeColor = System.Drawing.Color.Red;
            this.SonucDaire.Location = new System.Drawing.Point(84, 229);
            this.SonucDaire.Name = "SonucDaire";
            this.SonucDaire.Size = new System.Drawing.Size(0, 27);
            this.SonucDaire.TabIndex = 9;
            // 
            // btnDaireCH
            // 
            this.btnDaireCH.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaireCH.Location = new System.Drawing.Point(161, 93);
            this.btnDaireCH.Name = "btnDaireCH";
            this.btnDaireCH.Size = new System.Drawing.Size(118, 94);
            this.btnDaireCH.TabIndex = 8;
            this.btnDaireCH.Text = "Çevre Hesapla";
            this.btnDaireCH.UseVisualStyleBackColor = true;
            this.btnDaireCH.Click += new System.EventHandler(this.btnDaireCH_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Daire\'nin Yarı Çapını Giriniz:";
            // 
            // btnDaireAH
            // 
            this.btnDaireAH.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaireAH.Location = new System.Drawing.Point(27, 93);
            this.btnDaireAH.Name = "btnDaireAH";
            this.btnDaireAH.Size = new System.Drawing.Size(118, 94);
            this.btnDaireAH.TabIndex = 7;
            this.btnDaireAH.Text = "Alan Hesapla";
            this.btnDaireAH.UseVisualStyleBackColor = true;
            this.btnDaireAH.Click += new System.EventHandler(this.btnDaireAH_Click);
            // 
            // txtDaireYÇ
            // 
            this.txtDaireYÇ.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaireYÇ.Location = new System.Drawing.Point(208, 37);
            this.txtDaireYÇ.Name = "txtDaireYÇ";
            this.txtDaireYÇ.Size = new System.Drawing.Size(100, 27);
            this.txtDaireYÇ.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox3.Controls.Add(this.SonucDikdörtgen);
            this.groupBox3.Controls.Add(this.btnDikdörtgenCH);
            this.groupBox3.Controls.Add(this.txtDikdörtgenKK);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnDikdörtgenAH);
            this.groupBox3.Controls.Add(this.Labelll);
            this.groupBox3.Controls.Add(this.txtDikdörgenUK);
            this.groupBox3.Location = new System.Drawing.Point(326, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 284);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DİKDÖRTGEN";
            // 
            // SonucDikdörtgen
            // 
            this.SonucDikdörtgen.AutoSize = true;
            this.SonucDikdörtgen.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SonucDikdörtgen.ForeColor = System.Drawing.Color.Red;
            this.SonucDikdörtgen.Location = new System.Drawing.Point(112, 235);
            this.SonucDikdörtgen.Name = "SonucDikdörtgen";
            this.SonucDikdörtgen.Size = new System.Drawing.Size(0, 27);
            this.SonucDikdörtgen.TabIndex = 4;
            // 
            // btnDikdörtgenCH
            // 
            this.btnDikdörtgenCH.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDikdörtgenCH.Location = new System.Drawing.Point(193, 118);
            this.btnDikdörtgenCH.Name = "btnDikdörtgenCH";
            this.btnDikdörtgenCH.Size = new System.Drawing.Size(115, 93);
            this.btnDikdörtgenCH.TabIndex = 7;
            this.btnDikdörtgenCH.Text = "Çevre Hesapla";
            this.btnDikdörtgenCH.UseVisualStyleBackColor = true;
            this.btnDikdörtgenCH.Click += new System.EventHandler(this.btnDikdörtgenCH_Click);
            // 
            // txtDikdörtgenKK
            // 
            this.txtDikdörtgenKK.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDikdörtgenKK.Location = new System.Drawing.Point(257, 63);
            this.txtDikdörtgenKK.Name = "txtDikdörtgenKK";
            this.txtDikdörtgenKK.Size = new System.Drawing.Size(100, 27);
            this.txtDikdörtgenKK.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dikdörgen\'in Kısa Kenarını Giriniz:";
            // 
            // btnDikdörtgenAH
            // 
            this.btnDikdörtgenAH.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDikdörtgenAH.Location = new System.Drawing.Point(67, 118);
            this.btnDikdörtgenAH.Name = "btnDikdörtgenAH";
            this.btnDikdörtgenAH.Size = new System.Drawing.Size(115, 93);
            this.btnDikdörtgenAH.TabIndex = 4;
            this.btnDikdörtgenAH.Text = "Alan Hesapla";
            this.btnDikdörtgenAH.UseVisualStyleBackColor = true;
            this.btnDikdörtgenAH.Click += new System.EventHandler(this.btnDikdörtgenAH_Click);
            // 
            // Labelll
            // 
            this.Labelll.AutoSize = true;
            this.Labelll.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelll.Location = new System.Drawing.Point(6, 22);
            this.Labelll.Name = "Labelll";
            this.Labelll.Size = new System.Drawing.Size(252, 27);
            this.Labelll.TabIndex = 2;
            this.Labelll.Text = "Dikdörgen\'in Uzun Kenarını Giriniz:";
            // 
            // txtDikdörgenUK
            // 
            this.txtDikdörgenUK.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDikdörgenUK.Location = new System.Drawing.Point(251, 22);
            this.txtDikdörgenUK.Name = "txtDikdörgenUK";
            this.txtDikdörgenUK.Size = new System.Drawing.Size(103, 27);
            this.txtDikdörgenUK.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox4.Controls.Add(this.txtYukseklik);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.SonucUcgen);
            this.groupBox4.Controls.Add(this.btnUcgenCH);
            this.groupBox4.Controls.Add(this.btnUcgenAH);
            this.groupBox4.Controls.Add(this.txtUcgenK3);
            this.groupBox4.Controls.Add(this.txtUcgenK2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtUcgenK1);
            this.groupBox4.Location = new System.Drawing.Point(347, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(348, 284);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ÜÇGEN";
            // 
            // txtYukseklik
            // 
            this.txtYukseklik.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYukseklik.Location = new System.Drawing.Point(240, 128);
            this.txtYukseklik.Name = "txtYukseklik";
            this.txtYukseklik.Size = new System.Drawing.Size(100, 27);
            this.txtYukseklik.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Üçgen\'in Yüksekliğini Giriniz:";
            // 
            // SonucUcgen
            // 
            this.SonucUcgen.AutoSize = true;
            this.SonucUcgen.BackColor = System.Drawing.Color.Aquamarine;
            this.SonucUcgen.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SonucUcgen.ForeColor = System.Drawing.Color.Red;
            this.SonucUcgen.Location = new System.Drawing.Point(179, 276);
            this.SonucUcgen.Name = "SonucUcgen";
            this.SonucUcgen.Size = new System.Drawing.Size(0, 27);
            this.SonucUcgen.TabIndex = 11;
            // 
            // btnUcgenCH
            // 
            this.btnUcgenCH.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcgenCH.Location = new System.Drawing.Point(184, 184);
            this.btnUcgenCH.Name = "btnUcgenCH";
            this.btnUcgenCH.Size = new System.Drawing.Size(118, 94);
            this.btnUcgenCH.TabIndex = 10;
            this.btnUcgenCH.Text = "Çevre Hesapla";
            this.btnUcgenCH.UseVisualStyleBackColor = true;
            this.btnUcgenCH.Click += new System.EventHandler(this.btnUcgenCH_Click);
            // 
            // btnUcgenAH
            // 
            this.btnUcgenAH.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcgenAH.Location = new System.Drawing.Point(50, 184);
            this.btnUcgenAH.Name = "btnUcgenAH";
            this.btnUcgenAH.Size = new System.Drawing.Size(118, 94);
            this.btnUcgenAH.TabIndex = 9;
            this.btnUcgenAH.Text = "Alan Hesapla";
            this.btnUcgenAH.UseVisualStyleBackColor = true;
            this.btnUcgenAH.Click += new System.EventHandler(this.btnUcgenAH_Click);
            // 
            // txtUcgenK3
            // 
            this.txtUcgenK3.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUcgenK3.Location = new System.Drawing.Point(228, 92);
            this.txtUcgenK3.Name = "txtUcgenK3";
            this.txtUcgenK3.Size = new System.Drawing.Size(100, 27);
            this.txtUcgenK3.TabIndex = 8;
            // 
            // txtUcgenK2
            // 
            this.txtUcgenK2.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUcgenK2.Location = new System.Drawing.Point(228, 59);
            this.txtUcgenK2.Name = "txtUcgenK2";
            this.txtUcgenK2.Size = new System.Drawing.Size(100, 27);
            this.txtUcgenK2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "Üçgen\'in 3. Kenarını Giriniz:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Üçgen\'in 2. Kenarını Giriniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Üçgen\'in 1. Kenarını Giriniz:";
            // 
            // txtUcgenK1
            // 
            this.txtUcgenK1.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUcgenK1.Location = new System.Drawing.Point(228, 26);
            this.txtUcgenK1.Name = "txtUcgenK1";
            this.txtUcgenK1.Size = new System.Drawing.Size(100, 27);
            this.txtUcgenK1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(707, 597);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKareK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnKareAH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKareCH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDaireYÇ;
        private System.Windows.Forms.Button btnDikdörtgenAH;
        private System.Windows.Forms.Label Labelll;
        private System.Windows.Forms.TextBox txtDikdörgenUK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUcgenK1;
        private System.Windows.Forms.TextBox txtDikdörtgenKK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDaireCH;
        private System.Windows.Forms.Button btnDaireAH;
        private System.Windows.Forms.Button btnDikdörtgenCH;
        private System.Windows.Forms.Button btnUcgenCH;
        private System.Windows.Forms.Button btnUcgenAH;
        private System.Windows.Forms.TextBox txtUcgenK3;
        private System.Windows.Forms.TextBox txtUcgenK2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SonucKare1;
        private System.Windows.Forms.Label SonucDaire;
        private System.Windows.Forms.Label SonucDikdörtgen;
        private System.Windows.Forms.Label SonucUcgen;
        private System.Windows.Forms.TextBox txtYukseklik;
        private System.Windows.Forms.Label label6;
    }
}

