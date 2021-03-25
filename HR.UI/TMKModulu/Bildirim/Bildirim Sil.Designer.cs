namespace HR.UI.TMKModulu.Bildirim
{
    partial class Bildirim_Sil
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
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBildirim = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(306, 310);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(61, 35);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bildirim Tipi :";
            // 
            // lstBildirim
            // 
            this.lstBildirim.FormattingEnabled = true;
            this.lstBildirim.ItemHeight = 17;
            this.lstBildirim.Location = new System.Drawing.Point(149, 24);
            this.lstBildirim.Name = "lstBildirim";
            this.lstBildirim.Size = new System.Drawing.Size(369, 259);
            this.lstBildirim.TabIndex = 2;
            this.lstBildirim.SelectedIndexChanged += new System.EventHandler(this.lstBildirim_SelectedIndexChanged);
            // 
            // Bildirim_Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 379);
            this.Controls.Add(this.lstBildirim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Bildirim_Sil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bildirim Sil";
            this.Load += new System.EventHandler(this.Bildirim_Sil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBildirim;
    }
}