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
    public partial class CustomerUControl : UserControl
    {
        private Utilities utilities;
        private List<Control> controls;
        public CustomerUControl()
        {
            InitializeComponent();
        }

        private void CheckChange()
        {
            if (customerIdTxb.Text == "")
                customerIdTxb.Text = ".";
            if (utilities.IsNullTxb() || (!isEditData && !isAddData) ||
                !long.TryParse(phoneTxb.Text, out long res1) ||
                !int.TryParse(cumulativePointTxb.Text, out int res2))
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
        private void CustomerUControl_Load(object sender, EventArgs e)
        {
            controls = new List<Control>() {customerIdTxb, customerNameTxb, birthdayDTimePicker, sexCbx, addressRtxb,
                phoneTxb, cumulativePointTxb};
            utilities = new Utilities(controls, customerDataGridView);
            utilities.FormLoad(BLCustomer.GetData());
            utilities.SetEnableControl(false);
            utilities.SetEnableButton(new List<Button>() { saveBtn }, false);
            if (customerDataGridView.Rows.Count == 1)
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
            utilities.SetEnableButton(new List<Button>() { removeBtn, addBtn }, false);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if(BLLogin.AccountRole != Enum.ACCOUNT_ROLE.ADMIN)
            {
                MessageBox.Show("You don't have permissions to remove Customers!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string error = "";
            int selectedRowIndex = customerDataGridView.SelectedCells[0].RowIndex;
            string customerID = customerDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString().Trim();
            DialogResult res = MessageBox.Show("Do you want to remove this record ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No)
                return;
            bool success = BLCustomer.Remove(customerID, ref error);
            if (!success)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            utilities.Reload(BLCustomer.GetData());
            if (customerDataGridView.SelectedCells.Count == 0)
            {
                utilities.SetEnableButton(new List<Button>() { removeBtn, editBtn }, false);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string error = "";

            bool success = false;
            DateTime birthDate = birthdayDTimePicker.Value;
            if (isAddData)
            {
                success = BLCustomer.Insert(customerNameTxb.Text, 
                    new DateTime(birthDate.Year, birthDate.Month, birthDate.Day), sexCbx.Text, addressRtxb.Text,
                    phoneTxb.Text, int.Parse(cumulativePointTxb.Text), ref error);
                if (success)
                    isAddData = false;
            }
            else if (isEditData)
            {
                success = BLCustomer.Update(customerIdTxb.Text, customerNameTxb.Text,
                    new DateTime(birthDate.Year, birthDate.Month, birthDate.Day), sexCbx.Text, addressRtxb.Text,
                    phoneTxb.Text, int.Parse(cumulativePointTxb.Text), ref error);
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
            utilities.Reload(BLCustomer.GetData());
            if (customerDataGridView.SelectedCells.Count == 0)
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
            int temp = customerDataGridView.SelectedCells[0].RowIndex;
            if (temp == customerDataGridView.RowCount - 1)
                return;
            utilities.SetEnableButton(new List<Button>() { addBtn, removeBtn, editBtn }, true);
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            utilities.Reload(BLCustomer.GetData());
            if (customerDataGridView.SelectedCells.Count == 0)
            {
                return;
            }
            utilities.SetEnableButton(new List<Button>() { cancelBtn, saveBtn }, false);
            utilities.SetEnableButton(new List<Button>() { editBtn, removeBtn, addBtn }, true);
        }

        private void customerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            utilities.CellClick(cancelBtn, removeBtn, editBtn, saveBtn);
        }

        private void birthdayDTimePicker_ValueChanged(object sender, EventArgs e)
        {

            CheckChange();
        }

        private void sexCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckChange();
        }
    }
}
