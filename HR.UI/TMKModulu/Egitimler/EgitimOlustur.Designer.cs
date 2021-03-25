namespace HR.UI.TMKModulu.Egitimler
{
    partial class EgitimOlustur
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
            this.tbEgitim = new System.Windows.Forms.TextBox();
            this.btnEgitim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eğitim Adı:";
            // 
            // tbEgitim
            // 
            this.tbEgitim.Location = new System.Drawing.Point(213, 65);
            this.tbEgitim.Margin = new System.Windows.Forms.Padding(4);
            this.tbEgitim.MaxLength = 30;
            this.tbEgitim.Name = "tbEgitim";
            this.tbEgitim.Size = new System.Drawing.Size(160, 20);
            this.tbEgitim.TabIndex = 1;
            // 
            // btnEgitim
            // 
            this.btnEgitim.Location = new System.Drawing.Point(213, 170);
            this.btnEgitim.Margin = new System.Windows.Forms.Padding(4);
            this.btnEgitim.Name = "btnEgitim";
            this.btnEgitim.Size = new System.Drawing.Size(147, 34);
            this.btnEgitim.TabIndex = 2;
            this.btnEgitim.Text = "Eğitim Oluştur";
            this.btnEgitim.UseVisualStyleBackColor = true;
            this.btnEgitim.Click += new System.EventHandler(this.btnEgitim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eğitim Seviyesi";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(213, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // EgitimOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 250);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEgitim);
            this.Controls.Add(this.tbEgitim);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EgitimOlustur";
            this.Text = "Eğitim Oluştur";
            this.Load += new System.EventHandler(this.EgitimOlustur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEgitim;
        private System.Windows.Forms.Button btnEgitim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}