namespace HR.UI.TMKModulu.Servisler.İlanBilgileri
{
    partial class SubeBazli
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
            this.tb_IlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Ilan = new HR.UI.TMKModulu.Servisler.İlanBilgileri.Ilan();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_IlanTableAdapter = new HR.UI.TMKModulu.Servisler.İlanBilgileri.IlanTableAdapters.tb_IlanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tb_IlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ilan)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_IlanBindingSource
            // 
            this.tb_IlanBindingSource.DataMember = "tb_Ilan";
            this.tb_IlanBindingSource.DataSource = this.Ilan;
            // 
            // Ilan
            // 
            this.Ilan.DataSetName = "Ilan";
            this.Ilan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_IlanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HR.UI.TMKModulu.Servisler.İlanBilgileri.Report13.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(771, 473);
            this.reportViewer1.TabIndex = 0;
            // 
            // tb_IlanTableAdapter
            // 
            this.tb_IlanTableAdapter.ClearBeforeFill = true;
            // 
            // SubeBazli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(771, 473);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "SubeBazli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sube Bazli";
            this.Load += new System.EventHandler(this.SubeBazli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_IlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ilan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_IlanBindingSource;
        private Ilan Ilan;
        private IlanTableAdapters.tb_IlanTableAdapter tb_IlanTableAdapter;
    }
}