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
    public partial class ShowTimeUControl : UserControl
    {
        private Utilities utilities;
        private List<Control> controls;
        List<Tuple<string, string>> films;
        List<Tuple<string, string>> cinemaRooms;
        public ShowTimeUControl()
        {
            InitializeComponent();
        }
        private void ShowTimeUControl_Load(object sender, EventArgs e)
        {
            controls = new List<Control>() { showTimeIdTxb, showTimeStatusCbx, filmNameCbx, formatFilmTxb,
            cinemaRoomNameCbx, priceTicketTxb, showTimeDateDtimePicker, showTimeTimeDtimePicker};

            utilities = new Utilities(controls, showTimeDataGridView);
            films = BLMovie.GetFilms();
            cinemaRooms = BLCinemaRoom.GetCinemaRooms();
            films.ForEach(s =>
            {
                filmNameCbx.Items.Add(s.Item1);
            });
            cinemaRooms.ForEach(s =>
            {
                cinemaRoomNameCbx.Items.Add(s.Item1);
            });
            utilities.FormLoad(BLShowTime.GetData());
            utilities.SetEnableControl(false);
            utilities.SetEnableButton(new List<Button>() { saveBtn }, false);
            if (showTimeDataGridView.Rows.Count == 1)
            {
                utilities.SetEnableButton(new List<Button>() { editBtn, removeBtn }, false);
            }
            foreach (DataGridViewColumn dataCol in showTimeDataGridView.Columns)
            {
                propertySearchCbx.Items.Add(dataCol.Name);
            }
            propertySearchCbx.SelectedIndex = 0;
        }
        private void CheckChange()
        {
            if (utilities.IsNullTxb() || (!isEditData && !isAddData) )
            {
                utilities.SetEnableButton(new List<Button>() { saveBtn }, false);
                return;
            }
            utilities.SetEnableButton(new List<Button>() { saveBtn }, true);
        }
        private bool isAddData = false;
        private void addBtn_Click(object sender, EventArgs e)
        {
            utilities.SetEnableControl(true);
            priceTicketTxb.Enabled = false;
            formatFilmTxb.Enabled = false;
            isAddData = true;
            utilities.SetNullTextBox();
            utilities.SetEnableButton(new List<Button>() { cancelBtn }, true);
            utilities.SetEnableButton(new List<Button>() { removeBtn, editBtn }, false);
        }
        private bool isEditData = false;
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (BLTicket.IsTicketsCreateByShowTime(showTimeIdTxb.Text))
            {
                utilities.SetEnableControl(false);
                showTimeStatusCbx.Enabled = true;
                MessageBox.Show("Suất chiếu này đã được tạo vé nên chỉ thay đổi được trạng thái", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                utilities.SetEnableControl(true);
            priceTicketTxb.Enabled = false;
            formatFilmTxb.Enabled = false;
            isEditData = true;
            showTimeIdTxb.Enabled = false;
            utilities.SetEnableButton(new List<Button>() { removeBtn, addBtn }, false);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            string error = "";
            int selectedRowIndex = showTimeDataGridView.SelectedCells[0].RowIndex;
            string cinemaRoomID = showTimeDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString().Trim();
            DialogResult res = MessageBox.Show("Do you want to remove this record ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No)
                return;
            bool success = BLShowTime.Remove(cinemaRoomID, ref error);
            if (!success)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            utilities.SetNullTextBox();
            utilities.Reload(BLShowTime.GetData());
            if (showTimeDataGridView.SelectedCells.Count == 0)
            {
                removeBtn.Enabled = false;
                editBtn.Enabled = false;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string error = "";

            bool success = false;
            DateTime date = showTimeDateDtimePicker.Value;
            DateTime time = showTimeTimeDtimePicker.Value;
            int filmIndex = filmNameCbx.SelectedIndex;
            int cinemaRoomIndex = cinemaRoomNameCbx.SelectedIndex;
            if(cinemaRoomIndex != -1 && filmIndex != -1)
            {
                if (isAddData)
                {
                    success = BLShowTime.Insert(showTimeIdTxb.Text, new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second), showTimeStatusCbx.Text, films[filmIndex].Item2,
                        cinemaRooms[cinemaRoomIndex].Item2, ref error);
                    if (success)
                        isAddData = false;
                }
                else if (isEditData)
                {
                    success = BLShowTime.Update(showTimeIdTxb.Text, new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second), showTimeStatusCbx.Text, films[filmIndex].Item2,
                        cinemaRooms[cinemaRoomIndex].Item2, ref error);
                    if (success)
                        isEditData = false;
                }
            }
            else
            {
                error = "Phòng chiếu hoặc bộ phim chưa sẵn sàng!!";
            }
            
            if (!success || error != "")
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Thao tác không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            utilities.SetNullTextBox();
            utilities.Reload(BLShowTime.GetData());
            if (showTimeDataGridView.SelectedCells.Count == 0)
            {
                return;
            }
            utilities.SetEnableButton(new List<Button>() { addBtn, cancelBtn, removeBtn, editBtn }, true);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            utilities.ShowSelectedRow();
            utilities.SetEnableButton(new List<Button>() { saveBtn }, false);

            int temp = showTimeDataGridView.SelectedCells[0].RowIndex;
            if (temp == showTimeDataGridView.RowCount - 1)
                return;
            utilities.SetEnableButton(new List<Button>() { addBtn, removeBtn, editBtn }, true);
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            utilities.Reload(BLShowTime.GetData());

            if (showTimeDataGridView.SelectedCells.Count == 0)
            {
                return;
            }
            utilities.SetEnableButton(new List<Button>() { cancelBtn, removeBtn, editBtn }, false);
        }

        private void OnTextChange(object sender, EventArgs e)
        {
            CheckChange();
        }

        private void showTimeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            utilities.CellClick(cancelBtn, removeBtn, editBtn, saveBtn);
        }

        private void IndexChange(object sender, EventArgs e)
        {
            CheckChange();
            if (cinemaRoomNameCbx.SelectedIndex < 0)
                return;
            string cinemaRoomID = cinemaRooms[cinemaRoomNameCbx.SelectedIndex].Item2;
            priceTicketTxb.Text = BLTicket.GetTicketPriceFromCinemaRoomID(cinemaRoomID);
            formatFilmTxb.Text = BLScreenFormat.GetScreenFormatNameFromCinemaRoomID(cinemaRoomID);
        }

        private void showTimeDateDtimePicker_ValueChanged(object sender, EventArgs e)
        {
            CheckChange();
        }

        private void showTimeTimeDtimePicker_ValueChanged(object sender, EventArgs e)
        {
            CheckChange();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            showTimeDataGridView.DataSource = BLCommon.Search(BLShowTime.GetData(), propertySearchCbx.SelectedIndex, searchTxb.Text);
        }
    }
}
