namespace HR.UI.TMKModulu.Servisler.Duyurular
{
    partial class DuyuruListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuyuruListele));
            this.tb_DuyurularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Duyurular = new HR.UI.TMKModulu.Servisler.Duyurular.Duyurular();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_DuyurularTableAdapter = new HR.UI.TMKModulu.Servisler.Duyurular.DuyurularTableAdapters.tb_DuyurularTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tb_DuyurularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duyurular)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_DuyurularBindingSource
            // 
            this.tb_DuyurularBindingSource.DataMember = "tb_Duyurular";
            this.tb_DuyurularBindingSource.DataSource = this.Duyurular;
            // 
            // Duyurular
            // 
            this.Duyurular.DataSetName = "Duyurular";
            this.Duyurular.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_DuyurularBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HR.UI.TMKModulu.Servisler.Duyurular.Report9.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(891, 414);
            this.reportViewer1.TabIndex = 0;
            // 
            // tb_DuyurularTableAdapter
            // 
            this.tb_DuyurularTableAdapter.ClearBeforeFill = true;
            // 
            // DuyuruListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(891, 414);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DuyuruListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duyuru Listele";
            this.Load += new System.EventHandler(this.DuyuruListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_DuyurularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Duyurular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_DuyurularBindingSource;
        private Duyurular Duyurular;
        private DuyurularTableAdapters.tb_DuyurularTableAdapter tb_DuyurularTableAdapter;
    }
}