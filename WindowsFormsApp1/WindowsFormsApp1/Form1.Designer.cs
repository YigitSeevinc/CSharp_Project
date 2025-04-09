namespace WindowsFormsApp1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAH = new System.Windows.Forms.Button();
            this.lblKS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDikUK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDikKK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUK3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUK2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUK1 = new System.Windows.Forms.TextBox();
            this.lblDS = new System.Windows.Forms.Label();
            this.lblUS = new System.Windows.Forms.Label();
            this.lblDikS = new System.Windows.Forms.Label();
            this.btnCH = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKK);
            this.groupBox1.Controls.Add(this.lblKS);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kare";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Controls.Add(this.lblDikS);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDikKK);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDikUK);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(366, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dikdörtgen";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox3.Controls.Add(this.lblUS);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtUK1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtUK2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtUK3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtUh);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 229);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Üçgen";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox4.Controls.Add(this.lblDS);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtDr);
            this.groupBox4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(366, 247);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(348, 229);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Daire";
            // 
            // btnAH
            // 
            this.btnAH.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAH.Location = new System.Drawing.Point(784, 104);
            this.btnAH.Name = "btnAH";
            this.btnAH.Size = new System.Drawing.Size(104, 100);
            this.btnAH.TabIndex = 7;
            this.btnAH.Text = "ALAN HESAPLA";
            this.btnAH.UseVisualStyleBackColor = true;
            this.btnAH.Click += new System.EventHandler(this.btnAH_Click);
            // 
            // lblKS
            // 
            this.lblKS.AutoSize = true;
            this.lblKS.BackColor = System.Drawing.Color.Maroon;
            this.lblKS.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKS.ForeColor = System.Drawing.Color.White;
            this.lblKS.Location = new System.Drawing.Point(175, 175);
            this.lblKS.Name = "lblKS";
            this.lblKS.Size = new System.Drawing.Size(0, 20);
            this.lblKS.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(43, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Karenin kenaırını giriniz: ";
            // 
            // txtKK
            // 
            this.txtKK.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKK.Location = new System.Drawing.Point(203, 92);
            this.txtKK.Name = "txtKK";
            this.txtKK.Size = new System.Drawing.Size(100, 26);
            this.txtKK.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dikdörtgenin uzun kenarını giriniz";
            // 
            // txtDikUK
            // 
            this.txtDikUK.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDikUK.Location = new System.Drawing.Point(231, 60);
            this.txtDikUK.Name = "txtDikUK";
            this.txtDikUK.Size = new System.Drawing.Size(100, 26);
            this.txtDikUK.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dikdörtgenin kısa kenarını giriniz: ";
            // 
            // txtDikKK
            // 
            this.txtDikKK.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDikKK.Location = new System.Drawing.Point(231, 123);
            this.txtDikKK.Name = "txtDikKK";
            this.txtDikKK.Size = new System.Drawing.Size(100, 26);
            this.txtDikKK.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(18, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Üçgenin yüksekliğini giriniz: ";
            // 
            // txtUh
            // 
            this.txtUh.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUh.Location = new System.Drawing.Point(203, 153);
            this.txtUh.Name = "txtUh";
            this.txtUh.Size = new System.Drawing.Size(100, 26);
            this.txtUh.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(46, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dairenin yarıçapını giriniz: ";
            // 
            // txtDr
            // 
            this.txtDr.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDr.Location = new System.Drawing.Point(216, 93);
            this.txtDr.Name = "txtDr";
            this.txtDr.Size = new System.Drawing.Size(100, 26);
            this.txtDr.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(31, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Üçgenin tabanını  giriniz:";
            // 
            // txtUK3
            // 
            this.txtUK3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUK3.Location = new System.Drawing.Point(203, 93);
            this.txtUK3.Name = "txtUK3";
            this.txtUK3.Size = new System.Drawing.Size(100, 26);
            this.txtUK3.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(31, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Üçgenin 2. kenarını giriniz:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtUK2
            // 
            this.txtUK2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUK2.Location = new System.Drawing.Point(203, 57);
            this.txtUK2.Name = "txtUK2";
            this.txtUK2.Size = new System.Drawing.Size(100, 26);
            this.txtUK2.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(33, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Üçgenin 1. kenarını giriniz:";
            // 
            // txtUK1
            // 
            this.txtUK1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUK1.Location = new System.Drawing.Point(203, 25);
            this.txtUK1.Name = "txtUK1";
            this.txtUK1.Size = new System.Drawing.Size(100, 26);
            this.txtUK1.TabIndex = 17;
            // 
            // lblDS
            // 
            this.lblDS.AutoSize = true;
            this.lblDS.BackColor = System.Drawing.Color.Maroon;
            this.lblDS.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDS.ForeColor = System.Drawing.Color.White;
            this.lblDS.Location = new System.Drawing.Point(146, 159);
            this.lblDS.Name = "lblDS";
            this.lblDS.Size = new System.Drawing.Size(0, 20);
            this.lblDS.TabIndex = 9;
            // 
            // lblUS
            // 
            this.lblUS.AutoSize = true;
            this.lblUS.BackColor = System.Drawing.Color.Maroon;
            this.lblUS.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUS.ForeColor = System.Drawing.Color.White;
            this.lblUS.Location = new System.Drawing.Point(145, 194);
            this.lblUS.Name = "lblUS";
            this.lblUS.Size = new System.Drawing.Size(0, 20);
            this.lblUS.TabIndex = 10;
            // 
            // lblDikS
            // 
            this.lblDikS.AutoSize = true;
            this.lblDikS.BackColor = System.Drawing.Color.Maroon;
            this.lblDikS.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDikS.ForeColor = System.Drawing.Color.White;
            this.lblDikS.Location = new System.Drawing.Point(137, 175);
            this.lblDikS.Name = "lblDikS";
            this.lblDikS.Size = new System.Drawing.Size(0, 20);
            this.lblDikS.TabIndex = 11;
            // 
            // btnCH
            // 
            this.btnCH.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCH.Location = new System.Drawing.Point(784, 269);
            this.btnCH.Name = "btnCH";
            this.btnCH.Size = new System.Drawing.Size(104, 100);
            this.btnCH.TabIndex = 8;
            this.btnCH.Text = "ÇEVRE HESAPLA";
            this.btnCH.UseVisualStyleBackColor = true;
            this.btnCH.Click += new System.EventHandler(this.btnCH_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(947, 492);
            this.Controls.Add(this.btnCH);
            this.Controls.Add(this.btnAH);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ana Ekran";
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAH;
        private System.Windows.Forms.Label lblKS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDikKK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDikUK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUK1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUK2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUK3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDr;
        private System.Windows.Forms.Label lblDikS;
        private System.Windows.Forms.Label lblUS;
        private System.Windows.Forms.Label lblDS;
        private System.Windows.Forms.Button btnCH;
    }
}

