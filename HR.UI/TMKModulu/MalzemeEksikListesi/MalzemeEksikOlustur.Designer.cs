namespace HR.UI.TMKModulu.MalzemeEksikListesi
{
    partial class MalzemeEksikOlustur
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSection = new System.Windows.Forms.ComboBox();
            this.cbRequired = new System.Windows.Forms.ComboBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lstMalzemeAdi = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şube Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Malzeme Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "İstek Tipi :";
            // 
            // cbSection
            // 
            this.cbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSection.FormattingEnabled = true;
            this.cbSection.Location = new System.Drawing.Point(123, 37);
            this.cbSection.Name = "cbSection";
            this.cbSection.Size = new System.Drawing.Size(140, 21);
            this.cbSection.TabIndex = 4;
            this.cbSection.SelectionChangeCommitted += new System.EventHandler(this.cbSection_SelectionChangeCommitted);
            // 
            // cbRequired
            // 
            this.cbRequired.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRequired.FormattingEnabled = true;
            this.cbRequired.Location = new System.Drawing.Point(123, 261);
            this.cbRequired.Name = "cbRequired";
            this.cbRequired.Size = new System.Drawing.Size(140, 21);
            this.cbRequired.TabIndex = 7;
            this.cbRequired.SelectionChangeCommitted += new System.EventHandler(this.cbRequired_SelectionChangeCommitted);
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(151, 325);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(77, 31);
            this.btnOlustur.TabIndex = 8;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // lstMalzemeAdi
            // 
            this.lstMalzemeAdi.FormattingEnabled = true;
            this.lstMalzemeAdi.Location = new System.Drawing.Point(123, 87);
            this.lstMalzemeAdi.Name = "lstMalzemeAdi";
            this.lstMalzemeAdi.ScrollAlwaysVisible = true;
            this.lstMalzemeAdi.Size = new System.Drawing.Size(140, 147);
            this.lstMalzemeAdi.TabIndex = 9;
            this.lstMalzemeAdi.SelectedIndexChanged += new System.EventHandler(this.lstMalzemeAdi_SelectedIndexChanged);
            // 
            // MalzemeEksikOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 403);
            this.Controls.Add(this.lstMalzemeAdi);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.cbRequired);
            this.Controls.Add(this.cbSection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MalzemeEksikOlustur";
            this.Text = "Malzeme Eksik Listesi Oluştur";
            this.Load += new System.EventHandler(this.MalzemeEksikOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSection;
        private System.Windows.Forms.ComboBox cbRequired;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox lstMalzemeAdi;
    }
}