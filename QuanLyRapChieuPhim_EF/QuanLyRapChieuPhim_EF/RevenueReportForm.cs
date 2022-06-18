using Microsoft.Reporting.WinForms;
using QuanLyRapChieuPhim_EF.DBConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim_EF
{
    public partial class RevenueReportForm : Form
    {
        string filmID;
        DateTime startDate;
        DateTime endDate;
        public RevenueReportForm(string filmID, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            this.filmID = filmID;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        private void RevenueReportForm_Load(object sender, EventArgs e)
        {
            revenueDataSet = new RevenueDataSet();
            var rds = new ReportDataSource("RevenueDataSet", revenueDataSet.DoanhThu as DataTable);
            revenueReportView.LocalReport.DataSources.Clear();
            revenueReportView.LocalReport.DataSources.Add(rds);
            doanhThuTableAdapter = new RevenueDataSetTableAdapters.DoanhThuTableAdapter();
            doanhThuTableAdapter.Connection.Close();
            doanhThuTableAdapter.Connection.ConnectionString = DBConnection.ConnectionString;
            try
            {
                doanhThuTableAdapter.Connection.Open();
            }
            catch(SqlException err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                return;
            }
            doanhThuTableAdapter.Fill(revenueDataSet.DoanhThu, filmID, startDate.ToShortDateString(), endDate.ToShortDateString());
            ReportParameter[] parameter = new ReportParameter[3];
            parameter[0] = new ReportParameter("startDate", startDate.ToShortDateString());
            parameter[1] = new ReportParameter("endDate", endDate.ToShortDateString());
            parameter[2] = new ReportParameter("timeNow", DateTime.Now.ToString());

            this.revenueReportView.LocalReport.EnableExternalImages = true;
            this.revenueReportView.LocalReport.SetParameters(parameter);
            this.revenueReportView.RefreshReport();
        }
    }
}
