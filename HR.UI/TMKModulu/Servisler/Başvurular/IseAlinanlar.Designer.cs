namespace HR.UI.TMKModulu.Servisler.Başvurular
{
    partial class IseAlinanlar
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
            this.tb_PersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Basvurular = new HR.UI.TMKModulu.Servisler.Başvurular.Basvurular();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_PersonelTableAdapter = new HR.UI.TMKModulu.Servisler.Başvurular.BasvurularTableAdapters.tb_PersonelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tb_PersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Basvurular)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_PersonelBindingSource
            // 
            this.tb_PersonelBindingSource.DataMember = "tb_Personel";
            this.tb_PersonelBindingSource.DataSource = this.Basvurular;
            // 
            // Basvurular
            // 
            this.Basvurular.DataSetName = "Basvurular";
            this.Basvurular.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_PersonelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HR.UI.TMKModulu.Servisler.Başvurular.Report15.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(866, 434);
            this.reportViewer1.TabIndex = 0;
            // 
            // tb_PersonelTableAdapter
            // 
            this.tb_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // IseAlinanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(866, 434);
            this.Controls.Add(this.reportViewer1);
            this.Name = "IseAlinanlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşe Alınanlar";
            this.Load += new System.EventHandler(this.BasvuruListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_PersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Basvurular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_PersonelBindingSource;
        private Basvurular Basvurular;
        private BasvurularTableAdapters.tb_PersonelTableAdapter tb_PersonelTableAdapter;
    }
}