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
        public static string ConnectionString;
        private static void Connect()
        {
            ConnectionString = $"data source={ServerName};initial catalog={DatabaseName};integrated security=True;multipleactiveresultsets=True;application name=EntityFramework;Persist Security Info = True";
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["CinemaManagementModel"].ConnectionString = ConnectionString;
            config.ConnectionStrings.ConnectionStrings["CinemaManagementModel"].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Full);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
        public static bool CheckConnectDB()
        {
            bool success = true;
            try
            {
                Connect();
                SqlConnection DBconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CinemaManagementModel"].ConnectionString);
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
