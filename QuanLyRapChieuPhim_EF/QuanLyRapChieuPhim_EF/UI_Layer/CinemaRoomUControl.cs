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
    public partial class CinemaRoomUControl : UserControl
    {
        private Utilities utilities;
        private List<Control> controls;
        private List<Tuple<string, string>> screenFormats;
        public CinemaRoomUControl()
        {
            InitializeComponent();
        }
        private void CinemaRoomUControl_Load(object sender, EventArgs e)
        {
            controls = new List<Control>() { cinemaRoomIdTxb, cinemaRoomNameTxb, totalSeatTxb, cinemaRoomStatusCbx, totalNumberRowChairTxb,
            totalChairPerRowTxb, screenNameCinemaRoomCbx};
            utilities = new Utilities(controls, cinemaRoomDataGridView);
            utilities.FormLoad(BLCinemaRoom.GetData());
            utilities.SetEnableControl(false);
            //
            utilities.SetEnableButton(new List<Button>() { saveBtn }, false);
            if (cinemaRoomDataGridView.Rows.Count == 1)
            {
                utilities.SetEnableButton(new List<Button>() { editBtn, removeBtn }, false);
            }
            screenFormats = BLScreenFormat.GetScreenFormats();
            screenFormats.ForEach(s =>
            {
                screenNameCinemaRoomCbx.Items.Add(s.Item1);
            });
            cinemaRoomStatusCbx.SelectedIndex = 0;
            if (screenNameCinemaRoomCbx.Items.Count > 0)
                screenNameCinemaRoomCbx.SelectedIndex = 0;
        }
        private bool isAddData = false;
        private void addBtn_Click(object sender, EventArgs e)
        {
            utilities.SetEnableControl(true);
            totalSeatTxb.Enabled = false;
            isAddData = true;
            utilities.SetNullTextBox();
            //
            utilities.SetEnableButton(new List<Button>() { cancelBtn}, true);
            utilities.SetEnableButton(new List<Button>() { removeBtn, editBtn }, false);
        }
        private bool isEditData = false;
        private void editBtn_Click(object sender, EventArgs e)
        {
            utilities.SetEnableControl(true);
            totalSeatTxb.Enabled = false;
            isEditData = true;
            cinemaRoomIdTxb.Enabled = false;
            //
            utilities.SetEnableButton(new List<Button>() { removeBtn, addBtn }, false);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            string error = "";
            int selectedRowIndex = cinemaRoomDataGridView.SelectedCells[0].RowIndex;
            string cinemaRoomID = cinemaRoomDataGridView.Rows[selectedRowIndex].Cells[0]?.Value.ToString().Trim();
            DialogResult res = MessageBox.Show("Do you want to remove this record ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No)
                return;
            bool success = BLCinemaRoom.Remove(cinemaRoomID, ref error);
            if (!success)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            utilities.Reload(BLCinemaRoom.GetData());
            if (cinemaRoomDataGridView.SelectedCells.Count == 0)
            {
                utilities.SetEnableButton(new List<Button>() { removeBtn, editBtn }, false);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string error = "";
            
            bool success = false;
            string screenFormatID = screenFormats[screenNameCinemaRoomCbx.SelectedIndex].Item2;
            if (isAddData)
            {
                success = BLCinemaRoom.Insert(cinemaRoomIdTxb.Text, cinemaRoomNameTxb.Text, 
                    int.Parse(totalSeatTxb.Text), int.Parse(cinemaRoomStatusCbx.Text), int.Parse(totalNumberRowChairTxb.Text),
                    int.Parse(totalChairPerRowTxb.Text), screenFormatID, ref error);
                if (success)
                    isAddData = false;
            }
            else if(isEditData)
            {
                success = BLCinemaRoom.Update(cinemaRoomIdTxb.Text, cinemaRoomNameTxb.Text,
                    int.Parse(totalSeatTxb.Text), int.Parse(cinemaRoomStatusCbx.Text), int.Parse(totalNumberRowChairTxb.Text),
                    int.Parse(totalChairPerRowTxb.Text), screenFormatID, ref error);
                if (success)
                    isEditData = false;
            }

            if (!success || error != "")
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Thao tác không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            utilities.SetNullTextBox();
            utilities.Reload(BLCinemaRoom.GetData());
            if (cinemaRoomDataGridView.SelectedCells.Count == 0)
            {
                return;
            }
            //
            utilities.SetEnableButton(new List<Button>() { addBtn, cancelBtn, removeBtn, editBtn }, true);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            utilities.ShowSelectedRow();
            utilities.SetEnableButton(new List<Button>() { saveBtn}, false);
            //
            int temp = cinemaRoomDataGridView.SelectedCells[0].RowIndex;
            if (temp == cinemaRoomDataGridView.RowCount - 1)
                return;
            utilities.SetEnableButton(new List<Button>() { addBtn, removeBtn, editBtn }, true);
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            utilities.Reload(BLCinemaRoom.GetData());

            if (cinemaRoomDataGridView.SelectedCells.Count == 0)
            {
                return;
            }
            //
            utilities.SetEnableButton(new List<Button>() { cancelBtn, saveBtn }, false);
            utilities.SetEnableButton(new List<Button>() { editBtn, removeBtn, addBtn }, true);
        }

        private void cinemaRoomDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            utilities.CellClick(cancelBtn, removeBtn, editBtn, saveBtn);
        }
        private void CheckChange()
        {
            if (int.TryParse(totalChairPerRowTxb.Text, out int res2) &&
                int.TryParse(totalNumberRowChairTxb.Text, out int res3))
            {
                totalSeatTxb.Text = $"{int.Parse(totalChairPerRowTxb.Text) * int.Parse(totalNumberRowChairTxb.Text)}";
            }
            else
            {
                totalSeatTxb.Text = "";
            }
            if (utilities.IsNullTxb() || (!isEditData && !isAddData) ||
                !int.TryParse(totalChairPerRowTxb.Text, out res2) ||
                !int.TryParse(totalNumberRowChairTxb.Text, out res3) ||
                !int.TryParse(cinemaRoomStatusCbx.Text, out int res4))
            {
                //
                utilities.SetEnableButton(new List<Button>() { saveBtn }, false);
                return;
            }
            //
            utilities.SetEnableButton(new List<Button>() { saveBtn }, true);
        }
        private void OnTextChange(object sender, EventArgs e)
        {
            CheckChange();
        }

        private void cinemaRoomStatusCbx_SelectedValueChanged(object sender, EventArgs e)
        {
            CheckChange();
        }

        private void screenNameCinemaRoomCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckChange();
        }
    }
}
