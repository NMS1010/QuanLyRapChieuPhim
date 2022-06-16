using QuanLyRapChieuPhim_EF.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim_EF.UI_Layer
{
    public partial class AvaialbleShowTimeUControl : UserControl
    {
        ManagerForm orderTicketForm;
        Panel mainPnl;
        int selectedRowOrderTicketDTGridView = -1;
        int customerID;
        public AvaialbleShowTimeUControl()
        {
            InitializeComponent();
        }
        private void AvaialbleShowTimeUControl_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void LoadForm()
        {
            BLOrderTicket.GetValidShowTime();
            mainPnl = this.Parent as Panel;
            orderTicketForm = mainPnl.Parent as ManagerForm;
            avaiableShowTimeDataGridView.DataSource = BLOrderTicket.DataShowTime.Tables[0];

            if (avaiableShowTimeDataGridView.SelectedCells.Count > 0)
            {
                selectedRowOrderTicketDTGridView = avaiableShowTimeDataGridView.SelectedCells[0].RowIndex;
                BLOrderTicket.SelectedShowTimeID = BLOrderTicket.ShowTimeIDs[selectedRowOrderTicketDTGridView];
            }
            else
            {
                orderTicketBtn.Enabled = false;
            }
        }
        private void findShowTimeBtn_Click(object sender, EventArgs e)
        {
            DataSet ds;
            if(byDateCkb.Checked && byFilmNameCkb.Checked)
            {
                ds = BLOrderTicket.GetDataByDateAndFilmName(dateDtpicker.Value, filmNameTxb.Text);
            }
            else if (byDateCkb.Checked)
            {
                ds = BLOrderTicket.GetDataByDate(dateDtpicker.Value);
            }
            else if (byFilmNameCkb.Checked)
            {
                ds = BLOrderTicket.GetDataByFilmName(filmNameTxb.Text);
            }
            else
            {
                ds = BLOrderTicket.DataShowTime;
            }
            avaiableShowTimeDataGridView.DataSource = ds.Tables[0];
        }

        private void orderTicketBtn_Click(object sender, EventArgs e)
        {
            if (!BLCustomer.ContainCustomer(customerID.ToString()) && cumulatePointCkb.Checked) {
                MessageBox.Show("Khách hàng không tồn tại!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customerID = 0;
                return;
            }
            BLOrderTicket.CustomerID = customerID != 0 ?customerID.ToString() : "";
            mainPnl.Controls.Clear();
            mainPnl.Controls.Add(orderTicketForm.GetTicketForm());
        }

        private void avaiableShowTimeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowOrderTicketDTGridView = avaiableShowTimeDataGridView.SelectedCells[0].RowIndex;
            if(selectedRowOrderTicketDTGridView > avaiableShowTimeDataGridView.RowCount - 2 || selectedRowOrderTicketDTGridView < 0)
            {
                orderTicketBtn.Enabled = false;
                return;
            }
            orderTicketBtn.Enabled = true;
            BLOrderTicket.SelectedShowTimeID = BLOrderTicket.ShowTimeIDs[selectedRowOrderTicketDTGridView];
            CheckChange();
        }
        private void CheckChange()
        {
            if (!int.TryParse(customerIDTxb.Text, out customerID) && cumulatePointCkb.Checked)
            {
                orderTicketBtn.Enabled = false;
                return;
            }
            orderTicketBtn.Enabled = true;
        }
        private void customerIDTxb_TextChanged(object sender, EventArgs e)
        {
            CheckChange();
            if(avaiableShowTimeDataGridView.Rows.Count == 0)
                orderTicketBtn.Enabled = false;
        }

        private void cumulatePointCkb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                orderTicketBtn.Enabled = false;
                checkBox.Location = new Point(checkBox.Location.X, 490);
                customerIDLabel.Visible = true;
                customerIDTxb.Visible = true;
            }
            else
            {
                checkBox.Location = new Point(checkBox.Location.X, 535);
                customerIDLabel.Visible = false;
                customerIDTxb.Visible = false;
                if (selectedRowOrderTicketDTGridView != -1)
                    orderTicketBtn.Enabled = true;
            }
        }
    }
}
