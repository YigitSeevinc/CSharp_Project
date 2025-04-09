namespace Stok_Programı
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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1213, 604);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UrunEkle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox StokEkle;
        private System.Windows.Forms.Button SL_Goster;
        private System.Windows.Forms.Button UKaydet;
        private System.Windows.Forms.TextBox UAdiTextbox;
        private System.Windows.Forms.Label UrunUAdi;
        private System.Windows.Forms.Label Miktar;
        private System.Windows.Forms.Label USecimi;
        private System.Windows.Forms.TextBox Miktartextbox;
        private System.Windows.Forms.ComboBox USecimiCombobox;
        private System.Windows.Forms.Label Beden;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Button Sifirla;
        private System.Windows.Forms.RadioButton Beden3;
        private System.Windows.Forms.RadioButton Beden2;
        private System.Windows.Forms.RadioButton Beden1;
        private System.Windows.Forms.GroupBox StokListesi;
        private System.Windows.Forms.ListBox BListbox;
        private System.Windows.Forms.ListBox MListbox;
        private System.Windows.Forms.ListBox UAListbox;
        private System.Windows.Forms.Label StokBeden;
        private System.Windows.Forms.Label StokMiktar;
        private System.Windows.Forms.Label StokUAdi;
        private System.Windows.Forms.Button TumuSil;
        private System.Windows.Forms.Button SL_Gizle;
    }
}

