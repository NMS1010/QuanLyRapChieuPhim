namespace QuanLyRapChieuPhim_ADO
{
    partial class RevenueReportForm
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
            this.revenueReportView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // revenueReportView
            // 
            this.revenueReportView.LocalReport.ReportEmbeddedResource = "QuanLyRapChieuPhim_ADO.RevenueRP.rdlc";
            this.revenueReportView.Location = new System.Drawing.Point(0, -1);
            this.revenueReportView.Name = "revenueReportView";
            this.revenueReportView.ServerReport.BearerToken = null;
            this.revenueReportView.Size = new System.Drawing.Size(828, 482);
            this.revenueReportView.TabIndex = 0;
            // 
            // RevenueReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 483);
            this.Controls.Add(this.revenueReportView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(846, 522);
            this.MinimumSize = new System.Drawing.Size(846, 522);
            this.Name = "RevenueReportForm";
            this.Text = "Báo cáo doanh thu";
            this.Load += new System.EventHandler(this.RevenueReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer revenueReportView;
        private System.Windows.Forms.BindingSource doanhThuBindingSource;
        private RevenueDataSet revenueDataSet;
        private RevenueDataSetTableAdapters.DoanhThuTableAdapter doanhThuTableAdapter;
    }
}