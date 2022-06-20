using QuanLyRapChieuPhim_ADO.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim_ADO.BS_Layer
{
    internal static class BLTicket
    {
        private static string tableName = "Ve";
        static BLTicket()
        {
            
        }

        public static DataSet GetTicketDataByShowTime(string showTimeID)
        {
            string command = $"select * from {tableName} where MaSuatChieu = '{showTimeID}'";
            DataSet ds = DataProvider.GetData(command);
            return ds;
        }
        public static bool IsTicketsCreateByShowTime(string showTimeID)
        {
            List<string> values = DataProvider.GetStringValuesFromSpecificColumnWithCondition(tableName, "MaVe", $"MaSuatChieu = '{showTimeID}'");
            if (values.Count == 0)
                return false;
            return true;
        }
        public static DataSet GetShowTimeData()
        {
            DataSet ds = BLShowTime.GetData();
            ds.Tables[0].Columns.Remove("GiaVe");
            ds.Tables[0].Columns.Add(new DataColumn("TinhTrangVe", typeof(string)));
            DataSet res = ds.Clone();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow dr = ds.Tables[0].Rows[i];
                if ((int)dr["TrangThai"] != 0)
                {
                    if (!IsTicketsCreateByShowTime(dr["MaSuatChieu"].ToString()))
                    {
                        dr["TinhTrangVe"] = "Chưa tạo vé";
                    }
                    else
                    {
                        dr["TinhTrangVe"] = "Đã tạo vé";
                    }
                    res.Tables[0].Rows.Add(dr.ItemArray);
                }
            }
            return res;
        }
        public static bool Insert(int ticketStatus, string seatID, string customerID, string showTimeID, int ticketType, decimal ticketPrice, DateTime buyDate, ref string error)
        {
            string id = customerID != "" ? $"'{customerID}'" : "NULL";
            string command = $"insert into {tableName} values({ticketStatus}, '{seatID}', {id},'{showTimeID}', {ticketType}, {ticketPrice}, '{buyDate}')"; ;
            
            return DataProvider.ExecuteNonQuery(command, ref error);
        }

        public static bool UpdateOrderedTicket(string customerID, double ticketPrice, string seatID, int ticketType, int ticketStatus, string showID, DateTime buyDate, ref string error)
        {
            string id = customerID != "" ? $"'{customerID}'" : "NULL";
            string command = $"update {tableName} set MaKhachHang = {id}, TrangThai = {ticketStatus}, LoaiVe = {ticketType}, TienVe = {ticketPrice}, NgayMua = '{buyDate}' where MaGhe = '{seatID}' and MaSuatChieu = '{showID}'";
            return DataProvider.ExecuteNonQuery(command, ref error);
        }
        public static bool RemoveAllTicketByShowTime(string showTimeID, ref string error)
        {
            string command = $"delete from {tableName} where MaSuatChieu = '{showTimeID}'";
            return DataProvider.ExecuteNonQuery(command, ref error);
        }
        public static string GetTicketPriceFromCinemaRoomID(string cinemaRoomID)
        {
            string command = $"select MaDinhDangMH from PhongChieu where MaPhongChieu = N'{cinemaRoomID}'";
            string screenFormatID = DataProvider.GetSingleStringValueFromQuery(command);
            return GetTicketPriceFromScreenFormatID(screenFormatID);
        }

        public static string GetTicketPriceFromScreenFormatID(string screenFormatID)
        {
            string command = $"select GiaVe from DinhDangManHinh where MaDinhDangMH = N'{screenFormatID}'";
            return DataProvider.GetSingleStringValueFromQuery(command);
        }
        public static bool GenerateTicket(string showTimeID, ref string error)
        {
            if (IsTicketsCreateByShowTime(showTimeID))
            {
                error = "Đã tạo vé cho suất chiếu này";
                return false;
            }
            string cinemaRoomID = BLCinemaRoom.GetCinemaRoomIDFromShowTimeID(showTimeID);
            string command = $"select SoHangGhe, SoGheMoiHang from PhongChieu where MaPhongChieu = '{cinemaRoomID}'";
            DataSet seatInfo = DataProvider.GetData(command);
            if (seatInfo.Tables[0].Rows.Count == 0)
            {
                error = "Phòng chiếu không hợp lệ!!!";
                return false;
            }
            int numberRows = int.Parse(seatInfo.Tables[0].Rows[0]["SoHangGhe"].ToString());
            int numberChairPerRow = int.Parse(seatInfo.Tables[0].Rows[0]["SoGheMoiHang"].ToString());
            string strSequence = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            bool success = true;
            for(int i = 0; i < numberRows; i++)
            {
                for(int j = 0; j < numberChairPerRow; j++)
                {
                    success = Insert(0, strSequence[i] + j.ToString(), String.Empty, showTimeID, 0, (decimal)0, DateTime.Now, ref error);
                    if (!success)
                        return success;
                }
            }
            return success;
        }

    }
}
