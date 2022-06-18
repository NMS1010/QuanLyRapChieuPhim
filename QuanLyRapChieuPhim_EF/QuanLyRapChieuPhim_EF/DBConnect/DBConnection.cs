using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim_EF.DBConnect
{
    internal class DBConnection
    {
        public static string ServerName = "MINHSON\\MINHSON";
        public static string DatabaseName = "QuanLyRapChieuPhim";
        public static string ConnectionString = $"data source={ServerName};initial catalog={DatabaseName};integrated security=True;multipleactiveresultsets=True;application name=EntityFramework;Persist Security Info = True";
        private static void Connect()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["CinemaManagementModel"].ConnectionString = ConnectionString;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
        }
        public static bool CheckConnectDB()
        {
            bool success = true;
            try
            {
                SqlConnection DBconnection = new SqlConnection(ConnectionString);
                Connect();
                DBconnection.Open();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                success = false;
            }
            return success;
        }
    }
}
