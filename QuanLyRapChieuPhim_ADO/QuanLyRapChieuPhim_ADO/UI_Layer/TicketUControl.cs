using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapChieuPhim_ADO.BS_Layer;

namespace QuanLyRapChieuPhim_ADO.UI_Layer
{
    public partial class TicketUControl : UserControl
    {
        int selectedRowShowTimeDTGridView = -1;
        public TicketUControl()
        {
            InitializeComponent();
        }

        private void TicketUControl_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        public void LoadForm()
        {
            showTimeDataGridView.DataSource = BLTicket.GetShowTimeData().Tables[0];
            if (showTimeDataGridView.SelectedCells.Count > 0)
                selectedRowShowTimeDTGridView = showTimeDataGridView.SelectedCells[0].RowIndex;
            LoadTicket();
        }
        private void ticketGenBtn_Click(object sender, EventArgs e)
        {
            string error = "";
            bool success = BLTicket.GenerateTicket(showTimeDataGridView.Rows[selectedRowShowTimeDTGridView].Cells["MaSuatChieu"].Value.ToString(),
                ref error);
            if (!success)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                LoadTicket();
                showTimeDataGridView.Rows[selectedRowShowTimeDTGridView].Cells["TinhTrangVe"].Value = "Đã tạo vé";
            }
        }
        private void LoadTicket()
        {
            if (selectedRowShowTimeDTGridView < 0)
                return;
            ticketGenDataGridView.DataSource = BLTicket.GetTicketDataByShowTime(showTimeDataGridView.Rows[selectedRowShowTimeDTGridView].Cells["MaSuatChieu"].Value.ToString()).Tables[0];
        }
        private void showTimeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowShowTimeDTGridView = e.RowIndex;

            if (showTimeDataGridView.CurrentCell != null && selectedRowShowTimeDTGridView < showTimeDataGridView.RowCount - 1)
            {
                ticketGenBtn.Enabled = true;
                removeTicketBtn.Enabled = true;
            }
            else
            {
                ticketGenBtn.Enabled = false;
                removeTicketBtn.Enabled = false;
            }
            LoadTicket();
        }

        private void removeTicketBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá vé của Suất chiếu này ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            string error = "";
            bool success = BLTicket.RemoveAllTicketByShowTime(showTimeDataGridView.Rows[selectedRowShowTimeDTGridView].Cells["MaSuatChieu"].Value.ToString(),
                ref error);
            if (!success)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoadTicket();
                if (selectedRowShowTimeDTGridView < 0)
                    return;
                showTimeDataGridView.Rows[selectedRowShowTimeDTGridView].Cells["TinhTrangVe"].Value = "Chưa tạo vé";
            }
        }
    }
}
