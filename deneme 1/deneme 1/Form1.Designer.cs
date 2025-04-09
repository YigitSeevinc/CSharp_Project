namespace deneme_1
{
    partial class ana_ekran
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(243, 192);
            button1.Name = "button1";
            button1.Size = new Size(89, 48);
            button1.TabIndex = 0;
            button1.Text = "OTURUM AÇ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(337, 192);
            button2.Name = "button2";
            button2.Size = new Size(89, 48);
            button2.TabIndex = 1;
            button2.Text = "KAYIT OL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(210, 99);
            label1.Name = "label1";
            label1.Size = new Size(129, 21);
            label1.TabIndex = 2;
            label1.Text = "KULLANICI ADI :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(337, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(90, 22);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(337, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(90, 22);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(271, 141);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 5;
            label2.Text = "ŞİFRE :";
            // 
            // ana_ekran
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(666, 399);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ana_ekran";
            Text = "ana_ekran";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
    }
}