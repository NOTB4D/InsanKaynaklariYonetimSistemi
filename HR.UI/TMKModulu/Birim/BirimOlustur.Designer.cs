namespace HR.UI.TMKModulu.Birim
{
    partial class BirimOlustur
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBirimAdi = new System.Windows.Forms.TextBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBirimMuduru = new System.Windows.Forms.TextBox();
            this.tbYonetici = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Birim Adı Giriniz :";
            // 
            // tbBirimAdi
            // 
            this.tbBirimAdi.Location = new System.Drawing.Point(299, 58);
            this.tbBirimAdi.MaxLength = 25;
            this.tbBirimAdi.Multiline = true;
            this.tbBirimAdi.Name = "tbBirimAdi";
            this.tbBirimAdi.Size = new System.Drawing.Size(172, 20);
            this.tbBirimAdi.TabIndex = 0;
            this.tbBirimAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBirimAdi_KeyPress);
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(340, 244);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(95, 37);
            this.btnOlustur.TabIndex = 4;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Birim Müdürü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yönetici:";
            // 
            // tbBirimMuduru
            // 
            this.tbBirimMuduru.Location = new System.Drawing.Point(299, 100);
            this.tbBirimMuduru.MaxLength = 35;
            this.tbBirimMuduru.Name = "tbBirimMuduru";
            this.tbBirimMuduru.Size = new System.Drawing.Size(172, 21);
            this.tbBirimMuduru.TabIndex = 1;
            this.tbBirimMuduru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBirimMuduru_KeyPress);
            // 
            // tbYonetici
            // 
            this.tbYonetici.Location = new System.Drawing.Point(299, 145);
            this.tbYonetici.MaxLength = 35;
            this.tbYonetici.Name = "tbYonetici";
            this.tbYonetici.Size = new System.Drawing.Size(172, 21);
            this.tbYonetici.TabIndex = 2;
            this.tbYonetici.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbYonetici_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Şube Adı:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(299, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // BirimOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 357);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbYonetici);
            this.Controls.Add(this.tbBirimMuduru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.tbBirimAdi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BirimOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Birim Oluştur";
            this.Load += new System.EventHandler(this.BirimOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBirimAdi;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbYonetici;
        private System.Windows.Forms.TextBox tbBirimMuduru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}