namespace HR.UI.TMKModulu.Malzeme
{
    partial class MalzemeDetay
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
            this.DetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subeBazliMalzeme = new HR.UI.TMKModulu.Malzeme.SubeBazliMalzeme();
            this.btnGet = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbSubelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_SubelerTableAdapter = new HR.UI.TMKModulu.Malzeme.SubeBazliMalzemeTableAdapters.tb_SubelerTableAdapter();
            this.DetayTableAdapter = new HR.UI.TMKModulu.Malzeme.SubeBazliMalzemeTableAdapters.DetayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DetayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subeBazliMalzeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubelerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DetayBindingSource
            // 
            this.DetayBindingSource.DataMember = "Detay";
            this.DetayBindingSource.DataSource = this.subeBazliMalzeme;
            // 
            // subeBazliMalzeme
            // 
            this.subeBazliMalzeme.DataSetName = "SubeBazliMalzeme";
            this.subeBazliMalzeme.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(229, 13);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(142, 23);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Listele";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DetayBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HR.UI.TMKModulu.Malzeme.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 54);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(609, 369);
            this.reportViewer1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tbSubelerBindingSource;
            this.comboBox1.DisplayMember = "SubeAdi";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "ID";
            // 
            // tbSubelerBindingSource
            // 
            this.tbSubelerBindingSource.DataMember = "tb_Subeler";
            this.tbSubelerBindingSource.DataSource = this.subeBazliMalzeme;
            // 
            // tb_SubelerTableAdapter
            // 
            this.tb_SubelerTableAdapter.ClearBeforeFill = true;
            // 
            // DetayTableAdapter
            // 
            this.DetayTableAdapter.ClearBeforeFill = true;
            // 
            // MalzemeDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 436);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnGet);
            this.Name = "MalzemeDetay";
            this.Text = "MalzemeDetay";
            this.Load += new System.EventHandler(this.MalzemeDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subeBazliMalzeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubelerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private SubeBazliMalzeme subeBazliMalzeme;
        private System.Windows.Forms.BindingSource tbSubelerBindingSource;
        private SubeBazliMalzemeTableAdapters.tb_SubelerTableAdapter tb_SubelerTableAdapter;
        private System.Windows.Forms.BindingSource DetayBindingSource;
        private SubeBazliMalzemeTableAdapters.DetayTableAdapter DetayTableAdapter;

    }
}