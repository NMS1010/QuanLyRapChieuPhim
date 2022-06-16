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
    public partial class BuyTicketUControl : UserControl
    {
        ManagerForm orderTicketForm;
        Panel mainPnl;
        List<List<Button>> seats;
        Color disableColor = Color.White;
        Color enableColor = Color.GreenYellow;
        Color orderedColor = Color.MediumVioletRed;
        List<string> orderedTickets;
        List<string> selectedTickets;
        int totalSelectedSeat = 0;
        int totalSeat;
        SALE salePercent = 0;
        int ticketType = 0;

        public BuyTicketUControl()
        {
            InitializeComponent();
        }

        private void BuyTicket_Load(object sender, EventArgs e)
        {
            seats = new List<List<Button>>();
            selectedTickets = new List<string>();
            mainPnl = this.Parent as Panel;
            orderTicketForm = mainPnl.Parent as ManagerForm;
            DisplayData();
            using (Image img = Properties.Resources.cargo)
            {
                payBtn.Image = new Bitmap(img, 40, 40);
            }
        }

        private void DisplayData()
        {
            Dictionary<string, string> showTimeInfo = BLOrderTicket.GetShowTimeInfo();
            filmInfoLabel.Text = $"Tên phim: {showTimeInfo["TenPhim"]} ---- Phòng: {showTimeInfo["TenPhong"]}";
            DateTime t1 = Convert.ToDateTime(showTimeInfo["ThoiGian"]);
            DateTime t2 = t1.AddSeconds(double.Parse(showTimeInfo["ThoiLuong"]) * 60);
            timeInfoLabel.Text = $"Ngày chiếu: {t1.ToShortDateString()} --- Thời gian: {t1.ToShortTimeString()} - {t2.ToShortTimeString()}";
            orderedTickets = BLOrderTicket.GetOrderedTicket();
            int seatRows = int.Parse(showTimeInfo["SoHangGhe"]);
            int seatCols = int.Parse(showTimeInfo["SoGheMoiHang"]);
            totalSeat = seatRows * seatCols;
            ticketPriceTxb.Text = $"{showTimeInfo["GiaVe"]}";
            UpdateTicketPrice();
            GenerateSeats(seatRows, seatCols);
            statusSeatLabel.Text = $"{totalSeat - orderedTickets.Count}/{totalSeat}";
        }
        private void UpdateTicketPrice()
        {
            statusSeatLabel.Text = $"{totalSeat - totalSelectedSeat - orderedTickets.Count}/{totalSeat}";
            decreaseLb.Text = $"Giảm ({(int)SALE.STUDENT}%)";
            unitPriceTxb.Text = ticketPriceTxb.Text;
            countSeatTxb.Text = totalSelectedSeat.ToString();
            salePriceTxb.Text = (double.Parse(unitPriceTxb.Text) * (int)salePercent / 100 * int.Parse(countSeatTxb.Text)).ToString();
            double totalPrice = double.Parse(unitPriceTxb.Text) * int.Parse(countSeatTxb.Text) - double.Parse(salePriceTxb.Text);
            totalPriceTxb.Text = totalPrice.ToString();
            cumalativePointTxb.Text = (totalSelectedSeat * (int)BONUS_POINT.POINT).ToString();
        }
        private void GenerateSeats(int row, int col)
        {
            int width = seatPnl.Width / col;
            int height = seatPnl.Height / row;
            seatPnl.Controls.Clear();
            for (int i = 0; i < row; i++)
            {
                List<Button> temp = new List<Button>();
                for(int j = 0; j < col; j++)
                {
                    Color c = disableColor;
                    bool enable = true;
                    string seat = $"{(char)(i + 65)}{j.ToString()}";
                    if (orderedTickets.Contains(seat))
                    {
                        c = orderedColor;
                        enable = false;
                    }
                    Button b = new Button() { Enabled = enable, Width = width, Height = height, Location = new Point( j * width, i * height), BackColor = c, Text = seat};
                    b.Click += chooseSeat_Click;
                    seatPnl.Controls.Add(b);
                    temp.Add(b);
                }
                seats.Add(temp);
            }
        }
        private void exitPtrb_Click(object sender, EventArgs e)
        {
            mainPnl.Controls.Clear();
            mainPnl.Controls.Add(orderTicketForm.GetShowTimeForm());
        }

        private void chooseSeat_Click(object sender, EventArgs e)
        {
            Button seat = sender as Button;
            if (seat.Enabled == false)
                return;
            if(seat.BackColor == disableColor)
            {
                seat.BackColor = enableColor;
                totalSelectedSeat += 1;
                selectedTickets.Add(seat.Text);
            }
            else
            {
                seat.BackColor = disableColor;
                totalSelectedSeat -= 1;
                selectedTickets.Remove(seat.Text);
            }
            UpdateTicketPrice();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            if(r.Tag.ToString() == "0")
            {
                salePercent = SALE.ADULT;
                ticketType = 0;
            }
            else
            {
                salePercent = SALE.STUDENT;
                ticketType = 1;
            }
            UpdateTicketPrice();
        }

        private void countSeatTxb_TextChanged(object sender, EventArgs e)
        {
            if((sender as TextBox).Text == "0")
            {
                payBtn.Enabled = false;
                return;
            }
            payBtn.Enabled = true;
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            string result = string.Join(", ", selectedTickets);
            DialogResult res = MessageBox.Show($"Xác nhận mua những ghế sau {result}", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(res == DialogResult.OK)
            {
                string error = "";
                double ticketPrice = double.Parse(totalPriceTxb.Text) / totalSelectedSeat;
                bool success = BLOrderTicket.UpdateBoughtTicket(selectedTickets, ticketType, ticketPrice, DateTime.Now, ref error);
                if (success && BLOrderTicket.CustomerID != "")
                {
                    success = BLCustomer.UpdatePoint(BLOrderTicket.CustomerID, selectedTickets.Count * (int)BONUS_POINT.POINT, ref error);
                }
                if (!success)
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                totalSelectedSeat = 0;
            }
            DisplayData();
        }

        private void cancelSeatBtn_Click(object sender, EventArgs e)
        {
            totalSelectedSeat = 0;
            foreach(Button b in seatPnl.Controls)
            {
                if(b.BackColor == enableColor)
                {
                    b.BackColor = disableColor;
                }
            }
            UpdateTicketPrice();
        }
    }
}
