namespace HR.UI.TMKModulu.Istek
{
    partial class IstekTipiSil
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
            this.lstIstekTipi = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İstek Tipi :";
            // 
            // lstIstekTipi
            // 
            this.lstIstekTipi.FormattingEnabled = true;
            this.lstIstekTipi.ItemHeight = 17;
            this.lstIstekTipi.Location = new System.Drawing.Point(144, 37);
            this.lstIstekTipi.Name = "lstIstekTipi";
            this.lstIstekTipi.Size = new System.Drawing.Size(367, 293);
            this.lstIstekTipi.TabIndex = 1;
            this.lstIstekTipi.SelectedIndexChanged += new System.EventHandler(this.lstIstekTipi_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(296, 345);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(60, 32);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // IstekTipiSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 423);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lstIstekTipi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IstekTipiSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Istek Tipi Sil";
            this.Load += new System.EventHandler(this.IstekTipiSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstIstekTipi;
        private System.Windows.Forms.Button btnSil;
    }
}