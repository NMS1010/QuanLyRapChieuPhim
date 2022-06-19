using QuanLyRapChieuPhim_ADO.BS_Layer;
using QuanLyRapChieuPhim_ADO.RevenueDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim_ADO.UI_Layer
{
    public partial class RevenueUControl : UserControl
    {
        Utilities utilities;
        List<Control> controls;
        public RevenueUControl()
        {
            InitializeComponent();
        }

        private void RevenueUControl_Load(object sender, EventArgs e)
        {
            controls = new List<Control>() {filmIDTxb, filmNameTxb, startShowDTPicker, endShowDTPicker, totalTicketTxb, totalRevenueTxb };
            utilities = new Utilities(controls, revenueDataGridView);
            utilities.FormLoad(BLRevenue.GetRevenueData(startDTPicker.Value, endDTPicker.Value));
        }

        private void revenueDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            utilities.ShowSelectedRow();
        }

        private void DateChanged(object sender, EventArgs e)
        {
            filmSearchNameTxb.Text = "";
            utilities.FormLoad(BLRevenue.GetRevenueData(startDTPicker.Value, endDTPicker.Value));
        }

        private void Change_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }


        private void exportReportBtn_Click(object sender, EventArgs e)
        {
            RevenueReportForm revenueReport = new RevenueReportForm(filmIDTxb.Text, startDTPicker.Value, endDTPicker.Value);
            revenueReport.ShowDialog();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            utilities.FormLoad(BLRevenue.GetDataByFilmName(filmSearchNameTxb.Text));
        }
    }
}
