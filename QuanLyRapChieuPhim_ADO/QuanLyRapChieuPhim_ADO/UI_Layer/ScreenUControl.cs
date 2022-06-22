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
    public partial class ScreenUControl : UserControl
    {
        private Utilities utilities;
        private List<Control> controls;
        public ScreenUControl()
        {
            InitializeComponent();
        }

        private void ScreenUControl_Load(object sender, EventArgs e)
        {
            controls = new List<Control>() { screenIdTxb, nameScreenFormatTxb, ticketPriceTxb};
            utilities = new Utilities(controls, screenDataGridView);
            utilities.FormLoad(BLScreenFormat.GetData());
            utilities.SetEnableControl(false);
            utilities.SetEnableButton(new List<Button>() { saveBtn }, false);
            if (screenDataGridView.Rows.Count == 1)
            {
                utilities.SetEnableButton(new List<Button>() { editBtn, removeBtn }, false);
            }
            foreach (DataGridViewColumn dataCol in screenDataGridView.Columns)
            {
                propertySearchCbx.Items.Add(dataCol.Name);
            }
            propertySearchCbx.SelectedIndex = 0;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string error = "";
            bool success = false;
            if (isAddData)
            {
                success = BLScreenFormat.Insert(screenIdTxb.Text, nameScreenFormatTxb.Text, decimal.Parse(ticketPriceTxb.Text), ref error);
                if (success)
                    isAddData = false;
            }
            else if(isEditData)
            {
                success = BLScreenFormat.Update(screenIdTxb.Text, nameScreenFormatTxb.Text, decimal.Parse(ticketPriceTxb.Text), ref error);
                if (success)
                    isEditData = false;
            }

            if (!success)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Thao tác không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            utilities.SetNullTextBox();
            utilities.Reload(BLScreenFormat.GetData());
            if (screenDataGridView.SelectedCells.Count == 0)
            {
                return;
            }
            utilities.SetEnableButton(new List<Button>() { addBtn, cancelBtn, removeBtn, editBtn }, true);
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            utilities.Reload(BLScreenFormat.GetData());

            if (screenDataGridView.SelectedCells.Count == 0)
            {
                return;
            }
            utilities.SetEnableButton(new List<Button>() { cancelBtn, saveBtn }, false);
            utilities.SetEnableButton(new List<Button>() { editBtn, removeBtn, addBtn }, true);
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
        private void OnTextChange(object sender, EventArgs e)
        {
            if (utilities.IsNullTxb() || (!isEditData && !isAddData) || !decimal.TryParse(ticketPriceTxb.Text, out decimal res))
            {
                utilities.SetEnableButton(new List<Button>() { saveBtn }, false);
                return;
            }
            utilities.SetEnableButton(new List<Button>() { saveBtn }, true);
        }
        private bool isEditData = false;
        private void editBtn_Click(object sender, EventArgs e)
        {
            utilities.SetEnableControl(true);
            isEditData = true;
            screenIdTxb.Enabled = false;
            utilities.SetEnableButton(new List<Button>() { removeBtn, addBtn }, false);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            string error = "";
            
            int selectedRowIndex = screenDataGridView.SelectedCells[0].RowIndex;
            string screenID = screenDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString().Trim();
            DialogResult res = MessageBox.Show("Do you want to remove this record ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No)
                return;
            bool success = BLScreenFormat.Remove(screenID, ref error);
            if (!success)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            utilities.Reload(BLScreenFormat.GetData()); 
            if (screenDataGridView.SelectedCells.Count == 0)
            {
                utilities.SetEnableButton(new List<Button>() { removeBtn, editBtn }, false);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            utilities.ShowSelectedRow();
            utilities.SetEnableButton(new List<Button>() { saveBtn }, false);
            int temp = screenDataGridView.SelectedCells[0].RowIndex;
            if (temp == screenDataGridView.RowCount - 1)
                return;
            utilities.SetEnableButton(new List<Button>() { addBtn, removeBtn, editBtn }, true);
        }

        private void screenDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            utilities.CellClick(cancelBtn, removeBtn, editBtn, saveBtn);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            screenDataGridView.DataSource = BLCommon.Search(BLScreenFormat.GetData(), propertySearchCbx.SelectedIndex, searchTxb.Text);
        }
    }
}
