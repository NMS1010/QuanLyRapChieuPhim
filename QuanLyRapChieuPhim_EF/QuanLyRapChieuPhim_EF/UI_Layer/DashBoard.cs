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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        private void LoadImage()
        {
            using (Image img = Properties.Resources.cinema)
            {
                cinemaDataBtn.Image = new Bitmap(img, 60, 60);
            }
            using (Image img = Properties.Resources.customer_feedback)
            {
                customerDataBtn.Image = new Bitmap(img, 60, 60);
            }
            using (Image img = Properties.Resources.employee)
            {
                employeeDatabtn.Image = new Bitmap(img, 60, 60);
            }
            using (Image img = Properties.Resources.account)
            {
                accountDataBtn.Image = new Bitmap(img, 60, 60);
            }
            using (Image img = Properties.Resources.ticket)
            {
                ticketDataBtn.Image = new Bitmap(img, 60, 60);
            }
            using (Image img = Properties.Resources.revenue)
            {
                revenueDataBtn.Image = new Bitmap(img, 60, 60);
            }
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
            LoadImage();
            ChangeColor(cinemaDataBtn);
            CinemaDataManagerUControl dataManagerUControl = new CinemaDataManagerUControl();
            dataPnl.Controls.Clear();
            dataPnl.Controls.Add(dataManagerUControl);
        }
        private void cinemaDataBtn_Click(object sender, EventArgs e)
        {
            ChangeColor(sender as Button);
            CinemaDataManagerUControl dataManagerUControl = new CinemaDataManagerUControl();
            dataPnl.Controls.Clear();
            dataPnl.Controls.Add(dataManagerUControl);
        }
        private void ChangeColor(Button b)
        {
            sideBarPtrb.Location = new Point(b.Location.X + b.Width, b.Location.Y);
            sideBarPtrb.Visible = true;
        }
        private void customerDataBtn_Click(object sender, EventArgs e)
        {
            ChangeColor(sender as Button);
            CustomerUControl customerUControl = new CustomerUControl();
            dataPnl.Controls.Clear();
            dataPnl.Controls.Add(customerUControl);
        }

        private void employeeDatabtn_Click(object sender, EventArgs e)
        {
            ChangeColor(sender as Button);
            EmployeeUControl employeeUControl = new EmployeeUControl();
            dataPnl.Controls.Clear();
            dataPnl.Controls.Add(employeeUControl);
        }

        private void ticketDataBtn_Click(object sender, EventArgs e)
        {
            ChangeColor(sender as Button);
            TicketUControl ticketUControl = new TicketUControl();
            dataPnl.Controls.Clear();
            dataPnl.Controls.Add(ticketUControl);
        }

        private void accountDataBtn_Click(object sender, EventArgs e)
        {
            ChangeColor(sender as Button);
            AccountUControl accountUControl = new AccountUControl();
            dataPnl.Controls.Clear();
            dataPnl.Controls.Add(accountUControl);
        }

        private void revenueDataBtn_Click(object sender, EventArgs e)
        {
            ChangeColor(sender as Button);
            RevenueUControl revenueUControl = new RevenueUControl();
            dataPnl.Controls.Clear();
            dataPnl.Controls.Add(revenueUControl);
        }


        private void ChangeLeaveColor(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.ForeColor = Color.White;
        }

        private void ChangeEnterColor(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.ForeColor = Color.Black;
        }
    }
}
