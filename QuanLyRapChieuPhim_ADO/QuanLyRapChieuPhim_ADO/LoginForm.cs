using QuanLyRapChieuPhim_ADO.BS_Layer;
using QuanLyRapChieuPhim_ADO.UI_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim_ADO
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void OnTextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(userNameTxb.Text) || string.IsNullOrEmpty(passWordTxb.Text))
            {
                loginBtn.Enabled = false;
                return;
            }
            loginBtn.Enabled = true;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string error = "";
            bool success = BLLogin.Authentication(userNameTxb.Text, passWordTxb.Text, ref error);
            if (!success)
            {
                MessageBox.Show(error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Hide();
            ManagerForm orderTicketForm = new ManagerForm();
            orderTicketForm.ShowDialog();
            BLLogin.UserName = userNameTxb.Text;
            Show();
        }


        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(r == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void settingDBBtn_Click(object sender, EventArgs e)
        {
            DataBaseSettingForm settingForm = new DataBaseSettingForm();
            settingForm.ShowDialog();
        }
    }
}
