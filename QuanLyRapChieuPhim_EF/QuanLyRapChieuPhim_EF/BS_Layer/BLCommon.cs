using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapChieuPhim_EF.BS_Layer
{
    internal class BLCommon
    {
        public static DataTable Search(DataSet ds, int colNo, string value)
        {
            value = value.ToLower();
            DataTable dt = ds.Tables[0].Clone();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                string temp = dr.ItemArray[colNo].ToString().ToLower();
                if (DateTime.TryParse(dr.ItemArray[colNo].ToString(), out DateTime d))
                {
                    temp = ((DateTime)dr.ItemArray[colNo]).ToString("dd/MM/yyyy");
                    if (ds.Tables[0].Columns[colNo].ColumnName == "GioChieu")
                    {
                        temp = ((DateTime)dr.ItemArray[colNo]).ToString("HH:mm");
                    }
                }
                if (temp.Contains(value))
                    dt.Rows.Add(dr.ItemArray);
            }
            return dt;
        }
    }
}
