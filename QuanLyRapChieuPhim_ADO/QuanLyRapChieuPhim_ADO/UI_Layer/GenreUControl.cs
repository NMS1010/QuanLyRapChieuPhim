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
    public partial class GenreUControl : UserControl
    {
        private Utilities utilities;
        private List<Control> controls;
        public GenreUControl()
        {
            InitializeComponent();
        }
        private void GenreUControl_Load(object sender, EventArgs e)
        {
            controls = new List<Control>() { genreIdTxb, genreNameTxb};
            utilities = new Utilities(controls, genreDataGridView);
            utilities.FormLoad(BLGenre.GetData());
            utilities.SetEnableControl(false);
            utilities.SetEnableButton(new List<Button>() { saveBtn }, false);

            if (genreDataGridView.Rows.Count == 1)
            {
                utilities.SetEnableButton(new List<Button>() { editBtn, removeBtn }, false);
            }
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
            genreIdTxb.Enabled = false;
            utilities.SetEnableButton(new List<Button>() { removeBtn, addBtn }, false);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            string error = "";
            int selectedRowIndex = genreDataGridView.SelectedCells[0].RowIndex;
            string genreID = genreDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString().Trim();
            DialogResult res = MessageBox.Show("Do you want to remove this record ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No)
                return;
            bool success = BLGenre.Remove(genreID, ref error);
            if (!success)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            utilities.Reload(BLGenre.GetData());
            if (genreDataGridView.SelectedCells.Count == 0)
            {
                utilities.SetEnableButton(new List<Button>() { removeBtn, editBtn }, false);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string error = "";

            bool success = false;
            if (isAddData)
            {
                success = BLGenre.Insert(genreIdTxb.Text, genreNameTxb.Text, ref error);
                if (success)
                    isAddData = false;
            }
            else if (isEditData)
            {
                success = BLGenre.Update(genreIdTxb.Text, genreNameTxb.Text, ref error);
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
            utilities.Reload(BLGenre.GetData());
            if (genreDataGridView.SelectedCells.Count == 0)
            {
                return;
            }
            utilities.SetEnableButton(new List<Button>() { addBtn, cancelBtn, removeBtn, editBtn }, true);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            utilities.ShowSelectedRow();
            utilities.SetEnableButton(new List<Button>() { saveBtn }, false);
            //
            int temp = genreDataGridView.SelectedCells[0].RowIndex;
            if (temp == genreDataGridView.RowCount - 1)
                return;
            utilities.SetEnableButton(new List<Button>() { addBtn, removeBtn, editBtn }, true);
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            utilities.Reload(BLGenre.GetData());
            if (genreDataGridView.SelectedCells.Count == 0)
            {
                return;
            }
            utilities.SetEnableButton(new List<Button>() { cancelBtn, saveBtn }, false);
            utilities.SetEnableButton(new List<Button>() { editBtn, removeBtn, addBtn }, true);
        }

        private void OnTextChange(object sender, EventArgs e)
        {
            if (utilities.IsNullTxb() || (!isEditData && !isAddData))
            {
                utilities.SetEnableButton(new List<Button>() { saveBtn }, false);
                return;
            }
            utilities.SetEnableButton(new List<Button>() { saveBtn }, true);
        }

        private void genreDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            utilities.CellClick(cancelBtn, removeBtn, editBtn, saveBtn);
        }

    }
}
