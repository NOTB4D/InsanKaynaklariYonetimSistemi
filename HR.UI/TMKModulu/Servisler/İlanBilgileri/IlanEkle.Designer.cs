namespace HR.UI.TMKModulu.Servisler.İlanBilgileri
{
    partial class IlanEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IlanEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSirketAdi = new System.Windows.Forms.ComboBox();
            this.cbSubeAdi = new System.Windows.Forms.ComboBox();
            this.tbAciklama = new System.Windows.Forms.TextBox();
            this.tbPersonelSayi = new System.Windows.Forms.TextBox();
            this.tbIlan = new System.Windows.Forms.TextBox();
            this.btEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlan Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alınacak Personel Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Acıklama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şirket Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şube Adı:";
            // 
            // cbSirketAdi
            // 
            this.cbSirketAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSirketAdi.FormattingEnabled = true;
            this.cbSirketAdi.Location = new System.Drawing.Point(284, 140);
            this.cbSirketAdi.Name = "cbSirketAdi";
            this.cbSirketAdi.Size = new System.Drawing.Size(206, 22);
            this.cbSirketAdi.TabIndex = 5;
            this.cbSirketAdi.SelectionChangeCommitted += new System.EventHandler(this.cbSirketAdi_SelectionChangeCommitted);
            // 
            // cbSubeAdi
            // 
            this.cbSubeAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubeAdi.FormattingEnabled = true;
            this.cbSubeAdi.Location = new System.Drawing.Point(284, 192);
            this.cbSubeAdi.Name = "cbSubeAdi";
            this.cbSubeAdi.Size = new System.Drawing.Size(206, 22);
            this.cbSubeAdi.TabIndex = 6;
            this.cbSubeAdi.SelectionChangeCommitted += new System.EventHandler(this.cbSubeAdi_SelectionChangeCommitted);
            // 
            // tbAciklama
            // 
            this.tbAciklama.Location = new System.Drawing.Point(284, 253);
            this.tbAciklama.Multiline = true;
            this.tbAciklama.Name = "tbAciklama";
            this.tbAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAciklama.Size = new System.Drawing.Size(206, 100);
            this.tbAciklama.TabIndex = 7;
            // 
            // tbPersonelSayi
            // 
            this.tbPersonelSayi.Location = new System.Drawing.Point(284, 85);
            this.tbPersonelSayi.Name = "tbPersonelSayi";
            this.tbPersonelSayi.Size = new System.Drawing.Size(206, 22);
            this.tbPersonelSayi.TabIndex = 8;
            // 
            // tbIlan
            // 
            this.tbIlan.Location = new System.Drawing.Point(284, 28);
            this.tbIlan.Name = "tbIlan";
            this.tbIlan.Size = new System.Drawing.Size(206, 22);
            this.tbIlan.TabIndex = 9;
            // 
            // btEkle
            // 
            this.btEkle.Location = new System.Drawing.Point(284, 376);
            this.btEkle.Name = "btEkle";
            this.btEkle.Size = new System.Drawing.Size(206, 23);
            this.btEkle.TabIndex = 10;
            this.btEkle.Text = "Ekle";
            this.btEkle.UseVisualStyleBackColor = true;
            this.btEkle.Click += new System.EventHandler(this.btEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 271);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // IlanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(521, 428);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btEkle);
            this.Controls.Add(this.tbIlan);
            this.Controls.Add(this.tbPersonelSayi);
            this.Controls.Add(this.tbAciklama);
            this.Controls.Add(this.cbSubeAdi);
            this.Controls.Add(this.cbSirketAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IlanEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlan Ekle";
            this.Load += new System.EventHandler(this.IlanEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSirketAdi;
        private System.Windows.Forms.ComboBox cbSubeAdi;
        private System.Windows.Forms.TextBox tbAciklama;
        private System.Windows.Forms.TextBox tbPersonelSayi;
        private System.Windows.Forms.TextBox tbIlan;
        private System.Windows.Forms.Button btEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}