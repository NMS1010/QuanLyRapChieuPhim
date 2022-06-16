using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim_ADO
{
    internal class Utilities
    {
        private List<Control> controls;
        private DataGridView dataGV;

        public Utilities(List<Control> controls, DataGridView dataGridView)
        {
            Controls = new List<Control>(controls);
            dataGV = dataGridView;
            dataGV.ReadOnly = true;
        }

        public List<Control> Controls { get => controls; set => controls = value; }
        public DataGridView DataGV { get => dataGV; set => dataGV = value; }

        public void SetEnableControl(bool b)
        {
            foreach (Control control in controls)
            {
                control.Enabled = b;
            }
        }
        public void SetNullTextBox()
        {
            foreach (Control control in controls)
            {
                if (control is TextBox || control is RichTextBox)
                {
                    control.Text = "";
                }
                if (control is CheckedListBox)
                {
                    foreach (int i in (control as CheckedListBox).CheckedIndices)
                    {
                        (control as CheckedListBox).SetItemCheckState(i, CheckState.Unchecked);
                    }
                }
            }
        }
        public bool IsNullTxb()
        {
            foreach (Control control in controls)
            {
                if (control is CheckedListBox)
                {
                    continue;
                }
                else if (control.Text == "")
                {
                    return true;
                }
            }
            return false;
        }
        public void DisplayDataRow()
        {
            try
            {
                if (DataGV.CurrentCell == null)
                {
                    SetNullTextBox();
                    return;
                }
                int selectedRowIndex = DataGV.SelectedCells[0].RowIndex;

                for (int i = 0; i < Controls.Count; i++)
                {
                    if (Controls[i] is CheckedListBox)
                    {
                        List<string> temp = DataGV.Rows[selectedRowIndex].Cells[i]?.Value.ToString().Split(new string[] { ", " }, StringSplitOptions.None).ToList();
                        CheckedListBox t = Controls[i] as CheckedListBox;
                        for (int j = 0; j < t.Items.Count; j++)
                        {
                            if (temp.Contains(t.Items[j].ToString()))
                            {
                                t.SetItemChecked(j, true);
                            }
                            else
                            {
                                t.SetItemChecked(j, false);
                            }
                        }
                        continue;
                    }
                    Controls[i].Text = DataGV.Rows[selectedRowIndex].Cells[i].Value?.ToString().Trim();
                }
            }
            catch
            {
                MessageBox.Show("Thao tác quá nhanh, vui lòng thực hiện lại!!!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        public void AssignData(DataSet ds)
        {
            try
            {
                DataGV.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Dữ liệu lỗi, vui lòng thực hiện lại!!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ShowSelectedRow()
        {
            DisplayDataRow();
            SetEnableControl(false);
        }

        public void FormLoad(DataSet ds)
        {
            AssignData(ds);
            DisplayDataRow();
        }


        public void Reload(DataSet ds)
        {
            AssignData(ds);
            ShowSelectedRow();
        }
        public void SetEnableButton(List<Button> btns, bool enabled)
        {
            btns.ForEach(b => {
                b.Enabled = enabled;
                b.BackColor = enabled ? Color.Yellow : Color.Gray;
            });
        }
        public void CellClick(Button cancelBtn, Button removeBtn, Button editBtn, Button saveBtn)
        {
            int selectedRowIndex = DataGV.SelectedCells[0].RowIndex;
            if (selectedRowIndex > DataGV.RowCount - 2)
            {
                SetEnableButton(new List<Button>() { cancelBtn, removeBtn, editBtn }, false);
            }
            else
            {
                SetEnableButton(new List<Button>() { cancelBtn, removeBtn, editBtn }, true);
            }
            ShowSelectedRow();
            saveBtn.Enabled = false;
            saveBtn.BackColor = Color.Gray;
        }

    }
}
