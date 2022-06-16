using QuanLyRapChieuPhim_ADO.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace QuanLyRapChieuPhim_ADO.BS_Layer
{
    internal static class BLMovie
    {
        private static string tableName = "BoPhim";
        static BLMovie()
        {
            
        }

        public static DataSet GetData()
        {
            string command = $"select * from {tableName}";
            DataSet ds = DataProvider.GetData(command);
            ds.Tables[0].Columns.Add(new DataColumn("TheLoai", typeof(string)));
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string str = "";
                List<string> temp = BLGenre.GetGenreNameFromFilmID(row.ItemArray[0].ToString());
                if(temp.Count != 0)
                    str = temp.Aggregate((i, j) => i + ", " + j);
                row["TheLoai"] = str;
            }
            return ds;
        }
        public static bool Update(string filmId, string filmName, string filmDes, double totalFilmTime,
            DateTime startShow, DateTime endShow, int year, string director, string studioFilm, int movieStatus, ref string err)
        {
            if(endShow < startShow)
            {
                err = "Ngày khởi chiếu phải nhỏ hơn Ngày kết thúc";
                return false;
            }
            string command = $"update {tableName} set TenPhim = N'{filmName}'," +
                $" MoTa = N'{filmDes}', ThoiLuong = {totalFilmTime}, NgayKhoiChieu = '{startShow}'," +
                $"NgayKetThuc = '{endShow}', NamSX = {year}, DaoDien = N'{director}', TenHangPhim = N'{studioFilm}', TrangThai = {movieStatus} where MaBoPhim = '{filmId}'; ";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            List<string> showTimeIDs = DataProvider.GetStringValuesFromSpecificColumnWithCondition("SuatChieu", "MaSuatChieu", $"MaBoPhim = '{filmId}'");
            foreach(string showTimeID in showTimeIDs)
            {
                string cinemaRoomID = DataProvider.GetSingleStringValueFromQuery($"select MaPhongChieu from SuatChieu where MaSuatChieu = '{showTimeID}'");
                string cinemaRoomStatus = DataProvider.GetSingleStringValueFromQuery($"select TinhTrang from PhongChieu where MaPhongChieu = '{cinemaRoomID}'");
                if (cinemaRoomStatus == "0")
                    continue;
                success = BLCommon.UpdateState("TrangThai","SuatChieu", movieStatus, $"MaSuatChieu = '{showTimeID}'", ref err);
                if (!success)
                    return success;
            }
            return success;
        }
        public static bool Insert(string filmId, string filmName, string filmDes, double totalFilmTime,
            DateTime startShow, DateTime endShow, int year, string director, string studioFilm, int movieStatus, ref string err)
        {
            if (endShow < startShow)
            {
                err = "Ngày khởi chiếu phải nhỏ hơn Ngày kết thúc";
                return false;
            }
            string command = $@"insert into {tableName} values('{filmId}',N'{filmName}',N'{filmDes}','{totalFilmTime}','{startShow}','{endShow}','{year}',N'{director}',N'{studioFilm}', {movieStatus});";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }
        public static bool Remove_Movie_Genre(string filmId, ref string err)
        {
            string command = $"delete from BoPhim_TheLoai where MaBoPhim = '{filmId}';";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }
        public static string GetFilmNameFromFilmID(string filmID)
        {
            string command = $"select TenPhim from BoPhim where MaBoPhim = N'{filmID}'";
            return DataProvider.GetSingleStringValueFromQuery(command);
        }
        public static List<Tuple<string, string>> GetFilms()
        {
            string command = "select TenPhim, MaBoPhim from BoPhim";
            DataSet ds = DataProvider.GetData(command);
            List<Tuple<string, string>> films = new List<Tuple<string, string>>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                films.Add(new Tuple<string, string>(dr["TenPhim"].ToString(), dr["MaBoPhim"].ToString()));
            }
            return films;
        }
        public static bool Modify_Movie_Genre(string filmId, List<string> genreNames, ref string error)
        {
            bool success = Remove_Movie_Genre(filmId, ref error);
            if (!success)
                return success;
            foreach (string genreName in genreNames)
            {
                List<string> genreIDs = BLGenre.GetGenreIDFromGenreName(genreName);
                foreach (string genreID in genreIDs)
                {
                    string command = $"insert into BoPhim_TheLoai values('{filmId}', '{genreID}')";
                    success = DataProvider.ExecuteNonQuery(command, ref error);
                    if (!success)
                        return success;
                }
            }
            return success;
        }
        
        public static bool Remove(string filmId, ref string err)
        {
            string command = $"delete from BoPhim where MaBoPhim = '{filmId}'";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }
    }
}
