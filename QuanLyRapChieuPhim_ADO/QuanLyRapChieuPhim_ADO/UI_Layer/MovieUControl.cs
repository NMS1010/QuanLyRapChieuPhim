using QuanLyRapChieuPhim_ADO.BS_Layer;
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
    public partial class MovieUControl : UserControl
    {
        private Utilities utilities;
        private List<Control> controls;
        public MovieUControl()
        {
            InitializeComponent();
        }
        private void MovieUControl_Load(object sender, EventArgs e)
        {
            controls = new List<Control>() { filmIdTxb, filmNameTxb, filmDesRtxb, totalFilmTimeTxb, startDateDTimePicker,
            endDateDTimePicker, yearTxb, directorTxb, studioFilmTxb, movieStatusCbx,  genreCheckLstbox};
            
            utilities = new Utilities(controls, movieDataGridView);
            List<string> genreNames = BLMovie.GetGenreNames();
            genreNames.ForEach(genreName => {
                genreCheckLstbox.Items.Add(genreName);
            });
            movieStatusCbx.SelectedIndex = 0;
            utilities.FormLoad(BLMovie.GetData());
            utilities.SetEnableControl(false);
            utilities.SetEnableButton(new List<Button>() { saveBtn }, false);
        }
        private void CheckChange()
        {
            if (utilities.IsNullTxb() || (!isEditData && !isAddData) ||
                !double.TryParse(totalFilmTimeTxb.Text, out double res1) ||
                !int.TryParse(yearTxb.Text, out int res2) ||
                genreCheckLstbox.CheckedItems.Count == 0)
            {
                utilities.SetEnableButton(new List<Button>() { saveBtn }, false);
                return;
            }
            utilities.SetEnableButton(new List<Button>() { saveBtn }, true);
        }
        private void OnTextChange(object sender, EventArgs e)
        {
            CheckChange();
        }
        private void genreCheckLstbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckChange();
        }
        private bool isAddData = false;
        private void addBtn_Click(object sender, EventArgs e)
        {
            utilities.SetEnableControl(true);
            isAddData = true;
            utilities.SetNullTextBox();
            utilities.SetEnableButton(new List<Button>() { cancelBtn }, true);
            utilities.SetEnableButton(new List<Button>() { removeBtn, editBtn }, false);
        }
        private bool isEditData = false;
        private void editBtn_Click(object sender, EventArgs e)
        {
            utilities.SetEnableControl(true);
            isEditData = true;
            filmIdTxb.Enabled = false;
            utilities.SetEnableButton(new List<Button>() { removeBtn, addBtn }, false);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            string error = "";
            int selectedRowIndex = movieDataGridView.SelectedCells[0].RowIndex;
            string cinemaRoomID = movieDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString().Trim();
            DialogResult res = MessageBox.Show("Do you want to remove this record ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No)
                return;
            bool success = BLMovie.Remove(cinemaRoomID, ref error);
            if (!success)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            utilities.SetNullTextBox();
            utilities.Reload(BLMovie.GetData());
            if (movieDataGridView.SelectedCells.Count == 0)
            {
                utilities.SetEnableButton(new List<Button>() { removeBtn, editBtn }, false);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string error = "";

            bool success = false;
            List<string> genreName = new List<string>();
            DateTime startDate = startDateDTimePicker.Value;
            DateTime endDate = endDateDTimePicker.Value;
            foreach (var o in genreCheckLstbox.CheckedItems)
            {
                genreName.Add(o.ToString());
            }
            if (isAddData)
            {
                success = BLMovie.Insert(filmIdTxb.Text, filmNameTxb.Text, filmDesRtxb.Text, double.Parse(totalFilmTimeTxb.Text),
                    new DateTime(startDate.Year, startDate.Month, startDate.Day),
                    new DateTime(endDate.Year, endDate.Month, endDate.Day), int.Parse(yearTxb.Text),
                    directorTxb.Text, studioFilmTxb.Text, int.Parse(movieStatusCbx.Text), ref error);
                if (success)
                    isAddData = false;
            }
            else if (isEditData)
            {
                success = BLMovie.Update(filmIdTxb.Text, filmNameTxb.Text, filmDesRtxb.Text, double.Parse(totalFilmTimeTxb.Text),
                    new DateTime(startDate.Year, startDate.Month, startDate.Day),
                    new DateTime(endDate.Year, endDate.Month, endDate.Day), int.Parse(yearTxb.Text),
                    directorTxb.Text, studioFilmTxb.Text, int.Parse(movieStatusCbx.Text), ref error);
                if (success)
                    isEditData = false;
            }
            if (success)
            {
                success = BLMovie.Modify_Movie_Genre(filmIdTxb.Text, genreName, ref error);
            }
            if (!success || error != "")
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Thao tác không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            utilities.SetNullTextBox();
            utilities.Reload(BLMovie.GetData());
            if (movieDataGridView.SelectedCells.Count == 0)
            {
                return;
            }
            utilities.SetEnableButton(new List<Button>() { addBtn, cancelBtn, removeBtn, editBtn }, true);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            utilities.ShowSelectedRow();
            utilities.SetEnableButton(new List<Button>() { saveBtn }, false);
            int temp = movieDataGridView.SelectedCells[0].RowIndex;
            if (temp == movieDataGridView.RowCount - 1)
                return;
            utilities.SetEnableButton(new List<Button>() { addBtn, removeBtn, editBtn }, true);
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            utilities.Reload(BLMovie.GetData());

            if (movieDataGridView.SelectedCells.Count == 0)
            {
                return;
            }
            utilities.SetEnableButton(new List<Button>() { cancelBtn, saveBtn }, false);
            utilities.SetEnableButton(new List<Button>() { editBtn, removeBtn, addBtn }, true);
        }
        

        private void movieDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            utilities.CellClick(cancelBtn, removeBtn, editBtn, saveBtn);
        }

        private void movieStatusCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckChange();
        }

        private void startDateDTimePicker_ValueChanged(object sender, EventArgs e)
        {
            CheckChange();
        }

        private void endDateDTimePicker_ValueChanged(object sender, EventArgs e)
        {
            CheckChange();
        }

    }
}
