using QuanLyRapChieuPhim_ADO.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim_ADO.BS_Layer
{
    internal static class BLGenre
    {
        private static string tableName = "TheLoai";
        static BLGenre()
        {
            
        }

        public static DataSet GetData()
        {
            string command = $"select * from {tableName}";
            DataSet dt = DataProvider.GetData(command);
            return dt;
        }

        public static bool Update(string genreId, string genreName, ref string err)
        {
            string command = $"update {tableName} set TenTheLoai = N'{genreName}' where MaTheLoai = '{genreId}'; ";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }
        public static bool Insert(string genreId, string genreName, ref string err)
        {
            string command = $"insert into {tableName} values(N'{genreId}', N'{genreName}');";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }

        public static bool Remove(string genreId, ref string err)
        {
            string command = $"delete from TheLoai where MaTheLoai = '{genreId}';";
            bool success = DataProvider.ExecuteNonQuery(command, ref err);
            return success;
        }
    }
}
