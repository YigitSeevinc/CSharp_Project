namespace Stok_Sistemi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTaksitBelirle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUrunSatısı = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtUrunAdi = new System.Windows.Forms.RichTextBox();
            this.txtTaksitMiktari = new System.Windows.Forms.RichTextBox();
            this.txtMusteriAdiTaksit = new System.Windows.Forms.RichTextBox();
            this.txtUrunMiktariSat = new System.Windows.Forms.RichTextBox();
            this.txtUrunAdiSat = new System.Windows.Forms.RichTextBox();
            this.txtMusteriAdiSat = new System.Windows.Forms.RichTextBox();
            this.txtMusteriAdi = new System.Windows.Forms.RichTextBox();
            this.txtUrunFiyati = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1208, 667);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkKhaki;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1200, 641);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ana Menü";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.txtTaksitMiktari);
            this.groupBox4.Controls.Add(this.txtMusteriAdiTaksit);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btnTaksitBelirle);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(885, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(309, 629);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Taksitlendirme";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(111, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 101);
            this.button1.TabIndex = 50;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(36, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 24);
            this.label8.TabIndex = 48;
            this.label8.Text = "Taksit Miktarı:";
            // 
            // btnTaksitBelirle
            // 
            this.btnTaksitBelirle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaksitBelirle.Location = new System.Drawing.Point(111, 179);
            this.btnTaksitBelirle.Name = "btnTaksitBelirle";
            this.btnTaksitBelirle.Size = new System.Drawing.Size(110, 101);
            this.btnTaksitBelirle.TabIndex = 49;
            this.btnTaksitBelirle.Text = "Taksit Belirle";
            this.btnTaksitBelirle.UseVisualStyleBackColor = true;
            this.btnTaksitBelirle.Click += new System.EventHandler(this.btnTaksitBelirle_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(48, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 47;
            this.label7.Text = "Müşteri Adı:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtUrunMiktariSat);
            this.groupBox3.Controls.Add(this.txtUrunAdiSat);
            this.groupBox3.Controls.Add(this.txtMusteriAdiSat);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnUrunSatısı);
            this.groupBox3.Location = new System.Drawing.Point(551, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 629);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Satışı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(49, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 46;
            this.label6.Text = "Ürün Miktarı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(74, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "Ürün Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(57, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 44;
            this.label4.Text = "Müşteri adı:";
            // 
            // btnUrunSatısı
            // 
            this.btnUrunSatısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSatısı.Location = new System.Drawing.Point(139, 179);
            this.btnUrunSatısı.Name = "btnUrunSatısı";
            this.btnUrunSatısı.Size = new System.Drawing.Size(110, 101);
            this.btnUrunSatısı.TabIndex = 38;
            this.btnUrunSatısı.Text = "Ürün Satışı";
            this.btnUrunSatısı.UseVisualStyleBackColor = true;
            this.btnUrunSatısı.Click += new System.EventHandler(this.btnUrunSatısı_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMusteriAdi);
            this.groupBox2.Controls.Add(this.btnMusteriEkle);
            this.groupBox2.Location = new System.Drawing.Point(276, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 629);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Ekleme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Müşerti adı:";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkle.Location = new System.Drawing.Point(83, 182);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(110, 101);
            this.btnMusteriEkle.TabIndex = 33;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUrunFiyati);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnUrunEkle);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 629);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün ekleme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Ürün Fiyatı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ürün Adı:";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.Location = new System.Drawing.Point(69, 182);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(110, 101);
            this.btnUrunEkle.TabIndex = 32;
            this.btnUrunEkle.Text = "ürün ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkKhaki;
            this.tabPage2.Controls.Add(this.dataGridView4);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1200, 641);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ürün ve Müşteriler Listesi";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.Olive;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(1061, 120);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView4.Size = new System.Drawing.Size(112, 349);
            this.dataGridView4.TabIndex = 3;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.Olive;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(681, 120);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView3.Size = new System.Drawing.Size(374, 349);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Olive;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(444, 120);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Size = new System.Drawing.Size(231, 349);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Olive;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(402, 349);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(128, 73);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 27);
            this.txtUrunAdi.TabIndex = 37;
            this.txtUrunAdi.Text = "";
            // 
            // txtTaksitMiktari
            // 
            this.txtTaksitMiktari.Location = new System.Drawing.Point(163, 101);
            this.txtTaksitMiktari.Name = "txtTaksitMiktari";
            this.txtTaksitMiktari.Size = new System.Drawing.Size(100, 27);
            this.txtTaksitMiktari.TabIndex = 38;
            this.txtTaksitMiktari.Text = "";
            // 
            // txtMusteriAdiTaksit
            // 
            this.txtMusteriAdiTaksit.Location = new System.Drawing.Point(163, 72);
            this.txtMusteriAdiTaksit.Name = "txtMusteriAdiTaksit";
            this.txtMusteriAdiTaksit.Size = new System.Drawing.Size(100, 27);
            this.txtMusteriAdiTaksit.TabIndex = 39;
            this.txtMusteriAdiTaksit.Text = "";
            // 
            // txtUrunMiktariSat
            // 
            this.txtUrunMiktariSat.Location = new System.Drawing.Point(169, 120);
            this.txtUrunMiktariSat.Name = "txtUrunMiktariSat";
            this.txtUrunMiktariSat.Size = new System.Drawing.Size(100, 27);
            this.txtUrunMiktariSat.TabIndex = 40;
            this.txtUrunMiktariSat.Text = "";
            // 
            // txtUrunAdiSat
            // 
            this.txtUrunAdiSat.Location = new System.Drawing.Point(169, 91);
            this.txtUrunAdiSat.Name = "txtUrunAdiSat";
            this.txtUrunAdiSat.Size = new System.Drawing.Size(100, 27);
            this.txtUrunAdiSat.TabIndex = 41;
            this.txtUrunAdiSat.Text = "";
            // 
            // txtMusteriAdiSat
            // 
            this.txtMusteriAdiSat.Location = new System.Drawing.Point(169, 62);
            this.txtMusteriAdiSat.Name = "txtMusteriAdiSat";
            this.txtMusteriAdiSat.Size = new System.Drawing.Size(100, 27);
            this.txtMusteriAdiSat.TabIndex = 42;
            this.txtMusteriAdiSat.Text = "";
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(132, 70);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(100, 27);
            this.txtMusteriAdi.TabIndex = 43;
            this.txtMusteriAdi.Text = "";
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Location = new System.Drawing.Point(128, 102);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(100, 27);
            this.txtUrunFiyati.TabIndex = 44;
            this.txtUrunFiyati.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1232, 691);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "stok programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUrunSatısı;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUrunEkle;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTaksitBelirle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox txtUrunAdi;
        private System.Windows.Forms.RichTextBox txtUrunFiyati;
        private System.Windows.Forms.RichTextBox txtMusteriAdi;
        private System.Windows.Forms.RichTextBox txtMusteriAdiSat;
        private System.Windows.Forms.RichTextBox txtUrunAdiSat;
        private System.Windows.Forms.RichTextBox txtUrunMiktariSat;
        private System.Windows.Forms.RichTextBox txtMusteriAdiTaksit;
        private System.Windows.Forms.RichTextBox txtTaksitMiktari;
    }
}

