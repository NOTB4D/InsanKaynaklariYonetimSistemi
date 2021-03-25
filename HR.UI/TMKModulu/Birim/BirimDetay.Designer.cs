namespace HR.UI.TMKModulu.Birim
{
    partial class BirimDetay
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tb_BirimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BirimRapor = new HR.UI.TMKModulu.Birim.BirimRapor();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGet = new System.Windows.Forms.Button();
            this.tb_BirimTableAdapter = new HR.UI.TMKModulu.Birim.BirimRaporTableAdapters.tb_BirimTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tb_BirimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirimRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_BirimBindingSource
            // 
            this.tb_BirimBindingSource.DataMember = "tb_Birim";
            this.tb_BirimBindingSource.DataSource = this.BirimRapor;
            // 
            // BirimRapor
            // 
            this.BirimRapor.DataSetName = "BirimRapor";
            this.BirimRapor.EnforceConstraints = false;
            this.BirimRapor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_BirimBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HR.UI.TMKModulu.Birim.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(14, 47);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1055, 511);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(14, 12);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(209, 29);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Tüm Birimleri Listele";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // tb_BirimTableAdapter
            // 
            this.tb_BirimTableAdapter.ClearBeforeFill = true;
            // 
            // BirimDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 570);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BirimDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Birim Detay";
            this.Load += new System.EventHandler(this.BirimDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_BirimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirimRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.BindingSource tb_BirimBindingSource;
        private BirimRapor BirimRapor;
        private BirimRaporTableAdapters.tb_BirimTableAdapter tb_BirimTableAdapter;
    }
}