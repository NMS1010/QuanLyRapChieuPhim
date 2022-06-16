using QuanLyRapChieuPhim_ADO.DB_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim_ADO.BS_Layer
{
    public static class BLCommon
    {
        public static bool UpdateState(string column, string tableName, int stateValue, string condition, ref string err)
        {
            string command = $"update {tableName} set {column} = {stateValue} where {condition}";
            return DataProvider.ExecuteNonQuery(command, ref err);
        }
    }
}
