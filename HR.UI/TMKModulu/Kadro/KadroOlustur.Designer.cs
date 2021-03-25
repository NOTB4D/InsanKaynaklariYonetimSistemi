namespace HR.UI.TMKModulu.Kadro
{
    partial class KadroOlustur
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
            this.cbSube = new System.Windows.Forms.ComboBox();
            this.nudPersonelSayisi = new System.Windows.Forms.NumericUpDown();
            this.btnCreate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudPersonelSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Sayısı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şube :";
            // 
            // cbSube
            // 
            this.cbSube.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSube.FormattingEnabled = true;
            this.cbSube.Location = new System.Drawing.Point(165, 64);
            this.cbSube.Name = "cbSube";
            this.cbSube.Size = new System.Drawing.Size(140, 21);
            this.cbSube.TabIndex = 1;
            this.cbSube.SelectionChangeCommitted += new System.EventHandler(this.cbSube_SelectionChangeCommitted);
            // 
            // nudPersonelSayisi
            // 
            this.nudPersonelSayisi.Location = new System.Drawing.Point(165, 21);
            this.nudPersonelSayisi.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPersonelSayisi.Name = "nudPersonelSayisi";
            this.nudPersonelSayisi.Size = new System.Drawing.Size(141, 21);
            this.nudPersonelSayisi.TabIndex = 0;
            this.nudPersonelSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(198, 99);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(66, 33);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Oluştur";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // KadroOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 147);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.nudPersonelSayisi);
            this.Controls.Add(this.cbSube);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KadroOlustur";
            this.Text = "Kadro Oluştur";
            this.Load += new System.EventHandler(this.KadroOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPersonelSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSube;
        private System.Windows.Forms.NumericUpDown nudPersonelSayisi;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}