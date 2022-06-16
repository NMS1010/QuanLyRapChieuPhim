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
            List<string> values = DataProvider.GetStringValuesFromSpecificColumnWithCondition("Ve", "MaVe", $"MaSuatChieu = '{showTimeID}'");
            if (values.Count == 0)
                return false;
            return true;
        }
        public static DataSet GetShowTimeData()
        {
            DataSet ds = BLShowTime.GetData();
            ds.Tables[0].Columns.Remove("GiaVe");
            ds.Tables[0].Columns.Add(new DataColumn("TinhTrangVe", typeof(string)));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow dr = ds.Tables[0].Rows[i];
                if ((int)dr["TrangThai"] == 0)
                {
                    ds.Tables[0].Rows.Remove(dr);
                    i--;
                }
                else
                {
                    if (!IsTicketsCreateByShowTime(dr["MaSuatChieu"].ToString()))
                    {
                        dr["TinhTrangVe"] = "Chưa tạo vé";
                    }
                    else
                    {
                        dr["TinhTrangVe"] = "Đã tạo vé";
                    }
                }
            }
            return ds;
        }
        public static bool Insert(int ticketStatus, string seatID, string customerID, string showTimeID, int ticketType, decimal ticketPrice, DateTime buyDate, ref string error)
        {
            string id = "";
            if (customerID == "")
            {
                id = "NULL";
            }
            else
            {
                id = $"'{customerID}'";
            }
            string command = $"insert into {tableName} values({ticketStatus}, '{seatID}', {id},'{showTimeID}', {ticketType}, {ticketPrice}, '{buyDate}')"; ;
            
            return DataProvider.ExecuteNonQuery(command, ref error);
        }

        public static bool UpdateOrderedTicket(string customerID, double ticketPrice, string seatID, int ticketType, int ticketStatus, string showID, DateTime buyDate, ref string error)
        {
            string id = "";
            if (customerID == "")
            {
                id = "NULL";
            }
            else
            {
                id = $"'{customerID}'";
            }
            string command = $"update {tableName} set MaKhachHang = {id}, TrangThai = {ticketStatus}, LoaiVe = {ticketType}, TienVe = {ticketPrice}, NgayMua = '{buyDate}' where MaGhe = '{seatID}' and MaSuatChieu = '{showID}'";
            return DataProvider.ExecuteNonQuery(command, ref error);
        }
        public static bool RemoveAllTicketByShowTime(string showTimeID, ref string error)
        {
            string command = $"delete from {tableName} where MaSuatChieu = '{showTimeID}'";
            return DataProvider.ExecuteNonQuery(command, ref error);
        }
        public static bool GenerateTicket(string showTimeID, ref string error)
        {
            if (IsTicketsCreateByShowTime(showTimeID))
            {
                error = "Đã tạo vé cho suất chiếu này";
                return false;
            }
            string cinemaRoomID = BLShowTime.GetCinemaRoomIDFromShowTimeID(showTimeID);
            string command = $"select SoHangGhe, SoGheMoiHang from PhongChieu where MaPhongChieu = '{cinemaRoomID}'";
            DataSet seatInfo = DataProvider.GetData(command);
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
