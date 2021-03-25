namespace HR.UI.TMKModulu.Egitimler
{
    partial class EgitimGuncelle
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEgitimler = new System.Windows.Forms.Button();
            this.cbEgitimAdi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbYeniEgitimAdi = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eğitimler:";
            // 
            // btnEgitimler
            // 
            this.btnEgitimler.Location = new System.Drawing.Point(180, 216);
            this.btnEgitimler.Margin = new System.Windows.Forms.Padding(4);
            this.btnEgitimler.Name = "btnEgitimler";
            this.btnEgitimler.Size = new System.Drawing.Size(126, 31);
            this.btnEgitimler.TabIndex = 2;
            this.btnEgitimler.Text = "Eğitim Güncelle";
            this.btnEgitimler.UseVisualStyleBackColor = true;
            this.btnEgitimler.Click += new System.EventHandler(this.btnEgitimler_Click);
            // 
            // cbEgitimAdi
            // 
            this.cbEgitimAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEgitimAdi.FormattingEnabled = true;
            this.cbEgitimAdi.Location = new System.Drawing.Point(161, 46);
            this.cbEgitimAdi.Name = "cbEgitimAdi";
            this.cbEgitimAdi.Size = new System.Drawing.Size(168, 20);
            this.cbEgitimAdi.TabIndex = 3;
            this.cbEgitimAdi.SelectionChangeCommitted += new System.EventHandler(this.cbEgitimAdi_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yeni Eğitim Adı:";
            // 
            // tbYeniEgitimAdi
            // 
            this.tbYeniEgitimAdi.Location = new System.Drawing.Point(161, 140);
            this.tbYeniEgitimAdi.MaxLength = 30;
            this.tbYeniEgitimAdi.Name = "tbYeniEgitimAdi";
            this.tbYeniEgitimAdi.Size = new System.Drawing.Size(168, 20);
            this.tbYeniEgitimAdi.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(375, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(146, 172);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Eğitim Seviyesi:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 20);
            this.comboBox1.TabIndex = 8;
            // 
            // EgitimGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 305);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbYeniEgitimAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEgitimAdi);
            this.Controls.Add(this.btnEgitimler);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EgitimGuncelle";
            this.Text = "Egitim Güncelle";
            this.Load += new System.EventHandler(this.EgitimSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEgitimler;
        private System.Windows.Forms.ComboBox cbEgitimAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbYeniEgitimAdi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}