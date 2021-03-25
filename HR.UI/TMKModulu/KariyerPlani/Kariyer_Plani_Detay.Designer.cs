namespace HR.UI.TMKModulu.KariyerPlani
{
    partial class Kariyer__Plani_Detay
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kariyerDetay = new HR.UI.TMKModulu.KariyerPlani.KariyerDetay();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbSubelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_SubelerTableAdapter = new HR.UI.TMKModulu.KariyerPlani.KariyerDetayTableAdapters.tb_SubelerTableAdapter();
            this.btnGet = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DetayTableAdapter = new HR.UI.TMKModulu.KariyerPlani.KariyerDetayTableAdapters.DetayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DetayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kariyerDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubelerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DetayBindingSource
            // 
            this.DetayBindingSource.DataMember = "Detay";
            this.DetayBindingSource.DataSource = this.kariyerDetay;
            // 
            // kariyerDetay
            // 
            this.kariyerDetay.DataSetName = "KariyerDetay";
            this.kariyerDetay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tbSubelerBindingSource;
            this.comboBox1.DisplayMember = "SubeAdi";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID";
            // 
            // tbSubelerBindingSource
            // 
            this.tbSubelerBindingSource.DataMember = "tb_Subeler";
            this.tbSubelerBindingSource.DataSource = this.kariyerDetay;
            // 
            // tb_SubelerTableAdapter
            // 
            this.tb_SubelerTableAdapter.ClearBeforeFill = true;
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(211, 12);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(86, 23);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Listele";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DetayBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HR.UI.TMKModulu.KariyerPlani.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1017, 411);
            this.reportViewer1.TabIndex = 2;
            // 
            // DetayTableAdapter
            // 
            this.DetayTableAdapter.ClearBeforeFill = true;
            // 
            // Kariyer__Plani_Detay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 462);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.comboBox1);
            this.Name = "Kariyer__Plani_Detay";
            this.Text = "Kariyer Plani Detay";
            this.Load += new System.EventHandler(this.Kariyer__Plani_Detay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kariyerDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubelerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private KariyerDetay kariyerDetay;
        private System.Windows.Forms.BindingSource tbSubelerBindingSource;
        private KariyerDetayTableAdapters.tb_SubelerTableAdapter tb_SubelerTableAdapter;
        private System.Windows.Forms.Button btnGet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DetayBindingSource;
        private KariyerDetayTableAdapters.DetayTableAdapter DetayTableAdapter;
    }
}