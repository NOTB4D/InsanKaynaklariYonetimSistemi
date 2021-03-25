namespace HR.UI.TMKModulu.Subeler
{
    partial class SubeDetay
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
            this.tb_SubelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SubeRapor = new HR.UI.TMKModulu.Subeler.SubeRapor();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGet = new System.Windows.Forms.Button();
            this.tb_SubelerTableAdapter = new HR.UI.TMKModulu.Subeler.SubeRaporTableAdapters.tb_SubelerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tb_SubelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubeRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_SubelerBindingSource
            // 
            this.tb_SubelerBindingSource.DataMember = "tb_Subeler";
            this.tb_SubelerBindingSource.DataSource = this.SubeRapor;
            // 
            // SubeRapor
            // 
            this.SubeRapor.DataSetName = "SubeRapor";
            this.SubeRapor.EnforceConstraints = false;
            this.SubeRapor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "SubeRapor";
            reportDataSource1.Value = this.tb_SubelerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HR.UI.TMKModulu.Subeler.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(14, 49);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(808, 478);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(12, 12);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(159, 31);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Tüm Şubeleri Listele";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // tb_SubelerTableAdapter
            // 
            this.tb_SubelerTableAdapter.ClearBeforeFill = true;
            // 
            // SubeDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 533);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SubeDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şube Detay";
            this.Load += new System.EventHandler(this.SubeDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_SubelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubeRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.BindingSource tb_SubelerBindingSource;
        private SubeRapor SubeRapor;
        private SubeRaporTableAdapters.tb_SubelerTableAdapter tb_SubelerTableAdapter;
    }
}