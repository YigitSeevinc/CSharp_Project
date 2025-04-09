namespace sınav1_stok_programı
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
            this.Urun_Ekle_Groupbox = new System.Windows.Forms.GroupBox();
            this.Stok_Ekle_Groupbox = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Stok_Liste_Groupbox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Urun_Adi_Textbox = new System.Windows.Forms.TextBox();
            this.Urun_Kaydet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.Miktar_Textbox = new System.Windows.Forms.TextBox();
            this.Beden1 = new System.Windows.Forms.RadioButton();
            this.Beden2 = new System.Windows.Forms.RadioButton();
            this.Beden3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Liste1 = new System.Windows.Forms.ListBox();
            this.Liste2 = new System.Windows.Forms.ListBox();
            this.Liste3 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Tumunu_Sil = new System.Windows.Forms.Button();
            this.Urun_Ekle_Groupbox.SuspendLayout();
            this.Stok_Ekle_Groupbox.SuspendLayout();
            this.Stok_Liste_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Urun_Ekle_Groupbox
            // 
            this.Urun_Ekle_Groupbox.Controls.Add(this.button2);
            this.Urun_Ekle_Groupbox.Controls.Add(this.Urun_Kaydet);
            this.Urun_Ekle_Groupbox.Controls.Add(this.Urun_Adi_Textbox);
            this.Urun_Ekle_Groupbox.Controls.Add(this.label1);
            this.Urun_Ekle_Groupbox.Location = new System.Drawing.Point(12, 12);
            this.Urun_Ekle_Groupbox.Name = "Urun_Ekle_Groupbox";
            this.Urun_Ekle_Groupbox.Size = new System.Drawing.Size(314, 203);
            this.Urun_Ekle_Groupbox.TabIndex = 0;
            this.Urun_Ekle_Groupbox.TabStop = false;
            this.Urun_Ekle_Groupbox.Text = "Ürün Ekle";
            this.Urun_Ekle_Groupbox.Enter += new System.EventHandler(this.Urun_Ekle_Groupbox_Enter);
            // 
            // Stok_Ekle_Groupbox
            // 
            this.Stok_Ekle_Groupbox.Controls.Add(this.button4);
            this.Stok_Ekle_Groupbox.Controls.Add(this.button1);
            this.Stok_Ekle_Groupbox.Controls.Add(this.Beden3);
            this.Stok_Ekle_Groupbox.Controls.Add(this.Beden2);
            this.Stok_Ekle_Groupbox.Controls.Add(this.Beden1);
            this.Stok_Ekle_Groupbox.Controls.Add(this.Miktar_Textbox);
            this.Stok_Ekle_Groupbox.Controls.Add(this.comboBox);
            this.Stok_Ekle_Groupbox.Controls.Add(this.label4);
            this.Stok_Ekle_Groupbox.Controls.Add(this.label3);
            this.Stok_Ekle_Groupbox.Controls.Add(this.label2);
            this.Stok_Ekle_Groupbox.Location = new System.Drawing.Point(338, 12);
            this.Stok_Ekle_Groupbox.Name = "Stok_Ekle_Groupbox";
            this.Stok_Ekle_Groupbox.Size = new System.Drawing.Size(314, 203);
            this.Stok_Ekle_Groupbox.TabIndex = 1;
            this.Stok_Ekle_Groupbox.TabStop = false;
            this.Stok_Ekle_Groupbox.Text = "Stok Ekle";
            // 
            // Stok_Liste_Groupbox
            // 
            this.Stok_Liste_Groupbox.Controls.Add(this.Tumunu_Sil);
            this.Stok_Liste_Groupbox.Controls.Add(this.label7);
            this.Stok_Liste_Groupbox.Controls.Add(this.label6);
            this.Stok_Liste_Groupbox.Controls.Add(this.label5);
            this.Stok_Liste_Groupbox.Controls.Add(this.Liste3);
            this.Stok_Liste_Groupbox.Controls.Add(this.Liste2);
            this.Stok_Liste_Groupbox.Controls.Add(this.Liste1);
            this.Stok_Liste_Groupbox.Location = new System.Drawing.Point(12, 221);
            this.Stok_Liste_Groupbox.Name = "Stok_Liste_Groupbox";
            this.Stok_Liste_Groupbox.Size = new System.Drawing.Size(640, 282);
            this.Stok_Liste_Groupbox.TabIndex = 1;
            this.Stok_Liste_Groupbox.TabStop = false;
            this.Stok_Liste_Groupbox.Text = "Stok Listesi";
            this.Stok_Liste_Groupbox.Enter += new System.EventHandler(this.Stok_Liste_Groupbox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // Urun_Adi_Textbox
            // 
            this.Urun_Adi_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Urun_Adi_Textbox.Location = new System.Drawing.Point(102, 33);
            this.Urun_Adi_Textbox.Name = "Urun_Adi_Textbox";
            this.Urun_Adi_Textbox.Size = new System.Drawing.Size(100, 22);
            this.Urun_Adi_Textbox.TabIndex = 1;
            // 
            // Urun_Kaydet
            // 
            this.Urun_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Urun_Kaydet.Location = new System.Drawing.Point(208, 32);
            this.Urun_Kaydet.Name = "Urun_Kaydet";
            this.Urun_Kaydet.Size = new System.Drawing.Size(106, 44);
            this.Urun_Kaydet.TabIndex = 2;
            this.Urun_Kaydet.Text = "Ürün Kaydet";
            this.Urun_Kaydet.UseVisualStyleBackColor = true;
            this.Urun_Kaydet.Click += new System.EventHandler(this.Urun_Kaydet_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(92, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 66);
            this.button2.TabIndex = 3;
            this.button2.Text = "Stok Listesi Göster/Gizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(74, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Miktarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(73, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Beden";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(136, 31);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 8;
            // 
            // Miktar_Textbox
            // 
            this.Miktar_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Miktar_Textbox.Location = new System.Drawing.Point(136, 68);
            this.Miktar_Textbox.Name = "Miktar_Textbox";
            this.Miktar_Textbox.Size = new System.Drawing.Size(121, 22);
            this.Miktar_Textbox.TabIndex = 5;
            // 
            // Beden1
            // 
            this.Beden1.AutoSize = true;
            this.Beden1.Location = new System.Drawing.Point(134, 110);
            this.Beden1.Name = "Beden1";
            this.Beden1.Size = new System.Drawing.Size(37, 17);
            this.Beden1.TabIndex = 9;
            this.Beden1.TabStop = true;
            this.Beden1.Text = "37";
            this.Beden1.UseVisualStyleBackColor = true;
            // 
            // Beden2
            // 
            this.Beden2.AutoSize = true;
            this.Beden2.Location = new System.Drawing.Point(177, 110);
            this.Beden2.Name = "Beden2";
            this.Beden2.Size = new System.Drawing.Size(37, 17);
            this.Beden2.TabIndex = 10;
            this.Beden2.TabStop = true;
            this.Beden2.Text = "38";
            this.Beden2.UseVisualStyleBackColor = true;
            // 
            // Beden3
            // 
            this.Beden3.AutoSize = true;
            this.Beden3.Location = new System.Drawing.Point(220, 110);
            this.Beden3.Name = "Beden3";
            this.Beden3.Size = new System.Drawing.Size(37, 17);
            this.Beden3.TabIndex = 11;
            this.Beden3.TabStop = true;
            this.Beden3.Text = "39";
            this.Beden3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(220, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(126, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Sıfırla";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Liste1
            // 
            this.Liste1.FormattingEnabled = true;
            this.Liste1.Location = new System.Drawing.Point(77, 66);
            this.Liste1.Name = "Liste1";
            this.Liste1.Size = new System.Drawing.Size(205, 160);
            this.Liste1.TabIndex = 0;
            this.Liste1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Liste2
            // 
            this.Liste2.FormattingEnabled = true;
            this.Liste2.Location = new System.Drawing.Point(326, 66);
            this.Liste2.Name = "Liste2";
            this.Liste2.Size = new System.Drawing.Size(96, 160);
            this.Liste2.TabIndex = 1;
            // 
            // Liste3
            // 
            this.Liste3.FormattingEnabled = true;
            this.Liste3.Location = new System.Drawing.Point(462, 66);
            this.Liste3.Name = "Liste3";
            this.Liste3.Size = new System.Drawing.Size(96, 160);
            this.Liste3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(74, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ürün Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(323, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Miktarı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(459, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Beden";
            // 
            // Tumunu_Sil
            // 
            this.Tumunu_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tumunu_Sil.Location = new System.Drawing.Point(452, 245);
            this.Tumunu_Sil.Name = "Tumunu_Sil";
            this.Tumunu_Sil.Size = new System.Drawing.Size(126, 31);
            this.Tumunu_Sil.TabIndex = 17;
            this.Tumunu_Sil.Text = "Tümünü Sil";
            this.Tumunu_Sil.UseVisualStyleBackColor = true;
            this.Tumunu_Sil.Click += new System.EventHandler(this.Tumunu_Sil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 515);
            this.Controls.Add(this.Stok_Liste_Groupbox);
            this.Controls.Add(this.Stok_Ekle_Groupbox);
            this.Controls.Add(this.Urun_Ekle_Groupbox);
            this.Name = "Form1";
            this.Text = "Stok Programı (Quiz)";
            this.Urun_Ekle_Groupbox.ResumeLayout(false);
            this.Urun_Ekle_Groupbox.PerformLayout();
            this.Stok_Ekle_Groupbox.ResumeLayout(false);
            this.Stok_Ekle_Groupbox.PerformLayout();
            this.Stok_Liste_Groupbox.ResumeLayout(false);
            this.Stok_Liste_Groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Urun_Ekle_Groupbox;
        private System.Windows.Forms.GroupBox Stok_Ekle_Groupbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox Stok_Liste_Groupbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Urun_Kaydet;
        private System.Windows.Forms.TextBox Urun_Adi_Textbox;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Beden1;
        private System.Windows.Forms.TextBox Miktar_Textbox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Beden3;
        private System.Windows.Forms.RadioButton Beden2;
        private System.Windows.Forms.ListBox Liste1;
        private System.Windows.Forms.ListBox Liste3;
        private System.Windows.Forms.ListBox Liste2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Tumunu_Sil;
    }
}

