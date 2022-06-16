using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim_ADO.DB_Layer
{
    public static class DataProvider
    {
        private static string serverName;
        private static string databaseName;
        private static SqlConnection DBconnection;
        private static string strConnection;
        private static SqlDataAdapter adapter;

        public static string ServerName { get => serverName; set => serverName = value; }
        public static string DatabaseName { get => databaseName; set => databaseName = value; }
        public static string StrConnection { get => strConnection; set => strConnection = value; }

        static DataProvider()
        {
            ServerName = "MINHSON\\MINHSON";
            DatabaseName = "QuanLyRapChieuPhim";
        }
        public static DataSet GetData(string command)
        {
            DataSet ds = new DataSet();
            if (!CheckConnectDB())
                return ds;
            adapter = new SqlDataAdapter(command, DBconnection);
            try
            {
                adapter.Fill(ds);
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Message);
            }
            finally
            {
                DBconnection.Close();
            }
            return ds;
        }
        public static List<string> GetStringValuesFromSpecificColumn(string table, string attribute)
        {
            List<string> lst = new List<string>();
            string command = $"select {attribute} from {table}";
            DataSet ds = GetData(command);
            foreach (DataRow d in ds.Tables[0].Rows)
            {
                lst.Add(d.ItemArray[0].ToString());
            }
            return lst;
        }
        public static List<string> GetStringValuesFromSpecificColumnWithCondition(string table, string attribute, string condition)
        {
            List<string> lst = new List<string>();
            string command = $"select {attribute} from {table} where {condition}";
            DataSet ds = GetData(command);
            foreach (DataRow d in ds.Tables[0].Rows)
            {
                lst.Add(d.ItemArray[0].ToString());
            }
            return lst;
        }
        public static string GetSingleStringValueFromQuery(string command)
        {
            DataSet ds = GetData(command);
            if (ds.Tables[0].Rows.Count > 0)
                return ds.Tables[0].Rows[0].ItemArray[0].ToString();
            return "";
        }
        public static bool CheckConnectDB()
        {
            StrConnection = $"Data Source={ServerName};Initial Catalog={DatabaseName};Integrated Security={true};";
            bool success = true;
            try
            {
                DBconnection = new SqlConnection(StrConnection);
                DBconnection.Open();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                success = false;
            }
            return success;
        }
        public static bool ExecuteNonQuery(string command, ref string error)
        {
            bool success = false;
            if (!CheckConnectDB())
            {
                error = "Cannot connect to DataBase. Please try again!!!";
                return false;
            }
            SqlCommand sqlCommand = new SqlCommand(command, DBconnection);
            
            try
            {
                sqlCommand.ExecuteNonQuery();
                success = true;
            }
            catch (SqlException e)
            {
                error = e.Message;
            }
            DBconnection.Close();
            return success;
        }
        
    }
}
