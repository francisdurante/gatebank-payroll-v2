namespace GatebankPayroll
{
    partial class frmPayrollDetailsReport
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
            this.spReportGeneratedPayrollPerUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPayrollDetails = new GatebankPayroll.dataSetPayrollDetails();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spReportGeneratedPayrollPerUserTableAdapter = new GatebankPayroll.dataSetPayrollDetailsTableAdapters.spReportGeneratedPayrollPerUserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spReportGeneratedPayrollPerUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPayrollDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // spReportGeneratedPayrollPerUserBindingSource
            // 
            this.spReportGeneratedPayrollPerUserBindingSource.DataMember = "spReportGeneratedPayrollPerUser";
            this.spReportGeneratedPayrollPerUserBindingSource.DataSource = this.dataSetPayrollDetails;
            // 
            // dataSetPayrollDetails
            // 
            this.dataSetPayrollDetails.DataSetName = "dataSetPayrollDetails";
            this.dataSetPayrollDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spReportGeneratedPayrollPerUserBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GatebankPayroll.reportForPayrollDetails.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(640, 447);
            this.reportViewer1.TabIndex = 0;
            // 
            // spReportGeneratedPayrollPerUserTableAdapter
            // 
            this.spReportGeneratedPayrollPerUserTableAdapter.ClearBeforeFill = true;
            // 
            // frmPayrollDetailsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 447);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPayrollDetailsReport";
            this.Text = "Payroll Details Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPayrollDetailsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spReportGeneratedPayrollPerUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPayrollDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReportGeneratedPayrollPerUserBindingSource;
        private dataSetPayrollDetails dataSetPayrollDetails;
        private dataSetPayrollDetailsTableAdapters.spReportGeneratedPayrollPerUserTableAdapter spReportGeneratedPayrollPerUserTableAdapter;
    }
}