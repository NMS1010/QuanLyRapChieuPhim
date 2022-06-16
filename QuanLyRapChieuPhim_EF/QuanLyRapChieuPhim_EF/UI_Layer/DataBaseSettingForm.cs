using QuanLyRapChieuPhim_EF.DBConnect;
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
    public partial class DataBaseSettingForm : Form
    {
        public DataBaseSettingForm()
        {
            InitializeComponent();
        }

        private void testConnectBtn_Click(object sender, EventArgs e)
        {
            DBConnection.ServerName = serverNameTxb.Text;
            DBConnection.DatabaseName = dbNameTxb.Text;
            if (DBConnection.CheckConnectDB())
            {
                statusLabel.Text = "Connect to database" +
                    "\n successfully";
                statusLabel.ForeColor = Color.Lime;
            }
            else
            {
                statusLabel.Text = "Fail to connect" +
                    "\n to database";
                statusLabel.ForeColor = Color.Red;
            }
        }

        private void OnTextChange(object sender, EventArgs e)
        {
            if(serverNameTxb.Text == "" || dbNameTxb.Text == "")
            {
                testConnectBtn.BackColor = Color.Gray;
                testConnectBtn.Enabled = false;
                return;
            }
            testConnectBtn.BackColor = Color.Lime;
            testConnectBtn.Enabled = true;
        }

        private void DataBaseSettingForm_Load(object sender, EventArgs e)
        {
            serverNameTxb.Text = DBConnection.ServerName;
            dbNameTxb.Text = DBConnection.DatabaseName;
        }
    }
}
