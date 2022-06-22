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
    public partial class AccountUControl : UserControl
    {
        private Utilities utilities;
        private List<Control> controls;
        public AccountUControl()
        {
            InitializeComponent();
        }

        private void CheckChange()
        {
            if (utilities.IsNullTxb() || (!isEditData && !isAddData) ||
                !int.TryParse(employeeIDTxb.Text, out int res2))
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
        private void AccountUControl_Load(object sender, EventArgs e)
        {
            controls = new List<Control>() {userNameTxb, passwordTxb, employeeIDTxb,
                accountTypeCbx};
            utilities = new Utilities(controls, accountDataGridView);
            utilities.FormLoad(BLAccount.GetData());
            utilities.SetEnableControl(false);
            utilities.SetEnableButton(new List<Button>() { saveBtn }, false);

            if (accountDataGridView.Rows.Count == 1)
            {
                utilities.SetEnableButton(new List<Button>() { editBtn, removeBtn }, false);
            }
            foreach(DataGridViewColumn dataCol in accountDataGridView.Columns)
            {
                propertySearchCbx.Items.Add(dataCol.Name);
            }
            propertySearchCbx.SelectedIndex = 0;
        }
        private bool isAddData = false;
        private void addBtn_Click(object sender, EventArgs e)
        {
            utilities.SetEnableControl(true);
            isAddData = true;
            utilities.SetNullTextBox();
            utilities.SetEnableButton(new List<Button>() { cancelBtn }, true);
            utilities.SetEnableButton(new List<Button>() { removeBtn, editBtn }, false);
            if(accountTypeCbx.Text == "")
            {
                accountTypeCbx.Text = accountTypeCbx.Items[0].ToString();
            }
        }
        private bool isEditData = false;
        private void editBtn_Click(object sender, EventArgs e)
        {
            utilities.SetEnableControl(true);
            isEditData = true;
            utilities.SetEnableButton(new List<Button>() { removeBtn, addBtn }, false);
            userNameTxb.Enabled = false;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            string error = "";
            int selectedRowIndex = accountDataGridView.SelectedCells[0].RowIndex;
            string userName = accountDataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString().Trim();
            DialogResult res = MessageBox.Show("Do you want to remove this record ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No)
                return;
            bool success = BLAccount.Remove(userName, ref error);
            if (!success)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            utilities.Reload(BLAccount.GetData());
            if (accountDataGridView.SelectedCells.Count == 0)
            {
                utilities.SetEnableButton(new List<Button>() { removeBtn, editBtn }, false);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string error = "";
            int employeeID = -1;
            bool isEmployee = int.TryParse(employeeIDTxb.Text, out employeeID);
            bool success = false;
            if (isAddData)
            {
                success = BLAccount.Insert(userNameTxb.Text, passwordTxb.Text, employeeID, int.Parse(accountTypeCbx.Text), ref error);
                if (success)
                    isAddData = false;
            }
            else if (isEditData)
            {
                success = BLAccount.Update(userNameTxb.Text, passwordTxb.Text, employeeID, int.Parse(accountTypeCbx.Text), ref error);
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
            utilities.Reload(BLAccount.GetData());
            if (accountDataGridView.SelectedCells.Count == 0)
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
            int temp = accountDataGridView.SelectedCells[0].RowIndex;
            if (temp == accountDataGridView.RowCount - 1)
                return;
            utilities.SetEnableButton(new List<Button>() { addBtn, removeBtn, editBtn }, true);
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            utilities.Reload(BLAccount.GetData());
            if (accountDataGridView.SelectedCells.Count == 0)
            {
                return;
            }
            utilities.SetEnableButton(new List<Button>() { cancelBtn, saveBtn }, false);
            utilities.SetEnableButton(new List<Button>() { editBtn, removeBtn, addBtn }, true);
        }

        private void accountDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            utilities.CellClick(cancelBtn, removeBtn, editBtn, saveBtn);
        }
        private void accountTypeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            accountDataGridView.DataSource = BLCommon.Search(BLAccount.GetData(), propertySearchCbx.SelectedIndex, searchTxb.Text);
        }
    }
}
