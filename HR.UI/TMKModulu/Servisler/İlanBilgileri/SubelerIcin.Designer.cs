namespace HR.UI.TMKModulu.Servisler.İlanBilgileri
{
    partial class SubelerIcin
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SubeyeGore = new HR.UI.TMKModulu.Servisler.İlanBilgileri.SubeyeGore();
            this.tb_IlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_IlanTableAdapter = new HR.UI.TMKModulu.Servisler.İlanBilgileri.SubeyeGoreTableAdapters.tb_IlanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SubeyeGore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_IlanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_IlanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HR.UI.TMKModulu.Servisler.İlanBilgileri.Report14.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(901, 472);
            this.reportViewer1.TabIndex = 0;
            // 
            // SubeyeGore
            // 
            this.SubeyeGore.DataSetName = "SubeyeGore";
            this.SubeyeGore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_IlanBindingSource
            // 
            this.tb_IlanBindingSource.DataMember = "tb_Ilan";
            this.tb_IlanBindingSource.DataSource = this.SubeyeGore;
            // 
            // tb_IlanTableAdapter
            // 
            this.tb_IlanTableAdapter.ClearBeforeFill = true;
            // 
            // SubelerIcin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(901, 472);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "SubelerIcin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sube Bazlı Alınacak Personel Listesi";
            this.Load += new System.EventHandler(this.SubelerIcin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubeyeGore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_IlanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_IlanBindingSource;
        private SubeyeGore SubeyeGore;
        private SubeyeGoreTableAdapters.tb_IlanTableAdapter tb_IlanTableAdapter;
    }
}