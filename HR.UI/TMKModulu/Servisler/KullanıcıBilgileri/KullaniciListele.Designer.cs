namespace HR.UI.TMKModulu.Servisler.KullanıcıBilgileri
{
    partial class KullaniciListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciListele));
            this.tb_KullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Kullanici = new HR.UI.TMKModulu.Servisler.KullanıcıBilgileri.Kullanici();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_KullanicilarTableAdapter = new HR.UI.TMKModulu.Servisler.KullanıcıBilgileri.KullaniciTableAdapters.tb_KullanicilarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tb_KullanicilarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_KullanicilarBindingSource
            // 
            this.tb_KullanicilarBindingSource.DataMember = "tb_Kullanicilar";
            this.tb_KullanicilarBindingSource.DataSource = this.Kullanici;
            // 
            // Kullanici
            // 
            this.Kullanici.DataSetName = "Kullanici";
            this.Kullanici.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_KullanicilarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HR.UI.TMKModulu.Servisler.KullanıcıBilgileri.Report11.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(761, 551);
            this.reportViewer1.TabIndex = 0;
            // 
            // tb_KullanicilarTableAdapter
            // 
            this.tb_KullanicilarTableAdapter.ClearBeforeFill = true;
            // 
            // KullaniciListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(761, 551);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Detaycs";
            this.Load += new System.EventHandler(this.KullanıcıDetaycs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_KullanicilarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kullanici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_KullanicilarBindingSource;
        private Kullanici Kullanici;
        private KullaniciTableAdapters.tb_KullanicilarTableAdapter tb_KullanicilarTableAdapter;
    }
}