namespace deneme_1
{
    partial class kayit
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
            isim = new Label();
            sifre = new Label();
            soyisim = new Label();
            isim_text = new TextBox();
            sifre_text = new TextBox();
            soyisim_text = new TextBox();
            button1 = new Button();
            kullanici_adi_text = new TextBox();
            label1 = new Label();
            Not = new Label();
            SuspendLayout();
            // 
            // isim
            // 
            isim.AutoSize = true;
            isim.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            isim.Location = new Point(262, 139);
            isim.Name = "isim";
            isim.Size = new Size(52, 21);
            isim.TabIndex = 3;
            isim.Text = "İSİM :";
            isim.Click += isim_Click;
            // 
            // sifre
            // 
            sifre.AutoSize = true;
            sifre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sifre.Location = new Point(256, 228);
            sifre.Name = "sifre";
            sifre.Size = new Size(58, 21);
            sifre.TabIndex = 4;
            sifre.Text = "ŞİFRE :";
            sifre.Click += label2_Click;
            // 
            // soyisim
            // 
            soyisim.AutoSize = true;
            soyisim.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            soyisim.Location = new Point(228, 170);
            soyisim.Name = "soyisim";
            soyisim.Size = new Size(86, 21);
            soyisim.TabIndex = 6;
            soyisim.Text = "SOY İSİM :";
            soyisim.Click += soyisim_Click;
            // 
            // isim_text
            // 
            isim_text.Location = new Point(329, 141);
            isim_text.Name = "isim_text";
            isim_text.Size = new Size(194, 23);
            isim_text.TabIndex = 7;
            isim_text.TextChanged += isim_text_TextChanged;
            // 
            // sifre_text
            // 
            sifre_text.Location = new Point(329, 228);
            sifre_text.Name = "sifre_text";
            sifre_text.Size = new Size(194, 23);
            sifre_text.TabIndex = 8;
            sifre_text.TextChanged += sifre_text_TextChanged;
            // 
            // soyisim_text
            // 
            soyisim_text.Location = new Point(329, 170);
            soyisim_text.Name = "soyisim_text";
            soyisim_text.Size = new Size(194, 23);
            soyisim_text.TabIndex = 10;
            soyisim_text.TextChanged += soyisim_text_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(382, 279);
            button1.Name = "button1";
            button1.Size = new Size(78, 44);
            button1.TabIndex = 11;
            button1.Text = "KAYDET ve ÇIK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // kullanici_adi_text
            // 
            kullanici_adi_text.Location = new Point(329, 199);
            kullanici_adi_text.Name = "kullanici_adi_text";
            kullanici_adi_text.Size = new Size(194, 23);
            kullanici_adi_text.TabIndex = 13;
            kullanici_adi_text.TextChanged += kullanici_adi_text_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(185, 199);
            label1.Name = "label1";
            label1.Size = new Size(129, 21);
            label1.TabIndex = 12;
            label1.Text = "KULLANICI ADI :";
            // 
            // Not
            // 
            Not.AutoSize = true;
            Not.BackColor = Color.Red;
            Not.Location = new Point(307, 9);
            Not.Name = "Not";
            Not.Size = new Size(237, 15);
            Not.TabIndex = 14;
            Not.Text = "NOT :    Kullanıcı adı rakamlardan oluşamaz!";
            // 
            // kayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Not);
            Controls.Add(kullanici_adi_text);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(soyisim_text);
            Controls.Add(sifre_text);
            Controls.Add(isim_text);
            Controls.Add(soyisim);
            Controls.Add(sifre);
            Controls.Add(isim);
            Name = "kayit";
            Text = "kayit";
            Load += kayit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label isim;
        private Label sifre;
        private Label soyisim;
        public Button button1;
        private Label label1;
        private Label Not;
        public TextBox isim_text;
        public TextBox sifre_text;
        public TextBox soyisim_text;
        public TextBox kullanici_adi_text;
    }
}