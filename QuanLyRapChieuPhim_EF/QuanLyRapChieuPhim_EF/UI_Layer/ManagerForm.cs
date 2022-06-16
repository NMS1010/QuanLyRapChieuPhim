using QuanLyRapChieuPhim_EF.BS_Layer;
using QuanLyRapChieuPhim_EF.Enum;
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
    public partial class ManagerForm : Form
    {
        public AvaialbleShowTimeUControl avaialbleShowTimeUControl = new AvaialbleShowTimeUControl();


        public ManagerForm()
        {
            InitializeComponent();
        }
        public AvaialbleShowTimeUControl GetShowTimeForm()
        {
            return new AvaialbleShowTimeUControl();
        }
        public BuyTicketUControl GetTicketForm()
        {
            return new BuyTicketUControl();
        }
        private void OrderTicketForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void LoadForm()
        {
            mainPnl.Controls.Clear();
            mainPnl.Controls.Add(GetShowTimeForm());
            if (BLLogin.AccountRole == ACCOUNT_ROLE.ADMIN)
            {
                dataManagerBtn.Visible = true;
                customerDataManagerBtn.Visible = false;
            }
            else
            {
                dataManagerBtn.Visible = false;
                customerDataManagerBtn.Visible = true;
            }
            using (Image img = Properties.Resources.management)
            {
                dataManagerBtn.Image = new Bitmap(img, 40, 40);
            }
            using (Image img = Properties.Resources.customer_feedback)
            {
                customerDataManagerBtn.Image = new Bitmap(img, 40, 40);
            }
        }
        private void dataManagerBtn_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            Hide();
            dashBoard.ShowDialog();
            LoadForm();
            Show();
        }

        private void customerDataManagerBtn_Click(object sender, EventArgs e)
        {
            CustomerUControl customerUControl = new CustomerUControl();
            Form f = new Form() {Width = customerUControl.Width, Height = customerUControl.Height, Text = "Quản lý dữ liệu khách hàng" };
            f.Controls.Add(customerUControl);
            Hide();
            f.ShowDialog();
            Show();
        }
    }
}
